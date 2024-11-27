using CraftingTablePrototype.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.Modules
{

    /// <summary>
    /// A modul menedzser osztály a modulok táblára való lehelyezésétől a végső simításig végigkíséri az egyes modulok szerkesztését.
    /// </summary>
    public abstract class ModuleManager
    {

        /// <summary>
        /// Létrehozza a modult.
        /// </summary>
        /// <param name="game"></param>
        public abstract void CreateModule(GameObject game);

        /// <summary>
        /// Elmenti a modult.
        /// </summary>
        /// <param name="game"></param>
        public abstract void SaveModule(GameObject game);

        /// <summary>
        /// Egy modulon belüli változtatást hajt végre.
        /// </summary>
        /// <param name="game"></param>
        public abstract void AlterModule(GameObject game);

        /// <summary>
        /// Egy modulon kívüli változtatást hajt végre.
        /// </summary>
        /// <param name="game"></param>
        public abstract void ModifyModule(GameObject game);

    }
}
