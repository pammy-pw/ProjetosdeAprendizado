using System.Drawing;

namespace SistemaLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
  
        private void btnNewClone_Click(object sender, EventArgs e)
        {
            FormNewClone form = new FormNewClone();

            this.Hide();

            form.ShowDialog();

            this.Show();
        }

        private void btnAccessSystem_Click_1(object sender, EventArgs e)
        {
            FormAccessSystem form = new FormAccessSystem();

            this.Hide();

            form.ShowDialog();

            this.Show();
        }
    }
}




