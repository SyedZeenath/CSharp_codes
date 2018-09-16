using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_win_Events_UserControls
{
    //step 1: Define the delegate
     public delegate void VCRButtonClickHandler(object sender, VCRButtons button);
    public partial class VCRUserControl : UserControl
    {
        //step 2: register the events(whose return type is a delegate)
        public event VCRButtonClickHandler OnFirstButtonClick;
        public event VCRButtonClickHandler OnPreviousButtonClick;
        public event VCRButtonClickHandler OnNextButtonClick;
        public event VCRButtonClickHandler OnLastButtonClick;

        #region Properties
        public string TextOnFirst
        {
            get
            {
                return this.buttonFirst.Text;
            }
            set
            {
                this.buttonFirst.Text = value;
            }
        }
        public string TextOnPrevious
        {
            get
            {
                return this.buttonPrevious.Text;
            }
            set
            {
                this.buttonPrevious.Text = value;
            }
        }
        public string TextOnNext
        {
            get
            {
                return this.buttonNext.Text;
            }
            set
            {
                this.buttonNext.Text = value;
            }
        }
        public string TextOnLast
        {
            get
            {
                return this.buttonLast.Text;
            }
            set
            {
                this.buttonLast.Text = value;
            }
        }
        public string ToolTipOnFirst
        {
            get
            {
               return this.toolTip1.GetToolTip(this.buttonFirst);
                
            }
            set
            {
                this.toolTip1.SetToolTip(this.buttonFirst, value);
            }
        }

        public string ToolTipOnPrevious
        {
            get
            {
                return this.toolTip1.GetToolTip(this.buttonPrevious);

            }
            set
            {
                this.toolTip1.SetToolTip(this.buttonPrevious, value);
            }
        }

        public string ToolTipOnNext
        {
            get
            {
                return this.toolTip1.GetToolTip(this.buttonNext);

            }
            set
            {
                this.toolTip1.SetToolTip(this.buttonNext, value);
            }
        }

        public string ToolTipOnLast
        {
            get
            {
                return this.toolTip1.GetToolTip(this.buttonLast);

            }
            set
            {
                this.toolTip1.SetToolTip(this.buttonLast
, value);
            }
        }
        #endregion

        public VCRUserControl()
        {
            InitializeComponent();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            //step 3: check if event is subscribed
            if (this.OnFirstButtonClick != null)
            {
                //step 4: If subscribed raise the event notification
                this.OnFirstButtonClick(this, VCRButtons.First);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            //step 3: check if event is subscribed
            if (this.OnPreviousButtonClick != null)
            {
                //step 4: If subscribed raise the event notification
                this.OnPreviousButtonClick(this, VCRButtons.Previous);
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //step 3: check if event is subscribed
            if (this.OnNextButtonClick != null)
            {
                //step 4: If subscribed raise the event notification
                this.OnNextButtonClick(this, VCRButtons.Next);
            }

        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            //step 3: check if event is subscribed
            if (this.OnLastButtonClick != null)
            {
                //step 4: If subscribed raise the event notification
                this.OnLastButtonClick(this, VCRButtons.Last);
            }

        }
    }
}
