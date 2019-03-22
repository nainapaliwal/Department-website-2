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
    public partial class popup_ResearchByfaculty : Form
    {
        ByFaculty fac_Area;
        Form1 form = null;
        public popup_ResearchByfaculty(Form1 form, string username)
        {
            this.form = form;
            InitializeComponent();

            fac_Area = form.ResearchByFac(username);

            res_facName.Text = fac_Area.facultyName;
            res_facUsername.Text = fac_Area.username;

            foreach (var citation in fac_Area.citations)
            {
                richText_facCitation.Text += citation + "\r\n";
            }
        }

        private void popup_ResearchByfaculty_Load(object sender, EventArgs e)
        {

        }
    }
}
