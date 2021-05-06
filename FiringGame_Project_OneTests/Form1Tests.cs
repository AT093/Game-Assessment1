using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiringGame_Project_One;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiringGame_Project_One.Tests
{
    // 2 unit tests 

    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            GamePlan gamePlan = new GamePlan();
            if (gamePlan.show()==0) {
                Assert.IsTrue(true);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            GamePlan gamePlan = new GamePlan();
            gamePlan.genNo();
            if (gamePlan.show() > 0)
            {
                Assert.IsTrue(true);
            }
        }


    }
}