using System;
using System.Windows.Forms;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms
{
    public partial class UsuarioForm : Form
    {
        private readonly UsuarioRepository _repository = new UsuarioRepository();
        
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            var idUsuario = (int) dtgUsuario.Rows[e.RowIndex].Cells[1].Value;
            var form = new UsuarioInfoForm(_repository.BuscarPeloId(idUsuario));
            form.ShowDialog();
        }
    }
}