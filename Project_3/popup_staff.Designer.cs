namespace Project_3
{
    partial class popup_staff
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
            this.pic_staff = new System.Windows.Forms.PictureBox();
            this.richText_staff = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_staff
            // 
            this.pic_staff.Location = new System.Drawing.Point(30, 130);
            this.pic_staff.Name = "pic_staff";
            this.pic_staff.Size = new System.Drawing.Size(117, 123);
            this.pic_staff.TabIndex = 0;
            this.pic_staff.TabStop = false;
            // 
            // richText_staff
            // 
            this.richText_staff.Location = new System.Drawing.Point(250, 109);
            this.richText_staff.Name = "richText_staff";
            this.richText_staff.Size = new System.Drawing.Size(308, 203);
            this.richText_staff.TabIndex = 1;
            this.richText_staff.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Details";
            // 
            // popup_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richText_staff);
            this.Controls.Add(this.pic_staff);
            this.Name = "popup_staff";
            this.Text = "popup_staff";
            this.Load += new System.EventHandler(this.popup_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_staff;
        private System.Windows.Forms.RichTextBox richText_staff;
        private System.Windows.Forms.Label label1;
    }
}