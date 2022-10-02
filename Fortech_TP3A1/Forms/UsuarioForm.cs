using System;
using System.Windows.Forms;
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
            // ReSharper disable once PossibleNullReferenceException
            dtgUsuario.Columns["senha"].Visible = false;
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var idUsuario = (int)dtgUsuario.Rows[e.RowIndex].Cells[1].Value;
                var form = new UsuarioInfoForm(_repository.BuscarPeloId(idUsuario));
                form.ShowDialog();
            }

            if (e.ColumnIndex == 10)
            {
                var idUsuario = (int)dtgUsuario.Rows[e.RowIndex].Cells[1].Value;

                if (!(bool)dtgUsuario.Rows[e.RowIndex].Cells[10].Value)
                {
                    _repository.AlterarAtividade(idUsuario);
                    dtgUsuario.DataSource = _repository.BuscarTodos();
                    MessageBox.Show("Usuário ativado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _logRepository.Salvar("Usuário logado ativou o usuário com id " + idUsuario);
                    return;
                }

                if (MessageBox.Show("Você tem certeza que deseja desativar este usuário?", "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repository.AlterarAtividade(idUsuario);
                    dtgUsuario.DataSource = _repository.BuscarTodos();
                    MessageBox.Show("Usuário desativado com sucesso!", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _logRepository.Salvar("Usuário logado desativou o usuário com id " + idUsuario);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new UsuarioInfoForm(null);
            form.ShowDialog();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            dtgUsuario.DataSource = _repository.BuscarTodos();
        }
    }
}