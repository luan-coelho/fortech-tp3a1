using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Fortech_TP3A1
{
    public partial class CadastrarForm : Form
    {
        public CadastrarForm()
        {
            InitializeComponent();
            if (rdPessoaFisica.Checked)
            {
                lbCnpj.Hide();
                txCnpj.Hide();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();

            FortechContext db = new FortechContext();
            Usuario usuario = new Usuario(txNome.Text, txEmail.Text, txConfirmarSenha.Text, txCpf.Text, txRg.Text, txCnpj.Text, dtpNascimento.Value, true);

            try
            {
                if (validarCampos())
                {
                    usuarioRepository.Salvar(usuario);
                    limparFormulario();
                    MessageBox.Show("Você foi cadastrado com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Algo inesperado aconteceu. Tente novamente mais tarde", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void limparFormulario()
        {
            txNome.Text = txCpf.Text = txEmail.Text = txRg.Text = txSenha.Text = txConfirmarSenha.Text = txCnpj.Text = "";
        }

        private void rdPessoaFisica_Click(object sender, EventArgs e)
        {
            lbCpf.Show();
            txCpf.Show();
            lbRg.Show();
            txRg.Show();
            lbCnpj.Hide();
            txCnpj.Hide();
        }

        private void rdPessoaJuridica_Click(object sender, EventArgs e)
        {
            lbCnpj.Show();
            txCnpj.Show();
            lbCpf.Hide();
            txCpf.Hide();
            lbRg.Hide();
            txRg.Hide();
        }

        private bool validarCampos()
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();


            if (String.IsNullOrEmpty(txNome.Text))
            {
                MessageBox.Show("Informe o nome", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (!String.IsNullOrEmpty(txEmail.Text))
            {
                if(!Regex.IsMatch(txEmail.Text, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"))
                {
                    MessageBox.Show("Informe um email válido", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Informe o email", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rdPessoaFisica.Checked && !String.IsNullOrEmpty(txCpf.Text) && !Regex.IsMatch(txCpf.Text, "^\\d{3}.\\d{3}.\\d{3}-\\d{2}$")) { 
                MessageBox.Show("Informe um CPF válido", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (usuarioRepository.existePeloCpf(txCpf.Text))
                {
                    MessageBox.Show("Já existe um usuário cadastrado com o CPF informado", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txCpf.Text = "";
                }
            }

            if (rdPessoaJuridica.Checked && !String.IsNullOrEmpty(txCnpj.Text) && !Regex.IsMatch(txCpf.Text, "^(?!(\\d)\\1\\.\\1{3}\\.\\1{3}\\/\\1{4}\\\\-\\1{2}$)\\d{2}\\.\\d{3}\\.\\d{3}\\/\\d{4}\\\\-\\d{2}$\r\n"))
            {
               
                MessageBox.Show("Informe um CNPJ válido", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(txSenha.Text))
            {
                MessageBox.Show("Informe uma senha", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(txConfirmarSenha.Text))
            {
                MessageBox.Show("Confirme a senha", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!txSenha.Text.Equals(txConfirmarSenha.Text)){
                MessageBox.Show("As senhas não batem", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CadastrarForm_Load(object sender, EventArgs e)
        {

        }

        private void lbCpf_Click(object sender, EventArgs e)
        {

        }

        private void lbSenha_Click(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void lbCnpj_Click(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbRg_Click(object sender, EventArgs e)
        {

        }

        private void lbConfirmarSenha_Click(object sender, EventArgs e)
        {

        }

        private void txCnpj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
