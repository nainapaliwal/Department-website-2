using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class popup_faculty : Form
    {

        Faculty faculty;
        private RichTextBox richText_fac;
        private PictureBox pic_fac;
        private Label label1;
        Form1 form = null;

        public popup_faculty(Form1 form, string userName)
        {
            this.form = form;
            InitializeComponent();
            faculty = form.faculty_details(userName);

            richText_fac.Text = faculty.name + "\n " + faculty.title + "\n " + faculty.username + "\n " + faculty.office
                + "\n " + faculty.phone + "\n " + faculty.email + "\n " + faculty.interestArea + "\n " + faculty.website;
            pic_fac.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_fac.Load(faculty.imagePath);


        }

          void InitializeComponent()
        {
            this.richText_fac = new System.Windows.Forms.RichTextBox();
            this.pic_fac = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fac)).BeginInit();
            this.SuspendLayout();
            // 
            // richText_fac
            // 
            this.richText_fac.Location = new System.Drawing.Point(181, 68);
            this.richText_fac.Name = "richText_fac";
            this.richText_fac.Size = new System.Drawing.Size(407, 230);
            this.richText_fac.TabIndex = 0;
            this.richText_fac.Text = "";
            // 
            // pic_fac
            // 
            this.pic_fac.Location = new System.Drawing.Point(30, 101);
            this.pic_fac.Name = "pic_fac";
            this.pic_fac.Size = new System.Drawing.Size(115, 121);
            this.pic_fac.TabIndex = 1;
            this.pic_fac.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faculty Details";
            // 
            // popup_faculty
            // 
            this.ClientSize = new System.Drawing.Size(637, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_fac);
            this.Controls.Add(this.richText_fac);
            this.Name = "popup_faculty";
            ((System.ComponentModel.ISupportInitialize)(this.pic_fac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
