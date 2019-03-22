namespace Project_3
{
    partial class popup_ResearchByfaculty
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
            this.res_facUsername = new System.Windows.Forms.Label();
            this.res_facName = new System.Windows.Forms.Label();
            this.richText_facCitation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // res_facUsername
            // 
            this.res_facUsername.AutoSize = true;
            this.res_facUsername.Location = new System.Drawing.Point(285, 38);
            this.res_facUsername.Name = "res_facUsername";
            this.res_facUsername.Size = new System.Drawing.Size(35, 13);
            this.res_facUsername.TabIndex = 0;
            this.res_facUsername.Text = "label1";
            // 
            // res_facName
            // 
            this.res_facName.AutoSize = true;
            this.res_facName.Location = new System.Drawing.Point(90, 38);
            this.res_facName.Name = "res_facName";
            this.res_facName.Size = new System.Drawing.Size(35, 13);
            this.res_facName.TabIndex = 1;
            this.res_facName.Text = "label2";
            // 
            // richText_facCitation
            // 
            this.richText_facCitation.Location = new System.Drawing.Point(12, 119);
            this.richText_facCitation.Name = "richText_facCitation";
            this.richText_facCitation.Size = new System.Drawing.Size(505, 227);
            this.richText_facCitation.TabIndex = 3;
            this.richText_facCitation.Text = "";
            // 
            // popup_ResearchByfaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 358);
            this.Controls.Add(this.richText_facCitation);
            this.Controls.Add(this.res_facName);
            this.Controls.Add(this.res_facUsername);
            this.Name = "popup_ResearchByfaculty";
            this.Text = "popup_ResearchByfaculty";
            this.Load += new System.EventHandler(this.popup_ResearchByfaculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label res_facUsername;
        private System.Windows.Forms.Label res_facName;
        private System.Windows.Forms.RichTextBox richText_facCitation;
    }
}