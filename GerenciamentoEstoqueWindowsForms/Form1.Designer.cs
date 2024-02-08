namespace GerenciamentoEstoqueWindowsForms
{
    partial class frmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnListarProdutos = new System.Windows.Forms.Button();
            this.lblTituloCadastrarProduto = new System.Windows.Forms.Label();
            this.lblSelecionarOpcao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(400, 285);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(75, 36);
            this.btnCadastrarProduto.TabIndex = 12;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnListarProdutos
            // 
            this.btnListarProdutos.Location = new System.Drawing.Point(319, 285);
            this.btnListarProdutos.Name = "btnListarProdutos";
            this.btnListarProdutos.Size = new System.Drawing.Size(75, 36);
            this.btnListarProdutos.TabIndex = 13;
            this.btnListarProdutos.Text = "Gerenciar Produtos";
            this.btnListarProdutos.UseVisualStyleBackColor = true;
            // 
            // lblTituloCadastrarProduto
            // 
            this.lblTituloCadastrarProduto.AutoSize = true;
            this.lblTituloCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastrarProduto.Location = new System.Drawing.Point(342, 9);
            this.lblTituloCadastrarProduto.Name = "lblTituloCadastrarProduto";
            this.lblTituloCadastrarProduto.Size = new System.Drawing.Size(109, 13);
            this.lblTituloCadastrarProduto.TabIndex = 14;
            this.lblTituloCadastrarProduto.Text = "Seja bem-vindo(a)";
            // 
            // lblSelecionarOpcao
            // 
            this.lblSelecionarOpcao.AutoSize = true;
            this.lblSelecionarOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarOpcao.Location = new System.Drawing.Point(296, 153);
            this.lblSelecionarOpcao.Name = "lblSelecionarOpcao";
            this.lblSelecionarOpcao.Size = new System.Drawing.Size(200, 13);
            this.lblSelecionarOpcao.TabIndex = 15;
            this.lblSelecionarOpcao.Text = "Selecione uma opção para comerçarmos";
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelecionarOpcao);
            this.Controls.Add(this.lblTituloCadastrarProduto);
            this.Controls.Add(this.btnListarProdutos);
            this.Controls.Add(this.btnCadastrarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnListarProdutos;
        private System.Windows.Forms.Label lblTituloCadastrarProduto;
        private System.Windows.Forms.Label lblSelecionarOpcao;
    }
}

