using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    /// <summary>
    /// This class allows for creation of a Field in which the GOL would take place.
    /// </summary>

    class Field
    {
        public int x { get; set; } = 20; // Where the field starts on the X axis
        public int y { get; set; } = 150; // Where the field starts on the Y axis
        public float width { get; set; } = 500f; // How wide is the field
        public float height { get; set; } = 500f; // How high is the field
    }
}
