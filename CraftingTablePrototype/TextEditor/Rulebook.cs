using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.TextEditor
{

    /// <summary>
    /// A szabálykönyv az az osztály, ami egybefoglal mindent az eddig felsoroltak közül egy lementhető, kezelhető fájlba.
    /// </summary>
    public abstract class Rulebook
    {

        /// <summary>
        /// Szabálykönyv elnevezése
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Szabálykönyv létrehozásának dátuma
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// zabálykönyv utolsó módosításának dátuma
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Elmenti a szabálykönyvet.
        /// </summary>
        public abstract void Save();

        /// <summary>
        /// Visszaállítja a szabálykönyvet, ha kritikus hiba lép fel.
        /// </summary>
        public abstract void Recover();

    }
}
