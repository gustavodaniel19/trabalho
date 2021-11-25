
namespace Petshops
{
    partial class FormCliente
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDatanascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblInserir = new System.Windows.Forms.Button();
            this.lblAtualizar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Button();
            this.lblSair = new System.Windows.Forms.Button();
            this.lblLocalizar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(222, 34);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(3, 142);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 3;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(222, 88);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(3, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblDatanascimento
            // 
            this.lblDatanascimento.AutoSize = true;
            this.lblDatanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatanascimento.Location = new System.Drawing.Point(0, 126);
            this.lblDatanascimento.Name = "lblDatanascimento";
            this.lblDatanascimento.Size = new System.Drawing.Size(120, 13);
            this.lblDatanascimento.TabIndex = 7;
            this.lblDatanascimento.Text = "Data de nascimento";
            this.lblDatanascimento.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(219, 18);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(26, 13);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "Cpf";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(219, 72);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 9;
            this.lblCelular.Text = "Celular";
            // 
            // lblInserir
            // 
            this.lblInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserir.Location = new System.Drawing.Point(354, 18);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(75, 23);
            this.lblInserir.TabIndex = 10;
            this.lblInserir.Text = "Inserir";
            this.lblInserir.UseVisualStyleBackColor = true;
            // 
            // lblAtualizar
            // 
            this.lblAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtualizar.Location = new System.Drawing.Point(354, 62);
            this.lblAtualizar.Name = "lblAtualizar";
            this.lblAtualizar.Size = new System.Drawing.Size(75, 23);
            this.lblAtualizar.TabIndex = 11;
            this.lblAtualizar.Text = "Atualizar";
            this.lblAtualizar.UseVisualStyleBackColor = true;
            // 
            // lblApagar
            // 
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(354, 116);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(75, 23);
            this.lblApagar.TabIndex = 12;
            this.lblApagar.Text = "Apagar";
            this.lblApagar.UseVisualStyleBackColor = true;
            // 
            // lblSair
            // 
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(354, 163);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(75, 23);
            this.lblSair.TabIndex = 13;
            this.lblSair.Text = "Sair";
            this.lblSair.UseVisualStyleBackColor = true;
            // 
            // lblLocalizar
            // 
            this.lblLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizar.Location = new System.Drawing.Point(109, 31);
            this.lblLocalizar.Name = "lblLocalizar";
            this.lblLocalizar.Size = new System.Drawing.Size(75, 23);
            this.lblLocalizar.TabIndex = 14;
            this.lblLocalizar.Text = "Localizar";
            this.lblLocalizar.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(3, 192);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(439, 232);
            this.dgvCliente.TabIndex = 15;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 436);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.lblLocalizar);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblApagar);
            this.Controls.Add(this.lblAtualizar);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDatanascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtId);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDatanascimento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button lblInserir;
        private System.Windows.Forms.Button lblAtualizar;
        private System.Windows.Forms.Button lblApagar;
        private System.Windows.Forms.Button lblSair;
        private System.Windows.Forms.Button lblLocalizar;
        private System.Windows.Forms.DataGridView dgvCliente;
    }
}