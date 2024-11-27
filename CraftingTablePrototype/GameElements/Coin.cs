using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// Az érme osztályunk egy egymásra pakolható sokszög vagy kör objektumot hoz létre, amelynek lényege valaminek a jelzése (RPG játékokban például státusz jelzésére) vagy fizetőeszközként való használata lenne. Ez az osztály az IDrawable, ISpendable, IColourable és IRandomizable interfészeket implementálja, ahol is az IRandomizable interfész randNumGen() metódusát felülírja, és csak nulla és egy között generálhat random számot, ami egy fej vagy írás dobás eredményét adja vissza.
    /// </summary>
    public abstract class Coin : GameObject, IDrawable, ISpendable, IColourable, IRandomizable
    {
        public string CurrencyType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrencyValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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

        public void Spend()
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
        /// Egymásra halmozza az érméket.
        /// </summary>
        public abstract void Stack();

    }
}