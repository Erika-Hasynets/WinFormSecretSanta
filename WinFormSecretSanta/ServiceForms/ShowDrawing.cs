using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormSecretSanta.Service;
using static WinFormSecretSanta.Service.SantaService;

namespace WinFormSecretSanta.ServiceForms
{
    public partial class ShowDrawing : Form
    {
        int currentIndex = 0;
        public ShowDrawing()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_id.Text = "Id:";
            label_name.Text = "Ім'я:";
            label_lastname.Text = "Прізвище:";
            label_toId.Text = "Дарує до Id:";
            label_toName.Text = "Дарує до Ім'я:";
            label_toLastName.Text = "Дарує до Прізвища:";
            SantaService santaService = new SantaService();
            string filePath = "data/Present.json"; //шлях до файлу людей 
            List<SantaService.PresentTo> Present = santaService.LoadPresents(filePath);
            currentIndex = (currentIndex > 0) ? currentIndex - 1 : Present.Count - 1;
            string[] result = new string[6];
            result = santaService.ViewPresent(currentIndex);
            label_id.Text = label_id.Text + result[0];
            label_name.Text = label_name.Text + result[1];
            label_lastname.Text = label_lastname.Text + result[2];
            label_toId.Text = label_toId.Text + result[3];
            label_toName.Text = label_toName.Text + result[4];
            label_toLastName.Text = label_toLastName.Text + result[5];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_id.Text = "Id:";
            label_name.Text = "Ім'я:";
            label_lastname.Text = "Прізвище:";
            label_toId.Text = "Дарує до Id:";
            label_toName.Text = "Дарує до Ім'я:";
            label_toLastName.Text = "Дарує до Прізвища:";
            SantaService santaService = new SantaService();
            string filePath = "data/Present.json"; //шлях до файлу людей 
            List<SantaService.PresentTo> Present = santaService.LoadPresents(filePath);
            currentIndex = (currentIndex < Present.Count - 1) ? currentIndex + 1 : 0;
            string[] result = new string[6];
            result = santaService.ViewPresent(currentIndex);
            label_id.Text = label_id.Text + result[0];
            label_name.Text = label_name.Text + result[1];
            label_lastname.Text = label_lastname.Text + result[2];
            label_toId.Text = label_toId.Text + result[3];
            label_toName.Text = label_toName.Text + result[4];
            label_toLastName.Text = label_toLastName.Text + result[5];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigationView mainMenu = new NavigationView();
            mainMenu.Show();
            this.Close();
        }

       
    }
}
