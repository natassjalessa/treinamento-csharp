namespace MediaAluno
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite n1:";
            
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(120, 21);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(150, 31);
            this.txtN1.TabIndex = 1;
            
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(12, 153);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(296, 34);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite n2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite n3:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(120, 65);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(150, 31);
            this.txtN2.TabIndex = 5;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(120, 105);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(150, 31);
            this.txtN3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 214);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtN1;
        private Button btnCal;
        private Label label2;
        private Label label3;
        private TextBox txtN2;
        private TextBox txtN3;
    }
}