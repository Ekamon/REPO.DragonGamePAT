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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlayerNameOne = new System.Windows.Forms.Label();
            this.txtPlayerNameOne = new System.Windows.Forms.TextBox();
            this.lblDragonNameOne = new System.Windows.Forms.Label();
            this.txtDragonNameOne = new System.Windows.Forms.TextBox();
            this.gpbDragoneTypeOne = new System.Windows.Forms.GroupBox();
            this.radFireDragonOne = new System.Windows.Forms.RadioButton();
            this.radIceDragonOne = new System.Windows.Forms.RadioButton();
            this.radWindDragonOne = new System.Windows.Forms.RadioButton();
            this.radEarthDragonOne = new System.Windows.Forms.RadioButton();
            this.btnSaveOne = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerNameTwo = new System.Windows.Forms.TextBox();
            this.lblDragonNameTwo = new System.Windows.Forms.Label();
            this.txtDragonNameTwo = new System.Windows.Forms.TextBox();
            this.gpbDragonTypeTwo = new System.Windows.Forms.GroupBox();
            this.radFireDragonTwo = new System.Windows.Forms.RadioButton();
            this.radIceDragonTwo = new System.Windows.Forms.RadioButton();
            this.radWindDragonTwo = new System.Windows.Forms.RadioButton();
            this.radEarthDragonTwo = new System.Windows.Forms.RadioButton();
            this.btnSaveTwo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFireDragon = new System.Windows.Forms.Label();
            this.lblIceDragon = new System.Windows.Forms.Label();
            this.lblWindDragon = new System.Windows.Forms.Label();
            this.lblEarthDragon = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbDragoneTypeOne.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbDragonTypeTwo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSaveOne);
            this.groupBox1.Controls.Add(this.gpbDragoneTypeOne);
            this.groupBox1.Controls.Add(this.txtDragonNameOne);
            this.groupBox1.Controls.Add(this.lblDragonNameOne);
            this.groupBox1.Controls.Add(this.txtPlayerNameOne);
            this.groupBox1.Controls.Add(this.lblPlayerNameOne);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
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
            // txtPlayerNameOne
            // 
            this.txtPlayerNameOne.Location = new System.Drawing.Point(19, 68);
            this.txtPlayerNameOne.Name = "txtPlayerNameOne";
            this.txtPlayerNameOne.Size = new System.Drawing.Size(273, 30);
            this.txtPlayerNameOne.TabIndex = 1;
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
            // txtDragonNameOne
            // 
            this.txtDragonNameOne.Location = new System.Drawing.Point(19, 145);
            this.txtDragonNameOne.Name = "txtDragonNameOne";
            this.txtDragonNameOne.Size = new System.Drawing.Size(269, 30);
            this.txtDragonNameOne.TabIndex = 3;
            // 
            // gpbDragoneTypeOne
            // 
            this.gpbDragoneTypeOne.Controls.Add(this.radEarthDragonOne);
            this.gpbDragoneTypeOne.Controls.Add(this.radWindDragonOne);
            this.gpbDragoneTypeOne.Controls.Add(this.radIceDragonOne);
            this.gpbDragoneTypeOne.Controls.Add(this.radFireDragonOne);
            this.gpbDragoneTypeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDragoneTypeOne.Location = new System.Drawing.Point(22, 195);
            this.gpbDragoneTypeOne.Name = "gpbDragoneTypeOne";
            this.gpbDragoneTypeOne.Size = new System.Drawing.Size(250, 148);
            this.gpbDragoneTypeOne.TabIndex = 4;
            this.gpbDragoneTypeOne.TabStop = false;
            this.gpbDragoneTypeOne.Text = "Dragon Type :";
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
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnSaveTwo);
            this.groupBox3.Controls.Add(this.gpbDragonTypeTwo);
            this.groupBox3.Controls.Add(this.txtDragonNameTwo);
            this.groupBox3.Controls.Add(this.lblDragonNameTwo);
            this.groupBox3.Controls.Add(this.txtPlayerNameTwo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(465, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 437);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player 2";
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
            // txtPlayerNameTwo
            // 
            this.txtPlayerNameTwo.Location = new System.Drawing.Point(17, 70);
            this.txtPlayerNameTwo.Name = "txtPlayerNameTwo";
            this.txtPlayerNameTwo.Size = new System.Drawing.Size(288, 30);
            this.txtPlayerNameTwo.TabIndex = 1;
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
            // txtDragonNameTwo
            // 
            this.txtDragonNameTwo.Location = new System.Drawing.Point(17, 147);
            this.txtDragonNameTwo.Name = "txtDragonNameTwo";
            this.txtDragonNameTwo.Size = new System.Drawing.Size(285, 30);
            this.txtDragonNameTwo.TabIndex = 3;
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
            this.gpbDragonTypeTwo.Text = "groupBox2";
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
            // btnSaveTwo
            // 
            this.btnSaveTwo.ForeColor = System.Drawing.Color.Black;
            this.btnSaveTwo.Location = new System.Drawing.Point(21, 370);
            this.btnSaveTwo.Name = "btnSaveTwo";
            this.btnSaveTwo.Size = new System.Drawing.Size(284, 46);
            this.btnSaveTwo.TabIndex = 5;
            this.btnSaveTwo.Text = "SAVE!!!!";
            this.btnSaveTwo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblEarthDragon);
            this.groupBox2.Controls.Add(this.lblWindDragon);
            this.groupBox2.Controls.Add(this.lblIceDragon);
            this.groupBox2.Controls.Add(this.lblFireDragon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(32, 572);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dragon Stats:";
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
            // lblIceDragon
            // 
            this.lblIceDragon.AutoSize = true;
            this.lblIceDragon.Location = new System.Drawing.Point(237, 36);
            this.lblIceDragon.Name = "lblIceDragon";
            this.lblIceDragon.Size = new System.Drawing.Size(196, 90);
            this.lblIceDragon.TabIndex = 1;
            this.lblIceDragon.Text = "Ice Dragon\r\n30 HP\r\n4 Attack Damage\r\n9 Special Attack Damage\r\n5 Block Damage";
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
            // lblEarthDragon
            // 
            this.lblEarthDragon.AutoSize = true;
            this.lblEarthDragon.Location = new System.Drawing.Point(651, 36);
            this.lblEarthDragon.Name = "lblEarthDragon";
            this.lblEarthDragon.Size = new System.Drawing.Size(196, 90);
            this.lblEarthDragon.TabIndex = 3;
            this.lblEarthDragon.Text = "Earth Dragon\r\n50 HP\r\n2 Attack Damage\r\n5 Special Attack Damage\r\n6 Block Damage";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DragonGame.Properties.Resources.Screenshot__65_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 755);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Battle of the dragons";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbDragoneTypeOne.ResumeLayout(false);
            this.gpbDragoneTypeOne.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpbDragonTypeTwo.ResumeLayout(false);
            this.gpbDragonTypeTwo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlayerNameOne;
        private System.Windows.Forms.Label lblPlayerNameOne;
        private System.Windows.Forms.TextBox txtDragonNameOne;
        private System.Windows.Forms.Label lblDragonNameOne;
        private System.Windows.Forms.GroupBox gpbDragoneTypeOne;
        private System.Windows.Forms.Button btnSaveOne;
        private System.Windows.Forms.RadioButton radEarthDragonOne;
        private System.Windows.Forms.RadioButton radWindDragonOne;
        private System.Windows.Forms.RadioButton radIceDragonOne;
        private System.Windows.Forms.RadioButton radFireDragonOne;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIceDragon;
        private System.Windows.Forms.Label lblFireDragon;
        private System.Windows.Forms.Label lblEarthDragon;
        private System.Windows.Forms.Label lblWindDragon;
        private System.Windows.Forms.Button btnStartGame;
    }
}

