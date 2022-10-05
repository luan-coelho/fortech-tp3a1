using System.ComponentModel;

namespace Fortech_TP3A1.Forms.Admin
{
    partial class AdminHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.btSolicitacoes = new System.Windows.Forms.Button();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btEncerrarSessao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(25, 40);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(253, 29);
            this.lbGerencia.TabIndex = 2;
            this.lbGerencia.Text = "Gestão Administrador";
            // 
            // btSolicitacoes
            // 
            this.btSolicitacoes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btSolicitacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSolicitacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSolicitacoes.ForeColor = System.Drawing.Color.White;
            this.btSolicitacoes.Location = new System.Drawing.Point(36, 162);
            this.btSolicitacoes.Name = "btSolicitacoes";
            this.btSolicitacoes.Size = new System.Drawing.Size(272, 36);
            this.btSolicitacoes.TabIndex = 6;
            this.btSolicitacoes.Text = "Criar solicitação";
            this.btSolicitacoes.UseVisualStyleBackColor = false;
            this.btSolicitacoes.Click += new System.EventHandler(this.btSolicitacoes_Click);
            // 
            // btUsuarios
            // 
            this.btUsuarios.BackColor = System.Drawing.Color.Green;
            this.btUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btUsuarios.Location = new System.Drawing.Point(36, 219);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(272, 36);
            this.btUsuarios.TabIndex = 7;
            this.btUsuarios.Text = "Usuários";
            this.btUsuarios.UseVisualStyleBackColor = false;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btEncerrarSessao
            // 
            this.btEncerrarSessao.BackColor = System.Drawing.Color.Red;
            this.btEncerrarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncerrarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrarSessao.ForeColor = System.Drawing.Color.White;
            this.btEncerrarSessao.Location = new System.Drawing.Point(70, 270);
            this.btEncerrarSessao.Name = "btEncerrarSessao";
            this.btEncerrarSessao.Size = new System.Drawing.Size(196, 36);
            this.btEncerrarSessao.TabIndex = 8;
            this.btEncerrarSessao.Text = "Encerrar Sessão";
            this.btEncerrarSessao.UseVisualStyleBackColor = false;
            this.btEncerrarSessao.Click += new System.EventHandler(this.btEncerrarSessao_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Todas as solicitações";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEncerrarSessao);
            this.Controls.Add(this.btUsuarios);
            this.Controls.Add(this.btSolicitacoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Administrador";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btSolicitacoes;
        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Button btEncerrarSessao;

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.Button button1;
    }
}