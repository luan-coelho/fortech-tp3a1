using System;
using System.Windows.Forms;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms.Admin
{
    public partial class SelecionarUsuarioForm : Form
    {
        private readonly UsuarioRepository _usuarioRepository = new UsuarioRepository();

        public SelecionarUsuarioForm()
        {
            InitializeComponent();
        }

        private void SelecionarUsuarioForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fortechDataSet4.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter1.Fill(this.fortechDataSet4.Usuario);
            // TODO: esta linha de código carrega dados na tabela 'fortechDataSet3.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.fortechDataSet3.Usuario);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dtgUsuario.DataSource = _usuarioRepository.BuscarTodosPeloNome(txNome.Text);
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
            new SolicitacaoServicoForm().Show();
        }

        private void dtgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 8) return;
            var idUsuario = (int)dtgUsuario.Rows[e.RowIndex].Cells[0].Value;
            ContextoGlobal.usuarioSelecionado = _usuarioRepository.BuscarPeloId(idUsuario);
            Close();
            new SolicitacaoServicoForm().Show();
        }
    }
}