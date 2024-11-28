using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.TextEditor
{

    /// <summary>
    /// A lap osztály egy kirajzolt objektumok halmaza. Ez az a felület, amit a felhasználó valójában lát, és ahol történik a szerkesztés.
    /// </summary>
    public abstract class Page
    {

        /// <summary>
        /// Támogatott lapméretek
        /// </summary>
        public enum Sizes
        {

        }

        /// <summary>
        /// Lapmérete
        /// </summary>
        public Page.Sizes Size {  get; set; }

        /// <summary>
        /// Lap margóinak mérete
        /// </summary>
        public float[,,,] Margin { get; set; }

        /// <summary>
        /// ap elnevezése
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Készít egy másolatot a lapról.
        /// </summary>
        /// <returns></returns>
        public abstract Page Copy();

        /// <summary>
        /// Törli a lapot.
        /// </summary>
        public abstract void Delete();

        /// <summary>
        /// Megváltoztatja a lap margóinak méretét
        /// </summary>
        /// <param name="newMargin"></param>
        public abstract void ChangeMargin(float[,,,] newMargin);

        /// <summary>
        /// Megváltoztatja a lap méretét.
        /// </summary>
        /// <param name="newSize"></param>
        public abstract void ChangeSize(Page.Sizes newSize);
    }
}