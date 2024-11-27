using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Modules
{

    /// <summary>
    /// Ahhoz, hogy a panelek érzékeljék a változásokat, az osztály a JS EventListener segítségét használja, ami számára eseményekkel tér vissza. A PanelManager implementálja az IDraw interfészt.
    /// </summary>
    public abstract class PanelManager : IDraw
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Átméretezi a panelt.
        /// </summary>
        /// <param name="newSize"></param>
        public abstract void Resize(float[,] newSize);

    }
}
