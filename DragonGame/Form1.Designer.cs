namespace DragonGame
{
    partial class Form1
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
            this.gpbPlayerOne = new System.Windows.Forms.GroupBox();
            this.btnSaveOne = new System.Windows.Forms.Button();
            this.gpbDragonTypeOne = new System.Windows.Forms.GroupBox();
            this.radEarthDragonOne = new System.Windows.Forms.RadioButton();
            this.radWindDragonOne = new System.Windows.Forms.RadioButton();
            this.radIceDragonOne = new System.Windows.Forms.RadioButton();
            this.radFireDragonOne = new System.Windows.Forms.RadioButton();
            this.txtDragonNameOne = new System.Windows.Forms.TextBox();
            this.lblDragonNameOne = new System.Windows.Forms.Label();
            this.txtPlayerNameOne = new System.Windows.Forms.TextBox();
            this.lblPlayerNameOne = new System.Windows.Forms.Label();
            this.gpbPlayerTwo = new System.Windows.Forms.GroupBox();
            this.btnSaveTwo = new System.Windows.Forms.Button();
            this.gpbDragonTypeTwo = new System.Windows.Forms.GroupBox();
            this.radEarthDragonTwo = new System.Windows.Forms.RadioButton();
            this.radWindDragonTwo = new System.Windows.Forms.RadioButton();
            this.radIceDragonTwo = new System.Windows.Forms.RadioButton();
            this.radFireDragonTwo = new System.Windows.Forms.RadioButton();
            this.txtDragonNameTwo = new System.Windows.Forms.TextBox();
            this.lblDragonNameTwo = new System.Windows.Forms.Label();
            this.txtPlayerNameTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDragonStats = new System.Windows.Forms.GroupBox();
            this.lblEarthDragon = new System.Windows.Forms.Label();
            this.lblWindDragon = new System.Windows.Forms.Label();
            this.lblIceDragon = new System.Windows.Forms.Label();
            this.lblFireDragon = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.gpbPlayerOne.SuspendLayout();
            this.gpbDragonTypeOne.SuspendLayout();
            this.gpbPlayerTwo.SuspendLayout();
            this.gpbDragonTypeTwo.SuspendLayout();
            this.gpbDragonStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPlayerOne
            // 
            this.gpbPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.gpbPlayerOne.Controls.Add(this.btnSaveOne);
            this.gpbPlayerOne.Controls.Add(this.gpbDragonTypeOne);
            this.gpbPlayerOne.Controls.Add(this.txtDragonNameOne);
            this.gpbPlayerOne.Controls.Add(this.lblDragonNameOne);
            this.gpbPlayerOne.Controls.Add(this.txtPlayerNameOne);
            this.gpbPlayerOne.Controls.Add(this.lblPlayerNameOne);
            this.gpbPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPlayerOne.ForeColor = System.Drawing.Color.White;
            this.gpbPlayerOne.Location = new System.Drawing.Point(32, 64);
            this.gpbPlayerOne.Name = "gpbPlayerOne";
            this.gpbPlayerOne.Size = new System.Drawing.Size(308, 436);
            this.gpbPlayerOne.TabIndex = 0;
            this.gpbPlayerOne.TabStop = false;
            this.gpbPlayerOne.Text = "Player 1";
            // 
            // btnSaveOne
            // 
            this.btnSaveOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveOne.ForeColor = System.Drawing.Color.Black;
            this.btnSaveOne.Location = new System.Drawing.Point(16, 366);
            this.btnSaveOne.Name = "btnSaveOne";
            this.btnSaveOne.Size = new System.Drawing.Size(271, 48);
            this.btnSaveOne.TabIndex = 5;
            this.btnSaveOne.Text = "SAVE!!!!";
            this.btnSaveOne.UseVisualStyleBackColor = true;
            this.btnSaveOne.Click += new System.EventHandler(this.btnSaveOne_Click);
            // 
            // gpbDragonTypeOne
            // 
            this.gpbDragonTypeOne.Controls.Add(this.radEarthDragonOne);
            this.gpbDragonTypeOne.Controls.Add(this.radWindDragonOne);
            this.gpbDragonTypeOne.Controls.Add(this.radIceDragonOne);
            this.gpbDragonTypeOne.Controls.Add(this.radFireDragonOne);
            this.gpbDragonTypeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDragonTypeOne.Location = new System.Drawing.Point(22, 195);
            this.gpbDragonTypeOne.Name = "gpbDragonTypeOne";
            this.gpbDragonTypeOne.Size = new System.Drawing.Size(250, 148);
            this.gpbDragonTypeOne.TabIndex = 4;
            this.gpbDragonTypeOne.TabStop = false;
            this.gpbDragonTypeOne.Text = "Dragon Type :";
            // 
            // radEarthDragonOne
            // 
            this.radEarthDragonOne.AutoSize = true;
            this.radEarthDragonOne.Location = new System.Drawing.Point(6, 118);
            this.radEarthDragonOne.Name = "radEarthDragonOne";
            this.radEarthDragonOne.Size = new System.Drawing.Size(142, 24);
            this.radEarthDragonOne.TabIndex = 3;
            this.radEarthDragonOne.TabStop = true;
            this.radEarthDragonOne.Text = "Earth Dragon";
            this.radEarthDragonOne.UseVisualStyleBackColor = true;
            // 
            // radWindDragonOne
            // 
            this.radWindDragonOne.AutoSize = true;
            this.radWindDragonOne.Location = new System.Drawing.Point(6, 88);
            this.radWindDragonOne.Name = "radWindDragonOne";
            this.radWindDragonOne.Size = new System.Drawing.Size(139, 24);
            this.radWindDragonOne.TabIndex = 2;
            this.radWindDragonOne.TabStop = true;
            this.radWindDragonOne.Text = "Wind Dragon";
            this.radWindDragonOne.UseVisualStyleBackColor = true;
            // 
            // radIceDragonOne
            // 
            this.radIceDragonOne.AutoSize = true;
            this.radIceDragonOne.Location = new System.Drawing.Point(6, 56);
            this.radIceDragonOne.Name = "radIceDragonOne";
            this.radIceDragonOne.Size = new System.Drawing.Size(122, 24);
            this.radIceDragonOne.TabIndex = 1;
            this.radIceDragonOne.TabStop = true;
            this.radIceDragonOne.Text = "Ice Dragon";
            this.radIceDragonOne.UseVisualStyleBackColor = true;
            // 
            // radFireDragonOne
            // 
            this.radFireDragonOne.AutoSize = true;
            this.radFireDragonOne.Location = new System.Drawing.Point(6, 26);
            this.radFireDragonOne.Name = "radFireDragonOne";
            this.radFireDragonOne.Size = new System.Drawing.Size(130, 24);
            this.radFireDragonOne.TabIndex = 0;
            this.radFireDragonOne.TabStop = true;
            this.radFireDragonOne.Text = "Fire Dragon";
            this.radFireDragonOne.UseVisualStyleBackColor = true;
            // 
            // txtDragonNameOne
            // 
            this.txtDragonNameOne.Location = new System.Drawing.Point(19, 145);
            this.txtDragonNameOne.Name = "txtDragonNameOne";
            this.txtDragonNameOne.Size = new System.Drawing.Size(269, 30);
            this.txtDragonNameOne.TabIndex = 3;
            // 
            // lblDragonNameOne
            // 
            this.lblDragonNameOne.AutoSize = true;
            this.lblDragonNameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragonNameOne.Location = new System.Drawing.Point(19, 124);
            this.lblDragonNameOne.Name = "lblDragonNameOne";
            this.lblDragonNameOne.Size = new System.Drawing.Size(117, 18);
            this.lblDragonNameOne.TabIndex = 2;
            this.lblDragonNameOne.Text = "Dragon Name:";
            this.lblDragonNameOne.Click += new System.EventHandler(this.lblDragonNameOne_Click);
            // 
            // txtPlayerNameOne
            // 
            this.txtPlayerNameOne.Location = new System.Drawing.Point(19, 68);
            this.txtPlayerNameOne.Name = "txtPlayerNameOne";
            this.txtPlayerNameOne.Size = new System.Drawing.Size(273, 30);
            this.txtPlayerNameOne.TabIndex = 1;
            // 
            // lblPlayerNameOne
            // 
            this.lblPlayerNameOne.AutoSize = true;
            this.lblPlayerNameOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameOne.Location = new System.Drawing.Point(16, 47);
            this.lblPlayerNameOne.Name = "lblPlayerNameOne";
            this.lblPlayerNameOne.Size = new System.Drawing.Size(109, 18);
            this.lblPlayerNameOne.TabIndex = 0;
            this.lblPlayerNameOne.Text = "Player Name:";
            // 
            // gpbPlayerTwo
            // 
            this.gpbPlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.gpbPlayerTwo.Controls.Add(this.btnSaveTwo);
            this.gpbPlayerTwo.Controls.Add(this.gpbDragonTypeTwo);
            this.gpbPlayerTwo.Controls.Add(this.txtDragonNameTwo);
            this.gpbPlayerTwo.Controls.Add(this.lblDragonNameTwo);
            this.gpbPlayerTwo.Controls.Add(this.txtPlayerNameTwo);
            this.gpbPlayerTwo.Controls.Add(this.label1);
            this.gpbPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPlayerTwo.ForeColor = System.Drawing.Color.White;
            this.gpbPlayerTwo.Location = new System.Drawing.Point(465, 63);
            this.gpbPlayerTwo.Name = "gpbPlayerTwo";
            this.gpbPlayerTwo.Size = new System.Drawing.Size(333, 437);
            this.gpbPlayerTwo.TabIndex = 1;
            this.gpbPlayerTwo.TabStop = false;
            this.gpbPlayerTwo.Text = "Player 2";
            // 
            // btnSaveTwo
            // 
            this.btnSaveTwo.ForeColor = System.Drawing.Color.Black;
            this.btnSaveTwo.Location = new System.Drawing.Point(21, 370);
            this.btnSaveTwo.Name = "btnSaveTwo";
            this.btnSaveTwo.Size = new System.Drawing.Size(284, 46);
            this.btnSaveTwo.TabIndex = 5;
            this.btnSaveTwo.Text = "SAVE!!!!";
            this.btnSaveTwo.UseVisualStyleBackColor = true;
            this.btnSaveTwo.Click += new System.EventHandler(this.btnSaveTwo_Click);
            // 
            // gpbDragonTypeTwo
            // 
            this.gpbDragonTypeTwo.Controls.Add(this.radEarthDragonTwo);
            this.gpbDragonTypeTwo.Controls.Add(this.radWindDragonTwo);
            this.gpbDragonTypeTwo.Controls.Add(this.radIceDragonTwo);
            this.gpbDragonTypeTwo.Controls.Add(this.radFireDragonTwo);
            this.gpbDragonTypeTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDragonTypeTwo.Location = new System.Drawing.Point(24, 197);
            this.gpbDragonTypeTwo.Name = "gpbDragonTypeTwo";
            this.gpbDragonTypeTwo.Size = new System.Drawing.Size(284, 148);
            this.gpbDragonTypeTwo.TabIndex = 4;
            this.gpbDragonTypeTwo.TabStop = false;
            this.gpbDragonTypeTwo.Text = "Dragon Type";
            // 
            // radEarthDragonTwo
            // 
            this.radEarthDragonTwo.AutoSize = true;
            this.radEarthDragonTwo.Location = new System.Drawing.Point(6, 118);
            this.radEarthDragonTwo.Name = "radEarthDragonTwo";
            this.radEarthDragonTwo.Size = new System.Drawing.Size(142, 24);
            this.radEarthDragonTwo.TabIndex = 3;
            this.radEarthDragonTwo.TabStop = true;
            this.radEarthDragonTwo.Text = "Earth Dragon";
            this.radEarthDragonTwo.UseVisualStyleBackColor = true;
            // 
            // radWindDragonTwo
            // 
            this.radWindDragonTwo.AutoSize = true;
            this.radWindDragonTwo.Location = new System.Drawing.Point(6, 88);
            this.radWindDragonTwo.Name = "radWindDragonTwo";
            this.radWindDragonTwo.Size = new System.Drawing.Size(139, 24);
            this.radWindDragonTwo.TabIndex = 2;
            this.radWindDragonTwo.TabStop = true;
            this.radWindDragonTwo.Text = "Wind Dragon";
            this.radWindDragonTwo.UseVisualStyleBackColor = true;
            // 
            // radIceDragonTwo
            // 
            this.radIceDragonTwo.AutoSize = true;
            this.radIceDragonTwo.Location = new System.Drawing.Point(6, 56);
            this.radIceDragonTwo.Name = "radIceDragonTwo";
            this.radIceDragonTwo.Size = new System.Drawing.Size(122, 24);
            this.radIceDragonTwo.TabIndex = 1;
            this.radIceDragonTwo.TabStop = true;
            this.radIceDragonTwo.Text = "Ice Dragon";
            this.radIceDragonTwo.UseVisualStyleBackColor = true;
            // 
            // radFireDragonTwo
            // 
            this.radFireDragonTwo.AutoSize = true;
            this.radFireDragonTwo.Location = new System.Drawing.Point(6, 26);
            this.radFireDragonTwo.Name = "radFireDragonTwo";
            this.radFireDragonTwo.Size = new System.Drawing.Size(130, 24);
            this.radFireDragonTwo.TabIndex = 0;
            this.radFireDragonTwo.TabStop = true;
            this.radFireDragonTwo.Text = "Fire Dragon";
            this.radFireDragonTwo.UseVisualStyleBackColor = true;
            // 
            // txtDragonNameTwo
            // 
            this.txtDragonNameTwo.Location = new System.Drawing.Point(17, 147);
            this.txtDragonNameTwo.Name = "txtDragonNameTwo";
            this.txtDragonNameTwo.Size = new System.Drawing.Size(285, 30);
            this.txtDragonNameTwo.TabIndex = 3;
            // 
            // lblDragonNameTwo
            // 
            this.lblDragonNameTwo.AutoSize = true;
            this.lblDragonNameTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragonNameTwo.Location = new System.Drawing.Point(21, 126);
            this.lblDragonNameTwo.Name = "lblDragonNameTwo";
            this.lblDragonNameTwo.Size = new System.Drawing.Size(117, 18);
            this.lblDragonNameTwo.TabIndex = 2;
            this.lblDragonNameTwo.Text = "Dragon Name:";
            // 
            // txtPlayerNameTwo
            // 
            this.txtPlayerNameTwo.Location = new System.Drawing.Point(17, 70);
            this.txtPlayerNameTwo.Name = "txtPlayerNameTwo";
            this.txtPlayerNameTwo.Size = new System.Drawing.Size(288, 30);
            this.txtPlayerNameTwo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            // 
            // gpbDragonStats
            // 
            this.gpbDragonStats.BackColor = System.Drawing.Color.Transparent;
            this.gpbDragonStats.Controls.Add(this.lblEarthDragon);
            this.gpbDragonStats.Controls.Add(this.lblWindDragon);
            this.gpbDragonStats.Controls.Add(this.lblIceDragon);
            this.gpbDragonStats.Controls.Add(this.lblFireDragon);
            this.gpbDragonStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDragonStats.ForeColor = System.Drawing.Color.White;
            this.gpbDragonStats.Location = new System.Drawing.Point(32, 572);
            this.gpbDragonStats.Name = "gpbDragonStats";
            this.gpbDragonStats.Size = new System.Drawing.Size(851, 129);
            this.gpbDragonStats.TabIndex = 2;
            this.gpbDragonStats.TabStop = false;
            this.gpbDragonStats.Text = "Dragon Stats:";
            // 
            // lblEarthDragon
            // 
            this.lblEarthDragon.AutoSize = true;
            this.lblEarthDragon.Location = new System.Drawing.Point(651, 36);
            this.lblEarthDragon.Name = "lblEarthDragon";
            this.lblEarthDragon.Size = new System.Drawing.Size(196, 90);
            this.lblEarthDragon.TabIndex = 3;
            this.lblEarthDragon.Text = "Earth Dragon\r\n50 HP\r\n2 Attack Damage\r\n5 Special Attack Damage\r\n6 Block Damage";
            // 
            // lblWindDragon
            // 
            this.lblWindDragon.AutoSize = true;
            this.lblWindDragon.Location = new System.Drawing.Point(439, 36);
            this.lblWindDragon.Name = "lblWindDragon";
            this.lblWindDragon.Size = new System.Drawing.Size(196, 90);
            this.lblWindDragon.TabIndex = 2;
            this.lblWindDragon.Text = "Wind Dragon\r\n40 HP\r\n3 Attack Damage\r\n7 Special Attack Damage\r\n5 Block Damage";
            // 
            // lblIceDragon
            // 
            this.lblIceDragon.AutoSize = true;
            this.lblIceDragon.Location = new System.Drawing.Point(237, 36);
            this.lblIceDragon.Name = "lblIceDragon";
            this.lblIceDragon.Size = new System.Drawing.Size(196, 90);
            this.lblIceDragon.TabIndex = 1;
            this.lblIceDragon.Text = "Ice Dragon\r\n30 HP\r\n4 Attack Damage\r\n9 Special Attack Damage\r\n5 Block Damage";
            // 
            // lblFireDragon
            // 
            this.lblFireDragon.AutoSize = true;
            this.lblFireDragon.Location = new System.Drawing.Point(13, 36);
            this.lblFireDragon.Name = "lblFireDragon";
            this.lblFireDragon.Size = new System.Drawing.Size(205, 90);
            this.lblFireDragon.TabIndex = 0;
            this.lblFireDragon.Text = "Fire Dragon\r\n20 HP\r\n5 Attack Damage\r\n12 Special Attack Damage\r\n4 Block Damage";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Black;
            this.btnStartGame.Location = new System.Drawing.Point(37, 510);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(804, 48);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DragonGame.Properties.Resources.Screenshot__65_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 755);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.gpbDragonStats);
            this.Controls.Add(this.gpbPlayerTwo);
            this.Controls.Add(this.gpbPlayerOne);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Battle of the dragons";
            this.gpbPlayerOne.ResumeLayout(false);
            this.gpbPlayerOne.PerformLayout();
            this.gpbDragonTypeOne.ResumeLayout(false);
            this.gpbDragonTypeOne.PerformLayout();
            this.gpbPlayerTwo.ResumeLayout(false);
            this.gpbPlayerTwo.PerformLayout();
            this.gpbDragonTypeTwo.ResumeLayout(false);
            this.gpbDragonTypeTwo.PerformLayout();
            this.gpbDragonStats.ResumeLayout(false);
            this.gpbDragonStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerNameOne;
        private System.Windows.Forms.Label lblPlayerNameOne;
        private System.Windows.Forms.TextBox txtDragonNameOne;
        private System.Windows.Forms.Label lblDragonNameOne;
        private System.Windows.Forms.GroupBox gpbDragonTypeOne;
        private System.Windows.Forms.Button btnSaveOne;
        private System.Windows.Forms.RadioButton radEarthDragonOne;
        private System.Windows.Forms.RadioButton radWindDragonOne;
        private System.Windows.Forms.RadioButton radIceDragonOne;
        private System.Windows.Forms.RadioButton radFireDragonOne;
        private System.Windows.Forms.GroupBox gpbPlayerTwo;
        private System.Windows.Forms.TextBox txtPlayerNameTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDragonNameTwo;
        private System.Windows.Forms.Label lblDragonNameTwo;
        private System.Windows.Forms.GroupBox gpbDragonTypeTwo;
        private System.Windows.Forms.RadioButton radEarthDragonTwo;
        private System.Windows.Forms.RadioButton radWindDragonTwo;
        private System.Windows.Forms.RadioButton radIceDragonTwo;
        private System.Windows.Forms.RadioButton radFireDragonTwo;
        private System.Windows.Forms.Button btnSaveTwo;
        private System.Windows.Forms.GroupBox gpbDragonStats;
        private System.Windows.Forms.Label lblIceDragon;
        private System.Windows.Forms.Label lblFireDragon;
        private System.Windows.Forms.Label lblEarthDragon;
        private System.Windows.Forms.Label lblWindDragon;
        private System.Windows.Forms.Button btnStartGame;
    }
}

