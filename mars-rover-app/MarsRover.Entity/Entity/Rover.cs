
using MarsRover.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover : IRover
    {
        public int x { get; set; }
        public int y { get; set; }
        public string direction { get; set; }
        public IPlateau Plateau { get; set; }
        public Rover(string location, IPlateau plateau)
        {
            Plateau = plateau;
            //remove space from location text such as "1 2 N"
            string[] splitLocationChars = location.Split(" ");

            if (x <= plateau.xUnit && y <= plateau.yUnit)
            {
                x = Int32.Parse(splitLocationChars[0]);
                y = Int32.Parse(splitLocationChars[1]);
                direction = splitLocationChars[2];
            }
        }
        public void TurnLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "W":
                    direction = "S";
                    break;
                case "S":
                    direction = "E";
                    break;
                default:
                    throw new ArgumentException(string.Format("Invalid value: {0}", direction));
            }
        }
        public void TurnRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "W":
                    direction = "N";
                    break;
                case "S":
                    direction = "W";
                    break;
                default:
                    throw new ArgumentException(string.Format("Invalid value: {0}", direction));
            }
        }
        public void GoForward()
        {
            switch (direction)
            {
                case "N":
                    y++;
                    break;
                case "E":
                    x++;
                    break;
                case "W":
                    x--;
                    break;
                case "S":
                    y--;
                    break;
                default:
                    throw new ArgumentException(string.Format("Invalid value: {0}", direction));
            }
        }
        public void Move(string command)
        {
            //characters in the command
            char[] commandChars = command.ToCharArray();
            //provided to move according to the characters in the command

            foreach (var commandChar in commandChars)
            {
                if (x >= 0 && y >= 0 && x <= Plateau.xUnit && y <= Plateau.yUnit)
                {
                    switch (commandChar)
                    {
                        case 'L':
                            TurnLeft();
                            break;
                        case 'R':
                            TurnRight();
                            break;
                        case 'M':
                            GoForward();
                            break;
                        default:
                            throw new ArgumentException(string.Format("Invalid value: {0}", commandChar));
                    }
                }
            }
        }

        public string Result()
        {
            return string.Format("{0} {1} {2}", x, y, direction);
        }
    }
}
