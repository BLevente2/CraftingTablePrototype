using CraftingTablePrototype.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Modules
{

    /// <summary>
    /// A modul információ osztály az egyes modulok táblán lévő adatait kéri le és adja tovább, valamint a metaadatait jeleníti meg a felhasználó számára egy szövegbuborékban, amikor a felhasználó arra ráviszi az egerét. Ahhoz, hogy tudja, hogy mikor és melyik modulra vitték rá az egeret, ahhoz a JS EventListener segítségét veszi igénybe. Az osztály implementálja az IDraw interfészt.
    /// </summary>
    public abstract class ModuleInformation : IDraw
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Visszaadja a modul pozícióját.
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public abstract float[,] GetModulePosition(GameObject game);

        /// <summary>
        /// Visszaadja a modul metaadatait.
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public abstract string GetModuleParams(GameObject game);

        /// <summary>
        /// Kirajzolja a modul metaadatait egy szövegdobozban.
        /// </summary>
        /// <param name="game"></param>
        /// <param name="toDraw"></param>
        public abstract void DrawOnHover(GameObject game, IDrawable toDraw);

    }
}
