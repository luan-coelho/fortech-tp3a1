using Fortech_TP3A1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Fortech_TP3A1
{
    public partial class AcessoForm : Form
    {
        public AcessoForm()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            FortechContext db = new FortechContext();
            string email = txEmail.Text;
            string senha = txSenha.Text;

            List <Usuario> pesquisa = db.usuario.Where(x => x.email == email && x.senha == senha).ToList();
            if(pesquisa.Count() == 0)
            {
                MessageBox.Show("Login ou senha inválidos", "Ácesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(pesquisa[0].nome + " seja bem-vindo!", "Logado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ContextoGlobal.usuarioLogado = pesquisa[0];
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarForm cadastrarForm = new CadastrarForm();
            cadastrarForm.Show();
        }

        private void AcessoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Form1"].Close();
        }
    }
}
