using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entity.Interface
{
    public interface IRover
    {
        public int x { get; set; }
        public int y { get; set; }
        public string direction { get; set; }
        void Move(string commands);
        string Result();
    }
}
