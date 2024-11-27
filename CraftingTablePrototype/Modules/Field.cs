using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Modules
{

    /// <summary>
    /// A mező osztály 3 alosztállyal hozzácsatolva. A nevük eléggé szókimondó, az IntField olyan mezőt hoz létre, amely számok kezelésére szolgál; a StringField egy olyan mezőt, amely szöveg; és a React : Picture Handler a React egy beépített képkezelő osztálya, ami a képek feltöltését, megjelenítését és manipulálását teszi lehetővé egyes modulokon belül. Ezen alosztályok a Field osztálynak szolgálnak adatokkal, ami végül ezeket feldolgozza, és a felhasználó számára használható formátumban adja vissza.
    /// </summary>
    public abstract class Field
    {

        /// <summary>
        /// Mező megjelenítési mérete
        /// </summary>
        public float[,] Size {  get; set; }

        /// <summary>
        /// Mező pozíciója a képernyőn
        /// </summary>
        public float[,] Position { get; set; }

        /// <summary>
        /// Mező mozgatása a képernyő egyik pozíciójából a másikba
        /// </summary>
        /// <param name="newPosition"></param>
        public abstract void Move(float[,] newPosition);

        /// <summary>
        /// Mező átméretezése a megadott paraméterek alapján
        /// </summary>
        /// <param name="newSize"></param>
        public abstract void Resize(float[,] newSize);

        /// <summary>
        /// Mező forgatása a megadott paraméterek alapján
        /// </summary>
        /// <param name="newRotation"></param>
        public abstract void Rotate(float[,] newRotation);

        /// <summary>
        /// Mező elforgatása
        /// </summary>
        public float[,] Rotation { get; set; }

    }
}