using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealTimeStrategyGame
{
    public partial class Form1 : Form   //Creates the form 
    {
        GameEngine engine;
        Timer timer;
        Game gameState = Game.PAUSED;

        public enum Game //Will help determine if a game is running/paused/ended
        {
            RUNNING, PAUSED, ENDED
        }
        public Form1()
        {
            InitializeComponent();

            engine = new GameEngine();

            mapLabel.Text = engine.MapDisplay();  //Shows the map
            unitInfoTxtBox.Text = engine.UnitInfo(); //Displays the unit info to the textbox
            lblRound.Text = "Round: " + engine.Round; //Displays the round number to the textbox
            
            timer = new Timer();
            timer.Interval = 1000; // 1000  = 1 Second
            timer.Tick += TimerTick;
        }

        public void TimerTick(object sender,EventArgs e)
        {
            engine.GameLoop(); //Runs through 1 loop of the game every second
            UpdateUI();

            if (engine.IsGameOver) //Checks if the game is over
            {
                timer.Stop(); //Timer will stop if gameover is true
                mapLabel.Text = engine.WinningTeam + " WON! \n" + mapLabel.Text;
                gameState = Game.ENDED;
                startPauseButton.Text = "Restart";
            }
        }

        public void UpdateUI() //Updates the display 
        {
            mapLabel.Text = engine.MapDisplay();
            unitInfoTxtBox.Text = engine.UnitInfo();
            lblRound.Text = "Round: " + engine.Round;
        }

        private void startPauseButton_Click(object sender, EventArgs e) 
        {
            if (gameState == Game.RUNNING) //Checks and defines the game states
            {
                timer.Stop();
                gameState = Game.PAUSED;
                startPauseButton.Text = "Start";
            }
            else
            {
                if (gameState == Game.ENDED)
                {
                    engine.Reset();
                }

                timer.Start();
                gameState = Game.RUNNING;
                startPauseButton.Text = "Pause";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
