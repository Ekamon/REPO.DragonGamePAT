using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonGameForm2
{
    public partial class frmTwo : Form
        
    {   public static frmTwo Instance;
        Boolean blockFlag;
        public frmTwo()
        {
            InitializeComponent();
            frmTwo.Instance = this;

           
            
            
            //Setting form 2's arrays to form 1's arrays
            string p1Names = player1Names;
            string p2Names = player2Names;
            int p1Stats = player1Stats;
            int p2Stats = player2Stats;

            p1Names = p1Names[0];
            p2Names = p2Names[0];

            d1Name = p1Names[1];
            d2Name = p2Names[1];

            p1Types = p1Names[2];
            p2Types = p2Names[2];

            d1Health = p1Stats[0];
            d2Health = p2Stats[0];

            d1Attack = p1Stats[1];
            d2Attack = p2Stats[1];

            d1Special = p1Stats[2];
            d2Special = p2Stats[2];

            d1Block = p1Stats[3];
            d2Block = p2Stats[3];


        }

       public static void randomRoll(string[] args)
        {
            Random random = new Random();

            int player1Roll = random.Next(1,7);
            int player2Roll = random.Next(1,7);
            //double num = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);


            Console.ReadLine();
        } 

        public static void takeInitiative(string[] args)
        {
            if (player1Roll > player2Roll)
            {
                Console.WriteLine(p1Names + "'s" + " " + "takes initiative");
            }
            else if (player2Roll > player1Roll)
            {
                Console.WriteLine(p2Names + "'s" + " " + "takes initiative");
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (blockFlag = true && names[2] = )
            {
                p1Stats
            }
        }
    }
}
