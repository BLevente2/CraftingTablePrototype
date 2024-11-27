using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// Egy interfész, amely a játékelemek kirajzolásáért felel. Ezt a metódust a legtöbb osztályunk felülírja a saját paramétereivel.
    /// </summary>
    public interface IDrawable
    {

        /// <summary>
        /// Kirajzol egy játékelemet a megadott skála alapján.
        /// </summary>
        /// <param name="scale"></param>
        public void Draw(float scale);

    }
}