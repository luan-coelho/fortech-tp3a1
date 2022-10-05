using System;
using System.Windows.Forms;
using Fortech_TP3A1.Forms.Admin;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms
{
    public partial class UsuarioForm : Form
    {
        private readonly UsuarioRepository _repository = new UsuarioRepository();
        private readonly LogRepository _logRepository = new LogRepository();

        public UsuarioForm()
        {
            InitializeComponent();
            var usuarios = new UsuarioRepository().BuscarTodos();
            dtgUsuario.DataSource = usuarios;
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idUsuario = (int)dtgUsuario.Rows[e.RowIndex].Cells[0].Value;

            switch (e.ColumnIndex)
            {
                case 7:
                {
                    var condicao = !(bool)dtgUsuario.Rows[e.RowIndex].Cells[7].Value;

                    if (MessageBox.Show(
                            "Você tem certeza que deseja " + (condicao ? "adicionar" : "remover") +
                            " a permissão de administrador deste usuário?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _repository.AlterarPermissao(idUsuario);
                        dtgUsuario.DataSource = _repository.BuscarTodos();
                        MessageBox.Show(
                            "Permissão de administrador " + (condicao ? "adicionada" : "removida") + " com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        _logRepository.Salvar("Usuário logado " + (condicao ? "adicionou" : "removeu") +
                                              " permissão de administrador ao usuário com id " +
                                              idUsuario);
                    }

                    break;
                }
                case 8:
                {
                    var condicao = !(bool)dtgUsuario.Rows[e.RowIndex].Cells[8].Value;

                    if (MessageBox.Show(
                            "Você tem certeza que deseja " + (condicao ? "ativar" : "desativar") + " este usuário?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _repository.AlterarAtividade(idUsuario);
                        dtgUsuario.DataSource = _repository.BuscarTodos();
                        MessageBox.Show("Usuário " + (condicao ? "ativado" : "desativado") + " com sucesso!", "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        _logRepository.Salvar("Usuário logado " + (condicao ? "ativou" : "desativou") +
                                              " o usuário com id " + idUsuario);
                    }

                    break;
                }
                case 9:
                {
                    var form = new CadastroInfoUsuario(_repository.BuscarPeloId(idUsuario));
                    Hide();
                    form.Show();
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            var form = new CadastroInfoUsuario(null);
            form.Show();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            dtgUsuario.DataSource = _repository.BuscarTodos();
        }

        private void btEncerrarSessao_Click(object sender, EventArgs e)
        {
            ContextoGlobal.usuarioLogado = null;
            Close();
            Application.OpenForms["AcessoForm"]?.Show();
            _logRepository.Salvar("Usuário encerrou a sessão");
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
            var form = new AdminHomeForm();
            form.Show();
        }
    }
}