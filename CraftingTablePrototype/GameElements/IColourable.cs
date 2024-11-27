using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{
    /// <summary>
    /// Egy interfész, amely a játékelemek színeinek a változtatására szolgál, amit mi RGB formátumban kezelünk.
    /// </summary>
    public interface IColourable
    {

        /// <summary>
        /// Játékelem színe
        /// </summary>
        public byte[,,] Color { get; set; }

        /// <summary>
        /// Megváltoztatja a játékelem színét.
        /// </summary>
        /// <param name="newColor"></param>
        public void ColourChange(byte[,,] newColor);
    }
}