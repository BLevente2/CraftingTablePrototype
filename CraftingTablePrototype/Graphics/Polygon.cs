using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Graphics
{

    /// <summary>
    /// A sokszög osztály az, ami valójában eltárolja ezeket a pontokat és végül összefűzi, csoportosítja őket. Fontos, hogy egy sokszögnek minimum 3 ponttal kell rendelkeznie, mivel a szerkesztőnk 2 dimenzióban dolgozik, így sajnos az egyszögek (monogon) és a kétszögek (digon) nem rajzolhatók meg.
    /// </summary>
    public abstract class Polygon
    {

        /// <summary>
        /// Visszaadja a sokszög ponthalmazát.
        /// </summary>
        /// <returns></returns>
        public abstract List<Point> GetPoints();

        /// <summary>
        /// Átadja a sokszög ponthalmazát egy másik objektumnak.
        /// </summary>
        public abstract void Bundle();

    }
}
