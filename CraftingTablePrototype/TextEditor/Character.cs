using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.TextEditor
{

    /// <summary>
    /// A karakter osztály a betűnkénti átadást biztosítja a DrawObject számára. Azért maradtunk a betűnkénti átadásnál, mivel ez sokkal nagyobb testreszabhatóságot és uralmat ad a felhasználó számára.
    /// </summary>
    public abstract class Character
    {

        /// <summary>
        /// Karakter betűtípusa
        /// </summary>
        public string Font {  get; set; }

        /// <summary>
        /// Karakter betűmérete
        /// </summary>
        public int FontSize { get; set; }

        /// <summary>
        /// Karakter színe
        /// </summary>
        public byte[,,] Color { get; set; }

        /// <summary>
        /// Megvastagítja a karaktert.
        /// </summary>
        public bool Bold { get; set; }

        /// <summary>
        /// Dőlt betűssé teszi a karaktert.
        /// </summary>
        public bool Italic { get; set; }

        /// <summary>
        /// Kiemeli a karaktert a megadott színnel.
        /// </summary>
        public bool Highlighted { get; set; }

        /// <summary>
        /// Aláhúzza a karaktert.
        /// </summary>
        public bool Underline { get; set; }

        /// <summary>
        /// Áthúzza a karaktert.
        /// </summary>
        public bool Strikethrough { get; set; }

    }
}