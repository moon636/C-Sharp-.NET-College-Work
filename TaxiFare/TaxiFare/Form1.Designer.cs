namespace TaxiFare
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
            this.btnCalculateFare = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblFare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateFare
            // 
            this.btnCalculateFare.Location = new System.Drawing.Point(71, 86);
            this.btnCalculateFare.Name = "btnCalculateFare";
            this.btnCalculateFare.Size = new System.Drawing.Size(126, 23);
            this.btnCalculateFare.TabIndex = 0;
            this.btnCalculateFare.Text = "Calculate Fare";
            this.btnCalculateFare.UseVisualStyleBackColor = true;
            this.btnCalculateFare.Click += new System.EventHandler(this.btnCalculateFare_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(86, 48);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 1;
            // 
            // lblFare
            // 
            this.lblFare.Location = new System.Drawing.Point(50, 112);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(162, 54);
            this.lblFare.TabIndex = 2;
            this.lblFare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 195);
            this.Controls.Add(this.lblFare);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnCalculateFare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateFare;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblFare;
    }
}

