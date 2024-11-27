using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// Egy interfész a random szám generálásra. A Card osztályunknál érdekes a felhasználása, amelynél is a random számot nem megjelenítjük a felhasználó számára, hanem a kártyák összekeverésére használjuk.
    /// </summary>
    public interface IRandomizable
    {

        /// <summary>
        /// Generál egy véletlen számot a megadott tartományok között.
        /// </summary>
        /// <param name="lowerBoundary"></param>
        /// <param name="upperBoundary"></param>
        /// <returns></returns>
        public int RandNumGen(int lowerBoundary, int upperBoundary);

    }
}
