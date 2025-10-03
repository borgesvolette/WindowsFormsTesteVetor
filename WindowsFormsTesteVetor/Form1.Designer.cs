namespace WindowsFormsTesteVetor
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
            this.lblDigite = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.tbxProdutos = new System.Windows.Forms.TextBox();
            this.lbxQuantidade = new System.Windows.Forms.ListBox();
            this.btnQuantidade = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(9, 35);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(86, 13);
            this.lblDigite.TabIndex = 0;
            this.lblDigite.Text = "Digite o Produto:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(36, 249);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.Location = new System.Drawing.Point(12, 106);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(120, 95);
            this.lbxProdutos.TabIndex = 2;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(83, 300);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(147, 249);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // tbxProdutos
            // 
            this.tbxProdutos.Location = new System.Drawing.Point(12, 62);
            this.tbxProdutos.Name = "tbxProdutos";
            this.tbxProdutos.Size = new System.Drawing.Size(100, 20);
            this.tbxProdutos.TabIndex = 6;
            // 
            // lbxQuantidade
            // 
            this.lbxQuantidade.FormattingEnabled = true;
            this.lbxQuantidade.Location = new System.Drawing.Point(184, 138);
            this.lbxQuantidade.Name = "lbxQuantidade";
            this.lbxQuantidade.Size = new System.Drawing.Size(78, 43);
            this.lbxQuantidade.TabIndex = 7;
            // 
            // btnQuantidade
            // 
            this.btnQuantidade.Location = new System.Drawing.Point(203, 300);
            this.btnQuantidade.Name = "btnQuantidade";
            this.btnQuantidade.Size = new System.Drawing.Size(75, 23);
            this.btnQuantidade.TabIndex = 8;
            this.btnQuantidade.Text = "Quantidade";
            this.btnQuantidade.UseVisualStyleBackColor = true;
            this.btnQuantidade.Click += new System.EventHandler(this.btnQuantidade_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(179, 106);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(99, 13);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quatidade de itens:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 369);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnQuantidade);
            this.Controls.Add(this.lbxQuantidade);
            this.Controls.Add(this.tbxProdutos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lbxProdutos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblDigite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox tbxProdutos;
        private System.Windows.Forms.ListBox lbxQuantidade;
        private System.Windows.Forms.Button btnQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}

