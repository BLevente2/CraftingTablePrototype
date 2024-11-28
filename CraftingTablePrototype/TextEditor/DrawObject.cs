using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.TextEditor
{

    /// <summary>
    /// Az objektum kirajzolás osztály neve eléggé szókimondó, ez az osztály felel az objektumok megjelenítéséért, továbbá azok csoportosításáért egy lapon.
    /// </summary>
    public abstract class DrawObject
    {

        /// <summary>
        /// Objektum elnevezése
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Csoportosítja az objektumot egy másikkal.
        /// </summary>
        public abstract void Group();

    }
}
