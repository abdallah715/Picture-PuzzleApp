using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePuzzleGame
{
    public partial class FrmPuzzleGame : Form
    {
        int inNullIndex , inMoves = 0;
        List<Bitmap>LstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch Timer = new System.Diagnostics.Stopwatch();
        

        public FrmPuzzleGame()
        {
            InitializeComponent();
            //Here
            cbSelectImage_SelectedIndexChanged(this, new EventArgs());
            //LstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources.Null });
            lblMovesmade.Text += inMoves;
            lblTimeElapsed.Text = "00:00:00";
          
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _Shuffle();
        }
        private void _Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random randomNum = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[randomNum.Next(0,Indexes.Count)]));
                    // means for example if gbx0 will randomly matches to the set of pictures 
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = LstOriginalPictureList[j];
                    //as 9 index for NULL
                    if (j == 9) inNullIndex = i;

                }
            }
            while (_CheckWin());
        }
        private void _AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", "Puzzle-Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (sender as Guna2Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Guna2Button == btnQuit && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Puzzle-Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                _Shuffle();
                Timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inMoves = 0;
                lblMovesmade.Text = "Steps Taken : 0";
                cbSelectImage.Enabled = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
           if (btnPause.Text == "Pause")
            {
                Timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";
                btnShuffle.Enabled = false;
            }
            else
            {
                Timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
                btnShuffle.Enabled = true;

            }
        }
        private void _UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (Timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = Timer.Elapsed.ToString().Remove(8);
            if (Timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
        }
        private void _SwitchPictureBox(object sender, EventArgs e)
        {
            if(lblTimeElapsed.Text =="00:00:00")
            {
                Timer.Start();
                cbSelectImage.Enabled = false;
            }
            // the current PictureBox Iam in 
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if(inNullIndex != inPictureBoxIndex)
            {
                // that's for defining the borders of the Current Picture Box fpr the selected Index
                List<int> FourBrothers = new List<int>
                    
                    (new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1),// Left neigbor
                    (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1,// Right Neigbor
                     inPictureBoxIndex - 3,// Top Neigbor
                    inPictureBoxIndex + 3});// Bottom Neigbor
                if(FourBrothers.Contains(inNullIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = LstOriginalPictureList[9];
                    inNullIndex = inPictureBoxIndex;
                    lblMovesmade.Text = "Steps Taken : " + (++inMoves);
                    if(_CheckWin())
                    {
                        Timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = LstOriginalPictureList[8];
                        MessageBox.Show("Congratulations...\nYour Bear Is Happy\nTime Elapsed : " + Timer.Elapsed.ToString().Remove(8) + "\nTotal Moves Made : " + inMoves, "Bear Puzzle");
                        inMoves = 0;
                        lblMovesmade.Text = "Steps Taken : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        Timer.Reset();
                        _Shuffle();

                    }

                }

            }


        }

        private void cbSelectImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the existing list before adding new images
            LstOriginalPictureList.Clear();

            if (cbSelectImage.SelectedItem.ToString() == "Dog")
            {
                LstOriginalPictureList.AddRange(new Bitmap[]
                {
            Properties.Resources.Dog1,
            Properties.Resources.Dog2,
            Properties.Resources.Dog3,
            Properties.Resources.Dog4,
            Properties.Resources.Dog5,
            Properties.Resources.Dog6,
            Properties.Resources.Dog7,
            Properties.Resources.Dog8,
            Properties.Resources.Dog9,
            Properties.Resources.Null
                });
                gbOriginalImage.BackgroundImage = Properties.Resources.Dog; // Original Image for reference
            }
            else if (cbSelectImage.SelectedItem.ToString() == "Carrot")
            {
                LstOriginalPictureList.AddRange(new Bitmap[]
                {
            Properties.Resources.Car1,
            Properties.Resources.Car2,
            Properties.Resources.Car3,
            Properties.Resources.Car4,
            Properties.Resources.Car5,
            Properties.Resources.Car6,
            Properties.Resources.Car7,
            Properties.Resources.Car8,
            Properties.Resources.Car9,
            Properties.Resources.Null
                });
                gbOriginalImage.BackgroundImage = Properties.Resources.Caroriginal;
            }
            else
            {
                // Default image set (Bear in your case)
                LstOriginalPictureList.AddRange(new Bitmap[]
                {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6,
            Properties.Resources._7,
            Properties.Resources._8,
            Properties.Resources._9,
            Properties.Resources.Null
                });
                gbOriginalImage.BackgroundImage = Properties.Resources.andrik_langfield_1Kp3z9pdEsw_unsplash; // Set this to your default image
            }

            // After changing the images, shuffle the new set to display in the puzzle
            _Shuffle();
        }

        private bool _CheckWin()
        {
            int i ;
            for(i = 0;i<8;i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != LstOriginalPictureList[i]) break;
            }
            if(i==8)return true;
            else return false;
        }
    }
}
