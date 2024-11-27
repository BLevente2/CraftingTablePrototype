using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// Egy interfész azon játékelemek számára, amelyek fő célja valamilyen pénznem imitálása. Javarészt a currencyType és a currencyValue tagok csak leírószövegek a játékosok számára, hogy a szabályzatban leírtakat könnyebb legyen követni.
    /// </summary>
    public interface ISpendable
    {

        /// <summary>
        /// Pénznem típusa
        /// </summary>
        public string CurrencyType { get; set; }

        /// <summary>
        /// Pénznem értéke
        /// </summary>
        public int CurrencyValue { get; set; }

        /// <summary>
        /// Kezeli egy pénz objektum elköltésének mechanizmusát.
        /// </summary>
        public void Spend();
    }
}
