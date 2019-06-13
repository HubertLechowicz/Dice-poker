using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class DicePanel : UserControl, IDicePanel
    {
        #region Properties
        public PictureBox Dice
        {
            get
            {
                return pictureBox1;
            }
            set
            {
                pictureBox1 = value;
            }
        }
        #endregion
        #region Events
        public event Action<PictureBox> DiceClicked;
        #endregion
        public DicePanel()
        {
            InitializeComponent();
        }
        private void pictureBoxDice_Click(object sender, EventArgs e)
        {
            DiceClicked?.Invoke(Dice);
        }
    }
}
