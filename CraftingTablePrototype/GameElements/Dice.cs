using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// A kocka osztályunk is egy kidolgozottabb osztály, amelyben előre megszabott oldalszámok és stílus esetén különböző speciális kocka animációk is beállíthatóak, ezektől eltérő oldalszámok esetén a sokszög kirajzolódik egy számmal benne, viszont animáció nem játszódik le hozzá. Az osztály implementálja az IDrawable, IColourable és IRandomizable interfészeket.
    /// </summary>
    public abstract class Dice : GameObject, IDrawable, IColourable, IRandomizable
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

        public int RandNumGen(int lowerBoundary, int upperBoundary)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ezek az alapértelmezett dbókocka oldalak
        /// </summary>
        public enum DefaultSides
        {

        }

        /// <summary>
        /// Dobókocka oldalszáma
        /// </summary>
        public Dice.DefaultSides Sides { get; set; }

        /// <summary>
        /// Dobókocka oldalszáma abban az esetben, ha nem az előre meghatározott opciók közül választ a felhasználó
        /// </summary>
        public int SidesSpecial { get; set; }

        /// <summary>
        /// Előremeghatározott dobókockasémákat tartalmaz
        /// </summary>
        public enum Style
        {

        }

        /// <summary>
        /// Előre meghatározott dobókocka stílusok gyűjteménye
        /// </summary>
        public Dice.Style DiceStyle { get; set; }

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
        /// Megváltoztatja a dobókocka stílusát.
        /// </summary>
        public abstract void ChangeDiceStyle();

    }
}