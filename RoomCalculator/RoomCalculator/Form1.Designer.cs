namespace RoomCalculator
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
            this.txtRoomLength = new System.Windows.Forms.TextBox();
            this.txtRoomWidth = new System.Windows.Forms.TextBox();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.lblRoomWidth = new System.Windows.Forms.Label();
            this.lblRoomLength = new System.Windows.Forms.Label();
            this.txtRoomArea = new System.Windows.Forms.TextBox();
            this.btnCalculateVolume = new System.Windows.Forms.Button();
            this.txtRoomVolume = new System.Windows.Forms.TextBox();
            this.lblRoomHeight = new System.Windows.Forms.Label();
            this.txtRoomHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRoomLength
            // 
            this.txtRoomLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtRoomLength.Location = new System.Drawing.Point(40, 43);
            this.txtRoomLength.Multiline = true;
            this.txtRoomLength.Name = "txtRoomLength";
            this.txtRoomLength.Size = new System.Drawing.Size(228, 42);
            this.txtRoomLength.TabIndex = 0;
            this.txtRoomLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRoomWidth
            // 
            this.txtRoomWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomWidth.Location = new System.Drawing.Point(40, 137);
            this.txtRoomWidth.Multiline = true;
            this.txtRoomWidth.Name = "txtRoomWidth";
            this.txtRoomWidth.Size = new System.Drawing.Size(228, 35);
            this.txtRoomWidth.TabIndex = 1;
            this.txtRoomWidth.TextChanged += new System.EventHandler(this.txtRoomWidth_TextChanged);
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCalculateArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCalculateArea.Location = new System.Drawing.Point(12, 281);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(190, 39);
            this.btnCalculateArea.TabIndex = 2;
            this.btnCalculateArea.Text = "Calculate Area";
            this.btnCalculateArea.UseVisualStyleBackColor = false;
            this.btnCalculateArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRoomWidth
            // 
            this.lblRoomWidth.AutoSize = true;
            this.lblRoomWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomWidth.ForeColor = System.Drawing.Color.White;
            this.lblRoomWidth.Location = new System.Drawing.Point(34, 92);
            this.lblRoomWidth.Name = "lblRoomWidth";
            this.lblRoomWidth.Size = new System.Drawing.Size(234, 31);
            this.lblRoomWidth.TabIndex = 3;
            this.lblRoomWidth.Text = "Enter Room Width";
            this.lblRoomWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRoomLength
            // 
            this.lblRoomLength.AutoSize = true;
            this.lblRoomLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomLength.ForeColor = System.Drawing.Color.White;
            this.lblRoomLength.Location = new System.Drawing.Point(34, 9);
            this.lblRoomLength.Name = "lblRoomLength";
            this.lblRoomLength.Size = new System.Drawing.Size(248, 31);
            this.lblRoomLength.TabIndex = 4;
            this.lblRoomLength.Text = "Enter Room Length";
            this.lblRoomLength.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRoomArea
            // 
            this.txtRoomArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomArea.Location = new System.Drawing.Point(221, 281);
            this.txtRoomArea.Multiline = true;
            this.txtRoomArea.Name = "txtRoomArea";
            this.txtRoomArea.Size = new System.Drawing.Size(86, 39);
            this.txtRoomArea.TabIndex = 5;
            this.txtRoomArea.TextChanged += new System.EventHandler(this.txtRoomArea_TextChanged);
            // 
            // btnCalculateVolume
            // 
            this.btnCalculateVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCalculateVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCalculateVolume.Location = new System.Drawing.Point(12, 335);
            this.btnCalculateVolume.Name = "btnCalculateVolume";
            this.btnCalculateVolume.Size = new System.Drawing.Size(190, 39);
            this.btnCalculateVolume.TabIndex = 6;
            this.btnCalculateVolume.Text = "Calculate Volume";
            this.btnCalculateVolume.UseVisualStyleBackColor = false;
            this.btnCalculateVolume.Click += new System.EventHandler(this.btnCalculateVolume_Click_1);
            // 
            // txtRoomVolume
            // 
            this.txtRoomVolume.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomVolume.Location = new System.Drawing.Point(221, 335);
            this.txtRoomVolume.Multiline = true;
            this.txtRoomVolume.Name = "txtRoomVolume";
            this.txtRoomVolume.Size = new System.Drawing.Size(86, 39);
            this.txtRoomVolume.TabIndex = 7;
            // 
            // lblRoomHeight
            // 
            this.lblRoomHeight.AutoSize = true;
            this.lblRoomHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomHeight.ForeColor = System.Drawing.Color.White;
            this.lblRoomHeight.Location = new System.Drawing.Point(34, 178);
            this.lblRoomHeight.Name = "lblRoomHeight";
            this.lblRoomHeight.Size = new System.Drawing.Size(244, 31);
            this.lblRoomHeight.TabIndex = 9;
            this.lblRoomHeight.Text = "Enter Room Height";
            this.lblRoomHeight.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtRoomHeight
            // 
            this.txtRoomHeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomHeight.Location = new System.Drawing.Point(40, 223);
            this.txtRoomHeight.Multiline = true;
            this.txtRoomHeight.Name = "txtRoomHeight";
            this.txtRoomHeight.Size = new System.Drawing.Size(228, 37);
            this.txtRoomHeight.TabIndex = 8;
            this.txtRoomHeight.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(330, 405);
            this.Controls.Add(this.lblRoomHeight);
            this.Controls.Add(this.txtRoomHeight);
            this.Controls.Add(this.txtRoomVolume);
            this.Controls.Add(this.btnCalculateVolume);
            this.Controls.Add(this.txtRoomArea);
            this.Controls.Add(this.lblRoomLength);
            this.Controls.Add(this.lblRoomWidth);
            this.Controls.Add(this.btnCalculateArea);
            this.Controls.Add(this.txtRoomWidth);
            this.Controls.Add(this.txtRoomLength);
            this.Name = "Form1";
            this.Text = "Room Area Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomLength;
        private System.Windows.Forms.TextBox txtRoomWidth;
        private System.Windows.Forms.Label lblRoomWidth;
        private System.Windows.Forms.Label lblRoomLength;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.TextBox txtRoomArea;
        private System.Windows.Forms.Button btnCalculateVolume;
        private System.Windows.Forms.TextBox txtRoomVolume;
        private System.Windows.Forms.Label lblRoomHeight;
        private System.Windows.Forms.TextBox txtRoomHeight;
    }
}

