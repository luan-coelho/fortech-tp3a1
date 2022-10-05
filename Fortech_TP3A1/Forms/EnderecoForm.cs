using System;
using System.Windows.Forms;
using Fortech_TP3A1.CorreiosService;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Model.Dto;
using Fortech_TP3A1.Repository;
using Exception = System.Exception;

namespace Fortech_TP3A1.Forms
{
    public partial class EnderecoForm : Form
    {
        private readonly Usuario _usuario;
        private readonly Endereco _endereco;
        private readonly CredenciaisLogin _credenciaisLogin;

        public EnderecoForm(Usuario usuario, Endereco endereco, CredenciaisLogin credenciaisLogin)
        {
            InitializeComponent();
            _usuario = usuario;
            _endereco = endereco;
            _credenciaisLogin = credenciaisLogin;

            if (endereco != null)
            {
                PreencherInputs();
            }

            if (usuario.Id == 0) return;
            var enderecos = new UsuarioRepository().BuscarPeloId(usuario.Id).enderecos;
            dtgEndereco.DataSource = enderecos;
        }

        public void PreencherInputs()
        {
            txCep.Text = _endereco.cep;
            txRua.Text = _endereco.rua;
            txNumero.Text = _endereco.numero;
            txBairro.Text = _endereco.bairro;
            txComplemento.Text = _endereco.complemento;
            txCidade.Text = _endereco.cidade;
            txEstado.Text = _endereco.estado;
        }

        private void btVoltar_Click_1(object sender, EventArgs e)
        {
            var infoUsuario = new CadastroInfoUsuario(_usuario, MontarObjetoEndereco(), _credenciaisLogin);
            infoUsuario.Show();
            Close();
        }

        private void lbGerencia_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            var criacaoLoginForm = new CriacaoLoginForm(_usuario, MontarObjetoEndereco(), _credenciaisLogin);
            criacaoLoginForm.Show();
            Close();
        }

        private Endereco MontarObjetoEndereco()
        {
            var endereco = new Endereco
            {
                cep = txCep.Text,
                rua = txRua.Text,
                bairro = txBairro.Text,
                numero = txNumero.Text,
                complemento = txComplemento.Text,
                cidade = txCidade.Text,
                estado = txEstado.Text
            };

            return endereco;
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            using (var servico = new AtendeClienteClient())
            {
                try
                {
                    var resultado = servico.consultaCEP(txCep.Text);
                    txRua.Text = resultado.end;
                    txBairro.Text = resultado.bairro;
                    txComplemento.Text = resultado.complemento2;
                    txCidade.Text = resultado.cidade;
                    txEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}