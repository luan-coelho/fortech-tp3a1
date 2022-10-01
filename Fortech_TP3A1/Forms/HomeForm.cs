using System.Windows.Forms;

namespace Fortech_TP3A1.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Form1"]?.Close();
        }
    }
}
