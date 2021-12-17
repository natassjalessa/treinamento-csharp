namespace contaBancaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblRealizar = new System.Windows.Forms.Label();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTA BANCÁRIA";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(66, 99);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(183, 31);
            this.txtValor.TabIndex = 5;
            // 
            // lblRealizar
            // 
            this.lblRealizar.AutoSize = true;
            this.lblRealizar.Location = new System.Drawing.Point(18, 183);
            this.lblRealizar.Name = "lblRealizar";
            this.lblRealizar.Size = new System.Drawing.Size(0, 25);
            this.lblRealizar.TabIndex = 6;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(18, 146);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(288, 34);
            this.btnRealizar.TabIndex = 7;
            this.btnRealizar.Text = "REALIZAR";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Items.AddRange(new object[] {
            "DEPÓSITO",
            "SAQUE",
            "SALDO"});
            this.cmbBox.Location = new System.Drawing.Point(18, 33);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(288, 33);
            this.cmbBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite aqui o valor:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRealizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.lblRealizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BANCO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private Label lblRealizar;
        private Button btnRealizar;
        private ComboBox cmbBox;
        private Label label2;
    }
}