using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{
    /// <summary>
    /// Ez az absztrakt osztály, azon bázisosztály, amelyből a többi játékelem osztályok öröklik a tulajdonságaikat és metódusaikat.
    /// </summary>
    /// <remarks>
    /// Ez ténlyeg absztrakt osztály lesz.
    /// </remarks>
    public abstract class GameObject
    {

        /// <summary>
        ///  <summary>
        ///  Játékelem elnevezése
        ///  </summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Játékelem megjelenítési mérete
        /// </summary>
        public float[,] isplaySize { get; set; }

        /// <summary>
        /// Játékelem skálázási tényezője
        /// </summary>
        public float Scale { get; set; }

        /// <summary>
        /// Játékelem pozíciója a képernyőn
        /// </summary>
        public float[,] Position { get; set; }


        /// <summary>
        /// Játékelem elforgatása a képernyőn
        /// </summary>
        public float[,] Rotation { get; set; }

        /// <summary>
        /// Játékelem mozgatása a képernyő egyik pozíciójából a másikba
        /// </summary>
        /// <param name="newPosition"></param>
        public abstract void Move(float[,] newPosition);

        /// <summary>
        /// Játékelem forgatása a megadott paraméterek alapján
        /// </summary>
        /// <param name="newRotation"></param>
        public abstract void Rotate(float[,] newRotation);

    }
}