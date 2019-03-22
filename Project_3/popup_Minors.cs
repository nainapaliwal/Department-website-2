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
    public partial class popup_Minors : Form
    {
        UgMinor ugminor;
        Form1 form = null;
        public popup_Minors(Form1 form, string name)
        {
            this.form = form;
            InitializeComponent();

            ugminor = form.Minors(name);

            minor_title.Text = ugminor.title;
            minor_desc.Text = ugminor.description;
            minor_note.Text = ugminor.note;

         
            for (var i = 0; i < ugminor.courses.Count; i++)
            {
               
                richTextBox_minorCourses.Text += ugminor.courses[i] +"\n";
                
            } 
        }

        private void popup_Minors_Load(object sender, EventArgs e)
        {

        }
    }
}
