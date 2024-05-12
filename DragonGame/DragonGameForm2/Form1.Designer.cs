namespace DragonGameForm2
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
            this.gpbPlayerTurn = new System.Windows.Forms.GroupBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSpecialAttack = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerHp = new System.Windows.Forms.Label();
            this.gpbOpponent = new System.Windows.Forms.GroupBox();
            this.lblOpponentHp = new System.Windows.Forms.Label();
            this.lblDragonName = new System.Windows.Forms.Label();
            this.gpbBattleLog = new System.Windows.Forms.GroupBox();
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.gpbPlayerTurn.SuspendLayout();
            this.gpbOpponent.SuspendLayout();
            this.gpbBattleLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPlayerTurn
            // 
            this.gpbPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.gpbPlayerTurn.Controls.Add(this.btnBlock);
            this.gpbPlayerTurn.Controls.Add(this.btnSpecialAttack);
            this.gpbPlayerTurn.Controls.Add(this.btnAttack);
            this.gpbPlayerTurn.Controls.Add(this.lblPlayerHp);
            this.gpbPlayerTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbPlayerTurn.Location = new System.Drawing.Point(93, 21);
            this.gpbPlayerTurn.Name = "gpbPlayerTurn";
            this.gpbPlayerTurn.Size = new System.Drawing.Size(243, 254);
            this.gpbPlayerTurn.TabIndex = 0;
            this.gpbPlayerTurn.TabStop = false;
            this.gpbPlayerTurn.Text = "X, the X Dragon\'s Turn";
            // 
            // btnBlock
            // 
            this.btnBlock.ForeColor = System.Drawing.Color.Black;
            this.btnBlock.Location = new System.Drawing.Point(18, 203);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(203, 35);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSpecialAttack
            // 
            this.btnSpecialAttack.ForeColor = System.Drawing.Color.Black;
            this.btnSpecialAttack.Location = new System.Drawing.Point(22, 144);
            this.btnSpecialAttack.Name = "btnSpecialAttack";
            this.btnSpecialAttack.Size = new System.Drawing.Size(203, 41);
            this.btnSpecialAttack.TabIndex = 2;
            this.btnSpecialAttack.Text = "Special Attack";
            this.btnSpecialAttack.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAttack.Location = new System.Drawing.Point(18, 82);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(207, 45);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // lblPlayerHp
            // 
            this.lblPlayerHp.AutoSize = true;
            this.lblPlayerHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHp.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHp.Location = new System.Drawing.Point(84, 45);
            this.lblPlayerHp.Name = "lblPlayerHp";
            this.lblPlayerHp.Size = new System.Drawing.Size(64, 25);
            this.lblPlayerHp.TabIndex = 0;
            this.lblPlayerHp.Text = "HP: X";
            // 
            // gpbOpponent
            // 
            this.gpbOpponent.BackColor = System.Drawing.Color.Transparent;
            this.gpbOpponent.Controls.Add(this.lblOpponentHp);
            this.gpbOpponent.Controls.Add(this.lblDragonName);
            this.gpbOpponent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbOpponent.Location = new System.Drawing.Point(698, 21);
            this.gpbOpponent.Name = "gpbOpponent";
            this.gpbOpponent.Size = new System.Drawing.Size(250, 149);
            this.gpbOpponent.TabIndex = 1;
            this.gpbOpponent.TabStop = false;
            this.gpbOpponent.Text = "Opponent X";
            // 
            // lblOpponentHp
            // 
            this.lblOpponentHp.AutoSize = true;
            this.lblOpponentHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentHp.Location = new System.Drawing.Point(66, 105);
            this.lblOpponentHp.Name = "lblOpponentHp";
            this.lblOpponentHp.Size = new System.Drawing.Size(92, 32);
            this.lblOpponentHp.TabIndex = 1;
            this.lblOpponentHp.Text = "HP: X";
            // 
            // lblDragonName
            // 
            this.lblDragonName.AutoSize = true;
            this.lblDragonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragonName.Location = new System.Drawing.Point(46, 45);
            this.lblDragonName.Name = "lblDragonName";
            this.lblDragonName.Size = new System.Drawing.Size(166, 25);
            this.lblDragonName.TabIndex = 0;
            this.lblDragonName.Text = "X, the X Dragon";
            // 
            // gpbBattleLog
            // 
            this.gpbBattleLog.BackColor = System.Drawing.Color.Transparent;
            this.gpbBattleLog.Controls.Add(this.rtbBattleLog);
            this.gpbBattleLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbBattleLog.Location = new System.Drawing.Point(163, 432);
            this.gpbBattleLog.Name = "gpbBattleLog";
            this.gpbBattleLog.Size = new System.Drawing.Size(710, 165);
            this.gpbBattleLog.TabIndex = 2;
            this.gpbBattleLog.TabStop = false;
            this.gpbBattleLog.Text = "Battle Log";
            // 
            // rtbBattleLog
            // 
            this.rtbBattleLog.Location = new System.Drawing.Point(0, 21);
            this.rtbBattleLog.Name = "rtbBattleLog";
            this.rtbBattleLog.Size = new System.Drawing.Size(679, 129);
            this.rtbBattleLog.TabIndex = 0;
            this.rtbBattleLog.Text = "";
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(512, 377);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(140, 49);
            this.btnRest.TabIndex = 3;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DragonGameForm2.Properties.Resources.il_794xN_2652345332_otub;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 635);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.gpbBattleLog);
            this.Controls.Add(this.gpbOpponent);
            this.Controls.Add(this.gpbPlayerTurn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbPlayerTurn.ResumeLayout(false);
            this.gpbPlayerTurn.PerformLayout();
            this.gpbOpponent.ResumeLayout(false);
            this.gpbOpponent.PerformLayout();
            this.gpbBattleLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPlayerTurn;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSpecialAttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblPlayerHp;
        private System.Windows.Forms.GroupBox gpbOpponent;
        private System.Windows.Forms.Label lblOpponentHp;
        private System.Windows.Forms.Label lblDragonName;
        private System.Windows.Forms.GroupBox gpbBattleLog;
        private System.Windows.Forms.RichTextBox rtbBattleLog;
        private System.Windows.Forms.Button btnRest;
    }
}

