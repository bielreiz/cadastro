
namespace Cadastro
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxEnd = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lstCodigo = new System.Windows.Forms.ListBox();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.lstTelefone = new System.Windows.Forms.ListBox();
            this.lstRua = new System.Windows.Forms.ListBox();
            this.lstBairro = new System.Windows.Forms.ListBox();
            this.lstNum = new System.Windows.Forms.ListBox();
            this.gbxDados.SuspendLayout();
            this.gbxEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Clientes";
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.txtTel);
            this.gbxDados.Controls.Add(this.txtNome);
            this.gbxDados.Controls.Add(this.txtID);
            this.gbxDados.Controls.Add(this.label4);
            this.gbxDados.Controls.Add(this.label3);
            this.gbxDados.Controls.Add(this.label2);
            this.gbxDados.Location = new System.Drawing.Point(12, 45);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(262, 142);
            this.gbxDados.TabIndex = 1;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados pessoais";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(110, 87);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(85, 20);
            this.txtTel.TabIndex = 5;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 3;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome completo";
            // 
            // gbxEnd
            // 
            this.gbxEnd.Controls.Add(this.txtNum);
            this.gbxEnd.Controls.Add(this.txtBairro);
            this.gbxEnd.Controls.Add(this.txtRua);
            this.gbxEnd.Controls.Add(this.label7);
            this.gbxEnd.Controls.Add(this.label6);
            this.gbxEnd.Controls.Add(this.label5);
            this.gbxEnd.Location = new System.Drawing.Point(304, 45);
            this.gbxEnd.Name = "gbxEnd";
            this.gbxEnd.Size = new System.Drawing.Size(241, 142);
            this.gbxEnd.TabIndex = 2;
            this.gbxEnd.TabStop = false;
            this.gbxEnd.Text = "Endereço";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(82, 87);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(48, 20);
            this.txtNum.TabIndex = 6;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(82, 58);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(137, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(82, 27);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(137, 20);
            this.txtRua.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rua";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(177, 199);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(258, 199);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Excluir";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(339, 199);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lstCodigo
            // 
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(10, 254);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(58, 160);
            this.lstCodigo.TabIndex = 6;
            this.lstCodigo.SelectedIndexChanged += new System.EventHandler(this.lstCodigo_SelectedIndexChanged);
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.Location = new System.Drawing.Point(62, 254);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(116, 160);
            this.lstNome.TabIndex = 7;
            // 
            // lstTelefone
            // 
            this.lstTelefone.FormattingEnabled = true;
            this.lstTelefone.Location = new System.Drawing.Point(177, 254);
            this.lstTelefone.Name = "lstTelefone";
            this.lstTelefone.Size = new System.Drawing.Size(116, 160);
            this.lstTelefone.TabIndex = 8;
            // 
            // lstRua
            // 
            this.lstRua.FormattingEnabled = true;
            this.lstRua.Location = new System.Drawing.Point(289, 254);
            this.lstRua.Name = "lstRua";
            this.lstRua.Size = new System.Drawing.Size(116, 160);
            this.lstRua.TabIndex = 9;
            // 
            // lstBairro
            // 
            this.lstBairro.FormattingEnabled = true;
            this.lstBairro.Location = new System.Drawing.Point(386, 254);
            this.lstBairro.Name = "lstBairro";
            this.lstBairro.Size = new System.Drawing.Size(116, 160);
            this.lstBairro.TabIndex = 10;
            // 
            // lstNum
            // 
            this.lstNum.FormattingEnabled = true;
            this.lstNum.Location = new System.Drawing.Point(487, 254);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(79, 160);
            this.lstNum.TabIndex = 11;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 438);
            this.Controls.Add(this.lstNum);
            this.Controls.Add(this.lstBairro);
            this.Controls.Add(this.lstRua);
            this.Controls.Add(this.lstTelefone);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.lstCodigo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gbxEnd);
            this.Controls.Add(this.gbxDados);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.gbxEnd.ResumeLayout(false);
            this.gbxEnd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxEnd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ListBox lstCodigo;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.ListBox lstTelefone;
        private System.Windows.Forms.ListBox lstRua;
        private System.Windows.Forms.ListBox lstBairro;
        private System.Windows.Forms.ListBox lstNum;
    }
}

