using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// A figura osztályunk egy nagyon egyszerű sokszöget vagy kört jelenít meg, amely egy bábut reprezentálhat, számmal, betűvel, vagy akár egy saját kép feltöltésével is. Itt is vannak előre megszabott stílusú figurák, amiknek speciális megjelenítése van. Az osztály implementálja az IDrawable és IColourable interfészeket.
    /// </summary>
    public abstract class Figure : IDrawable, IColourable
    {
        public byte[,,] Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ColourChange(byte[,,] newColor)
        {
            throw new NotImplementedException();
        }

        public void Draw(float scale)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Beépített figurasémák
        /// </summary>
        public enum Style
        {

        }

        /// <summary>
        /// lőre meghatározott figura stílusok gyűjteménye
        /// </summary>
        public Figure.Style FigureStyle { get; set; }

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
        /// Megváltoztatja a figura stílusát.
        /// </summary>
        /// <param name="newStyle"></param>
        public abstract void ChangeFigureStyle(string newStyle);

    }
}