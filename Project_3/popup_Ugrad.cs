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
    public partial class popup_Ugrad : Form
    {
        //private Label lab_title;
        //private Label lab_deg_desc;
        //private Label lab_conc;
        private RichTextBox richText_conc;
        Form1 form = null;
        public popup_Ugrad(Form1 form, string deg_name, string title)
        {
            this.form = form;
            InitializeComponent();
            label_Ugrad_title.Text = title;
          
            foreach (var con in form.Undergrad_Conc(deg_name))
            {
              
                richText_conc.Text += "- " +con + "\n";
            }
        }
        
    }
}
