namespace ManagerApp
{
    partial class RingsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.NumberTB = new Guna.UI.WinForms.GunaNumeric();
            this.Mr7laNumber = new Guna.UI.WinForms.GunaNumeric();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "أضافة حلقة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberTB
            // 
            this.NumberTB.BaseColor = System.Drawing.Color.White;
            this.NumberTB.BorderColor = System.Drawing.Color.Silver;
            this.NumberTB.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NumberTB.ButtonForeColor = System.Drawing.Color.White;
            this.NumberTB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NumberTB.ForeColor = System.Drawing.Color.Black;
            this.NumberTB.Location = new System.Drawing.Point(34, 106);
            this.NumberTB.Maximum = ((long)(9999999));
            this.NumberTB.Minimum = ((long)(0));
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(75, 30);
            this.NumberTB.TabIndex = 2;
            this.NumberTB.Text = "gunaNumeric1";
            this.NumberTB.Value = ((long)(0));
            // 
            // Mr7laNumber
            // 
            this.Mr7laNumber.BaseColor = System.Drawing.Color.White;
            this.Mr7laNumber.BorderColor = System.Drawing.Color.Silver;
            this.Mr7laNumber.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Mr7laNumber.ButtonForeColor = System.Drawing.Color.White;
            this.Mr7laNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Mr7laNumber.ForeColor = System.Drawing.Color.Black;
            this.Mr7laNumber.Location = new System.Drawing.Point(153, 106);
            this.Mr7laNumber.Maximum = ((long)(9999999));
            this.Mr7laNumber.Minimum = ((long)(0));
            this.Mr7laNumber.Name = "Mr7laNumber";
            this.Mr7laNumber.Size = new System.Drawing.Size(75, 30);
            this.Mr7laNumber.TabIndex = 4;
            this.Mr7laNumber.Text = "gunaNumeric1";
            this.Mr7laNumber.Value = ((long)(0));
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "أضافة مرحلة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Mr7laNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumberTB);
            this.Controls.Add(this.button1);
            this.Name = "RingsForm";
            this.Text = "RingsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaNumeric NumberTB;
        private Guna.UI.WinForms.GunaNumeric Mr7laNumber;
        private System.Windows.Forms.Button button2;
    }
}