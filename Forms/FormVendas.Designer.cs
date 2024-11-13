namespace SistemaGerenciamentoClientesProdutos.Forms
{
    partial class FormVendas
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
            this.LblCliente = new System.Windows.Forms.Label();
            this.CBCliente = new System.Windows.Forms.ComboBox();
            this.CBProduto = new System.Windows.Forms.ComboBox();
            this.LblProduto = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.DTVenda = new System.Windows.Forms.DateTimePicker();
            this.LblVendas = new System.Windows.Forms.Label();
            this.GVvendas = new System.Windows.Forms.DataGridView();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(46, 37);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(63, 17);
            this.LblCliente.TabIndex = 3;
            this.LblCliente.Text = "Cliente:";
            // 
            // CBCliente
            // 
            this.CBCliente.FormattingEnabled = true;
            this.CBCliente.Location = new System.Drawing.Point(49, 57);
            this.CBCliente.Name = "CBCliente";
            this.CBCliente.Size = new System.Drawing.Size(351, 21);
            this.CBCliente.TabIndex = 4;
            // 
            // CBProduto
            // 
            this.CBProduto.FormattingEnabled = true;
            this.CBProduto.Location = new System.Drawing.Point(49, 113);
            this.CBProduto.Name = "CBProduto";
            this.CBProduto.Size = new System.Drawing.Size(351, 21);
            this.CBProduto.TabIndex = 6;
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProduto.Location = new System.Drawing.Point(46, 93);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(70, 17);
            this.LblProduto.TabIndex = 5;
            this.LblProduto.Text = "Produto:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(144, 154);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(56, 20);
            this.TxtQuantidade.TabIndex = 7;
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidade.Location = new System.Drawing.Point(46, 155);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(97, 17);
            this.LblQuantidade.TabIndex = 8;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // DTVenda
            // 
            this.DTVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTVenda.Location = new System.Drawing.Point(223, 154);
            this.DTVenda.Name = "DTVenda";
            this.DTVenda.Size = new System.Drawing.Size(177, 20);
            this.DTVenda.TabIndex = 9;
            // 
            // LblVendas
            // 
            this.LblVendas.AutoSize = true;
            this.LblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVendas.Location = new System.Drawing.Point(188, 9);
            this.LblVendas.Name = "LblVendas";
            this.LblVendas.Size = new System.Drawing.Size(62, 17);
            this.LblVendas.TabIndex = 10;
            this.LblVendas.Text = "Vendas";
            // 
            // GVvendas
            // 
            this.GVvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVvendas.Location = new System.Drawing.Point(49, 217);
            this.GVvendas.Name = "GVvendas";
            this.GVvendas.Size = new System.Drawing.Size(350, 233);
            this.GVvendas.TabIndex = 11;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(49, 473);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(151, 37);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(248, 473);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(151, 37);
            this.BtnListar.TabIndex = 13;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 542);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GVvendas);
            this.Controls.Add(this.LblVendas);
            this.Controls.Add(this.DTVenda);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.CBProduto);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.CBCliente);
            this.Controls.Add(this.LblCliente);
            this.Name = "FormVendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.GVvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.ComboBox CBCliente;
        private System.Windows.Forms.ComboBox CBProduto;
        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.DateTimePicker DTVenda;
        private System.Windows.Forms.Label LblVendas;
        private System.Windows.Forms.DataGridView GVvendas;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnListar;
    }
}