using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiringGame_Project_One
{
   public class GamePlan
    {
        // random function giving tiggers

        Random obj_rand = new Random();
        public int deadTrigger = 0;
        public int Trigger = 0;
        public void genNo() {
            deadTrigger = obj_rand.Next(1, 5);
            Trigger = obj_rand.Next(1, 3);
        }

        public int display() {
          
            return deadTrigger;
        }
        public int show()
        {
            System.Media.SoundPlayer sund = new System.Media.SoundPlayer(FiringGame_Project_One.Properties.Resources.Fire);
            sund.Play();
            return Trigger;
        }


        public void setbtn(Button btn)
        {
            if (btn.Enabled == true)
            {
                btn.Enabled = false;
            }
            else {
                btn.Enabled = true;
            }

        }

    }
}
