using MarsRover.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Plateau: IPlateau
    {
        public int xUnit { get; set; }
        public int yUnit { get; set; }
        public Plateau(string input)
        {
            //remove space from location text such as "1 2 N"
            string[] splitInputChars = input.Split(" ");
         
                xUnit = Int32.Parse(splitInputChars[0]);
                yUnit = Int32.Parse(splitInputChars[1]);
            
        }
    }
}
