using System;
using System.Windows.Forms;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Forms
{
    public partial class UsuarioInfoForm : Form
    {
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
            var enderecoForm = new EnderecoForm();
            enderecoForm.ShowDialog();
        }
    }
}