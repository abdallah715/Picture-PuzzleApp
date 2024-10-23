using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MemeoryGame
{
    public partial class frmMainMemoryGame : Form
    {
        Random Random = new Random();
        List<Bitmap> Images = new List<Bitmap>();
        Guna2HtmlLabel FirstClicked, SecondClicked;
       
        public frmMainMemoryGame()
        {
            InitializeComponent();
            Images.AddRange(new Bitmap[]
            {
            Properties.Resources.bear, Properties.Resources.cartoon, Properties.Resources.cat,
            Properties.Resources.Caty, Properties.Resources.child, Properties.Resources.dog,
            Properties.Resources.frog, Properties.Resources.raccoon,
            Properties.Resources.bear, Properties.Resources.cartoon, Properties.Resources.cat,
            Properties.Resources.Caty, Properties.Resources.child, Properties.Resources.dog,
            Properties.Resources.frog, Properties.Resources.raccoon
            });
            
        }

        private void frmMainMemoryGame_Load(object sender, EventArgs e)
        {
            _Shuffle();
        }

        private void _Shuffle()
        {
            Guna2HtmlLabel PbSelected;
            List<int> Indexes = new List<int>(new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 });
            int RandomNumber;
            for(int i = 0;i<tableLayoutPanel1.Controls.Count;i++)
            {
                if (tableLayoutPanel1.Controls[i] is Guna2HtmlLabel)
                    PbSelected = (Guna2HtmlLabel)tableLayoutPanel1.Controls[i];
                else     
                    continue;
                Indexes.Remove((RandomNumber = Indexes[Random.Next(0, Indexes.Count)]));
                PbSelected.Tag  = RandomNumber;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
                FirstClicked.BackgroundImage = null;
                SecondClicked.BackgroundImage = null;
            
            FirstClicked = null; SecondClicked = null;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            
            if (FirstClicked != null && SecondClicked != null) return;
            Guna2HtmlLabel ClickedLabel = (Guna2HtmlLabel)sender;
            if (ClickedLabel == null) return;
            if (ClickedLabel.BackgroundImage != null) return;
            
            if(FirstClicked == null && ClickedLabel.BackgroundImage == null)
            {
                FirstClicked = ClickedLabel;
                FirstClicked.BackgroundImage = Images[(int)FirstClicked.Tag];
                return;
            }

                SecondClicked = ClickedLabel;
                SecondClicked.BackgroundImage = Images[(int)ClickedLabel.Tag];
           if(Math.Abs((int)FirstClicked.Tag - (int)SecondClicked.Tag)== Images.Count()/2)
            {
                FirstClicked = null;
                SecondClicked = null;
            }
            else 
            timer1.Start();
            _CheckWinning();
        }

        private void _CheckWinning()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {

                if (tableLayoutPanel1.Controls[i].BackgroundImage as Image == null)
                {
                    return;
                }
            }
            MessageBox.Show("Winner Winner Chicken Dinner", "Memory Game");
        }
    }
}

    


