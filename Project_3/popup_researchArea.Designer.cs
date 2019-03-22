namespace Project_3
{
    partial class popup_researchArea
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
            this.richTxt_res_area = new System.Windows.Forms.RichTextBox();
            this.lab_areaName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTxt_res_area
            // 
            this.richTxt_res_area.Location = new System.Drawing.Point(37, 82);
            this.richTxt_res_area.Name = "richTxt_res_area";
            this.richTxt_res_area.Size = new System.Drawing.Size(436, 224);
            this.richTxt_res_area.TabIndex = 0;
            this.richTxt_res_area.Text = "";
            // 
            // lab_areaName
            // 
            this.lab_areaName.AutoSize = true;
            this.lab_areaName.Location = new System.Drawing.Point(173, 24);
            this.lab_areaName.Name = "lab_areaName";
            this.lab_areaName.Size = new System.Drawing.Size(35, 13);
            this.lab_areaName.TabIndex = 1;
            this.lab_areaName.Text = "label1";
            // 
            // popup_researchArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 329);
            this.Controls.Add(this.lab_areaName);
            this.Controls.Add(this.richTxt_res_area);
            this.Name = "popup_researchArea";
            this.Text = "popup_researchArea";
            //this.Load += new System.EventHandler(this.popup_researchArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt_res_area;
        private System.Windows.Forms.Label lab_areaName;
    }
}