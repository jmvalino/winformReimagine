using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSBoard
{
    public partial class BoardMDI : Form
    {
        public static bool varcontinue =false;
        public BoardMDI()
        {
            InitializeComponent();
            varcontinue = true;
           
        }

        //private void BoardMDI_Load(object sender, EventArgs e)
        //{
        //    Views.Home hm = new Views.Home();
        //    hm.ShowDialog();
        //}

        private void BoardMDI_Load_1(object sender, EventArgs e)
        {


            while (varcontinue == true)
            {
               
                if (varcontinue == true)
                {
                    showHome();
                }
                else
                {
                    this.Close();
                }
                if (varcontinue == true)
                {
                    showProjects();
                }
                else
                {
                    this.Close();
                }
                if (varcontinue == true)
                {
                    showManhours();
                }
                else
                {
                    this.Close();
                }
                if (varcontinue == true)
                {
                    showAnnouncements();
                }
                else
                {
                    this.Close();
                }
                if (varcontinue == true)
                {
                    showBanners();
                }
                else
                {
                    this.Close();
                }
           
            
                
            }
                
            
        }

        

        void showHome()
        {
            lblSection.Text = "DDG";
           Views.Home home = new Views.Home();
            home.ShowDialog();
           
            //home.ParentForm.Close();
        }


        void showProjects()
        {
            lblSection.Text = "Projects";
            Views.frmProjects proj = new Views.frmProjects();
            proj.ShowDialog();
        }

        void showManhours()
        {
            lblSection.Text = "Manhours";
            Views.frmManhours man = new Views.frmManhours();
            man.ShowDialog();
        }
        void showBanners()
         {
             lblSection.Text = "DDG";
            Views.frmBanners banners = new Views.frmBanners();
            banners.ShowDialog();
        }

        void showAnnouncements()
        {
            lblSection.Text = "Annoucements";
            Views.frmAnnouncements ann = new Views.frmAnnouncements();
            ann.ShowDialog();
        }

        private void lblSection_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoardMDI_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
