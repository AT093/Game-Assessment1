using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiringGame_Project_One
{
    public partial class Form1 : Form
    {
        // intilization of vars 

        GamePlan gamePlan = new GamePlan();
        int lifes = 4,helpLifes=2;
        public Form1()
        {
            InitializeComponent();
        }

        // setting buttons working

        private void Form1_Load(object sender, EventArgs e)
        {
            gamePlan.genNo();
            //this code is to set the working of the buttons 
            gamePlan.setbtn(load_gun_btn);
            gamePlan.setbtn(spin_btn);
            gamePlan.setbtn(Fire_btn);
            gamePlan.setbtn(Fire_away_btn);
            gamePlan.setbtn(play_again_button);

        }

        // workings being defined on clicking buttons
        

        private void start_Game_btn_Click(object sender, EventArgs e)
        {
            gamePlan.setbtn(start_Game_btn);
            gamePlan.setbtn(load_gun_btn);
            //here we need to set the image which is required 
            image_box.Image = FiringGame_Project_One.Properties.Resources.start_fire;
        }

        // workings being defined on clicking buttons

        private void load_gun_btn_Click(object sender, EventArgs e)
        {
            gamePlan.setbtn(load_gun_btn);
            gamePlan.setbtn(spin_btn);
            image_box.Image = FiringGame_Project_One.Properties.Resources.gun_loading;
        }

        // workings being defined on clicking buttons

        private void spin_btn_Click(object sender, EventArgs e)
        {
            
            gamePlan.setbtn(spin_btn);
            gamePlan.setbtn(Fire_away_btn);
            gamePlan.setbtn(Fire_btn);
            image_box.Image = FiringGame_Project_One.Properties.Resources.gun_spin;
        }

        // fire away button working according to gameplan function

        private void Fire_away_btn_Click(object sender, EventArgs e)
        {
            if (helpLifes == gamePlan.show())
            {
                MessageBox.Show("Sorry you lose the game ");
            }
            else {
                if (helpLifes == 0)
                {
                    MessageBox.Show("you won the game");
                    gamePlan.setbtn(Fire_btn);
                    gamePlan.setbtn(Fire_away_btn);
                    gamePlan.setbtn(play_again_button);

                }

            }

            if (helpLifes>0) { 
                
                helpLifes--; 
            
            }
        }

        // workings being defined on clicking buttons

        private void play_again_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You want to play again ");
            Application.Restart(); 
        }

        // when click on fire button it genreates sound and according to random function it works

        private void Fire_btn_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sund = new System.Media.SoundPlayer(FiringGame_Project_One.Properties.Resources.Fire);
            sund.Play();
            if (lifes == gamePlan.display())
            {
                MessageBox.Show("Sorry you lose the game ");
                gamePlan.setbtn(Fire_btn);
                gamePlan.setbtn(play_again_button);
            }
            else {
                if (lifes == 0) {
                    MessageBox.Show("you won the game");
                    gamePlan.setbtn(Fire_btn);
                    gamePlan.setbtn(play_again_button);
                }
            }
            if (lifes>0) {
                lifes--;
            }

            
        }
    }
}
