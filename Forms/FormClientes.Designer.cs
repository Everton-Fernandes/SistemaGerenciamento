namespace SistemaGerenciamentoClientesProdutos.Forms
{
    partial class FormClientes
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
            this.BtnCarregarCliente = new System.Windows.Forms.Button();
            this.TxtClienteid = new System.Windows.Forms.TextBox();
            this.LblClienteid = new System.Windows.Forms.Label();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GVClientes = new System.Windows.Forms.DataGridView();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblClientes = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.LblTeleforne = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCarregarCliente
            // 
            this.BtnCarregarCliente.Location = new System.Drawing.Point(262, 363);
            this.BtnCarregarCliente.Name = "BtnCarregarCliente";
            this.BtnCarregarCliente.Size = new System.Drawing.Size(132, 34);
            this.BtnCarregarCliente.TabIndex = 33;
            this.BtnCarregarCliente.Text = "Carregar Cliente";
            this.BtnCarregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCarregarCliente.UseVisualStyleBackColor = false;
            this.BtnCarregarCliente.Click += new System.EventHandler(this.BtnCarregarCliente_Click);
            // 
            // TxtClienteid
            // 
            this.TxtClienteid.Location = new System.Drawing.Point(136, 371);
            this.TxtClienteid.Name = "TxtClienteid";
            this.TxtClienteid.Size = new System.Drawing.Size(85, 20);
            this.TxtClienteid.TabIndex = 32;
            // 
            // LblClienteid
            // 
            this.LblClienteid.AutoSize = true;
            this.LblClienteid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteid.Location = new System.Drawing.Point(52, 372);
            this.LblClienteid.Name = "LblClienteid";
            this.LblClienteid.Size = new System.Drawing.Size(71, 17);
            this.LblClienteid.TabIndex = 31;
            this.LblClienteid.Text = "ClienteId";
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(49, 499);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(350, 25);
            this.BtnListar.TabIndex = 30;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(49, 468);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(350, 25);
            this.BtnExcluir.TabIndex = 29;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(49, 437);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(350, 25);
            this.BtnEditar.TabIndex = 28;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(49, 406);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(350, 25);
            this.BtnSalvar.TabIndex = 27;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // GVClientes
            // 
            this.GVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVClientes.Location = new System.Drawing.Point(49, 250);
            this.GVClientes.Name = "GVClientes";
            this.GVClientes.Size = new System.Drawing.Size(351, 98);
            this.GVClientes.TabIndex = 26;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(49, 115);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(351, 20);
            this.TxtEndereco.TabIndex = 21;
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndereco.Location = new System.Drawing.Point(46, 95);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(77, 17);
            this.LblEndereco.TabIndex = 20;
            this.LblEndereco.Text = "Endereço";
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.Location = new System.Drawing.Point(188, 18);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(66, 17);
            this.LblClientes.TabIndex = 19;
            this.LblClientes.Text = "Clientes";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(49, 66);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(351, 20);
            this.TxtNome.TabIndex = 18;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(46, 46);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 17);
            this.LblNome.TabIndex = 17;
            this.LblNome.Text = "Nome";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(49, 164);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(351, 20);
            this.TxtTelefone.TabIndex = 35;
            // 
            // LblTeleforne
            // 
            this.LblTeleforne.AutoSize = true;
            this.LblTeleforne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTeleforne.Location = new System.Drawing.Point(46, 144);
            this.LblTeleforne.Name = "LblTeleforne";
            this.LblTeleforne.Size = new System.Drawing.Size(78, 17);
            this.LblTeleforne.TabIndex = 34;
            this.LblTeleforne.Text = "Teleforne";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(48, 210);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(351, 20);
            this.TxtEmail.TabIndex = 37;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(45, 190);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(47, 17);
            this.LblEmail.TabIndex = 36;
            this.LblEmail.Text = "Email";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 542);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.LblTeleforne);
            this.Controls.Add(this.BtnCarregarCliente);
            this.Controls.Add(this.TxtClienteid);
            this.Controls.Add(this.LblClienteid);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GVClientes);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblClientes);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.GVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCarregarCliente;
        private System.Windows.Forms.TextBox TxtClienteid;
        private System.Windows.Forms.Label LblClienteid;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView GVClientes;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label LblTeleforne;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
    }
}