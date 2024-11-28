using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.TextEditor
{

    /// <summary>
    /// A csoportosítás osztály végtelenül egyszerű. A kirajzolt objektumokat halmazba rendezi és úgy csoportosítja. Fontos, hogy az objektumok száma minimum 2 (kettő)
    /// </summary>
    public abstract class Group
    {

        /// <summary>
        /// Megszünteti az objektumok csoportját.
        /// </summary>
        public abstract void Delete();

    }
}
