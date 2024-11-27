using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Modules
{

    /// <summary>
    /// A panel és panel menedzser osztályok a különböző panelek megjelenítését végzik el. Panelek alatt a kisebb téglalap alakú részekre gondolunk a weboldalon belül. De nemcsak ezek, hanem a szerkesztőfelület legtetején lévő ikonok és modulok is mind panelként jelennek meg.
    /// </summary>
    public abstract class Panel
    {

        /// <summary>
        /// Panel pozíciója a képernyőn
        /// </summary>
        public float[,] Position { get; set; }

        /// <summary>
        /// Panel megjelenítési mérete
        /// </summary>
        public float[,] Size { get; set; }

        /// <summary>
        /// Panel skálázási tényezője
        /// </summary>
        public float Scale { get; set; }

    }
}
