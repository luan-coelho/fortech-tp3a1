using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortech_TP3A1.Forms.Admin
{
    public partial class SolicitacoesForm : Form
    {
        private readonly LogRepository _logRepository = new LogRepository();

        public SolicitacoesForm()
        {
            InitializeComponent();
        }

        private void SolicitacoesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fortechDataSet5.SolicitacaoServico'. Você pode movê-la ou removê-la conforme necessário.
            this.solicitacaoServicoTableAdapter.Fill(this.fortechDataSet5.SolicitacaoServico);

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var form = new AdminHomeForm();
            form.Show();
        }

        private void btEncerrarSessao_Click(object sender, EventArgs e)
        {
            ContextoGlobal.usuarioLogado = null;
            Close();
            Application.OpenForms["AcessoForm"]?.Show();
            _logRepository.Salvar("Usuário encerrou a sessão");
        }
    }
}
