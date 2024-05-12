using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Constants for dragon types
       static void dragonConstants(string[] args) 
        {
            //Constants for Fire Dragon
            const string FIRE_DRAG_NAME = "Fire Dragon";
            const int FIRE_DRAG_HP = 20;
            const int FIRE_DRAG_ATK = 5;
            const int FIRE_DRAG_SPATK = 12;
            const int FIRE_DRAG_BLOCK = 4;

            //Constants for Ice Dragon
            const string ICE_DRAG_NAME = "Ice Dragon";
            const int ICE_DRAG_HP = 30;
            const int ICE_DRAG_ATK = 4;
            const int ICE_DRAG_SPATK = 9;
            const int ICE_DRAG_BLOCK = 5;

            //Constants for Wind Dragon
            const string WIND_DRAG_NAME = "Wind Dragon";
            const int WIND_DRAG_HP = 40;
            const int WIND_DRAG_ATK = 3;
            const int WIND_DRAG_SPATK = 7;
            const int WIND_DRAG_BLOCK = 5;

            //Constants for Earth Dragon
            const string EARTH_DRAG_NAME = "Earth Dragon";
            const int EARTH_DRAG_HP = 50;
            const int EARTH_DRAG_ATK = 2;
            const int EARTH_DRAG_SPATK = 5;
            const int EARTH_DRAG_BLOCK = 6;

        }

        private void lblDragonNameOne_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveOne_Click(object sender, EventArgs e)
        {
          
            {
                //example : String cars = {"BMW", "Mustang", "Corvette"}
                String[] P1data = {txtPlayerNameOne.Text, txtDragonNameOne.Text
                , gpbDragoneTypeOne.Text};
                int[] P1values = { dragonConstants };

        }
            Console.ReadLine();
        }
    }
}
