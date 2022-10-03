using System.ComponentModel;

namespace Fortech_TP3A1.Forms
{
    partial class UsuarioForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcpfcnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesabilitar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btEncerrarSessao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AllowUserToResizeColumns = false;
            this.dtgUsuario.AllowUserToResizeRows = false;
            this.dtgUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.clmId, this.clmNome, this.clmEmail, this.clmcpfcnpj, this.clmDesabilitar, this.clmRg, this.clmCnpj, this.clmDataNascimento, this.clmAdmin, this.clmEditar });
            this.dtgUsuario.Location = new System.Drawing.Point(12, 115);
            this.dtgUsuario.MultiSelect = false;
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersVisible = false;
            this.dtgUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgUsuario.ShowEditingIcon = false;
            this.dtgUsuario.Size = new System.Drawing.Size(643, 258);
            this.dtgUsuario.TabIndex = 0;
            this.dtgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellClick);
            this.dtgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellContentClick);
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "id";
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "nome";
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.DataPropertyName = "email";
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            // 
            // clmcpfcnpj
            // 
            this.clmcpfcnpj.DataPropertyName = "cpf";
            this.clmcpfcnpj.HeaderText = "CPF/CNPJ";
            this.clmcpfcnpj.Name = "clmcpfcnpj";
            this.clmcpfcnpj.ReadOnly = true;
            // 
            // clmDesabilitar
            // 
            this.clmDesabilitar.DataPropertyName = "ativo";
            this.clmDesabilitar.HeaderText = "Ativo";
            this.clmDesabilitar.Name = "clmDesabilitar";
            this.clmDesabilitar.ReadOnly = true;
            // 
            // clmRg
            // 
            this.clmRg.DataPropertyName = "rg";
            this.clmRg.HeaderText = "RG";
            this.clmRg.Name = "clmRg";
            this.clmRg.ReadOnly = true;
            // 
            // clmCnpj
            // 
            this.clmCnpj.DataPropertyName = "cnpj";
            this.clmCnpj.HeaderText = "CNPJ";
            this.clmCnpj.Name = "clmCnpj";
            this.clmCnpj.ReadOnly = true;
            // 
            // clmDataNascimento
            // 
            this.clmDataNascimento.DataPropertyName = "dataNascimento";
            this.clmDataNascimento.HeaderText = "Nascimento";
            this.clmDataNascimento.Name = "clmDataNascimento";
            this.clmDataNascimento.ReadOnly = true;
            // 
            // clmAdmin
            // 
            this.clmAdmin.DataPropertyName = "admin";
            this.clmAdmin.HeaderText = "Admin";
            this.clmAdmin.Name = "clmAdmin";
            this.clmAdmin.ReadOnly = true;
            // 
            // clmEditar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.clmEditar.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clmEditar.HeaderText = "";
            this.clmEditar.Name = "clmEditar";
            this.clmEditar.ReadOnly = true;
            this.clmEditar.Text = "Editar";
            this.clmEditar.UseColumnTextForButtonValue = true;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Green;
            this.btNovo.FlatAppearance.BorderSize = 0;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.Color.White;
            this.btNovo.Location = new System.Drawing.Point(12, 76);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(76, 33);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btEncerrarSessao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 54);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerencia de Usuários";
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(12, 9);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(247, 29);
            this.lbGerencia.TabIndex = 0;
            this.lbGerencia.Text = "Gerencia de Usuários";
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btAtualizar.FlatAppearance.BorderSize = 0;
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.ForeColor = System.Drawing.Color.White;
            this.btAtualizar.Location = new System.Drawing.Point(579, 76);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(76, 33);
            this.btAtualizar.TabIndex = 3;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btEncerrarSessao
            // 
            this.btEncerrarSessao.BackColor = System.Drawing.Color.Red;
            this.btEncerrarSessao.FlatAppearance.BorderSize = 0;
            this.btEncerrarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncerrarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrarSessao.ForeColor = System.Drawing.Color.White;
            this.btEncerrarSessao.Location = new System.Drawing.Point(534, 14);
            this.btEncerrarSessao.Name = "btEncerrarSessao";
            this.btEncerrarSessao.Size = new System.Drawing.Size(121, 27);
            this.btEncerrarSessao.TabIndex = 4;
            this.btEncerrarSessao.Text = "Encerrar Sessão";
            this.btEncerrarSessao.UseVisualStyleBackColor = false;
            this.btEncerrarSessao.Click += new System.EventHandler(this.btEncerrarSessao_Click);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 396);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.dtgUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btEncerrarSessao;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btAtualizar;

        private System.Windows.Forms.DataGridViewTextBoxColumn clmCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataNascimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAdmin;

        private System.Windows.Forms.DataGridViewTextBoxColumn clmRg;

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button btNovo;

        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDesabilitar;

        private System.Windows.Forms.DataGridViewButtonColumn clmEditar;

        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcpfcnpj;

        private System.Windows.Forms.DataGridView dtgUsuario;

        #endregion
    }
}