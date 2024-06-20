using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    public class Dice
    {
        public int NumLados { get; set; }

        public int NumSort { get; set; }


        public void RolarDado()
        {
            NumSort = new Random().Next(NumLados) + 1;
        }

        public Dice(int num)
        {
            NumLados = num;
        }
    }
}
