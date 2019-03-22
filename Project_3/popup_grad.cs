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
    public partial class popup_grad : Form
    {
        Form1 form = null;
        public popup_grad(Form1 form, string deg_name, string title)
        {
            this.form = form;
             InitializeComponent();
            lab_title.Text = title;

            foreach (var con in form.grad_Conc(deg_name))
            {
                richText_conc.Text += "- " +con + "\n";
            }
        }

        private void popup_grad_Load(object sender, EventArgs e)
        {

        }
    }
}
