﻿using System;
using System.Windows.Forms;
using Fortech_TP3A1.Model;
using Fortech_TP3A1.Repository;

namespace Fortech_TP3A1.Forms
{
    public partial class AcessoForm : Form
    {
        private LogRepository _logRepository = new LogRepository();

        public AcessoForm()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            var usuarioRepository = new UsuarioRepository();
            var email = txEmail.Text;
            var senha = txSenha.Text;

            var usuario = usuarioRepository.Autenticado(email, senha);
            if (usuario == null)
            {
                MessageBox.Show("Login ou senha inválidos", "Ácesso negado", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(usuario.nome + " seja bem-vindo!", "Logado com sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ContextoGlobal.usuarioLogado = usuario;
                if (usuario.admin)
                {
                    var usuarioForm = new UsuarioForm();
                    txEmail.Text = "";
                    txSenha.Text = "";
                    usuarioForm.Show();
                }
                else
                {
                    var homeForm = new HomeForm();
                    homeForm.Show();
                }
                Hide();
                _logRepository.Salvar("Usuário realizou login");
            }
        }
        
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["Form1"]?.Show();
        }
    }
}