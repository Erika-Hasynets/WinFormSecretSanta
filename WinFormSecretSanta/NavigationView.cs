using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormSecretSanta.Service;
using WinFormSecretSanta.ServiceForms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace WinFormSecretSanta
{
    public partial class NavigationView : Form
    {
        public enum AppTheme
        {
            Light,
            Dark,
            HighContrast
        }
        public enum Language
        {
            English,
            Українська
        }
        public NavigationView()
        {
            InitializeComponent();
            InitUi();
        }
        private void InitUi()
        {
            // Мова
            comboBoxLanguage.Items.Clear(); // очищення на випадок повторної ініціалізації
            comboBoxLanguage.Items.AddRange(Enum.GetNames(typeof(Language))); //Заповнення елементів комбо_бокса
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged; //додавання події, зміни елемента
            comboBoxLanguage.SelectedItem = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "uk" //перевірка мови яка вибрана
                ? Language.Українська : Language.English;

            // Тема
            comboBoxTheme.Items.Clear();
            comboBoxTheme.Items.AddRange(Enum.GetNames(typeof(AppTheme)));
            comboBoxTheme.SelectedIndexChanged += (s, e) =>
            {
                var selectedTheme = (AppTheme)Enum.Parse(typeof(AppTheme), comboBoxTheme.SelectedItem.ToString());
                ThemeManager.SetTheme(selectedTheme);
            };

            ThemeManager.ApplyTheme(this);
        }
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCulture = comboBoxLanguage.SelectedItem.ToString() == "English" ? "en" : "uk";
            ChangeLanguage(selectedCulture);
        }

        private void ChangeLanguage(string cultureCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);

            // Перезапустити форму
            this.Controls.Clear();
            InitializeComponent();
            InitUi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPeople showPeople = new ShowPeople();
            OpenNewFormWithFade(showPeople);
         
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ShowDrawing showDrawing = new ShowDrawing();
            OpenNewFormWithFade(showDrawing);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            OpenNewFormWithFade(addUserForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            OpenNewFormWithFade(editForm);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DeletePeople deletePeople = new DeletePeople();
            OpenNewFormWithFade(deletePeople);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SantaService santaService = new SantaService();
            label_msg.Text = "message: " + santaService.DeleteAllPeople();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SantaService santaService = new SantaService();
            label_msg.Text = "message: " + santaService.randomPresent();
        }
        private void OpenNewFormWithFade(Form newForm)
        {
            Timer fadeOut = new Timer();
            fadeOut.Interval = 30;
            fadeOut.Tick += (s, e) =>
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                }
                else
                {
                    fadeOut.Stop();
                    newForm.Opacity = 0;
                    newForm.Show();
                    Timer fadeIn = new Timer();
                    fadeIn.Interval = 30;
                    fadeIn.Tick += (s2, e2) =>
                    {
                        if (newForm.Opacity < 1)
                        {
                            newForm.Opacity += 0.05;
                        }
                        else
                        {
                            fadeIn.Stop();
                            this.Close(); 
                        }
                    };
                    fadeIn.Start();
                }
            };
            fadeOut.Start();
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
