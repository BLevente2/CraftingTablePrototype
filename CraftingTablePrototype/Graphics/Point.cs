using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Graphics
{

    /// <summary>
    /// A pont osztály adja meg a sokszögek csúcsainak számát, nagyságát, szögét és elhelyezkedését a térben.
    /// </summary>
    public abstract class Point
    {

        /// <summary>
        /// A pont x koordinátája
        /// </summary>
        public float X {  get; set; }

        /// <summary>
        /// A pont y koordinátája
        /// </summary>
        public float Y { get; set; }

    }
}
