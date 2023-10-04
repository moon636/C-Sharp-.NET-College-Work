namespace CalcHypotenuse
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLengthA = new System.Windows.Forms.TextBox();
            this.lblLengthA = new System.Windows.Forms.Label();
            this.lblLengthB = new System.Windows.Forms.Label();
            this.txtLengthB = new System.Windows.Forms.TextBox();
            this.lblLengthC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 156);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 36);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Hypotenuse";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLengthA
            // 
            this.txtLengthA.Location = new System.Drawing.Point(31, 42);
            this.txtLengthA.Name = "txtLengthA";
            this.txtLengthA.Size = new System.Drawing.Size(100, 20);
            this.txtLengthA.TabIndex = 1;
            this.txtLengthA.TextChanged += new System.EventHandler(this.txtLengthA_TextChanged);
            // 
            // lblLengthA
            // 
            this.lblLengthA.AutoSize = true;
            this.lblLengthA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthA.Location = new System.Drawing.Point(45, 9);
            this.lblLengthA.Name = "lblLengthA";
            this.lblLengthA.Size = new System.Drawing.Size(74, 20);
            this.lblLengthA.TabIndex = 2;
            this.lblLengthA.Text = "Length A";
            // 
            // lblLengthB
            // 
            this.lblLengthB.AutoSize = true;
            this.lblLengthB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthB.Location = new System.Drawing.Point(45, 81);
            this.lblLengthB.Name = "lblLengthB";
            this.lblLengthB.Size = new System.Drawing.Size(74, 20);
            this.lblLengthB.TabIndex = 4;
            this.lblLengthB.Text = "Length B";
            // 
            // txtLengthB
            // 
            this.txtLengthB.Location = new System.Drawing.Point(31, 120);
            this.txtLengthB.Name = "txtLengthB";
            this.txtLengthB.Size = new System.Drawing.Size(100, 20);
            this.txtLengthB.TabIndex = 3;
            this.txtLengthB.TextChanged += new System.EventHandler(this.txtLengthB_TextChanged);
            // 
            // lblLengthC
            // 
            this.lblLengthC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthC.Location = new System.Drawing.Point(-1, 207);
            this.lblLengthC.Name = "lblLengthC";
            this.lblLengthC.Size = new System.Drawing.Size(182, 25);
            this.lblLengthC.TabIndex = 5;
            this.lblLengthC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLengthC.Click += new System.EventHandler(this.lblLengthC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 258);
            this.Controls.Add(this.lblLengthC);
            this.Controls.Add(this.lblLengthB);
            this.Controls.Add(this.txtLengthB);
            this.Controls.Add(this.lblLengthA);
            this.Controls.Add(this.txtLengthA);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtLengthA;
        private System.Windows.Forms.Label lblLengthA;
        private System.Windows.Forms.Label lblLengthB;
        private System.Windows.Forms.TextBox txtLengthB;
        private System.Windows.Forms.Label lblLengthC;
    }
}

