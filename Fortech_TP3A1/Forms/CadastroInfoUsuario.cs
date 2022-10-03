using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Model.Dto;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms
{
    public partial class CadastroInfoUsuario : Form
    {
        private readonly Usuario _usuario;
        private readonly Endereco _endereco;
        private readonly CredenciaisLogin _credenciaisLogin;

        public CadastroInfoUsuario(Usuario usuario, Endereco endereco, CredenciaisLogin credenciaisLogin)
        {
            InitializeComponent();

            _endereco = endereco;
            _credenciaisLogin = credenciaisLogin;

            if (rdPf.Checked)
            {
                OcultarCamposPessoaJuridica();
            }
            else
            {
                OcultarCamposPessoaFisica();
            }

            if (usuario != null)
            {
                PreencherInputs(usuario);
            }
        }

        public CadastroInfoUsuario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            if (rdPf.Checked)
            {
                OcultarCamposPessoaJuridica();
            }
            else
            {
                OcultarCamposPessoaFisica();
            }

            if (usuario != null)
            {
                PreencherInputs(usuario);
            }
        }

        public void PreencherInputs(Usuario usuario)
        {
            txNome.Text = usuario.nome;
            txCpf.Text = usuario.cpf;
            txRg.Text = usuario.rg;
            txCnpj.Text = usuario.cnpj;
            dtpNascimento.Value = usuario.dataNascimento;
        }

        private void rdPf_CheckedChanged(object sender, EventArgs e)
        {
            OcultarCamposPessoaJuridica();
        }

        private void OcultarCamposPessoaJuridica()
        {
            txCnpj.Text = "";
            lbCpf.Show();
            txCpf.Show();
            lbRg.Show();
            txRg.Show();
            lbCnpj.Hide();
            txCnpj.Hide();
            lbNascimento.Show();
            dtpNascimento.Show();
        }

        private void rdPj_CheckedChanged(object sender, EventArgs e)
        {
            OcultarCamposPessoaFisica();
        }

        private void OcultarCamposPessoaFisica()
        {
            txCpf.Text = "";
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
            if (ContextoGlobal.usuarioLogado != null && ContextoGlobal.usuarioLogado.admin)
            {
                var formUsuario = new UsuarioForm();
                formUsuario.Show();
            }
            else
            {
                Application.OpenForms["Form1"]?.Show();
            }
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            var enderecoForm =
                new EnderecoForm(_usuario ?? MontarObjetoUsuario(), _endereco, _credenciaisLogin);
            enderecoForm.Show();
            ContextoGlobal.cpf = txCpf.Text;
            Close();
        }

        public Usuario MontarObjetoUsuario()
        {
            var usuario = new Usuario
            {
                nome = txNome.Text,
                cpf = txCpf.Text,
                rg = txRg.Text,
                dataNascimento = dtpNascimento.Value
            };
            return usuario;
        }

        private bool ValidarCampos()
        {
            var usuarioRepository = new UsuarioRepository();


            if (string.IsNullOrEmpty(txNome.Text))
            {
                MessageBox.Show("Informe o nome", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rdPessoaFisica.Checked && !string.IsNullOrEmpty(txCpf.Text) &&
                !Regex.IsMatch(txCpf.Text, "^\\d{3}.\\d{3}.\\d{3}-\\d{2}$"))
            {
                MessageBox.Show("Informe um CPF válido", "Validação falhou", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (_usuario != null)
            {
                var usuarioBanco = usuarioRepository.BuscarPeloId(_usuario.Id);
                if (usuarioBanco != null)
                {
                    if (!usuarioBanco.cpf.Equals(txCpf.Text))
                    {
                        if (VerificarSeExisteCpfCadastrado(usuarioRepository) == false)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (!VerificarSeExisteCpfCadastrado(usuarioRepository)) return false;
            }

            if (rdPessoaJuridica.Checked && !string.IsNullOrEmpty(txCnpj.Text) && !Regex.IsMatch(txCpf.Text,
                    "^(?!(\\d)\\1\\.\\1{3}\\.\\1{3}\\/\\1{4}\\\\-\\1{2}$)\\d{2}\\.\\d{3}\\.\\d{3}\\/\\d{4}\\\\-\\d{2}$\r\n"))
            {
                MessageBox.Show("Informe um CNPJ válido", "Validação falhou", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool VerificarSeExisteCpfCadastrado(UsuarioRepository usuarioRepository)
        {
            if (usuarioRepository.ExistePeloCpf(txCpf.Text))
            {
                MessageBox.Show("Já existe um usuário cadastrado com o CPF informado", "Validação falhou",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txCpf.Text = "";
                return false;
            }
            return true;
        }
    }
}