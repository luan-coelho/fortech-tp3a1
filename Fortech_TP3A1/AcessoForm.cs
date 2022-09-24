using Fortech_TP3A1.Model;
using System;
using System.Data;
using System.Data.Entity;
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
            string login = txLogin.Text;
            string senha = txSenha.Text;

            var pesquisa = db.usuario.Where(x => x.email == login && x.senha == senha).ToList();
            if(pesquisa.Count() == 0)
            {
                MessageBox.Show("Login ou senha inválidos", "Ácesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(pesquisa[0].nome + " seja bem-vindo!", "Logado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ContextoGlobal.usuarioLogado = pesquisa[0];
                this.Close();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }
        }
    }
}
