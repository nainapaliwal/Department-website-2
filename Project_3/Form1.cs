using Newtonsoft.Json.Linq;
using RestUtil;
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
    public partial class Form1 : Form
    {
        //keep all of my objects globally
        About about;
        Degrees Ugrad;
        Degrees grad;
        popup_grad pop_grad;
        popup_Ugrad pop_Ugrad;
        Minors minor;
        popup_Minors pop_minor;
        Resources resources;
        People people;
        popup_faculty pop_fac;
        popup_staff pop_staff;
        Research research;
        popup_researchArea pop_resArea;
        popup_ResearchByfaculty pop_resFac;
        Employment employment;
        Footer footer;
        News news;

        // restful interface
        REST rj = new REST("http://ist.rit.edu/api");
        REST googleRj = new REST("http://google.com/coolAPI");
       

        public Form1()
        {
            InitializeComponent();
            Undergraduate();
            Graduate();
            Minors();
            People();
            Research();
            Employment();
            Footer();
            News();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //go get about....
            string jsonAbout = rj.getJSON("/about/");
            
            about = JToken.Parse(jsonAbout).ToObject<About>();          
            label_title.Text = about.title;
            richText_about_desc.Text = about.description;
            label_author.Text = about.quoteAuthor;
            richText_quote.Text = about.quote;
        }

        // get the underegraduate degree information and is loaded in the second tab

        private void Undergraduate()
        {
            string jsonUndergrad = rj.getJSON("/degrees/undergraduate");
            Ugrad = JToken.Parse(jsonUndergrad).ToObject<Degrees>();

            
            button_wmc.Text = Ugrad.undergraduate[0].title;
            button_hcc.Text = Ugrad.undergraduate[1].title;
            button_cit.Text = Ugrad.undergraduate[2].title;

            desc_wmc.Text = Ugrad.undergraduate[0].description;
            desc_hcc.Text = Ugrad.undergraduate[1].description;
            desc_cit.Text = Ugrad.undergraduate[2].description;
        }

        private void Graduate()
        {
            string jsonGrad = rj.getJSON("/degrees/graduate");
            grad = JToken.Parse(jsonGrad).ToObject<Degrees>();

            
            button_ist.Text = grad.graduate[0].title;
            button_hci.Text = grad.graduate[1].title;
            button_nsa.Text = grad.graduate[2].title;

            desc_ist.Text = grad.graduate[0].description;
            desc_hci.Text = grad.graduate[1].description;
            desc_nsa.Text = grad.graduate[2].description;
        }

        // to get the  degree details 

        public List<string> Undergrad_Conc(string degree_name)
        {
            List<String> conc = new List<string>();
            foreach (var deg in Ugrad.undergraduate)
            {
                if (deg.degreeName == degree_name)
                {                   
                    foreach (var con in deg.concentrations)
                    {
                        conc.Add(con);
                    }
                }
            }
            return conc;
        }

        public List<string> grad_Conc(string degree_name)
        {
            List<String> conc = new List<string>();
            foreach (var deg in grad.graduate)
            {
                if (deg.degreeName == degree_name)
                {                  
                    foreach (var con in deg.concentrations)
                    {
                        conc.Add(con);
                    }
                }
            }
            return conc;
        }

        private void button_wmc_Click(object sender, EventArgs e)
        {
            pop_Ugrad = new popup_Ugrad(this, Ugrad.undergraduate[0].degreeName, Ugrad.undergraduate[0].title);
            pop_Ugrad.Show();
        }

        private void button_hcc_Click(object sender, EventArgs e)
        {
            pop_Ugrad = new popup_Ugrad(this, Ugrad.undergraduate[1].degreeName, Ugrad.undergraduate[1].title);
            pop_Ugrad.Show();
        }

        private void button_cit_Click(object sender, EventArgs e)
        {
            pop_Ugrad = new popup_Ugrad(this, Ugrad.undergraduate[2].degreeName, Ugrad.undergraduate[2].title);
            pop_Ugrad.Show();
        }

        private void button_ist_Click(object sender, EventArgs e)
        {
            pop_grad = new popup_grad(this, grad.graduate[0].degreeName, grad.graduate[0].title);
            pop_grad.Show();
        }

        private void button_hci_Click(object sender, EventArgs e)
        {
            pop_grad = new popup_grad(this, grad.graduate[1].degreeName, grad.graduate[1].title);
            pop_grad.Show();
        }

        private void button_nsa_Click(object sender, EventArgs e)
        {
            pop_grad = new popup_grad(this, grad.graduate[2].degreeName, grad.graduate[2].title);
            pop_grad.Show();
        }

        // to get the Minors details from the API

        private void Minors()
        {
            string jsonMinors = rj.getJSON("/minors");
            minor = JToken.Parse(jsonMinors).ToObject<Minors>();

            var minorBoxes = new Button[] { button1, button2, button3, button4, button5, button6,
                button7, button8 };

            for (var i = 0; i < minor.UgMinors.Count; i++)
            {
                minorBoxes[i].Text = minor.UgMinors[i].title;
            }
        }

        public UgMinor Minors(string name)
        {
            UgMinor min = new UgMinor();

            foreach (var m in minor.UgMinors)
            {
                if (m.name == name)
                {
                    min = m;
                }
            }
            return min;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[0].name);
            pop_minor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[1].name);
            pop_minor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[2].name);
            pop_minor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[3].name);
            pop_minor.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[4].name);
            pop_minor.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[5].name);
            pop_minor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[6].name);
            pop_minor.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pop_minor = new popup_Minors(this, minor.UgMinors[7].name);
            pop_minor.Show();
        }

        // to get the research details from the API 

        private void Research()
        {
            string jsonResearch = rj.getJSON("/research/");
            research = JToken.Parse(jsonResearch).ToObject<Research>();

            var res_area = new Label[]
            {
                label8, label9, label10, label11, label12, label13,
                label14, label15, label16, label17, label18, label19
            };

            for (var i = 0; i < research.byInterestArea.Count; i++)
            {
                res_area[i].Text = research.byInterestArea[i].areaName;
            }

            var res_faculty = new Label[]
            {
                label21, label22, label23, label24, label25,
                label26, label27, label28, label29, label30, label31, label32, label33,
                label34, label35, label36, label37, label38, label39, label40,
                label41, label42
            };

            for (var i = 0; i < research.byFaculty.Count; i++)
            {
                res_faculty[i].Text = research.byFaculty[i].facultyName;
            }

        }

        // to call  InterestArea() in popup

        public ByInterestArea InterestArea(string areaname)
        {
            ByInterestArea interestArea = new ByInterestArea();
            foreach (var interest in research.byInterestArea)
            {
                if (interest.areaName == areaname)
                {
                    interestArea = interest;
                }
            }
            return interestArea;
        }

        // research


        private void label8_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[0].areaName);
            pop_resArea.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[1].areaName);
            pop_resArea.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[2].areaName);
            pop_resArea.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[3].areaName);
            pop_resArea.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[4].areaName);
            pop_resArea.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[5].areaName);
            pop_resArea.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[6].areaName);
            pop_resArea.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[7].areaName);
            pop_resArea.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[8].areaName);
            pop_resArea.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[9].areaName);
            pop_resArea.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[10].areaName);
            pop_resArea.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            pop_resArea = new popup_researchArea(this, research.byInterestArea[11].areaName);
            pop_resArea.Show();
        }

        // to call ResearchByFac() in popup

        public ByFaculty ResearchByFac(string username)
        {
            ByFaculty bf = new ByFaculty();
            foreach (var f in research.byFaculty)
            {
                if (f.username == username)
                {
                    bf = f;
                }
            }
            return bf;
        }






        // to get faculty from the API

        private void People()
        {
            string jsonPeople = rj.getJSON("/people/");
            people = JToken.Parse(jsonPeople).ToObject<People>();

            var fac = new PictureBox[] {  pictureBox2, pictureBox3, pictureBox4, pictureBox5,
                pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13,
                pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
                pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27,
                pictureBox28, pictureBox29, pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34,
                pictureBox35 };

            for (var i = 0; i < people.faculty.Count; i++)
            {
                fac[i].SizeMode = PictureBoxSizeMode.StretchImage;
                fac[i].Load(people.faculty[i].imagePath);
            }

            var staff = new PictureBox[]
            {
                pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40,
                pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48
            };

            for (var j = 0; j < people.staff.Count; j++)
            {
                staff[j].SizeMode = PictureBoxSizeMode.StretchImage;
                staff[j].Load(people.staff[j].imagePath);
               
            }
        }

        // to call faculty() in popup

        public Faculty faculty_details(string username)
        {
            Faculty faculty = new Faculty();

            foreach (var f in people.faculty)
            {
                if (f.username == username)
                {
                    faculty = f;
                }
            }
            return faculty;
        }

        // to call staff() in popup

        public Staff staff_details(string user)
        {
            Staff staff = new Staff();

            foreach (var s in people.staff)
            {
                if (s.username == user)
                {
                    staff = s;
                }
            }
            return staff;
        }

        // to open faculty popups on click event

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[0].username);
            pop_fac.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[1].username);
            pop_fac.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[2].username);
            pop_fac.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[3].username);
            pop_fac.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[4].username);
            pop_fac.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[5].username);
            pop_fac.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[6].username);
            pop_fac.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[7].username);
            pop_fac.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[8].username);
            pop_fac.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[9].username);
            pop_fac.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[10].username);
            pop_fac.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[11].username);
            pop_fac.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[12].username);
            pop_fac.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[13].username);
            pop_fac.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[14].username);
            pop_fac.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[15].username);
            pop_fac.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[16].username);
            pop_fac.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[17].username);
            pop_fac.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[18].username);
            pop_fac.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[19].username);
            pop_fac.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[20].username);
            pop_fac.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[21].username);
            pop_fac.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[22].username);
            pop_fac.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[23].username);
            pop_fac.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[24].username);
            pop_fac.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[25].username);
            pop_fac.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[26].username);
            pop_fac.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[27].username);
            pop_fac.Show();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[28].username);
            pop_fac.Show();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[29].username);
            pop_fac.Show();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[30].username);
            pop_fac.Show();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[31].username);
            pop_fac.Show();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pop_fac = new popup_faculty(this, people.faculty[32].username);
            pop_fac.Show();
        }

        // to open staff popups on click event

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[0].username);
            pop_staff.Show();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[1].username);
            pop_staff.Show();
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[2].username);
            pop_staff.Show();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[3].username);
            pop_staff.Show();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[4].username);
            pop_staff.Show();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[5].username);
            pop_staff.Show();
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[6].username);
            pop_staff.Show();
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[7].username);
            pop_staff.Show();
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[8].username);
            pop_staff.Show();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[9].username);
            pop_staff.Show();
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[10].username);
            pop_staff.Show();
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[11].username);
            pop_staff.Show();
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            pop_staff = new popup_staff(this, people.staff[12].username);
            pop_staff.Show();
        }

        // faculty research



        private void label21_Click(object sender, EventArgs e)
        {
            pop_resFac  = new popup_ResearchByfaculty(this, research.byFaculty[0].username);
            pop_resFac.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[1].username);
            pop_resFac.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[2].username);
            pop_resFac.Show();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[3].username);
            pop_resFac.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[4].username);
            pop_resFac.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[5].username);
            pop_resFac.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[6].username);
            pop_resFac.Show();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[7].username);
            pop_resFac.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[8].username);
            pop_resFac.Show();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[9].username);
            pop_resFac.Show();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[10].username);
            pop_resFac.Show();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[11].username);
            pop_resFac.Show();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[12].username);
            pop_resFac.Show();
        }

        private void label36_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[13].username);
            pop_resFac.Show();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[14].username);
            pop_resFac.Show();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[15].username);
            pop_resFac.Show();
        }

        private void label39_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[16].username);
            pop_resFac.Show();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[17].username);
            pop_resFac.Show();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[18].username);
            pop_resFac.Show();
        }

        private void label42_Click(object sender, EventArgs e)
        {
            pop_resFac = new popup_ResearchByfaculty(this, research.byFaculty[19].username);
            pop_resFac.Show();
        }

        // to get employemnt information

        private void Employment()
        {
            string jsonEmployment = rj.getJSON("/employment");
            employment = JToken.Parse(jsonEmployment).ToObject<Employment>();

            lab_empTitle.Text = employment.introduction.title;           
            richtxt_emp_desc.Text = employment.introduction.content[0].description;

            richTextBox1.Text = employment.degreeStatistics.statistics[0].value +
                "\r\n" + employment.degreeStatistics.statistics[0].description;
            richTextBox2.Text = employment.degreeStatistics.statistics[1].value +
                "\r\n" + employment.degreeStatistics.statistics[1].description; 
            richTextBox3.Text = employment.degreeStatistics.statistics[2].value +
                "\r\n" + employment.degreeStatistics.statistics[2].description;
            richTextBox4.Text = employment.degreeStatistics.statistics[3].value +
                "\r\n" + employment.degreeStatistics.statistics[3].description;

            richText_coopDesc.Text = employment.introduction.content[1].description;
            
            foreach (var employer in employment.employers.employerNames)
            {
                richTextBox_employers.Text += employer + "   ";
            }
            foreach (var career in employment.careers.careerNames)
            {
                richTextBox_careers.Text += career + "  ";
            }
        }

        // Get employment table       

        private void button_emplTable_Click(object sender, EventArgs e)
        {
            //load the data
            string jsonEmploy = rj.getJSON("/employment/");
            employment = JToken.Parse(jsonEmploy).ToObject<Employment>();

            listView_empTable.View = View.Details;
            listView_empTable.GridLines = true;
            listView_empTable.FullRowSelect = true;
            listView_empTable.Width = 710;
           
            listView_empTable.Columns.Add("Employers", 200);
            listView_empTable.Columns.Add("Degree", 200);
            listView_empTable.Columns.Add("City", 200);
            listView_empTable.Columns.Add("Title", 100);
            listView_empTable.Columns.Add("Start Term", 100);

            //dump in data
            ListViewItem item;
            for (int i = 0; i < employment.employmentTable.professionalEmploymentInformation.Count; i++)
            {
                item = new ListViewItem(new String[] {
                    employment.employmentTable.professionalEmploymentInformation[i].employer,
                    employment.employmentTable.professionalEmploymentInformation[i].degree,
                    employment.employmentTable.professionalEmploymentInformation[i].city,
                    employment.employmentTable.professionalEmploymentInformation[i].title,
                    employment.employmentTable.professionalEmploymentInformation[i].startDate
                });
                listView_empTable.Items.Add(item);
            }
        }

        // get cooptable on button click
        
        private void button_coopTable_Click(object sender, EventArgs e)
        {
            //load the data
            string jsonEmploy = rj.getJSON("/employment/");
            //turn into object
            employment = JToken.Parse(jsonEmploy).ToObject<Employment>();

            //prepare the listView
            //set up how I want it to look...

            listView_coopTable.View = View.Details;
            listView_coopTable.GridLines = true;
            listView_coopTable.FullRowSelect = true;
            listView_coopTable.Width = 710;
            //assing the headers
            listView_coopTable.Columns.Add("Employers", 200);
            listView_coopTable.Columns.Add("Degree", 200);
            listView_coopTable.Columns.Add("City", 200);
            listView_coopTable.Columns.Add("Term", 100);

            //dump in data
            ListViewItem item;
            for (int i = 0; i < employment.coopTable.coopInformation.Count; i++)
            {
                item = new ListViewItem(new String[] {
                    employment.coopTable.coopInformation[i].employer,
                    employment.coopTable.coopInformation[i].degree,
                    employment.coopTable.coopInformation[i].city,
                    employment.coopTable.coopInformation[i].term
                });
                listView_coopTable.Items.Add(item);
            }
        }

        // to get the details of each resource on click event

        private void button9_Click(object sender, EventArgs e)
        {
            string jsonResources = rj.getJSON("/resources/");
            resources = JToken.Parse(jsonResources).ToObject<Resources>();

            richTextBox_AllResources.Text = resources.studyAbroad.description+" \n\n" ;

            for (var i = 0; i < resources.studyAbroad.places.Count; i++)
            {
                richTextBox_AllResources.Text += "\r\n\n" + "- " + resources.studyAbroad.places[i].nameOfPlace +
                  "\r\n\n" + resources.studyAbroad.places[i].description;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string jsonResources = rj.getJSON("/resources/");
            resources = JToken.Parse(jsonResources).ToObject<Resources>();

            richTextBox_AllResources.Text = resources.tutorsAndLabInformation.tutoringLabHoursLink + " \n\n"
            + resources.tutorsAndLabInformation.description + " \n\n";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string jsonResources = rj.getJSON("/resources/");
            resources = JToken.Parse(jsonResources).ToObject<Resources>();

            richTextBox_AllResources.Text = "\n";

            for (var i = 0; i < resources.coopEnrollment.enrollmentInformationContent.Count; i++)
            {
                richTextBox_AllResources.Text += "\r\n\n"  +"- " + resources.coopEnrollment.enrollmentInformationContent[i].title +
                  "\r\n\n" + resources.coopEnrollment.enrollmentInformationContent[i].description;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string jsonResources = rj.getJSON("/resources/");
            resources = JToken.Parse(jsonResources).ToObject<Resources>();

            richTextBox_AllResources.Text = resources.studentAmbassadors.ambassadorsImageSource + " \n\n";

            for (var i = 0; i < resources.studentAmbassadors.subSectionContent.Count; i++)
            {
                richTextBox_AllResources.Text += "\r\n\n" + "- "+resources.studentAmbassadors.subSectionContent[i].title +
                  "\r\n\n" + resources.studentAmbassadors.subSectionContent[i].description;
            }

            richTextBox_AllResources.Text += resources.studentAmbassadors.applicationFormLink + " \n\n"+
                resources.studentAmbassadors.note;

        }

        // to get data for footer

        private void Footer() {

            string jsonFooter = rj.getJSON("/footer/");
            footer = JToken.Parse(jsonFooter).ToObject<Footer>();

            richTextBox_footer.Text =  footer.social.tweet + " Tweeted By : "+
                 footer.social.by + "\n\n Follow Us on :\n\n" + footer.social.twitter + " \n" + footer.social.facebook + " \n";

            for (var i = 0; i < footer.quickLinks.Count; i++)
            {
                richTextBox_footer.Text += "\r\n\n"  + footer.quickLinks[i].title + " - "+
                   footer.quickLinks[i].href;
            }

            richTextBox_footer.Text += "\n\n Copyright: " + footer.copyright.html;
               
        }

        // to get data for News

        private void News()
        {

            string jsonNews = rj.getJSON("/news/");
            news = JToken.Parse(jsonNews).ToObject<News>();

            for (var i = 0; i < news.older.Count; i++)
            {
                richTextBox_news.Text += "\r\n\n "+ (i+1) +". " + news.older[i].title + " - " + news.older[i].date +
                  "\n\n"+ news.older[i].description;
            }          
        }

    }
}
