using System;
using System.Windows.Forms;

namespace Fortech_TP3A1.Forms
{
    public partial class EnderecoForm : Form
    {
        public EnderecoForm()
        {
            InitializeComponent();
        }
        
        private void btVoltar_Click(object sender, EventArgs e)
        {
            var cadastrarForm = new CadastrarForm();
            cadastrarForm.Show();
            Close();
        }
    }
}