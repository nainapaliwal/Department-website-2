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
    public partial class popup_researchArea : Form
    {
        ByInterestArea interestArea;
        Form1 f1 = null;
        public popup_researchArea(Form1 f1, string areaName)
        {
            this.f1 = f1;
            InitializeComponent();

            interestArea = f1.InterestArea(areaName);

            lab_areaName.Text = interestArea.areaName;
            foreach (string citation in interestArea.citations)
            {
                richTxt_res_area.Text += citation + "\r\n";
            }
        }
    }
}
