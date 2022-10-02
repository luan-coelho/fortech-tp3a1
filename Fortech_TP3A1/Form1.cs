using System;
using System.Windows.Forms;
using Fortech_TP3A1.Forms;

namespace Fortech_TP3A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var acessoForm = new UsuarioForm();
            acessoForm.Show();
        }
    }
}
