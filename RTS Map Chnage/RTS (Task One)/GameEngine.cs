using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTS__Task_One_
{
    class GameEngine
    {
        //Timer timer = new Timer(); //Timer for the game engine
        Map map = new Map(10);
        //int rounds;
        Random random = new Random();    

        public void GameLogic(Label label)
        {
            map.GenerateUnits();
            map.PrintMap(label);
        }

        public void RoundLogic(Label label)
        {
            map.Update();
            map.PrintMap(label);
        }



    }
}
