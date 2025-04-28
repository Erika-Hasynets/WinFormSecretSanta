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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            bool stop = true;
            SantaService santaService = new SantaService();
            int id = 0;
            try
            {
                id = int.Parse(textBox_id.Text);
            }
            catch (Exception ex)
            {
                label_msg.Text = ex.Message;
                stop = false;
            }
            string name = textBox_name.Text;
            string lastname = textBox_lastname.Text;
            if (stop)
            {
                label_msg.Text = santaService.editPeople(id, name, lastname);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            NavigationView mainMenu = new NavigationView();
            mainMenu.Show();
            this.Close();
        }

    }
}
