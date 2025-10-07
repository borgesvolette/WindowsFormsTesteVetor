namespace WindowsFormsTesteVetor
{
    partial class Produtos
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(17, 27);
            this.lblDigite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(163, 30);
            this.lblDigite.TabIndex = 0;
            this.lblDigite.Text = "Digite o Produto:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(70, 373);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(138, 52);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 30;
            this.lbxProdutos.Location = new System.Drawing.Point(15, 131);
            this.lbxProdutos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(217, 154);
            this.lbxProdutos.TabIndex = 2;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(70, 456);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(138, 52);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(274, 373);
            this.btnListar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(138, 52);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // tbxProdutos
            // 
            this.tbxProdutos.Location = new System.Drawing.Point(15, 65);
            this.tbxProdutos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbxProdutos.Name = "tbxProdutos";
            this.tbxProdutos.Size = new System.Drawing.Size(180, 38);
            this.tbxProdutos.TabIndex = 6;
            this.tbxProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxProdutos_KeyPress);
            // 
            // lbxQuantidade
            // 
            this.lbxQuantidade.FormattingEnabled = true;
            this.lbxQuantidade.ItemHeight = 30;
            this.lbxQuantidade.Location = new System.Drawing.Point(349, 131);
            this.lbxQuantidade.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lbxQuantidade.Name = "lbxQuantidade";
            this.lbxQuantidade.Size = new System.Drawing.Size(140, 94);
            this.lbxQuantidade.TabIndex = 7;
            // 
            // btnQuantidade
            // 
            this.btnQuantidade.Location = new System.Drawing.Point(290, 456);
            this.btnQuantidade.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnQuantidade.Name = "btnQuantidade";
            this.btnQuantidade.Size = new System.Drawing.Size(138, 52);
            this.btnQuantidade.TabIndex = 8;
            this.btnQuantidade.Text = "Quantidade";
            this.btnQuantidade.UseVisualStyleBackColor = true;
            this.btnQuantidade.Click += new System.EventHandler(this.btnQuantidade_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(341, 56);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(180, 30);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quatidade de itens:";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Blue;
            this.btnFechar.Location = new System.Drawing.Point(511, 3);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(53, 49);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(565, 534);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnQuantidade);
            this.Controls.Add(this.lbxQuantidade);
            this.Controls.Add(this.tbxProdutos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lbxProdutos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblDigite);
            this.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Produtos";
            this.Text = "Produtos";
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
        private System.Windows.Forms.Button btnFechar;
    }
}

