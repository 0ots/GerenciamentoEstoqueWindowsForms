namespace GerenciamentoEstoqueWindowsForms
{
    partial class frmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProduto));
            this.lblTituloCadastrarProduto = new System.Windows.Forms.Label();
            this.cmbCategoriaProduto = new System.Windows.Forms.ComboBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblCategoriaProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidadeProduto = new System.Windows.Forms.Label();
            this.btnRetornarTelaInicial = new System.Windows.Forms.Button();
            this.lblErroNomeProduto = new System.Windows.Forms.Label();
            this.lblErroPrecoProduto = new System.Windows.Forms.Label();
            this.lblErroQuantidadeProduto = new System.Windows.Forms.Label();
            this.lblErroCategoriaProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloCadastrarProduto
            // 
            this.lblTituloCadastrarProduto.AutoSize = true;
            this.lblTituloCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastrarProduto.Location = new System.Drawing.Point(364, 9);
            this.lblTituloCadastrarProduto.Name = "lblTituloCadastrarProduto";
            this.lblTituloCadastrarProduto.Size = new System.Drawing.Size(109, 13);
            this.lblTituloCadastrarProduto.TabIndex = 0;
            this.lblTituloCadastrarProduto.Text = "Cadastrar Produto";
            // 
            // cmbCategoriaProduto
            // 
            this.cmbCategoriaProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaProduto.FormattingEnabled = true;
            this.cmbCategoriaProduto.Items.AddRange(new object[] {
            "Massa",
            "Legume",
            "Frios"});
            this.cmbCategoriaProduto.Location = new System.Drawing.Point(142, 292);
            this.cmbCategoriaProduto.Name = "cmbCategoriaProduto";
            this.cmbCategoriaProduto.Size = new System.Drawing.Size(522, 21);
            this.cmbCategoriaProduto.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(142, 85);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(522, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(300, 372);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(75, 36);
            this.btnCadastrarProduto.TabIndex = 3;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Location = new System.Drawing.Point(381, 372);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(75, 36);
            this.btnLimparCampos.TabIndex = 4;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblCategoriaProduto
            // 
            this.lblCategoriaProduto.AutoSize = true;
            this.lblCategoriaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProduto.Location = new System.Drawing.Point(139, 276);
            this.lblCategoriaProduto.Name = "lblCategoriaProduto";
            this.lblCategoriaProduto.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaProduto.TabIndex = 5;
            this.lblCategoriaProduto.Text = "Categoria:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.CausesValidation = false;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(139, 69);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(41, 13);
            this.lblNomeProduto.TabIndex = 6;
            this.lblNomeProduto.Text = "Nome: ";
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoProduto.Location = new System.Drawing.Point(142, 139);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoProduto.TabIndex = 7;
            this.lblPrecoProduto.Text = "Preço:";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(142, 155);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(522, 20);
            this.txtPrecoProduto.TabIndex = 8;
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(142, 224);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(522, 20);
            this.txtQuantidadeProduto.TabIndex = 10;
            // 
            // lblQuantidadeProduto
            // 
            this.lblQuantidadeProduto.AutoSize = true;
            this.lblQuantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeProduto.Location = new System.Drawing.Point(142, 208);
            this.lblQuantidadeProduto.Name = "lblQuantidadeProduto";
            this.lblQuantidadeProduto.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidadeProduto.TabIndex = 9;
            this.lblQuantidadeProduto.Text = "Quantidade:";
            // 
            // btnRetornarTelaInicial
            // 
            this.btnRetornarTelaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarTelaInicial.Location = new System.Drawing.Point(462, 372);
            this.btnRetornarTelaInicial.Name = "btnRetornarTelaInicial";
            this.btnRetornarTelaInicial.Size = new System.Drawing.Size(75, 36);
            this.btnRetornarTelaInicial.TabIndex = 11;
            this.btnRetornarTelaInicial.Text = "Voltar";
            this.btnRetornarTelaInicial.UseVisualStyleBackColor = true;
            this.btnRetornarTelaInicial.Click += new System.EventHandler(this.btnRetornarTelaInicial_Click);
            // 
            // lblErroNomeProduto
            // 
            this.lblErroNomeProduto.AutoSize = true;
            this.lblErroNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblErroNomeProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroNomeProduto.Location = new System.Drawing.Point(139, 108);
            this.lblErroNomeProduto.Name = "lblErroNomeProduto";
            this.lblErroNomeProduto.Size = new System.Drawing.Size(26, 13);
            this.lblErroNomeProduto.TabIndex = 12;
            this.lblErroNomeProduto.Text = "Erro";
            this.lblErroNomeProduto.Visible = false;
            // 
            // lblErroPrecoProduto
            // 
            this.lblErroPrecoProduto.AutoSize = true;
            this.lblErroPrecoProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroPrecoProduto.Location = new System.Drawing.Point(142, 178);
            this.lblErroPrecoProduto.Name = "lblErroPrecoProduto";
            this.lblErroPrecoProduto.Size = new System.Drawing.Size(26, 13);
            this.lblErroPrecoProduto.TabIndex = 13;
            this.lblErroPrecoProduto.Text = "Erro";
            this.lblErroPrecoProduto.Visible = false;
            // 
            // lblErroQuantidadeProduto
            // 
            this.lblErroQuantidadeProduto.AutoSize = true;
            this.lblErroQuantidadeProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroQuantidadeProduto.Location = new System.Drawing.Point(142, 247);
            this.lblErroQuantidadeProduto.Name = "lblErroQuantidadeProduto";
            this.lblErroQuantidadeProduto.Size = new System.Drawing.Size(26, 13);
            this.lblErroQuantidadeProduto.TabIndex = 14;
            this.lblErroQuantidadeProduto.Text = "Erro";
            this.lblErroQuantidadeProduto.Visible = false;
            // 
            // lblErroCategoriaProduto
            // 
            this.lblErroCategoriaProduto.AutoSize = true;
            this.lblErroCategoriaProduto.ForeColor = System.Drawing.Color.Red;
            this.lblErroCategoriaProduto.Location = new System.Drawing.Point(139, 316);
            this.lblErroCategoriaProduto.Name = "lblErroCategoriaProduto";
            this.lblErroCategoriaProduto.Size = new System.Drawing.Size(26, 13);
            this.lblErroCategoriaProduto.TabIndex = 15;
            this.lblErroCategoriaProduto.Text = "Erro";
            this.lblErroCategoriaProduto.Visible = false;
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErroCategoriaProduto);
            this.Controls.Add(this.lblErroQuantidadeProduto);
            this.Controls.Add(this.lblErroPrecoProduto);
            this.Controls.Add(this.lblErroNomeProduto);
            this.Controls.Add(this.btnRetornarTelaInicial);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.lblQuantidadeProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.lblPrecoProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblCategoriaProduto);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.cmbCategoriaProduto);
            this.Controls.Add(this.lblTituloCadastrarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCadastrarProduto;
        private System.Windows.Forms.ComboBox cmbCategoriaProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblCategoriaProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label lblQuantidadeProduto;
        private System.Windows.Forms.Button btnRetornarTelaInicial;
        private System.Windows.Forms.Label lblErroNomeProduto;
        private System.Windows.Forms.Label lblErroPrecoProduto;
        private System.Windows.Forms.Label lblErroQuantidadeProduto;
        private System.Windows.Forms.Label lblErroCategoriaProduto;
    }
}