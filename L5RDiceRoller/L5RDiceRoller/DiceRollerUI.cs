using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5RDiceRoller
{
    public partial class DiceRollerUI : Form
    {
        public DiceRollerUI()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
                int.TryParse(txtRing.Text, out int nbDeeRing);
                int.TryParse(txtSkill.Text, out int nbDeeSkill);
                txtResultat.Text += ("Pour " + nbDeeRing + " dés de ring et " + nbDeeSkill + " dés de skill:\n");
                for (int countDeeRing = 0; countDeeRing < nbDeeRing; ++countDeeRing)
                {
                    txtResultat.Text += "\n" + new Dee(6).ToString();
                }
                for (int countDeeSkill = 0; countDeeSkill < nbDeeSkill; ++countDeeSkill)
                {
                    txtResultat.Text += "\n" + new Dee(12).ToString();
                }
        }
    }
}
