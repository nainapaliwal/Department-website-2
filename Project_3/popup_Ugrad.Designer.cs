namespace Project_3
{
    partial class popup_Ugrad
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
            this.richText_conc = new System.Windows.Forms.RichTextBox();
            this.label_Ugrad_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richText_conc
            // 
            this.richText_conc.Location = new System.Drawing.Point(72, 155);
            this.richText_conc.Name = "richText_conc";
            this.richText_conc.Size = new System.Drawing.Size(163, 96);
            this.richText_conc.TabIndex = 0;
            this.richText_conc.Text = "";
            // 
            // label_Ugrad_title
            // 
            this.label_Ugrad_title.AutoSize = true;
            this.label_Ugrad_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ugrad_title.Location = new System.Drawing.Point(69, 43);
            this.label_Ugrad_title.Name = "label_Ugrad_title";
            this.label_Ugrad_title.Size = new System.Drawing.Size(51, 20);
            this.label_Ugrad_title.TabIndex = 1;
            this.label_Ugrad_title.Text = "label1";
            // 
            // popup_Ugrad
            // 
            this.ClientSize = new System.Drawing.Size(350, 319);
            this.Controls.Add(this.label_Ugrad_title);
            this.Controls.Add(this.richText_conc);
            this.Name = "popup_Ugrad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label_Ugrad_title;

        #endregion

        // private System.Windows.Forms.Label label_desc_Ugrad;
    }
}