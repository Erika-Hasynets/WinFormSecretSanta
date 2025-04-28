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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool stop = true;
            try
            {
                id = int.Parse(textBox_id.Text);
            }
            catch (Exception ex)
            {
                label_msg.Text = ex.Message;
                stop = false;
            }
            if (stop)
            {
                string name = textBox_name.Text;
                string lastname = textBox_lastname.Text;
                SantaService santaService = new SantaService();
                label_msg.Text = santaService.addPeople(id, name, lastname);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            NavigationView mainMenu = new NavigationView();
            mainMenu.Show();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
