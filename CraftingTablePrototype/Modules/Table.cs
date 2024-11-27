using CraftingTablePrototype.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Modules
{

    /// <summary>
    /// A tábla osztály létrehoz egy játékmezőt, aminek a méretét és alakját a felhasználó személyre szabhatja. Ez az a játékfelület, amin majd minden elhelyezkedik, és ezt hozza a felhasználó létre legelőször. Ahhoz, hogy tudjuk, hogy a lehelyezett modul a táblán van-e, a ModuleInformation és a ModuleManager osztályoktól is kapnia kell információkat. A Table osztály ezenfelül implementálja az IDraw interfészt és felül is írja.
    /// </summary>
    public abstract class Table : IDraw
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Tábla mérete
        /// </summary>
        public loat[,] Size { get; set; }

        /// <summary>
        /// Tábla méretének átmeneti megnövelése
        /// </summary>
        public int Increment { get; set; }

        /// <summary>
        /// Ellenőrzi, hogy az objektum a táblán belül került-e lehelyezésre.
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public abstract bool IsIn(float[,] area);
    }
        /// <summary>
        /// Jelzi a táblának, hogy átmenetileg megnőtt a mérete
        /// </summary>
        /// <param name="isResized"></param>
    public abstract void EventResized(bool isResized);

        /// <summary>
        /// Lekezeli az átmeneti méretnövekedés mechanizmusát.
        /// </summary>
        public abstract void OnResize();

        /// <summary>
        /// Visszaadja a tábla középpontjának koordinátáit.
        /// </summary>
        /// <returns></returns>
        public abstract float GetCenter(GameObject game);

    }
}