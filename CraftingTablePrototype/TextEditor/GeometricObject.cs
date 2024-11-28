using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.TextEditor
{

    /// <summary>
    /// A geometriai alakzat osztály különböző alakzatok paramétereinek a csoportosításáért felelős, amiket utána átad a DrawObject osztálynak feldolgozásra.
    /// </summary>
    public abstract class GeometricObject
    {
        /// <summary>
        /// Geometriai alakzat elnevezése
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Geometriai alakzat elforgatása
        /// </summary>
        public float[,] Rotation { get; set; }

        /// <summary>
        /// Elforgatja a geometriai alakzatot.
        /// </summary>
        /// <param name="newRotation"></param>
        public abstract void Rotate(float[,] newRotation);

        /// <summary>
        /// Tükrözi a geometriai alakzatot.
        /// </summary>
        public abstract void Mirror();

        /// <summary>
        /// Kiválasztja a geometriai alakzatot határoló objektumot.
        /// </summary>
        public abstract void SelectBorder();

    }
}
