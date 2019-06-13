using Poker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form,IView
    {
        #region properties
        public Engine Game { get; set; }

        public TableLayoutPanel Table
        {
            get
            {
                return tableScore;
            }
            set
            {
                tableScore = value;
            }
        }

        public int ScoreLabel
        {
            get
            {
                return int.Parse(labelPointsSum.Text);
            }
            set
            {
                labelPointsSum.Text = value.ToString();
            }
        }

        public IDicePanel DiceFirst
        {
            get
            {
                return dicePanel1;
            }
        }
        public IDicePanel DiceSecond
        {
            get
            {
                return dicePanel2;
            }
        }
        public IDicePanel DiceThird
        {
            get
            {
                return dicePanel5;
            }
        }
        public IDicePanel DiceFourth
        {
            get
            {
                return dicePanel3;
            }
        }
        public IDicePanel DiceFifth
        {
            get
            {
                return dicePanel4;
            }
        }

        public PictureBox RollButton
        {
            get
            {
                return pictureBoxRoll;
            }
            set
            {
                pictureBoxRoll = value;
            }
        }
        public PictureBox PassButton
        {
            get
            {
                return pictureBoxPass;
            }
            set
            {
                pictureBoxPass = value;
            }
        }

        public List<PictureBox> Dices
        {
            get
            {
                return new List<PictureBox>
                {
                    DiceFirst.Dice,
                    DiceSecond.Dice,
                    DiceThird.Dice,
                    DiceFourth.Dice,
                    DiceFifth.Dice,
                };
            }
            set
            {
                DiceFirst.Dice = value[0];
                DiceSecond.Dice = value[1];
                DiceThird.Dice = value[2];
                DiceFourth.Dice = value[3];
                DiceFifth.Dice = value[4];

            }
        }
        public List<PictureBox> Buttons
        {
            get
            {
                return new List<PictureBox>
                {
                    RollButton,
                    PassButton
                };
            }
            set
            {
                RollButton = value[0];
                PassButton = value[1];
            }
        }
        public List<Bitmap> DiceResources { get; set; }
        public List<Bitmap> DiceOpacityResources { get; set; }

        #endregion
        public Form1()
        {
            InitializeComponent();

            List<Bitmap> diceResources = new List<Bitmap>
            {
                Resources.diceEmpty,
                Resources.dice_1,
                Resources.dice_2,
                Resources.dice_3,
                Resources.dice_4,
                Resources.dice_5,
                Resources.dice_6,
                
                Resources.DiceRoll,
                Resources.DicePass
            };
            DiceResources = diceResources;
            List<Bitmap> diceOpacityResources = new List<Bitmap>
            {
                Resources.diceOpacity,
                Resources._1Opacity,
                Resources._2Opacity,
                Resources._3Opacity,               
                Resources._4Opacity,
                Resources._5Opacity,
                Resources._6Opacity,
                Resources.PassRollOpacity,
                Resources.PassRollOpacity
            };
            DiceOpacityResources = diceOpacityResources;
        }
        #region Events
        public event Action FormLoaded;
        public event Action RollButtonClicked;
        public event Action PassButtonClicked;
        #endregion

        #region Methods
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RollButtonClicked?.Invoke();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke();
        }

        private void pictureBoxPass_Click(object sender, EventArgs e)
        {
            PassButtonClicked?.Invoke();
        }
        public void Exit()
        {
            Close();
        }
        #endregion

        private void tableScore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPointsAces_Click(object sender, EventArgs e)
        {

        }
    }


}
