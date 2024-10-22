using System.Runtime.CompilerServices;

namespace PicturePuzzleGame
{
    partial class FrmPuzzleGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuzzleGame));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbOriginalImage = new System.Windows.Forms.GroupBox();
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.lblMovesmade = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.btnShuffle = new Guna.UI2.WinForms.Guna2Button();
            this.btnPause = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.cbSelectImage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOriginalImage
            // 
            this.gbOriginalImage.BackgroundImage = global::PicturePuzzleGame.Properties.Resources.andrik_langfield_1Kp3z9pdEsw_unsplash;
            this.gbOriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginalImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOriginalImage.ForeColor = System.Drawing.Color.White;
            this.gbOriginalImage.Location = new System.Drawing.Point(713, 138);
            this.gbOriginalImage.Name = "gbOriginalImage";
            this.gbOriginalImage.Size = new System.Drawing.Size(462, 314);
            this.gbOriginalImage.TabIndex = 0;
            this.gbOriginalImage.TabStop = false;
            this.gbOriginalImage.Text = "Original Image";
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx5);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPuzzleBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbPuzzleBox.Location = new System.Drawing.Point(30, 121);
            this.gbPuzzleBox.Margin = new System.Windows.Forms.Padding(4);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Padding = new System.Windows.Forms.Padding(4);
            this.gbPuzzleBox.Size = new System.Drawing.Size(569, 533);
            this.gbPuzzleBox.TabIndex = 1;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "Puzzle Board";
            // 
            // pbx1
            // 
            this.pbx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx1.Location = new System.Drawing.Point(23, 28);
            this.pbx1.Margin = new System.Windows.Forms.Padding(4);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(173, 160);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx2.Location = new System.Drawing.Point(199, 28);
            this.pbx2.Margin = new System.Windows.Forms.Padding(4);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(173, 160);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx3.Location = new System.Drawing.Point(375, 28);
            this.pbx3.Margin = new System.Windows.Forms.Padding(4);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(173, 160);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx4.Location = new System.Drawing.Point(23, 191);
            this.pbx4.Margin = new System.Windows.Forms.Padding(4);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(173, 160);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx5.Location = new System.Drawing.Point(199, 191);
            this.pbx5.Margin = new System.Windows.Forms.Padding(4);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(173, 160);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx6.Location = new System.Drawing.Point(375, 191);
            this.pbx6.Margin = new System.Windows.Forms.Padding(4);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(173, 160);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx7.Location = new System.Drawing.Point(23, 353);
            this.pbx7.Margin = new System.Windows.Forms.Padding(4);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(173, 160);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx8.Location = new System.Drawing.Point(199, 353);
            this.pbx8.Margin = new System.Windows.Forms.Padding(4);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(173, 160);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // pbx9
            // 
            this.pbx9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx9.Location = new System.Drawing.Point(375, 353);
            this.pbx9.Margin = new System.Windows.Forms.Padding(4);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(173, 160);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this._SwitchPictureBox);
            // 
            // lblMovesmade
            // 
            this.lblMovesmade.AutoSize = true;
            this.lblMovesmade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesmade.Location = new System.Drawing.Point(25, 678);
            this.lblMovesmade.Name = "lblMovesmade";
            this.lblMovesmade.Size = new System.Drawing.Size(201, 32);
            this.lblMovesmade.TabIndex = 2;
            this.lblMovesmade.Text = "Steps Taken :";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(771, 455);
            this.lblTimeElapsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(332, 98);
            this.lblTimeElapsed.TabIndex = 4;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShuffle.CheckedState.Parent = this.btnShuffle;
            this.btnShuffle.CustomImages.Parent = this.btnShuffle;
            this.btnShuffle.FillColor = System.Drawing.Color.White;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.Black;
            this.btnShuffle.HoverState.Parent = this.btnShuffle;
            this.btnShuffle.Location = new System.Drawing.Point(682, 577);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.ShadowDecoration.Parent = this.btnShuffle;
            this.btnShuffle.Size = new System.Drawing.Size(132, 45);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPause.CheckedState.Parent = this.btnPause;
            this.btnPause.CustomImages.Parent = this.btnPause;
            this.btnPause.FillColor = System.Drawing.Color.White;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.HoverState.Parent = this.btnPause;
            this.btnPause.Location = new System.Drawing.Point(874, 577);
            this.btnPause.Name = "btnPause";
            this.btnPause.ShadowDecoration.Parent = this.btnPause;
            this.btnPause.Size = new System.Drawing.Size(132, 45);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.CheckedState.Parent = this.btnQuit;
            this.btnQuit.CustomImages.Parent = this.btnQuit;
            this.btnQuit.FillColor = System.Drawing.Color.White;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.HoverState.Parent = this.btnQuit;
            this.btnQuit.Location = new System.Drawing.Point(1061, 577);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.ShadowDecoration.Parent = this.btnQuit;
            this.btnQuit.Size = new System.Drawing.Size(132, 45);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this._UpdateTimeElapsed);
            // 
            // cbSelectImage
            // 
            this.cbSelectImage.BackColor = System.Drawing.Color.Transparent;
            this.cbSelectImage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelectImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectImage.FocusedColor = System.Drawing.Color.Empty;
            this.cbSelectImage.FocusedState.Parent = this.cbSelectImage;
            this.cbSelectImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSelectImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSelectImage.FormattingEnabled = true;
            this.cbSelectImage.HoverState.Parent = this.cbSelectImage;
            this.cbSelectImage.ItemHeight = 30;
            this.cbSelectImage.Items.AddRange(new object[] {
            "Bear",
            "Carrot",
            "Dog"});
            this.cbSelectImage.ItemsAppearance.Parent = this.cbSelectImage;
            this.cbSelectImage.Location = new System.Drawing.Point(457, 56);
            this.cbSelectImage.Name = "cbSelectImage";
            this.cbSelectImage.ShadowDecoration.Parent = this.cbSelectImage;
            this.cbSelectImage.Size = new System.Drawing.Size(291, 36);
            this.cbSelectImage.StartIndex = 0;
            this.cbSelectImage.TabIndex = 8;
            this.cbSelectImage.SelectedIndexChanged += new System.EventHandler(this.cbSelectImage_SelectedIndexChanged);
            // 
            // FrmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 735);
            this.Controls.Add(this.cbSelectImage);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblMovesmade);
            this.Controls.Add(this.gbPuzzleBox);
            this.Controls.Add(this.gbOriginalImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                 Puzzle-Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOriginalImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.Label lblMovesmade;
        private System.Windows.Forms.Label lblTimeElapsed;
        private Guna.UI2.WinForms.Guna2Button btnShuffle;
        private Guna.UI2.WinForms.Guna2Button btnPause;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private Guna.UI2.WinForms.Guna2ComboBox cbSelectImage;
    }
}

