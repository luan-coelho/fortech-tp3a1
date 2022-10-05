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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fortechDataSet = new Fortech_TP3A1.fortechDataSet();
            this.btNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btEncerrarSessao = new System.Windows.Forms.Button();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new Fortech_TP3A1.fortechDataSetTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortechDataSet)).BeginInit();
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
            this.dtgUsuario.AutoGenerateColumns = false;
            this.dtgUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.clmId, this.clmNome, this.clmEmail, this.clmCpf, this.clmRg, this.clmCnpj, this.clmDataNascimento, this.clmAdmin, this.clmAtivo, this.clmEditar });
            this.dtgUsuario.DataSource = this.usuarioBindingSource;
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
            this.clmId.DataPropertyName = "Id";
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "nome";
            this.clmNome.HeaderText = "nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.DataPropertyName = "email";
            this.clmEmail.HeaderText = "email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            // 
            // clmCpf
            // 
            this.clmCpf.DataPropertyName = "cpf";
            this.clmCpf.HeaderText = "cpf";
            this.clmCpf.Name = "clmCpf";
            this.clmCpf.ReadOnly = true;
            // 
            // clmRg
            // 
            this.clmRg.DataPropertyName = "rg";
            this.clmRg.HeaderText = "rg";
            this.clmRg.Name = "clmRg";
            this.clmRg.ReadOnly = true;
            // 
            // clmCnpj
            // 
            this.clmCnpj.DataPropertyName = "cnpj";
            this.clmCnpj.HeaderText = "cnpj";
            this.clmCnpj.Name = "clmCnpj";
            this.clmCnpj.ReadOnly = true;
            // 
            // clmDataNascimento
            // 
            this.clmDataNascimento.DataPropertyName = "dataNascimento";
            this.clmDataNascimento.HeaderText = "dataNascimento";
            this.clmDataNascimento.Name = "clmDataNascimento";
            this.clmDataNascimento.ReadOnly = true;
            // 
            // clmAdmin
            // 
            this.clmAdmin.DataPropertyName = "admin";
            this.clmAdmin.HeaderText = "admin";
            this.clmAdmin.Name = "clmAdmin";
            this.clmAdmin.ReadOnly = true;
            // 
            // clmAtivo
            // 
            this.clmAtivo.DataPropertyName = "ativo";
            this.clmAtivo.HeaderText = "ativo";
            this.clmAtivo.Name = "clmAtivo";
            this.clmAtivo.ReadOnly = true;
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
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.fortechDataSet;
            // 
            // fortechDataSet
            // 
            this.fortechDataSet.DataSetName = "fortechDataSet";
            this.fortechDataSet.Namespace = "http://tempuri.org/fortechDataSet.xsd";
            this.fortechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Controls.Add(this.btEncerrarSessao);
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 54);
            this.panel1.TabIndex = 2;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(452, 11);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 33);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
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
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(12, 12);
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
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortechDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btVoltar;

        private System.Windows.Forms.Button btEncerrarSessao;

        private System.Windows.Forms.Button btAtualizar;

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button btNovo;

        private System.Windows.Forms.DataGridView dtgUsuario;

        #endregion

        private fortechDataSet fortechDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private fortechDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataNascimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAtivo;
        private System.Windows.Forms.DataGridViewButtonColumn clmEditar;
    }
}