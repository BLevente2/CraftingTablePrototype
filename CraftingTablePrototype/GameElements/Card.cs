using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// A kártya osztályunk az egyik legkidolgozottabb és legbonyolultabb abban az értelemben, hogy nagyon sok tulajdonsága és metódusa van. A kártyák különböző előre meghatározott fajtái egy enum-ban szerepelnek, amely kiválasztásakor azon mezők és paraméterek kerülnek meghívásra, amelyek ahhoz a kártyához szükségesek. A kártyák szigorúan téglalapok lehetnek. Ez az osztály implementálja az IDrawable, IColourable és IRandomizable interfészeket.
    /// </summary>
    public abstract class Card : GameObject, IDrawable, IColourable, IRandomizable
    {
        public byte[,,] Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void ColourChange(byte[,,] newColor)
        {
            throw new NotImplementedException();
        }

        public virtual void Draw(float scale)
        {
            throw new NotImplementedException();
        }

        public virtual int RandNumGen(int lowerBoundary, int upperBoundary)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Képek tárolására szánt mező
        /// </summary>
        public byte[] PictureField { get; set; }

        /// <summary>
        /// Egész számok tárolására szánt mező
        /// </summary>
        public List<int> IntField { get; set; }

        /// <summary>
        /// Szöveges input tárolására szánt mező
        /// </summary>
        public List<string> StringField { get; set; }

        /// <summary>
        /// Elment egy kártyát a pakliba.
        /// </summary>
        public abstract void SaveToDeck(int tecNumberk);


        /// <summary>
        /// Megkeveri a paklit.
        /// </summary>
        public abstract void Shuffle();

        /// <summary>
        /// Felhasznál egy kártyát
        /// </summary>
        public abstract void UseUp();

        /// <summary>
        /// Megváltoztatja a kártya sémáját.
        /// </summary>
        /// <param name="newType"></param>
        public abstract void ChangeCardType(string newType);

        /// <summary>
        /// Ezek az előre meghatározott kártyasémák
        /// </summary>
        public enum Type
        {

        }

        /// <summary>
        /// Előre meghatározott kártyasémák gyűjteménye
        /// </summary>
        public Card.Type CardType { get; set; }

    }
}