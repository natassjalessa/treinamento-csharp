namespace notaEscolar
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
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDada = new System.Windows.Forms.TextBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblFreq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTA 1:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(139, 26);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(150, 31);
            this.txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(139, 63);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(150, 31);
            this.txtN2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOTA 2:";
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(139, 137);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(150, 31);
            this.txtFreq.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "FREQUÊNCIA:";
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(20, 174);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(269, 47);
            this.btnRes.TabIndex = 6;
            this.btnRes.Text = "RESULTADO";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "AULA DADA:";
            // 
            // txtDada
            // 
            this.txtDada.Location = new System.Drawing.Point(139, 100);
            this.txtDada.Name = "txtDada";
            this.txtDada.Size = new System.Drawing.Size(150, 31);
            this.txtDada.TabIndex = 8;
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(20, 237);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(0, 25);
            this.lblMed.TabIndex = 9;
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(20, 273);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(0, 25);
            this.lblFreq.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 352);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.txtDada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label2);
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
        private TextBox txtN2;
        private Label label2;
        private TextBox txtFreq;
        private Label label3;
        private Button btnRes;
        private Label label4;
        private TextBox txtDada;
        private Label lblMed;
        private Label lblFreq;
    }
}