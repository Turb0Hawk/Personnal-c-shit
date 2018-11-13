using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendOfTheFiveRingsCounter
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
        }

        bool triggered(int strife, int maxStrife)
        {
            bool triggered;
            if (strife == maxStrife)
            {
                lblTrongerd.Enabled = true;
                triggered = true;
            } else
            {
                lblTrongerd.Enabled = false;
                triggered = false;
            }
            return triggered;
        }

        private void btnPlusStrife_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStrife.Text, out int strife);
            int.TryParse(txtMaxStrife.Text, out int maxStrife);
            strife = (strife == null) ? 0 : strife;
            if(!triggered((strife+1), maxStrife))
            {
                ++strife;
                txtStrife.Text = strife.ToString();
            }  else 
            {
               if(strife+1 <= maxStrife)
                {
                    ++strife;
                    triggered(strife, maxStrife);
                    txtStrife.Text = strife.ToString();
                } 
               
            }
        }

        private void btnRemStrife_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStrife.Text, out int strife);
            int.TryParse(txtMaxStrife.Text, out int maxStrife);
            strife = (strife == null) ? 0 : strife;
            if (!triggered((strife + 1), maxStrife))
            {
                --strife;
                txtStrife.Text = strife.ToString();
            }
            else
            {
                if (strife + 1 <= maxStrife)
                {
                    --strife;
                    triggered(strife, maxStrife);
                    txtStrife.Text = strife.ToString();
                }

            }
        }
    }
}
