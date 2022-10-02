using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms
{
    public partial class UsuarioInfoForm : Form
    {
        private readonly UsuarioRepository _usuarioRepository = new UsuarioRepository();
        
        public UsuarioInfoForm(Usuario usuario)
        {
            InitializeComponent();
            if (!rdPessoaFisica.Checked) return;
            lbCnpj.Hide();
            txCnpj.Hide();
            if (usuario != null)
            {
                PreencherInputs(usuario);
            }
        }

        public void PreencherInputs(Usuario usuario)
        {
            txNome.Text = usuario.nome;
            txEmail.Text = usuario.email;
            txCpf.Text = usuario.cpf;
            txRg.Text = usuario.rg;
            txCnpj.Text = usuario.cnpj;
            txSenha.Text = usuario.senha;
            txConfirmarSenha.Text = usuario.senha;
            dtpNascimento.Value = usuario.dataNascimento;
        }
        
          private bool ValidarCampos()
        {
            var usuarioRepository = new UsuarioRepository();


            if (string.IsNullOrEmpty(txNome.Text))
            {
                MessageBox.Show("Informe o nome", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (!string.IsNullOrEmpty(txEmail.Text))
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

            if (rdPessoaFisica.Checked && !string.IsNullOrEmpty(txCpf.Text) && !Regex.IsMatch(txCpf.Text, "^\\d{3}.\\d{3}.\\d{3}-\\d{2}$")) { 
                MessageBox.Show("Informe um CPF válido", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (usuarioRepository.ExistePeloEmail(txEmail.Text))
            {
                MessageBox.Show("Já existe um usuário cadastrado com o Email informado", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txEmail.Text = "";
                return false;
            }

            if (usuarioRepository.ExistePeloCpf(txCpf.Text))
            {
                MessageBox.Show("Já existe um usuário cadastrado com o CPF informado", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txCpf.Text = "";
                return false;
            }

            if (rdPessoaJuridica.Checked && !string.IsNullOrEmpty(txCnpj.Text) && !Regex.IsMatch(txCpf.Text, "^(?!(\\d)\\1\\.\\1{3}\\.\\1{3}\\/\\1{4}\\\\-\\1{2}$)\\d{2}\\.\\d{3}\\.\\d{3}\\/\\d{4}\\\\-\\d{2}$\r\n"))
            {
               
                MessageBox.Show("Informe um CNPJ válido", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txSenha.Text))
            {
                MessageBox.Show("Informe uma senha", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txConfirmarSenha.Text))
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
        
        private void LimparFormulario()
        {
            txNome.Text = txCpf.Text = txEmail.Text = txRg.Text = txSenha.Text = txConfirmarSenha.Text = txCnpj.Text = "";
        }

        private void rdPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            lbCpf.Show();
            txCpf.Show();
            lbRg.Show();
            txRg.Show();
            lbCnpj.Hide();
            txCnpj.Hide();
            lbNascimento.Show();
            dtpNascimento.Show();
        }

        private void rdPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lbCnpj.Show();
            txCnpj.Show();
            lbCpf.Hide();
            txCpf.Hide();
            lbRg.Hide();
            txRg.Hide();
            lbNascimento.Hide();
            dtpNascimento.Hide();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario(txNome.Text, txEmail.Text, txConfirmarSenha.Text, txCpf.Text, txRg.Text, txCnpj.Text, dtpNascimento.Value, true);
            try
            {
                if (!ValidarCampos()) return;
                _usuarioRepository.Salvar(usuario);
                LimparFormulario();
                MessageBox.Show("Você foi cadastrado com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Algo inesperado aconteceu. Tente novamente mais tarde", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}