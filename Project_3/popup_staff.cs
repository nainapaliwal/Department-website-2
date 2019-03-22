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
    public partial class popup_staff : Form
    {
        Form1 form = null;
        Staff staff;
        public popup_staff(Form1 form, string userName)
        {
            this.form = form;
            InitializeComponent();
            staff = form.staff_details(userName);

            richText_staff.Text = staff.name + "\n " + staff.title + "\n " + staff.username + "\n " + staff.office
                + "\n " + staff.phone + "\n " + staff.email + "\n " + staff.interestArea + "\n " + staff.website;
            pic_staff.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_staff.Load(staff.imagePath);


        }

        private void popup_staff_Load(object sender, EventArgs e)
        {

        }
    }
}
