using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTS__Task_One_
{
    public partial class Form1 : Form
    {
        //Map map = new Map(3); //Wíll create 3 beginnning units that will be displayed on the field once start is pressed
        GameEngine gengine = new GameEngine();

        public Form1()
        {
            InitializeComponent();
            /*mapLabel.Visible = false;
            roundLabel.Visible = false;
            roundTextLabel.Visible = false;*/
            gengine.GameLogic(mapLabel);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            mapLabel.Visible = true;

            //roundLabel.Visible = true;
            //roundTextLabel.Visible = true;

            //map.GenerateUnits();            

            //map.PrintMap(mapLabel);

            //map.Information(informationTextBox);
            //map.Update();
        }

        private void mapLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
