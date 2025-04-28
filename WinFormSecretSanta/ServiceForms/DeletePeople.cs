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
    public partial class DeletePeople : Form
    {
        public DeletePeople()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            label_msg.Text = "message: ";
            SantaService santaService = new SantaService();
            int id = 0;
            try
            {
                id = int.Parse(textBox_id.Text);
            }
            catch (Exception ex)
            {
                label_msg.Text = label_msg.Text + ex.Message;
            }

            label_msg.Text = label_msg.Text + santaService.DeletePeople(id);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            NavigationView mainMenu = new NavigationView();
            mainMenu.Show();
            this.Close();
        }
    }
}
