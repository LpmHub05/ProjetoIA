namespace CadastroIA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.gbxFrmCategoria = new System.Windows.Forms.GroupBox();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.lblAnoLancamentoIA = new System.Windows.Forms.Label();
            this.lblNomeCategoria = new System.Windows.Forms.Label();
            this.lblCodigoCategoria = new System.Windows.Forms.Label();
            this.btnConfirmarAlteracoes = new System.Windows.Forms.Button();
            this.gbxBotoesCategoriaFabricante = new System.Windows.Forms.GroupBox();
            this.btnUltimoCategoriaFabricante = new System.Windows.Forms.Button();
            this.btnPrimeiroCategoriaFabricante = new System.Windows.Forms.Button();
            this.btnPosteriorCategoriaFabricante = new System.Windows.Forms.Button();
            this.btnSairCategoriaFabricante = new System.Windows.Forms.Button();
            this.btnAnteriorCategoriaFabricante = new System.Windows.Forms.Button();
            this.btnCadastrarCategoriaFabricante = new System.Windows.Forms.Button();
            this.btnExcluirCategoriaFabricante = new System.Windows.Forms.Button();
            this.btnAlterarCategoriaFabricante = new System.Windows.Forms.Button();
            this.gbxFrmFabricante = new System.Windows.Forms.GroupBox();
            this.txtProprietarioFabricante = new System.Windows.Forms.TextBox();
            this.txtPaisOrigemFabricante = new System.Windows.Forms.TextBox();
            this.txtNomeFabricante = new System.Windows.Forms.TextBox();
            this.txtCodigoFabricante = new System.Windows.Forms.TextBox();
            this.lblPaisOrigemFabricante = new System.Windows.Forms.Label();
            this.lblProprietarioFabricante = new System.Windows.Forms.Label();
            this.lblNomeFabricante = new System.Windows.Forms.Label();
            this.lblCodigoFabricante = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nmVoltarCadastrarIAs = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxFrmCategoria.SuspendLayout();
            this.gbxBotoesCategoriaFabricante.SuspendLayout();
            this.gbxFrmFabricante.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFrmCategoria
            // 
            this.gbxFrmCategoria.Controls.Add(this.txtDescricaoCategoria);
            this.gbxFrmCategoria.Controls.Add(this.txtNomeCategoria);
            this.gbxFrmCategoria.Controls.Add(this.txtCodigoCategoria);
            this.gbxFrmCategoria.Controls.Add(this.lblAnoLancamentoIA);
            this.gbxFrmCategoria.Controls.Add(this.lblNomeCategoria);
            this.gbxFrmCategoria.Controls.Add(this.lblCodigoCategoria);
            this.gbxFrmCategoria.Location = new System.Drawing.Point(105, 49);
            this.gbxFrmCategoria.Name = "gbxFrmCategoria";
            this.gbxFrmCategoria.Size = new System.Drawing.Size(346, 263);
            this.gbxFrmCategoria.TabIndex = 9;
            this.gbxFrmCategoria.TabStop = false;
            this.gbxFrmCategoria.Text = "frmCategoria";
            // 
            // txtDescricaoCategoria
            // 
            this.txtDescricaoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCategoria.Location = new System.Drawing.Point(22, 135);
            this.txtDescricaoCategoria.Multiline = true;
            this.txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            this.txtDescricaoCategoria.Size = new System.Drawing.Size(264, 93);
            this.txtDescricaoCategoria.TabIndex = 20;
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Enabled = false;
            this.txtNomeCategoria.Location = new System.Drawing.Point(155, 70);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.ReadOnly = true;
            this.txtNomeCategoria.Size = new System.Drawing.Size(115, 20);
            this.txtNomeCategoria.TabIndex = 8;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Enabled = false;
            this.txtCodigoCategoria.Location = new System.Drawing.Point(80, 39);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.ReadOnly = true;
            this.txtCodigoCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCategoria.TabIndex = 7;
            this.txtCodigoCategoria.TextChanged += new System.EventHandler(this.TxtCodigoCategoria_TextChanged);
            // 
            // lblAnoLancamentoIA
            // 
            this.lblAnoLancamentoIA.AutoSize = true;
            this.lblAnoLancamentoIA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoLancamentoIA.Location = new System.Drawing.Point(19, 108);
            this.lblAnoLancamentoIA.Name = "lblAnoLancamentoIA";
            this.lblAnoLancamentoIA.Size = new System.Drawing.Size(152, 17);
            this.lblAnoLancamentoIA.TabIndex = 2;
            this.lblAnoLancamentoIA.Text = "Descrição da Categoria:";
            // 
            // lblNomeCategoria
            // 
            this.lblNomeCategoria.AutoSize = true;
            this.lblNomeCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCategoria.Location = new System.Drawing.Point(19, 73);
            this.lblNomeCategoria.Name = "lblNomeCategoria";
            this.lblNomeCategoria.Size = new System.Drawing.Size(130, 17);
            this.lblNomeCategoria.TabIndex = 1;
            this.lblNomeCategoria.Text = "Nome da Categoria:";
            // 
            // lblCodigoCategoria
            // 
            this.lblCodigoCategoria.AutoSize = true;
            this.lblCodigoCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCategoria.Location = new System.Drawing.Point(19, 40);
            this.lblCodigoCategoria.Name = "lblCodigoCategoria";
            this.lblCodigoCategoria.Size = new System.Drawing.Size(55, 17);
            this.lblCodigoCategoria.TabIndex = 0;
            this.lblCodigoCategoria.Text = "Código:";
            // 
            // btnConfirmarAlteracoes
            // 
            this.btnConfirmarAlteracoes.Enabled = false;
            this.btnConfirmarAlteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAlteracoes.Location = new System.Drawing.Point(93, 183);
            this.btnConfirmarAlteracoes.Name = "btnConfirmarAlteracoes";
            this.btnConfirmarAlteracoes.Size = new System.Drawing.Size(93, 45);
            this.btnConfirmarAlteracoes.TabIndex = 14;
            this.btnConfirmarAlteracoes.Text = "Confirmar Alterações";
            this.btnConfirmarAlteracoes.UseVisualStyleBackColor = true;
            this.btnConfirmarAlteracoes.Click += new System.EventHandler(this.BtnConfirmarAlteracoesCategoria_Click);
            // 
            // gbxBotoesCategoriaFabricante
            // 
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnUltimoCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnPrimeiroCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnPosteriorCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnSairCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnAnteriorCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnCadastrarCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnExcluirCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Controls.Add(this.btnAlterarCategoriaFabricante);
            this.gbxBotoesCategoriaFabricante.Location = new System.Drawing.Point(62, 327);
            this.gbxBotoesCategoriaFabricante.Name = "gbxBotoesCategoriaFabricante";
            this.gbxBotoesCategoriaFabricante.Size = new System.Drawing.Size(800, 69);
            this.gbxBotoesCategoriaFabricante.TabIndex = 12;
            this.gbxBotoesCategoriaFabricante.TabStop = false;
            this.gbxBotoesCategoriaFabricante.Text = "Botões";
            // 
            // btnUltimoCategoriaFabricante
            // 
            this.btnUltimoCategoriaFabricante.Enabled = false;
            this.btnUltimoCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoCategoriaFabricante.Location = new System.Drawing.Point(311, 19);
            this.btnUltimoCategoriaFabricante.Name = "btnUltimoCategoriaFabricante";
            this.btnUltimoCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnUltimoCategoriaFabricante.TabIndex = 10;
            this.btnUltimoCategoriaFabricante.Text = "Último";
            this.btnUltimoCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnUltimoCategoriaFabricante.Click += new System.EventHandler(this.BtnUltimoCategoriaFabricante_Click);
            // 
            // btnPrimeiroCategoriaFabricante
            // 
            this.btnPrimeiroCategoriaFabricante.Enabled = false;
            this.btnPrimeiroCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiroCategoriaFabricante.Location = new System.Drawing.Point(210, 19);
            this.btnPrimeiroCategoriaFabricante.Name = "btnPrimeiroCategoriaFabricante";
            this.btnPrimeiroCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnPrimeiroCategoriaFabricante.TabIndex = 9;
            this.btnPrimeiroCategoriaFabricante.Text = "Primeiro";
            this.btnPrimeiroCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnPrimeiroCategoriaFabricante.Click += new System.EventHandler(this.BtnPrimeiroCategoriaFabricante_Click);
            // 
            // btnPosteriorCategoriaFabricante
            // 
            this.btnPosteriorCategoriaFabricante.Enabled = false;
            this.btnPosteriorCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosteriorCategoriaFabricante.Location = new System.Drawing.Point(112, 19);
            this.btnPosteriorCategoriaFabricante.Name = "btnPosteriorCategoriaFabricante";
            this.btnPosteriorCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnPosteriorCategoriaFabricante.TabIndex = 8;
            this.btnPosteriorCategoriaFabricante.Text = "Posterior";
            this.btnPosteriorCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnPosteriorCategoriaFabricante.Click += new System.EventHandler(this.btnPosteriorCategoriaFabricante_Click);
            // 
            // btnSairCategoriaFabricante
            // 
            this.btnSairCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairCategoriaFabricante.Location = new System.Drawing.Point(700, 19);
            this.btnSairCategoriaFabricante.Name = "btnSairCategoriaFabricante";
            this.btnSairCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnSairCategoriaFabricante.TabIndex = 7;
            this.btnSairCategoriaFabricante.Text = "Sair";
            this.btnSairCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnSairCategoriaFabricante.Click += new System.EventHandler(this.btnSairCategoriaFabricante_Click);
            // 
            // btnAnteriorCategoriaFabricante
            // 
            this.btnAnteriorCategoriaFabricante.Enabled = false;
            this.btnAnteriorCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorCategoriaFabricante.Location = new System.Drawing.Point(15, 19);
            this.btnAnteriorCategoriaFabricante.Name = "btnAnteriorCategoriaFabricante";
            this.btnAnteriorCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnAnteriorCategoriaFabricante.TabIndex = 6;
            this.btnAnteriorCategoriaFabricante.Text = "Anterior";
            this.btnAnteriorCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnAnteriorCategoriaFabricante.Click += new System.EventHandler(this.BtnAnteriorCategoriaFabricante_Click);
            // 
            // btnCadastrarCategoriaFabricante
            // 
            this.btnCadastrarCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCategoriaFabricante.Location = new System.Drawing.Point(409, 19);
            this.btnCadastrarCategoriaFabricante.Name = "btnCadastrarCategoriaFabricante";
            this.btnCadastrarCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnCadastrarCategoriaFabricante.TabIndex = 3;
            this.btnCadastrarCategoriaFabricante.Text = "Cadastrar";
            this.btnCadastrarCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoriaFabricante.Click += new System.EventHandler(this.btnCadastrarCategoriaFabricante_Click);
            // 
            // btnExcluirCategoriaFabricante
            // 
            this.btnExcluirCategoriaFabricante.Enabled = false;
            this.btnExcluirCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCategoriaFabricante.Location = new System.Drawing.Point(504, 19);
            this.btnExcluirCategoriaFabricante.Name = "btnExcluirCategoriaFabricante";
            this.btnExcluirCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnExcluirCategoriaFabricante.TabIndex = 4;
            this.btnExcluirCategoriaFabricante.Text = "Excluir";
            this.btnExcluirCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnExcluirCategoriaFabricante.Click += new System.EventHandler(this.BtnExcluirCategoriaFabricante_Click);
            // 
            // btnAlterarCategoriaFabricante
            // 
            this.btnAlterarCategoriaFabricante.Enabled = false;
            this.btnAlterarCategoriaFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCategoriaFabricante.Location = new System.Drawing.Point(601, 19);
            this.btnAlterarCategoriaFabricante.Name = "btnAlterarCategoriaFabricante";
            this.btnAlterarCategoriaFabricante.Size = new System.Drawing.Size(88, 36);
            this.btnAlterarCategoriaFabricante.TabIndex = 5;
            this.btnAlterarCategoriaFabricante.Text = "Alterar";
            this.btnAlterarCategoriaFabricante.UseVisualStyleBackColor = true;
            this.btnAlterarCategoriaFabricante.Click += new System.EventHandler(this.BtnAlterarCategoriaFabricante_Click);
            // 
            // gbxFrmFabricante
            // 
            this.gbxFrmFabricante.Controls.Add(this.txtProprietarioFabricante);
            this.gbxFrmFabricante.Controls.Add(this.btnConfirmarAlteracoes);
            this.gbxFrmFabricante.Controls.Add(this.txtPaisOrigemFabricante);
            this.gbxFrmFabricante.Controls.Add(this.txtNomeFabricante);
            this.gbxFrmFabricante.Controls.Add(this.txtCodigoFabricante);
            this.gbxFrmFabricante.Controls.Add(this.lblPaisOrigemFabricante);
            this.gbxFrmFabricante.Controls.Add(this.lblProprietarioFabricante);
            this.gbxFrmFabricante.Controls.Add(this.lblNomeFabricante);
            this.gbxFrmFabricante.Controls.Add(this.lblCodigoFabricante);
            this.gbxFrmFabricante.Location = new System.Drawing.Point(471, 49);
            this.gbxFrmFabricante.Name = "gbxFrmFabricante";
            this.gbxFrmFabricante.Size = new System.Drawing.Size(301, 263);
            this.gbxFrmFabricante.TabIndex = 15;
            this.gbxFrmFabricante.TabStop = false;
            this.gbxFrmFabricante.Text = "frmFabricante";
            // 
            // txtProprietarioFabricante
            // 
            this.txtProprietarioFabricante.Location = new System.Drawing.Point(110, 105);
            this.txtProprietarioFabricante.Name = "txtProprietarioFabricante";
            this.txtProprietarioFabricante.Size = new System.Drawing.Size(138, 20);
            this.txtProprietarioFabricante.TabIndex = 9;
            // 
            // txtPaisOrigemFabricante
            // 
            this.txtPaisOrigemFabricante.Location = new System.Drawing.Point(130, 135);
            this.txtPaisOrigemFabricante.Name = "txtPaisOrigemFabricante";
            this.txtPaisOrigemFabricante.Size = new System.Drawing.Size(111, 20);
            this.txtPaisOrigemFabricante.TabIndex = 10;
            // 
            // txtNomeFabricante
            // 
            this.txtNomeFabricante.Enabled = false;
            this.txtNomeFabricante.Location = new System.Drawing.Point(161, 72);
            this.txtNomeFabricante.Name = "txtNomeFabricante";
            this.txtNomeFabricante.ReadOnly = true;
            this.txtNomeFabricante.Size = new System.Drawing.Size(120, 20);
            this.txtNomeFabricante.TabIndex = 8;
            // 
            // txtCodigoFabricante
            // 
            this.txtCodigoFabricante.Enabled = false;
            this.txtCodigoFabricante.Location = new System.Drawing.Point(80, 40);
            this.txtCodigoFabricante.Name = "txtCodigoFabricante";
            this.txtCodigoFabricante.ReadOnly = true;
            this.txtCodigoFabricante.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFabricante.TabIndex = 7;
            // 
            // lblPaisOrigemFabricante
            // 
            this.lblPaisOrigemFabricante.AutoSize = true;
            this.lblPaisOrigemFabricante.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaisOrigemFabricante.Location = new System.Drawing.Point(19, 141);
            this.lblPaisOrigemFabricante.Name = "lblPaisOrigemFabricante";
            this.lblPaisOrigemFabricante.Size = new System.Drawing.Size(105, 17);
            this.lblPaisOrigemFabricante.TabIndex = 4;
            this.lblPaisOrigemFabricante.Text = "País de Origem:";
            // 
            // lblProprietarioFabricante
            // 
            this.lblProprietarioFabricante.AutoSize = true;
            this.lblProprietarioFabricante.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProprietarioFabricante.Location = new System.Drawing.Point(19, 108);
            this.lblProprietarioFabricante.Name = "lblProprietarioFabricante";
            this.lblProprietarioFabricante.Size = new System.Drawing.Size(85, 17);
            this.lblProprietarioFabricante.TabIndex = 2;
            this.lblProprietarioFabricante.Text = "Proprietário:";
            // 
            // lblNomeFabricante
            // 
            this.lblNomeFabricante.AutoSize = true;
            this.lblNomeFabricante.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFabricante.Location = new System.Drawing.Point(19, 73);
            this.lblNomeFabricante.Name = "lblNomeFabricante";
            this.lblNomeFabricante.Size = new System.Drawing.Size(136, 17);
            this.lblNomeFabricante.TabIndex = 1;
            this.lblNomeFabricante.Text = "Nome do Fabricante:";
            // 
            // lblCodigoFabricante
            // 
            this.lblCodigoFabricante.AutoSize = true;
            this.lblCodigoFabricante.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFabricante.Location = new System.Drawing.Point(19, 40);
            this.lblCodigoFabricante.Name = "lblCodigoFabricante";
            this.lblCodigoFabricante.Size = new System.Drawing.Size(55, 17);
            this.lblCodigoFabricante.TabIndex = 0;
            this.lblCodigoFabricante.Text = "Código:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmVoltarCadastrarIAs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nmVoltarCadastrarIAs
            // 
            this.nmVoltarCadastrarIAs.Enabled = false;
            this.nmVoltarCadastrarIAs.Name = "nmVoltarCadastrarIAs";
            this.nmVoltarCadastrarIAs.Size = new System.Drawing.Size(49, 20);
            this.nmVoltarCadastrarIAs.Text = "Voltar";
            this.nmVoltarCadastrarIAs.Click += new System.EventHandler(this.nmVoltarCadastrarIAs_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbxFrmFabricante);
            this.Controls.Add(this.gbxBotoesCategoriaFabricante);
            this.Controls.Add(this.gbxFrmCategoria);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbxFrmCategoria.ResumeLayout(false);
            this.gbxFrmCategoria.PerformLayout();
            this.gbxBotoesCategoriaFabricante.ResumeLayout(false);
            this.gbxFrmFabricante.ResumeLayout(false);
            this.gbxFrmFabricante.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxFrmCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
        private System.Windows.Forms.Label lblAnoLancamentoIA;
        private System.Windows.Forms.Label lblNomeCategoria;
        private System.Windows.Forms.Label lblCodigoCategoria;
        private System.Windows.Forms.Button btnConfirmarAlteracoes;
        private System.Windows.Forms.GroupBox gbxBotoesCategoriaFabricante;
        private System.Windows.Forms.Button btnUltimoCategoriaFabricante;
        private System.Windows.Forms.Button btnPrimeiroCategoriaFabricante;
        private System.Windows.Forms.Button btnPosteriorCategoriaFabricante;
        private System.Windows.Forms.Button btnSairCategoriaFabricante;
        private System.Windows.Forms.Button btnAnteriorCategoriaFabricante;
        private System.Windows.Forms.Button btnAlterarCategoriaFabricante;
        private System.Windows.Forms.Button btnExcluirCategoriaFabricante;
        private System.Windows.Forms.Button btnCadastrarCategoriaFabricante;
        private System.Windows.Forms.GroupBox gbxFrmFabricante;
        private System.Windows.Forms.TextBox txtProprietarioFabricante;
        private System.Windows.Forms.TextBox txtPaisOrigemFabricante;
        private System.Windows.Forms.TextBox txtNomeFabricante;
        private System.Windows.Forms.TextBox txtCodigoFabricante;
        private System.Windows.Forms.Label lblPaisOrigemFabricante;
        private System.Windows.Forms.Label lblProprietarioFabricante;
        private System.Windows.Forms.Label lblNomeFabricante;
        private System.Windows.Forms.Label lblCodigoFabricante;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nmVoltarCadastrarIAs;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
    }
}