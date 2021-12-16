namespace bancoSaldo
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
            this.cmbOp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtDin = new System.Windows.Forms.TextBox();
            this.txtSaq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRes1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOp
            // 
            this.cmbOp.FormattingEnabled = true;
            this.cmbOp.Items.AddRange(new object[] {
            "Depósito",
            "Saque",
            "Ver Saldo"});
            this.cmbOp.Location = new System.Drawing.Point(12, 44);
            this.cmbOp.Name = "cmbOp";
            this.cmbOp.Size = new System.Drawing.Size(464, 33);
            this.cmbOp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRANSAÇÃO BANCÁRIA";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(12, 155);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(464, 34);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Realizar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 204);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 25);
            this.lblRes.TabIndex = 3;
            // 
            // txtDin
            // 
            this.txtDin.Location = new System.Drawing.Point(115, 84);
            this.txtDin.Name = "txtDin";
            this.txtDin.Size = new System.Drawing.Size(232, 31);
            this.txtDin.TabIndex = 4;
            // 
            // txtSaq
            // 
            this.txtSaq.Location = new System.Drawing.Point(115, 118);
            this.txtSaq.Name = "txtSaq";
            this.txtSaq.Size = new System.Drawing.Size(232, 31);
            this.txtSaq.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEPÓSITO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "SAQUE:";
            // 
            // lblRes1
            // 
            this.lblRes1.AutoSize = true;
            this.lblRes1.Location = new System.Drawing.Point(12, 239);
            this.lblRes1.Name = "lblRes1";
            this.lblRes1.Size = new System.Drawing.Size(59, 25);
            this.lblRes1.TabIndex = 8;
            this.lblRes1.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 289);
            this.Controls.Add(this.lblRes1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaq);
            this.Controls.Add(this.txtDin);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbOp;
        private Label label1;
        private Button btnVerificar;
        private Label lblRes;
        private TextBox txtDin;
        private TextBox txtSaq;
        private Label label2;
        private Label label3;
        private Label lblRes1;
    }
}