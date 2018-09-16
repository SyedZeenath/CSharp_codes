using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_win_Events_UserControls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.vcrUserControl1.OnNextButtonClick 
            //    += new VCRButtonClickHandler(vcrUserControl1_OnNextButtonClick);
        } // twice gets loaded, this is called EVENT CALLSTACK

        private void vcrUserControl1_OnFirstButtonClick(object sender, VCRButtons button)
        {
            MessageBox.Show("First button got clicked");
        }

        private void vcrUserControl1_OnLastButtonClick(object sender, VCRButtons button)
        {
            MessageBox.Show("Last Button is clicked");
        }

        private void vcrUserControl1_OnNextButtonClick(object sender, VCRButtons button)
        {
            MessageBox.Show("Next Button is clicked");
        }

        private void vcrUserControl1_OnPreviousButtonClick(object sender, VCRButtons button)
        {
            MessageBox.Show("Previous Button is clicked");
        }
    }
}
