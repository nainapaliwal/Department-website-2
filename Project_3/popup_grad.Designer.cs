namespace Project_3
{
    partial class popup_grad
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
            this.lab_title = new System.Windows.Forms.Label();
            this.richText_conc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.Location = new System.Drawing.Point(49, 35);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(51, 20);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "label1";
            // 
            // richText_conc
            // 
            this.richText_conc.Location = new System.Drawing.Point(71, 127);
            this.richText_conc.Name = "richText_conc";
            this.richText_conc.Size = new System.Drawing.Size(100, 96);
            this.richText_conc.TabIndex = 1;
            this.richText_conc.Text = "";
            // 
            // popup_grad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richText_conc);
            this.Controls.Add(this.lab_title);
            this.Name = "popup_grad";
            this.Text = "popup_grad";
            this.Load += new System.EventHandler(this.popup_grad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.RichTextBox richText_conc;
    }
}