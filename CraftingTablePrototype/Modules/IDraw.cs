using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Modules
{

    /// <summary>
    /// Az IDraw interfész hasonlít az IDrawable interfészre, amit korábban már említettünk, ez viszont az ezen az alrendszeren belüli osztályok kirajzolását segíti.
    /// </summary>
    public interface IDraw
    {

        /// <summary>
        /// Kirajzol egy modult.
        /// </summary>
        public void Draw();

    }
}
