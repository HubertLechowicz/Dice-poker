using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public interface IDicePanel
    {
        #region Properties
        PictureBox Dice { get; set; }
        #endregion

        #region Events
        event Action<PictureBox> DiceClicked;
        #endregion
    }
}
