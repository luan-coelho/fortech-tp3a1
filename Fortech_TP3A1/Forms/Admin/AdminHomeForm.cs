using System;
using System.Windows.Forms;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms.Admin
{
    public partial class AdminHomeForm : Form
    {
        private readonly LogRepository _logRepository = new LogRepository();
        
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void btEncerrarSessao_Click(object sender, EventArgs e)
        {
            ContextoGlobal.usuarioLogado = null;
            Close();
            Application.OpenForms["AcessoForm"]?.Show();
            _logRepository.Salvar("Usuário encerrou a sessão");
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            Close();
            var form = new UsuarioForm();
            form.Show();
        }

        private void btSolicitacoes_Click(object sender, EventArgs e)
        {
            Close();
            var form = new SolicitacaoServicoForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            new SolicitacoesForm().Show();
        }
    }
}