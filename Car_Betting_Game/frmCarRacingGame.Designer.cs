namespace Car_Betting_Game
{
    partial class frmCarRacingGame
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
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.car4 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.btnRace = new MetroFramework.Controls.MetroButton();
            this.Reset = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.numBets = new System.Windows.Forms.NumericUpDown();
            this.btnBets = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.numCar = new System.Windows.Forms.NumericUpDown();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.lblBets = new MetroFramework.Controls.MetroLabel();
            this.lblJoe = new MetroFramework.Controls.MetroLabel();
            this.lblAI = new MetroFramework.Controls.MetroLabel();
            this.lblBob = new MetroFramework.Controls.MetroLabel();
            this.racetrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // timer6
            // 
            this.timer6.Interval = 25;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick_1);
            // 
            // car4
            // 
            this.car4.BackColor = System.Drawing.Color.Transparent;
            this.car4.BackgroundImage = global::Car_Betting_Game.Properties.Resources.carh_4;
            this.car4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car4.Location = new System.Drawing.Point(17, 356);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(93, 43);
            this.car4.TabIndex = 27;
            this.car4.TabStop = false;
            // 
            // car3
            // 
            this.car3.BackColor = System.Drawing.Color.Transparent;
            this.car3.BackgroundImage = global::Car_Betting_Game.Properties.Resources.carh_3;
            this.car3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car3.Location = new System.Drawing.Point(17, 308);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(93, 40);
            this.car3.TabIndex = 26;
            this.car3.TabStop = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.BackgroundImage = global::Car_Betting_Game.Properties.Resources.carh_2;
            this.car2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car2.Location = new System.Drawing.Point(17, 260);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(93, 37);
            this.car2.TabIndex = 25;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.BackgroundImage = global::Car_Betting_Game.Properties.Resources.carh_1;
            this.car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car1.Location = new System.Drawing.Point(17, 211);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(93, 39);
            this.car1.TabIndex = 24;
            this.car1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.BackgroundImage = global::Car_Betting_Game.Properties.Resources._base;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.metroRadioButton3);
            this.groupBox1.Controls.Add(this.numBets);
            this.groupBox1.Controls.Add(this.btnBets);
            this.groupBox1.Controls.Add(this.metroRadioButton1);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.numCar);
            this.groupBox1.Controls.Add(this.metroRadioButton2);
            this.groupBox1.Controls.Add(this.lblBets);
            this.groupBox1.Controls.Add(this.lblJoe);
            this.groupBox1.Controls.Add(this.lblAI);
            this.groupBox1.Controls.Add(this.lblBob);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 157);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maximum Bet";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.CausesValidation = false;
            this.btnExit.Location = new System.Drawing.Point(523, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 31);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseCustomForeColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_2);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblName.Location = new System.Drawing.Point(594, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 19);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name :";
            this.lblName.UseCustomBackColor = true;
            this.lblName.UseCustomForeColor = true;
            this.lblName.UseStyleColors = true;
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.Teal;
            this.btnRace.Location = new System.Drawing.Point(792, 110);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(113, 32);
            this.btnRace.TabIndex = 20;
            this.btnRace.Text = "Start Race!!";
            this.btnRace.UseCustomBackColor = true;
            this.btnRace.UseCustomForeColor = true;
            this.btnRace.UseSelectable = true;
            this.btnRace.UseStyleColors = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.RoyalBlue;
            this.Reset.Location = new System.Drawing.Point(658, 111);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(113, 32);
            this.Reset.TabIndex = 21;
            this.Reset.Text = "Reset";
            this.Reset.UseCustomBackColor = true;
            this.Reset.UseCustomForeColor = true;
            this.Reset.UseSelectable = true;
            this.Reset.UseStyleColors = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton3.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton3.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroRadioButton3.Location = new System.Drawing.Point(18, 87);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(39, 19);
            this.metroRadioButton3.TabIndex = 11;
            this.metroRadioButton3.Text = "AI";
            this.metroRadioButton3.UseCustomBackColor = true;
            this.metroRadioButton3.UseCustomForeColor = true;
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.UseStyleColors = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged_1);
            // 
            // numBets
            // 
            this.numBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBets.Location = new System.Drawing.Point(785, 61);
            this.numBets.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBets.Name = "numBets";
            this.numBets.Size = new System.Drawing.Size(120, 22);
            this.numBets.TabIndex = 29;
            // 
            // btnBets
            // 
            this.btnBets.BackColor = System.Drawing.Color.Crimson;
            this.btnBets.Location = new System.Drawing.Point(658, 57);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(113, 31);
            this.btnBets.TabIndex = 31;
            this.btnBets.Text = "Apply Bet";
            this.btnBets.UseCustomBackColor = true;
            this.btnBets.UseCustomForeColor = true;
            this.btnBets.UseSelectable = true;
            this.btnBets.UseStyleColors = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click_1);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroRadioButton1.ForeColor = System.Drawing.Color.White;
            this.metroRadioButton1.Location = new System.Drawing.Point(18, 36);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(48, 19);
            this.metroRadioButton1.TabIndex = 10;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Joe";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroRadioButton1.UseCustomBackColor = true;
            this.metroRadioButton1.UseCustomForeColor = true;
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.UseStyleColors = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(650, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Bets On Car No. :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // numCar
            // 
            this.numCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCar.Location = new System.Drawing.Point(785, 20);
            this.numCar.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCar.Name = "numCar";
            this.numCar.Size = new System.Drawing.Size(120, 22);
            this.numCar.TabIndex = 28;
            this.numCar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroRadioButton2.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroRadioButton2.Location = new System.Drawing.Point(18, 62);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(52, 19);
            this.metroRadioButton2.TabIndex = 10;
            this.metroRadioButton2.Text = "Bob";
            this.metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroRadioButton2.UseCustomBackColor = true;
            this.metroRadioButton2.UseCustomForeColor = true;
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.UseStyleColors = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged_1);
            // 
            // lblBets
            // 
            this.lblBets.AutoSize = true;
            this.lblBets.BackColor = System.Drawing.Color.Transparent;
            this.lblBets.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBets.Location = new System.Drawing.Point(247, 26);
            this.lblBets.Name = "lblBets";
            this.lblBets.Size = new System.Drawing.Size(45, 19);
            this.lblBets.TabIndex = 24;
            this.lblBets.Text = "Bets :";
            this.lblBets.UseCustomBackColor = true;
            this.lblBets.UseCustomForeColor = true;
            this.lblBets.UseStyleColors = true;
            // 
            // lblJoe
            // 
            this.lblJoe.AutoSize = true;
            this.lblJoe.BackColor = System.Drawing.Color.Transparent;
            this.lblJoe.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblJoe.Location = new System.Drawing.Point(247, 53);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(54, 19);
            this.lblJoe.TabIndex = 25;
            this.lblJoe.Text = "label 1";
            this.lblJoe.UseCustomBackColor = true;
            this.lblJoe.UseCustomForeColor = true;
            this.lblJoe.UseStyleColors = true;
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.BackColor = System.Drawing.Color.Transparent;
            this.lblAI.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAI.Location = new System.Drawing.Point(247, 110);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(54, 19);
            this.lblAI.TabIndex = 27;
            this.lblAI.Text = "label 3";
            this.lblAI.UseCustomBackColor = true;
            this.lblAI.UseCustomForeColor = true;
            this.lblAI.UseStyleColors = true;
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.BackColor = System.Drawing.Color.Transparent;
            this.lblBob.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBob.Location = new System.Drawing.Point(247, 82);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(54, 19);
            this.lblBob.TabIndex = 26;
            this.lblBob.Text = "label 2";
            this.lblBob.UseCustomBackColor = true;
            this.lblBob.UseCustomForeColor = true;
            this.lblBob.UseStyleColors = true;
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.Color.Transparent;
            this.racetrack.BackgroundImage = global::Car_Betting_Game.Properties.Resources.track_path;
            this.racetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.racetrack.Location = new System.Drawing.Point(-1, -3);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(920, 559);
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // frmCarRacingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 554);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.racetrack);
            this.Name = "frmCarRacingGame";
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroButton btnBets;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown numBets;
        private System.Windows.Forms.NumericUpDown numCar;
        private MetroFramework.Controls.MetroLabel lblAI;
        private MetroFramework.Controls.MetroLabel lblBob;
        private MetroFramework.Controls.MetroLabel lblJoe;
        private MetroFramework.Controls.MetroLabel lblBets;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroButton Reset;
        private MetroFramework.Controls.MetroButton btnRace;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car4;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}