namespace CadastroIA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nmCategoriaFabricante = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxIA = new System.Windows.Forms.GroupBox();
            this.btnConfirmarAlteracoesIA = new System.Windows.Forms.Button();
            this.btnSelecionarArquivoIA = new System.Windows.Forms.Button();
            this.txtCategoriaIA = new System.Windows.Forms.TextBox();
            this.lblCategoriaIA = new System.Windows.Forms.Label();
            this.txtAparelhoIA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAnoLancamentoIA = new System.Windows.Forms.TextBox();
            this.txtFabricanteIA = new System.Windows.Forms.TextBox();
            this.txtNomeIA = new System.Windows.Forms.TextBox();
            this.txtCodigoIA = new System.Windows.Forms.TextBox();
            this.lblLogoIA = new System.Windows.Forms.Label();
            this.lblAparelhoIA = new System.Windows.Forms.Label();
            this.lblFabricanteIA = new System.Windows.Forms.Label();
            this.lblAnoLancamentoIA = new System.Windows.Forms.Label();
            this.lblNomeIA = new System.Windows.Forms.Label();
            this.lblCodigoIA = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCadastrarIA = new System.Windows.Forms.Button();
            this.btnExcluirIA = new System.Windows.Forms.Button();
            this.btnAlterarIA = new System.Windows.Forms.Button();
            this.btnAnteriorIA = new System.Windows.Forms.Button();
            this.btnSairIA = new System.Windows.Forms.Button();
            this.gbxBotoesIA = new System.Windows.Forms.GroupBox();
            this.btnUltimoIA = new System.Windows.Forms.Button();
            this.btnPrimeiroIA = new System.Windows.Forms.Button();
            this.btnPosteriorIA = new System.Windows.Forms.Button();
            this.ofdFileDIalog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gbxIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxBotoesIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmCategoriaFabricante});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nmCategoriaFabricante
            // 
            this.nmCategoriaFabricante.Enabled = false;
            this.nmCategoriaFabricante.Name = "nmCategoriaFabricante";
            this.nmCategoriaFabricante.Size = new System.Drawing.Size(130, 20);
            this.nmCategoriaFabricante.Text = "Categoria/Fabricante";
            this.nmCategoriaFabricante.Click += new System.EventHandler(this.nmCategoriaFabricante_Click);
            // 
            // gbxIA
            // 
            this.gbxIA.Controls.Add(this.btnConfirmarAlteracoesIA);
            this.gbxIA.Controls.Add(this.btnSelecionarArquivoIA);
            this.gbxIA.Controls.Add(this.txtCategoriaIA);
            this.gbxIA.Controls.Add(this.lblCategoriaIA);
            this.gbxIA.Controls.Add(this.txtAparelhoIA);
            this.gbxIA.Controls.Add(this.pictureBox1);
            this.gbxIA.Controls.Add(this.txtAnoLancamentoIA);
            this.gbxIA.Controls.Add(this.txtFabricanteIA);
            this.gbxIA.Controls.Add(this.txtNomeIA);
            this.gbxIA.Controls.Add(this.txtCodigoIA);
            this.gbxIA.Controls.Add(this.lblLogoIA);
            this.gbxIA.Controls.Add(this.lblAparelhoIA);
            this.gbxIA.Controls.Add(this.lblFabricanteIA);
            this.gbxIA.Controls.Add(this.lblAnoLancamentoIA);
            this.gbxIA.Controls.Add(this.lblNomeIA);
            this.gbxIA.Controls.Add(this.lblCodigoIA);
            this.gbxIA.Location = new System.Drawing.Point(277, 27);
            this.gbxIA.Name = "gbxIA";
            this.gbxIA.Size = new System.Drawing.Size(723, 300);
            this.gbxIA.TabIndex = 1;
            this.gbxIA.TabStop = false;
            this.gbxIA.Text = "frmIA";
            // 
            // btnConfirmarAlteracoesIA
            // 
            this.btnConfirmarAlteracoesIA.Enabled = false;
            this.btnConfirmarAlteracoesIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAlteracoesIA.Location = new System.Drawing.Point(22, 244);
            this.btnConfirmarAlteracoesIA.Name = "btnConfirmarAlteracoesIA";
            this.btnConfirmarAlteracoesIA.Size = new System.Drawing.Size(101, 43);
            this.btnConfirmarAlteracoesIA.TabIndex = 14;
            this.btnConfirmarAlteracoesIA.Text = "Confirmar Alterações";
            this.btnConfirmarAlteracoesIA.UseVisualStyleBackColor = true;
            this.btnConfirmarAlteracoesIA.Click += new System.EventHandler(this.btnConfirmarAlteracoes_Click);
            // 
            // btnSelecionarArquivoIA
            // 
            this.btnSelecionarArquivoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivoIA.Location = new System.Drawing.Point(142, 244);
            this.btnSelecionarArquivoIA.Name = "btnSelecionarArquivoIA";
            this.btnSelecionarArquivoIA.Size = new System.Drawing.Size(96, 43);
            this.btnSelecionarArquivoIA.TabIndex = 13;
            this.btnSelecionarArquivoIA.Text = "Selecionar Imagem";
            this.btnSelecionarArquivoIA.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivoIA.Click += new System.EventHandler(this.BtnSelecionarArquivoIA_Click);
            // 
            // txtCategoriaIA
            // 
            this.txtCategoriaIA.Location = new System.Drawing.Point(105, 208);
            this.txtCategoriaIA.Name = "txtCategoriaIA";
            this.txtCategoriaIA.Size = new System.Drawing.Size(100, 20);
            this.txtCategoriaIA.TabIndex = 14;
            // 
            // lblCategoriaIA
            // 
            this.lblCategoriaIA.AutoSize = true;
            this.lblCategoriaIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaIA.Location = new System.Drawing.Point(19, 208);
            this.lblCategoriaIA.Name = "lblCategoriaIA";
            this.lblCategoriaIA.Size = new System.Drawing.Size(79, 16);
            this.lblCategoriaIA.TabIndex = 13;
            this.lblCategoriaIA.Text = "Categoria:";
            // 
            // txtAparelhoIA
            // 
            this.txtAparelhoIA.Location = new System.Drawing.Point(105, 172);
            this.txtAparelhoIA.Name = "txtAparelhoIA";
            this.txtAparelhoIA.Size = new System.Drawing.Size(100, 20);
            this.txtAparelhoIA.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(364, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 268);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtAnoLancamentoIA
            // 
            this.txtAnoLancamentoIA.Location = new System.Drawing.Point(174, 107);
            this.txtAnoLancamentoIA.Name = "txtAnoLancamentoIA";
            this.txtAnoLancamentoIA.Size = new System.Drawing.Size(100, 20);
            this.txtAnoLancamentoIA.TabIndex = 9;
            // 
            // txtFabricanteIA
            // 
            this.txtFabricanteIA.Location = new System.Drawing.Point(105, 140);
            this.txtFabricanteIA.Name = "txtFabricanteIA";
            this.txtFabricanteIA.Size = new System.Drawing.Size(100, 20);
            this.txtFabricanteIA.TabIndex = 10;
            // 
            // txtNomeIA
            // 
            this.txtNomeIA.Location = new System.Drawing.Point(78, 73);
            this.txtNomeIA.Name = "txtNomeIA";
            this.txtNomeIA.Size = new System.Drawing.Size(100, 20);
            this.txtNomeIA.TabIndex = 8;
            // 
            // txtCodigoIA
            // 
            this.txtCodigoIA.Enabled = false;
            this.txtCodigoIA.Location = new System.Drawing.Point(87, 42);
            this.txtCodigoIA.Name = "txtCodigoIA";
            this.txtCodigoIA.ReadOnly = true;
            this.txtCodigoIA.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoIA.TabIndex = 7;
            // 
            // lblLogoIA
            // 
            this.lblLogoIA.AutoSize = true;
            this.lblLogoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoIA.Location = new System.Drawing.Point(311, 19);
            this.lblLogoIA.Name = "lblLogoIA";
            this.lblLogoIA.Size = new System.Drawing.Size(46, 16);
            this.lblLogoIA.TabIndex = 3;
            this.lblLogoIA.Text = "Logo:";
            // 
            // lblAparelhoIA
            // 
            this.lblAparelhoIA.AutoSize = true;
            this.lblAparelhoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAparelhoIA.Location = new System.Drawing.Point(19, 176);
            this.lblAparelhoIA.Name = "lblAparelhoIA";
            this.lblAparelhoIA.Size = new System.Drawing.Size(74, 16);
            this.lblAparelhoIA.TabIndex = 5;
            this.lblAparelhoIA.Text = "Aparelho:";
            // 
            // lblFabricanteIA
            // 
            this.lblFabricanteIA.AutoSize = true;
            this.lblFabricanteIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricanteIA.Location = new System.Drawing.Point(19, 141);
            this.lblFabricanteIA.Name = "lblFabricanteIA";
            this.lblFabricanteIA.Size = new System.Drawing.Size(85, 16);
            this.lblFabricanteIA.TabIndex = 4;
            this.lblFabricanteIA.Text = "Fabricante:";
            // 
            // lblAnoLancamentoIA
            // 
            this.lblAnoLancamentoIA.AutoSize = true;
            this.lblAnoLancamentoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoLancamentoIA.Location = new System.Drawing.Point(19, 108);
            this.lblAnoLancamentoIA.Name = "lblAnoLancamentoIA";
            this.lblAnoLancamentoIA.Size = new System.Drawing.Size(148, 16);
            this.lblAnoLancamentoIA.TabIndex = 2;
            this.lblAnoLancamentoIA.Text = "Ano de Lançamento:";
            // 
            // lblNomeIA
            // 
            this.lblNomeIA.AutoSize = true;
            this.lblNomeIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeIA.Location = new System.Drawing.Point(19, 73);
            this.lblNomeIA.Name = "lblNomeIA";
            this.lblNomeIA.Size = new System.Drawing.Size(52, 16);
            this.lblNomeIA.TabIndex = 1;
            this.lblNomeIA.Text = "Nome:";
            // 
            // lblCodigoIA
            // 
            this.lblCodigoIA.AutoSize = true;
            this.lblCodigoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoIA.Location = new System.Drawing.Point(19, 40);
            this.lblCodigoIA.Name = "lblCodigoIA";
            this.lblCodigoIA.Size = new System.Drawing.Size(61, 16);
            this.lblCodigoIA.TabIndex = 0;
            this.lblCodigoIA.Text = "Código:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCadastrarIA
            // 
            this.btnCadastrarIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarIA.Location = new System.Drawing.Point(30, 157);
            this.btnCadastrarIA.Name = "btnCadastrarIA";
            this.btnCadastrarIA.Size = new System.Drawing.Size(88, 47);
            this.btnCadastrarIA.TabIndex = 3;
            this.btnCadastrarIA.Text = "Cadastrar";
            this.btnCadastrarIA.UseVisualStyleBackColor = true;
            this.btnCadastrarIA.Click += new System.EventHandler(this.BtnCadastrarIA_Click);
            // 
            // btnExcluirIA
            // 
            this.btnExcluirIA.Enabled = false;
            this.btnExcluirIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirIA.Location = new System.Drawing.Point(144, 157);
            this.btnExcluirIA.Name = "btnExcluirIA";
            this.btnExcluirIA.Size = new System.Drawing.Size(88, 47);
            this.btnExcluirIA.TabIndex = 4;
            this.btnExcluirIA.Text = "Excluir";
            this.btnExcluirIA.UseVisualStyleBackColor = true;
            this.btnExcluirIA.Click += new System.EventHandler(this.BtnExcluirIA_Click);
            // 
            // btnAlterarIA
            // 
            this.btnAlterarIA.Enabled = false;
            this.btnAlterarIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarIA.Location = new System.Drawing.Point(30, 222);
            this.btnAlterarIA.Name = "btnAlterarIA";
            this.btnAlterarIA.Size = new System.Drawing.Size(88, 47);
            this.btnAlterarIA.TabIndex = 5;
            this.btnAlterarIA.Text = "Alterar";
            this.btnAlterarIA.UseVisualStyleBackColor = true;
            this.btnAlterarIA.Click += new System.EventHandler(this.btnAlterarIA_Click);
            // 
            // btnAnteriorIA
            // 
            this.btnAnteriorIA.Enabled = false;
            this.btnAnteriorIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorIA.Location = new System.Drawing.Point(30, 27);
            this.btnAnteriorIA.Name = "btnAnteriorIA";
            this.btnAnteriorIA.Size = new System.Drawing.Size(88, 47);
            this.btnAnteriorIA.TabIndex = 6;
            this.btnAnteriorIA.Text = "Anterior";
            this.btnAnteriorIA.UseVisualStyleBackColor = true;
            this.btnAnteriorIA.Click += new System.EventHandler(this.BtnAnteriorIA_Click);
            // 
            // btnSairIA
            // 
            this.btnSairIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairIA.Location = new System.Drawing.Point(144, 222);
            this.btnSairIA.Name = "btnSairIA";
            this.btnSairIA.Size = new System.Drawing.Size(88, 47);
            this.btnSairIA.TabIndex = 7;
            this.btnSairIA.Text = "Sair";
            this.btnSairIA.UseVisualStyleBackColor = true;
            this.btnSairIA.Click += new System.EventHandler(this.btnSairIA_Click);
            // 
            // gbxBotoesIA
            // 
            this.gbxBotoesIA.Controls.Add(this.btnUltimoIA);
            this.gbxBotoesIA.Controls.Add(this.btnSairIA);
            this.gbxBotoesIA.Controls.Add(this.btnPrimeiroIA);
            this.gbxBotoesIA.Controls.Add(this.btnAlterarIA);
            this.gbxBotoesIA.Controls.Add(this.btnExcluirIA);
            this.gbxBotoesIA.Controls.Add(this.btnPosteriorIA);
            this.gbxBotoesIA.Controls.Add(this.btnCadastrarIA);
            this.gbxBotoesIA.Controls.Add(this.btnAnteriorIA);
            this.gbxBotoesIA.Location = new System.Drawing.Point(12, 27);
            this.gbxBotoesIA.Name = "gbxBotoesIA";
            this.gbxBotoesIA.Size = new System.Drawing.Size(259, 300);
            this.gbxBotoesIA.TabIndex = 8;
            this.gbxBotoesIA.TabStop = false;
            this.gbxBotoesIA.Text = "Botões";
            // 
            // btnUltimoIA
            // 
            this.btnUltimoIA.Enabled = false;
            this.btnUltimoIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoIA.Location = new System.Drawing.Point(144, 92);
            this.btnUltimoIA.Name = "btnUltimoIA";
            this.btnUltimoIA.Size = new System.Drawing.Size(88, 47);
            this.btnUltimoIA.TabIndex = 10;
            this.btnUltimoIA.Text = "Último";
            this.btnUltimoIA.UseVisualStyleBackColor = true;
            this.btnUltimoIA.Click += new System.EventHandler(this.BtnUltimoIA_Click);
            // 
            // btnPrimeiroIA
            // 
            this.btnPrimeiroIA.Enabled = false;
            this.btnPrimeiroIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiroIA.Location = new System.Drawing.Point(30, 92);
            this.btnPrimeiroIA.Name = "btnPrimeiroIA";
            this.btnPrimeiroIA.Size = new System.Drawing.Size(88, 47);
            this.btnPrimeiroIA.TabIndex = 9;
            this.btnPrimeiroIA.Text = "Primeiro";
            this.btnPrimeiroIA.UseVisualStyleBackColor = true;
            this.btnPrimeiroIA.Click += new System.EventHandler(this.BtnPrimeiroIA_Click);
            // 
            // btnPosteriorIA
            // 
            this.btnPosteriorIA.Enabled = false;
            this.btnPosteriorIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosteriorIA.Location = new System.Drawing.Point(144, 27);
            this.btnPosteriorIA.Name = "btnPosteriorIA";
            this.btnPosteriorIA.Size = new System.Drawing.Size(88, 47);
            this.btnPosteriorIA.TabIndex = 8;
            this.btnPosteriorIA.Text = "Posterior";
            this.btnPosteriorIA.UseVisualStyleBackColor = true;
            this.btnPosteriorIA.Click += new System.EventHandler(this.BtnPosteriorIA_Click);
            // 
            // ofdFileDIalog
            // 
            this.ofdFileDIalog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1027, 349);
            this.Controls.Add(this.gbxBotoesIA);
            this.Controls.Add(this.gbxIA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxIA.ResumeLayout(false);
            this.gbxIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxBotoesIA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nmCategoriaFabricante;
        private System.Windows.Forms.GroupBox gbxIA;
        private System.Windows.Forms.TextBox txtFabricanteIA;
        private System.Windows.Forms.TextBox txtAnoLancamentoIA;
        private System.Windows.Forms.TextBox txtNomeIA;
        private System.Windows.Forms.TextBox txtCodigoIA;
        private System.Windows.Forms.Label lblFabricanteIA;
        private System.Windows.Forms.Label lblLogoIA;
        private System.Windows.Forms.Label lblAnoLancamentoIA;
        private System.Windows.Forms.Label lblNomeIA;
        private System.Windows.Forms.Label lblCodigoIA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCadastrarIA;
        private System.Windows.Forms.Button btnExcluirIA;
        private System.Windows.Forms.Button btnAlterarIA;
        private System.Windows.Forms.Button btnAnteriorIA;
        private System.Windows.Forms.Button btnSairIA;
        private System.Windows.Forms.GroupBox gbxBotoesIA;
        private System.Windows.Forms.Button btnSelecionarArquivoIA;
        private System.Windows.Forms.Button btnUltimoIA;
        private System.Windows.Forms.Button btnPrimeiroIA;
        private System.Windows.Forms.Button btnPosteriorIA;
        private System.Windows.Forms.OpenFileDialog ofdFileDIalog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmarAlteracoesIA;
        private System.Windows.Forms.TextBox txtCategoriaIA;
        private System.Windows.Forms.Label lblCategoriaIA;
        private System.Windows.Forms.TextBox txtAparelhoIA;
        private System.Windows.Forms.Label lblAparelhoIA;
    }
}

