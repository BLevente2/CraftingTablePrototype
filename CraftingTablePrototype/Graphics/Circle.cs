using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Graphics
{

    /// <summary>
    /// A kör osztályunk felel a körök adatainak tárolásáért és kezeléséért. Mivel nem akarjuk felrobbantani a felhasználók gépét végtelen sok szögű sokszögekkel, ezért létre kellett hoznunk egy osztályt csak a körök számára.
    /// </summary>
    public abstract class Circle
    {

        /// <summary>
        /// A kör sugara
        /// </summary>
        public float Radius { get; set; }

        /// <summary>
        /// A kör középpontjának koordinátái
        /// </summary>
        public float[,] Centre {  get; set; }

    }
}
