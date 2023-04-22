namespace ManagerApp
{
    partial class HaleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 28);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lalezar", 12F);
            this.label1.Location = new System.Drawing.Point(118, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "الحالة";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Font = new System.Drawing.Font("Adobe Arabic", 18F);
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "يحضر",
            "ناجح",
            "راسب",
            "مطرود",
            "أنتظار"});
            this.StatusComboBox.Location = new System.Drawing.Point(5, 34);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusComboBox.Size = new System.Drawing.Size(272, 34);
            this.StatusComboBox.TabIndex = 8;
            this.StatusComboBox.Text = "الحالة";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(7, 74);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(198, 30);
            this.gunaDateTimePicker1.TabIndex = 9;
            this.gunaDateTimePicker1.Text = "Tuesday, February 11, 2020";
            this.gunaDateTimePicker1.Value = new System.DateTime(2020, 2, 11, 18, 45, 39, 596);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lalezar", 12F);
            this.label2.Location = new System.Drawing.Point(209, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ اليوم";
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Lalezar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton6.Image")));
            this.gunaButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton6.Location = new System.Drawing.Point(89, 110);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Radius = 7;
            this.gunaButton6.Size = new System.Drawing.Size(92, 37);
            this.gunaButton6.TabIndex = 16;
            this.gunaButton6.Text = "حفظ";
            this.gunaButton6.Click += new System.EventHandler(this.gunaButton6_Click);
            // 
            // HaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.gunaButton6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HaleForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "حالة الطالب";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private Guna.UI.WinForms.GunaButton gunaButton6;
    }
}