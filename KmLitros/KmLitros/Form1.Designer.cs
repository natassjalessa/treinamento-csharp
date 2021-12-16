namespace KmLitros
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.txtCheg = new System.Windows.Forms.TextBox();
            this.txtLi = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KM INICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "KM CHEGADA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "REABASTECIMENTO";
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(56, 59);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(419, 31);
            this.txtInit.TabIndex = 3;
            // 
            // txtCheg
            // 
            this.txtCheg.Location = new System.Drawing.Point(56, 121);
            this.txtCheg.Name = "txtCheg";
            this.txtCheg.Size = new System.Drawing.Size(419, 31);
            this.txtCheg.TabIndex = 4;
            // 
            // txtLi
            // 
            this.txtLi.Location = new System.Drawing.Point(56, 183);
            this.txtLi.Name = "txtLi";
            this.txtLi.Size = new System.Drawing.Size(419, 31);
            this.txtLi.TabIndex = 5;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(174, 220);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(149, 34);
            this.btnRes.TabIndex = 6;
            this.btnRes.Text = "RESULTADO";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 249);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 25);
            this.lblRes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 457);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txtLi);
            this.Controls.Add(this.txtCheg);
            this.Controls.Add(this.txtInit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtInit;
        private TextBox txtCheg;
        private TextBox txtLi;
        private Button btnRes;
        private Label lblRes;
    }
}