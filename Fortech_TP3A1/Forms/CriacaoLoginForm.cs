using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Model.Dto;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms
{
    public partial class CriacaoLoginForm : Form
    {
        private readonly UsuarioRepository _usuarioRepository = new UsuarioRepository();
        private Usuario _usuario;
        private Endereco _endereco;
        private CredenciaisLogin _credenciaisLogin;

        public CriacaoLoginForm(Usuario usuario, Endereco endereco, CredenciaisLogin credenciaisLogin)
        {
            InitializeComponent();
            _usuario = usuario;
            _endereco = endereco;
            _credenciaisLogin = credenciaisLogin;
            if (credenciaisLogin != null)
            {
                PreencherInputs();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                _usuario.email = txEmail.Text;
                _usuario.senha = txConfirmarSenha.Text;
                _usuario.ativo = true;
                if (_usuario.enderecos == null)
                {
                    _usuario.enderecos = new List<Endereco>();
                }

                _usuario.enderecos.Add(_endereco);
                _usuarioRepository.Salvar(_usuario);
                Limpar();

                MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro ao salvar usuário", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            var enderecoForm = new EnderecoForm(_usuario, _endereco, MontarObjetoCredenciais());
            enderecoForm.Show();
            Close();
        }

        private CredenciaisLogin MontarObjetoCredenciais()
        {
            var credenciais = new CredenciaisLogin
            {
                email = txEmail.Text,
            };
            return credenciais;
        }

        public void Limpar()
        {
            _usuario = null;
            _endereco = null;
            _credenciaisLogin = null;
            txEmail.Text = "";
            txSenha.Text = "";
            txConfirmarSenha.Text = "";
        }

        public void PreencherInputs()
        {
            txEmail.Text = _credenciaisLogin.email;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
            if (ContextoGlobal.usuarioLogado.admin)
            {
                var formUsuario = new UsuarioForm();
                formUsuario.Show();
            }
            else
            {
                Application.OpenForms["Form1"]?.Show();
            }
        }

        private bool ValidarCampos()
        {
            var usuarioRepository = new UsuarioRepository();

            if (!string.IsNullOrEmpty(txEmail.Text))
            {
                if (!Regex.IsMatch(txEmail.Text, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"))
                {
                    MessageBox.Show("Informe um email válido", "Validação falhou", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Informe o email", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_usuario != null)
            {
                var usuarioBanco = usuarioRepository.BuscarPeloId(_usuario.Id);
                if (usuarioBanco != null)
                {
                    if (!usuarioBanco.email.Equals(txEmail.Text))
                    {
                        if (VerificarSeExisteEmailCadastrado(usuarioRepository) == false)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (!VerificarSeExisteEmailCadastrado(usuarioRepository)) return false;
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

            if (!txSenha.Text.Equals(txConfirmarSenha.Text))
            {
                MessageBox.Show("As senhas não batem", "Validação falhou", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool VerificarSeExisteEmailCadastrado(UsuarioRepository usuarioRepository)
        {
            if (usuarioRepository.ExistePeloEmail(txEmail.Text))
            {
                MessageBox.Show("Já existe um usuário cadastrado com o Email informado", "Validação falhou",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txEmail.Text = "";
                return false;
            }

            return true;
        }
    }
}