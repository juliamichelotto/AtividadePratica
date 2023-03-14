namespace AtividadePratica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.lblVD = new System.Windows.Forms.Label();
            this.txtVD = new System.Windows.Forms.TextBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblSb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Ir = new System.Windows.Forms.Label();
            this.lblSl = new System.Windows.Forms.Label();
            this.txtSb = new System.Windows.Forms.TextBox();
            this.txtIr = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(22, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(100, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 32);
            this.txtNome.TabIndex = 1;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(114, 132);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 25);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDT.Location = new System.Drawing.Point(22, 79);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(159, 25);
            this.lblDT.TabIndex = 4;
            this.lblDT.Text = "Dias Trabalhados:";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDT.Location = new System.Drawing.Point(187, 76);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(119, 32);
            this.txtDT.TabIndex = 3;
            // 
            // lblVD
            // 
            this.lblVD.AutoSize = true;
            this.lblVD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVD.Location = new System.Drawing.Point(21, 174);
            this.lblVD.Name = "lblVD";
            this.lblVD.Size = new System.Drawing.Size(141, 25);
            this.lblVD.TabIndex = 6;
            this.lblVD.Text = "Valor da Diária:";
            // 
            // txtVD
            // 
            this.txtVD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVD.Location = new System.Drawing.Point(187, 171);
            this.txtVD.Name = "txtVD";
            this.txtVD.Size = new System.Drawing.Size(119, 32);
            this.txtVD.TabIndex = 4;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(195, 257);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(111, 41);
            this.btnConcluir.TabIndex = 8;
            this.btnConcluir.Text = "Calcular";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblSb
            // 
            this.lblSb.AutoSize = true;
            this.lblSb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSb.Location = new System.Drawing.Point(384, 34);
            this.lblSb.Name = "lblSb";
            this.lblSb.Size = new System.Drawing.Size(118, 25);
            this.lblSb.TabIndex = 9;
            this.lblSb.Text = "Salário Base:";
            this.lblSb.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(502, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 10;
            // 
            // lbl_Ir
            // 
            this.lbl_Ir.AutoSize = true;
            this.lbl_Ir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ir.Location = new System.Drawing.Point(384, 91);
            this.lbl_Ir.Name = "lbl_Ir";
            this.lbl_Ir.Size = new System.Drawing.Size(108, 25);
            this.lbl_Ir.TabIndex = 11;
            this.lbl_Ir.Text = "Valor do IR:";
            // 
            // lblSl
            // 
            this.lblSl.AutoSize = true;
            this.lblSl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSl.Location = new System.Drawing.Point(384, 148);
            this.lblSl.Name = "lblSl";
            this.lblSl.Size = new System.Drawing.Size(142, 25);
            this.lblSl.TabIndex = 12;
            this.lblSl.Text = "Salário Liquido:";
            // 
            // txtSb
            // 
            this.txtSb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSb.Location = new System.Drawing.Point(531, 31);
            this.txtSb.Name = "txtSb";
            this.txtSb.Size = new System.Drawing.Size(116, 32);
            this.txtSb.TabIndex = 13;
            // 
            // txtIr
            // 
            this.txtIr.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIr.Location = new System.Drawing.Point(531, 88);
            this.txtIr.Name = "txtIr";
            this.txtIr.Size = new System.Drawing.Size(116, 32);
            this.txtIr.TabIndex = 14;
            // 
            // txtSl
            // 
            this.txtSl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSl.Location = new System.Drawing.Point(532, 148);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(115, 32);
            this.txtSl.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(187, 129);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(119, 32);
            this.txtCPF.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 319);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtIr);
            this.Controls.Add(this.txtSb);
            this.Controls.Add(this.lblSl);
            this.Controls.Add(this.lbl_Ir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSb);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.txtVD);
            this.Controls.Add(this.lblVD);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCPF;
        private Label lblDT;
        private TextBox txtDT;
        private Label lblVD;
        private TextBox txtVD;
        private Button btnConcluir;
        private Label lblSb;
        private Label label1;
        private Label lbl_Ir;
        private Label lblSl;
        private TextBox txtSb;
        private TextBox txtIr;
        private TextBox txtSl;
        private MaskedTextBox txtCPF;
    }
}