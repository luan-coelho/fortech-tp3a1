using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms.Admin
{
    public partial class SolicitacaoServicoForm : Form
    {
        private readonly SolicitacaoServicoRepository
            _solicitacaoServicoRepository = new SolicitacaoServicoRepository();

        private readonly TipoServicoRepository _tipoServicoRepository = new TipoServicoRepository();
        private readonly UsuarioRepository _usuarioRepository = new UsuarioRepository();
        private readonly LogRepository _logRepository = new LogRepository();

        public SolicitacaoServicoForm()
        {
            InitializeComponent();
            if (ContextoGlobal.eletronico != null)
            {
                var endereco = new List<Eletronico> { ContextoGlobal.eletronico };
                dtgEletronico.DataSource = endereco;
                btAdicionar.Visible = false;
            }

            if (ContextoGlobal.usuarioSelecionado != null)
            {
                lbNomeUsuario.Text = ContextoGlobal.usuarioSelecionado.nome;
                lbNomeUsuario.Visible = true;
                btAdicionarCliente.Text = "Alterar";
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var form = new AdminHomeForm();
            form.Show();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Close();
            var form = new CadastrarEletronico();
            form.Show();
        }

        private void SolicitacaoServicoForm_Load(object sender, EventArgs e)
        {
            tipoServicoTableAdapter1.Fill(fortechDataSet2.TipoServico);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var tipoServicoBanco = _tipoServicoRepository.BuscarPeloId((int)cbTipoServico.SelectedValue);

            var eletronicos = dtgEletronico.DataSource as List<Eletronico>;
            var solicitacaoServico = new SolicitacaoServico()
            {
                nome = txNome.Text,
                detalhes = txDetalhes.Text,
                valor = decimal.Parse(txValor.Text),
                eletronico = eletronicos != null && eletronicos.Count > 0 ? eletronicos[0] : null,
                tipoServico = tipoServicoBanco,
                Usuario_Id = ContextoGlobal.usuarioSelecionado.Id
            };

            try
            {
                _solicitacaoServicoRepository.Salvar(solicitacaoServico);
                MessageBox.Show("Solicitação realizada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Limpar();
                _logRepository.Salvar("usuário logado criou uma nova solicitação de serviço");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btAdicionarCliente_Click(object sender, EventArgs e)
        {
            Close();
            new SelecionarUsuarioForm().Show();
        }

        private void dtgEletronico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ContextoGlobal.eletronico == null)
            {
                return;
            }

            if (e.ColumnIndex != 0) return;
            {
                dtgEletronico.Columns.Clear();
                btAdicionar.Visible = true;
            }
        }

        public void Limpar()
        {
            ContextoGlobal.usuarioSelecionado = null;
            txNome.Text = txDetalhes.Text = txValor.Text = "";
            dtgEletronico.Columns.Clear();
            lbNomeUsuario.Visible = false;
            btAdicionarCliente.Text = "Adicionar";
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