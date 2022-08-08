﻿using System;
namespace RollerDice.Models
{
    public class Die
    {
        public string Name { get; set; }
        public int NumberSides { get; set; }
        public int CurrentSide { get; set; }

        public Die()
        {
            Name = "d6";
            NumberSides = 6;
            Roll();
        }

        public Die(int numberSides)
        {
            Name = "d" + numberSides;
            NumberSides = numberSides;
            Roll();
        }

        public Die(string namePrefix, int numberSides)
        {
            Name = namePrefix + numberSides;
            NumberSides = numberSides;
            Roll();
        }

        public void Roll()
        {
            Random r = new Random();
            CurrentSide = r.Next(NumberSides) + 1;
        }

        public int CountRoll(int numberSides)
        {

            int ctr = 0;

            while (ctr >= 0)
            {
                ctr++;
                Roll();
                if (CurrentSide == numberSides)
                {
                    break;
                }
            }
            return ctr;

        }
    }
}

