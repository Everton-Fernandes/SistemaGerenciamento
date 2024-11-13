namespace SistemaGerenciamentoClientesProdutos.Forms
{
    partial class FormProdutos
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
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblProdutos = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.LblEstoque = new System.Windows.Forms.Label();
            this.GVProdutos = new System.Windows.Forms.DataGridView();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.TxtProdutoId = new System.Windows.Forms.TextBox();
            this.LblProdutoId = new System.Windows.Forms.Label();
            this.BtnCarregarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(46, 37);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 17);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(49, 57);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(351, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // LblProdutos
            // 
            this.LblProdutos.AutoSize = true;
            this.LblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdutos.Location = new System.Drawing.Point(188, 9);
            this.LblProdutos.Name = "LblProdutos";
            this.LblProdutos.Size = new System.Drawing.Size(73, 17);
            this.LblProdutos.TabIndex = 2;
            this.LblProdutos.Text = "Produtos";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(49, 109);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(351, 20);
            this.TxtDescricao.TabIndex = 4;
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricao.Location = new System.Drawing.Point(46, 89);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(80, 17);
            this.LblDescricao.TabIndex = 3;
            this.LblDescricao.Text = "Descrição";
            // 
            // TxtPreco
            // 
            this.TxtPreco.Location = new System.Drawing.Point(49, 158);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(137, 20);
            this.TxtPreco.TabIndex = 6;
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreco.Location = new System.Drawing.Point(46, 138);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(50, 17);
            this.LblPreco.TabIndex = 5;
            this.LblPreco.Text = "Preço";
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Location = new System.Drawing.Point(262, 158);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(137, 20);
            this.TxtEstoque.TabIndex = 8;
            // 
            // LblEstoque
            // 
            this.LblEstoque.AutoSize = true;
            this.LblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstoque.Location = new System.Drawing.Point(259, 138);
            this.LblEstoque.Name = "LblEstoque";
            this.LblEstoque.Size = new System.Drawing.Size(67, 17);
            this.LblEstoque.TabIndex = 7;
            this.LblEstoque.Text = "Estoque";
            // 
            // GVProdutos
            // 
            this.GVProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVProdutos.Location = new System.Drawing.Point(49, 205);
            this.GVProdutos.Name = "GVProdutos";
            this.GVProdutos.Size = new System.Drawing.Size(351, 134);
            this.GVProdutos.TabIndex = 9;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(49, 397);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(350, 25);
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(49, 428);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(350, 25);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(49, 459);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(350, 25);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(49, 490);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(350, 25);
            this.BtnListar.TabIndex = 13;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // TxtProdutoId
            // 
            this.TxtProdutoId.Location = new System.Drawing.Point(136, 362);
            this.TxtProdutoId.Name = "TxtProdutoId";
            this.TxtProdutoId.Size = new System.Drawing.Size(85, 20);
            this.TxtProdutoId.TabIndex = 15;
            // 
            // LblProdutoId
            // 
            this.LblProdutoId.AutoSize = true;
            this.LblProdutoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdutoId.Location = new System.Drawing.Point(52, 363);
            this.LblProdutoId.Name = "LblProdutoId";
            this.LblProdutoId.Size = new System.Drawing.Size(78, 17);
            this.LblProdutoId.TabIndex = 14;
            this.LblProdutoId.Text = "ProdutoId";
            // 
            // BtnCarregarProduto
            // 
            this.BtnCarregarProduto.Location = new System.Drawing.Point(262, 354);
            this.BtnCarregarProduto.Name = "BtnCarregarProduto";
            this.BtnCarregarProduto.Size = new System.Drawing.Size(132, 34);
            this.BtnCarregarProduto.TabIndex = 16;
            this.BtnCarregarProduto.Text = "Carregar Produto";
            this.BtnCarregarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCarregarProduto.UseVisualStyleBackColor = false;
            this.BtnCarregarProduto.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 542);
            this.Controls.Add(this.BtnCarregarProduto);
            this.Controls.Add(this.TxtProdutoId);
            this.Controls.Add(this.LblProdutoId);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GVProdutos);
            this.Controls.Add(this.TxtEstoque);
            this.Controls.Add(this.LblEstoque);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblProdutos);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.GVProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblProdutos;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.Label LblEstoque;
        private System.Windows.Forms.DataGridView GVProdutos;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.TextBox TxtProdutoId;
        private System.Windows.Forms.Label LblProdutoId;
        private System.Windows.Forms.Button BtnCarregarProduto;
    }
}