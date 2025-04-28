using WinFormSecretSanta.Service;

namespace WinFormSecretSanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            SantaService santaService = new SantaService();
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool isUser = santaService.startAutentification(login, password, 2);
            if (isUser)
            {
                label3.Text = "message: sucessful";
                NavigationView mainMenu = new NavigationView();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "message: error";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SantaService santaService = new SantaService();
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool isUser = santaService.startAutentification(login, password, 1);
            if (isUser)
            {
                label3.Text = "message: sucessful";
                NavigationView mainMenu = new NavigationView();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "message: error";
            }
        } 
    }
}
