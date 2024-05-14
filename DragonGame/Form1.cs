using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonGame
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

            string[] player1Names = new string[3];
            string[] player2Names = new string[3];
            int[] player1stats = new int[4];
            int[] player2stats = new int[4];

            //Constants for dragon types


            //Constants for Fire Dragon
            const string FIRE_TYPE = "Fire Dragon";
            const int FIRE_DRAG_HP = 20;
            const int FIRE_DRAG_ATK = 5;
            const int FIRE_DRAG_SPATK = 12;
            const int FIRE_DRAG_BLOCK = 4;

            //Constants for Ice Dragon
            const string ICE_TYPE = "Ice Dragon";
            const int ICE_DRAG_HP = 30;
            const int ICE_DRAG_ATK = 4;
            const int ICE_DRAG_SPATK = 9;
            const int ICE_DRAG_BLOCK = 5;

            //Constants for Wind Dragon
            const string WIND_TYPE = "Wind Dragon";
            const int WIND_DRAG_HP = 40;
            const int WIND_DRAG_ATK = 3;
            const int WIND_DRAG_SPATK = 7;
            const int WIND_DRAG_BLOCK = 5;

            //Constants for Earth Dragon
            const string EARTH_TYPE = "Earth Dragon";
            const int EARTH_DRAG_HP = 50;
            const int EARTH_DRAG_ATK = 2;
            const int EARTH_DRAG_SPATK = 5;
            const int EARTH_DRAG_BLOCK = 6;
        


        private void lblDragonNameOne_Click(object sender, EventArgs e)
        {

        }

        //taking parameter arrays
        private void radFireDragonOne_CheckedChanged(object sender, EventArgs e)
        {
            player1Names[2] = FIRE_TYPE;
        }

        private void radIceDragonOne_CheckedChanged(object sender, EventArgs e)
        {
            player1Names[2] = ICE_TYPE;
        }

        private void radWindDragonOne_CheckedChanged(object sender, EventArgs e)
        {
            player1Names[2] = WIND_TYPE;
        }
        private void radEarthDragonOne_CheckedChanged(object sender, EventArgs e)
        {
            player1Names[2] = EARTH_TYPE;
        }

        private void radFireDragonTwo_CheckedChanged(object sender, EventArgs e)
        {
            player2Names[2] = FIRE_TYPE;
        }

        private void radEarthDragonTwo_CheckedChanged(object sender, EventArgs e)
        {
            player2Names[2] = EARTH_TYPE;
        }

        private void radWindDragonTwo_CheckedChanged(object sender, EventArgs e)
        {
            player1Names[2] = WIND_TYPE;
        }

        private void radIceDragonTwo_CheckedChanged(object sender, EventArgs e)
        {
            player1Names[2] = ICE_TYPE;
        }


        private void btnSaveOne_Click(object sender, EventArgs e)
        {

            SaveValues(player1stats, player1Names, 1);
        }

        private void btnSaveTwo_Click(object sender, EventArgs e)
        {

            SaveValues(player2stats, player2Names, 2);
        }

        void SaveValues(int[] stats, string[] names, int player) // Player 1
        {
            if (player == 1) //Player 1
            {
                names[0] = txtPlayerNameOne.Text;
                names[1] = txtDragonNameOne.Text;
            }
            else // has to be Player 2
            {
                names[0] = txtPlayerNameTwo.Text;
                names[1] = txtDragonNameTwo.Text;
            }

            if (names[2] == FIRE_TYPE) // if fire type dragon
            {
                stats[0] = FIRE_DRAG_HP;
                stats[1] = FIRE_DRAG_ATK;
                stats[2] = FIRE_DRAG_SPATK;
                stats[3] = FIRE_DRAG_BLOCK;
            }
            else if (names[2] == ICE_TYPE)
            {
                stats[0] = ICE_DRAG_HP;
                stats[1] = ICE_DRAG_ATK;
                stats[2] = ICE_DRAG_SPATK;
                stats[3] = ICE_DRAG_BLOCK;
            }
            else if (names[2] == WIND_TYPE)
            {
                stats[0] = WIND_DRAG_HP;
                stats[1] = WIND_DRAG_ATK;
                stats[2] = WIND_DRAG_SPATK;
                stats[3] = WIND_DRAG_BLOCK;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e) // start game button
        {
           
            frm2 frm2 = new frm2();
            this.Hide();
            frm2.Show;
           
          


            if (btnSaveTwo.Enabled == false)
            {
                btnStartGame.Enabled = true;
                btnSaveOne.Enabled = false;
            }
            else if (btnSaveOne.Enabled == false)
            {
                btnStartGame.Enabled = true;
                btnSaveTwo.Enabled = false;

            }
        }
    }
}




   

