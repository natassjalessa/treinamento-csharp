namespace trianguloLados
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(263, 17);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(150, 31);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(263, 63);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(150, 31);
            this.txtY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Y";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(263, 114);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(150, 31);
            this.txtZ.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Z";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(189, 162);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(224, 34);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar ";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(189, 211);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 25);
            this.lblTipo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 272);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtX;
        private TextBox txtY;
        private Label label2;
        private TextBox txtZ;
        private Label label3;
        private Button btnVerificar;
        private Label lblTipo;
    }
}