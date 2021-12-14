using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_player_nw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomizeD();
        }

        private void CustomizeD()
        {

            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void HideSubM()
        {

            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        private void ShowSubM(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {

                HideSubM();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        
        }


        private Form activeForm = null;

        private void OpenlChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            ShowSubM(panelMediaSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenlChildForm(new Form2());

            HideSubM();
        }

        private void button5_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {

            ShowSubM(panelPlaylistSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            
            
            
            HideSubM();
        }

        private void button8_Click(object sender, EventArgs e)
        {




            HideSubM();
        }

        private void button7_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void button6_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {




            HideSubM();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {

            ShowSubM(panelToolsSubMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void button14_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void button13_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void button12_Click(object sender, EventArgs e)
        {




            HideSubM();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {



            HideSubM();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



