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

namespace WinFormSecretSanta.ServiceForms
{
    public partial class ShowPeople : Form
    {
        public ShowPeople()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        int currentIndex = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label_id.Text = "Id: ";
            label_name.Text = "Ім'я: ";
            label_lastname.Text = "Прізвище: ";
            SantaService santaService = new SantaService();
            string filePath = "data/People.json"; //шлях до файлу людей 
            List<SantaService.People> people = santaService.LoadPeoples(filePath);
            currentIndex = (currentIndex > 0) ? currentIndex - 1 : people.Count - 1;
            string[] result = new string[3];
            result = santaService.ViewPeople(currentIndex);
            label_id.Text = label_id.Text + result[0];
            label_name.Text = label_name.Text + result[1];
            label_lastname.Text = label_lastname.Text + result[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_id.Text = "Id: ";
            label_name.Text = "Ім'я: ";
            label_lastname.Text = "Прізвище: ";
            SantaService santaService = new SantaService();
            string filePath = "data/People.json"; //шлях до файлу людей 
            List<SantaService.People> people = santaService.LoadPeoples(filePath);
            currentIndex = (currentIndex < people.Count - 1) ? currentIndex + 1 : 0;
            string[] result = new string[3];
            result = santaService.ViewPeople(currentIndex);
            label_id.Text = label_id.Text + result[0];
            label_name.Text = label_name.Text + result[1];
            label_lastname.Text = label_lastname.Text + result[2];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigationView mainMenu = new NavigationView();
            mainMenu.Show();
            this.Close();
        }

        private void ShowPeople_Load(object sender, EventArgs e)
        {

        }
    }
}
