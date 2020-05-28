using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    /// <summary>
    /// Essentially represents one unit in a the CGOL. It is simply a cell, that can either be alive, or not.
    /// </summary>
    class Cell
    {
        public float height { get; set; } // Height of the cell
        public float width { get; set; } // Width of the cell
        public float coordinateX { get; set; } // Location where the cell needs to be start being drawn on X-axis
        public float coordinateY { get; set; } // Location where the cell needs to be start being drawn on Y-axis
        public bool state { get; set; } // State of the cell - either on or off (true or false)
        public int activeNeighbours { get; set; } // Amount of active neighbours that the cell has

        public List<List<int>> neighboursPosition = new List<List<int>>(); // Location of assumed closest neighbours (always 8)

    }
}
