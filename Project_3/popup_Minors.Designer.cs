namespace Project_3
{
    partial class popup_Minors
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
            this.minor_title = new System.Windows.Forms.Label();
            this.minor_desc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minor_note = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_minorCourses = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // minor_title
            // 
            this.minor_title.AutoSize = true;
            this.minor_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_title.Location = new System.Drawing.Point(136, 9);
            this.minor_title.Name = "minor_title";
            this.minor_title.Size = new System.Drawing.Size(57, 20);
            this.minor_title.TabIndex = 0;
            this.minor_title.Text = "label1";
            // 
            // minor_desc
            // 
            this.minor_desc.Location = new System.Drawing.Point(12, 57);
            this.minor_desc.Name = "minor_desc";
            this.minor_desc.Size = new System.Drawing.Size(734, 96);
            this.minor_desc.TabIndex = 1;
            this.minor_desc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Courses:";
            // 
            // minor_note
            // 
            this.minor_note.Location = new System.Drawing.Point(87, 174);
            this.minor_note.Name = "minor_note";
            this.minor_note.Size = new System.Drawing.Size(579, 28);
            this.minor_note.TabIndex = 3;
            this.minor_note.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note:";
            // 
            // richTextBox_minorCourses
            // 
            this.richTextBox_minorCourses.Location = new System.Drawing.Point(249, 242);
            this.richTextBox_minorCourses.Name = "richTextBox_minorCourses";
            this.richTextBox_minorCourses.Size = new System.Drawing.Size(100, 96);
            this.richTextBox_minorCourses.TabIndex = 5;
            this.richTextBox_minorCourses.Text = "";
            // 
            // popup_Minors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 371);
            this.Controls.Add(this.richTextBox_minorCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minor_note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minor_desc);
            this.Controls.Add(this.minor_title);
            this.Name = "popup_Minors";
            this.Text = "popup_Minors";
            this.Load += new System.EventHandler(this.popup_Minors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minor_title;
        private System.Windows.Forms.RichTextBox minor_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox minor_note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_minorCourses;
    }
}