using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace RTS__Task_One_
{
    class Map
    {
        const int WIDTH = 20;

        const int HEIGHT = 20;

        //const int NUMUNITS = 3; Was used 
        //bool[,] isUnit = new bool[WIDTH, HEIGHT]; 
        string [,] map = new string [WIDTH,HEIGHT]; // 20 X 20 battlefield array
        MeleeUnit melee = new MeleeUnit();
        RangedUnit ranged = new RangedUnit();

        //MeleeUnit[] melee = new MeleeUnit [NUMUNITS]; //Array
        //RangedUnit[] ranged = new RangedUnit [NUMUNITS];

        Random random = new Random();
        Unit[] unit;

        public Map(int numUnits)
        {
            unit = new Unit[numUnits];
        }

        public void GenerateUnits()
        {
            for (int X = 0; X < HEIGHT; X++) //For the battlefield 
            {
                for (int Y = 0; Y < WIDTH; Y++)
                {
                    map[X, Y] = " . ";                 

                }
            }

            for (int i = 0; i < unit.Length; i++)
            {
                int temp = random.Next(0, 2);

                if (temp == 0)
                {
                    //MeleeUnit melee = new MeleeUnit(); // unit position i = new melee unit if variable = 0 
                    melee.XPOS = random.Next(0, 20);
                    melee.YPOS = random.Next(0, 20);                
                    
                    if (map[melee.XPOS, melee.YPOS] == " . ")
                    {
                        map[melee.XPOS, melee.YPOS] = " @ ";
                        unit[i] = melee;
                    }
                }
                
                else
                {
                    //RangedUnit rangedunit = new RangedUnit();
                    ranged.XPOS = random.Next(0, 20);
                    ranged.YPOS = random.Next(0, 20);
                    

                    if (map[ranged.XPOS, ranged.YPOS] == " . ")
                    {
                        map[ranged.XPOS, ranged.YPOS] = "  %  ";
                        unit[i] = ranged;
                    }
                }
            }
        }       
                 

        public void PrintMap(Label lbl) //Prints the battlefield into the label
        {
            lbl.Text = "";
            for (int X = 0; X < WIDTH; X++)
            {
                for (int Y = 0; Y < HEIGHT; Y++)
                {

                    lbl.Text = lbl.Text + map[X, Y];
                }
                lbl.Text += "\n";
            }
        }

        public void Information (RichTextBox txtBox) //TextBox to display the units information
        {
        
            for (int i = 0; i < 3; i++)
            {                
                txtBox.Text += melee.ToString();
                txtBox.Text += ranged.ToString();
            }             

        } 

        public void Update() // It's SUPPOSED to update and move units to another position
        {           
            for (int i = 0; i < unit.Length; i++)
            {
                unit[i].MovePosition();
            }

        }
    }
}
