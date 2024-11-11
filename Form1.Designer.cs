namespace SistemaGerenciamentoClientesProdutos
{
    partial class Inicial
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
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.Location = new System.Drawing.Point(0, 0);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(349, 49);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 49);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(349, 49);
            this.BtnProdutos.TabIndex = 1;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnVendas
            // 
            this.BtnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVendas.Location = new System.Drawing.Point(0, 98);
            this.BtnVendas.Name = "BtnVendas";
            this.BtnVendas.Size = new System.Drawing.Size(349, 49);
            this.BtnVendas.TabIndex = 2;
            this.BtnVendas.Text = "Vendas";
            this.BtnVendas.UseVisualStyleBackColor = true;
            this.BtnVendas.Click += new System.EventHandler(this.BtnVendas_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 149);
            this.Controls.Add(this.BtnVendas);
            this.Controls.Add(this.BtnProdutos);
            this.Controls.Add(this.BtnClientes);
            this.Name = "Inicial";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnVendas;
    }
}

