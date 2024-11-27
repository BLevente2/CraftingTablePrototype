using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// A papírpénz vagy készpénz osztály az ISpendable interfészt implementálja, és a Card osztályt örökli azonfelül, hogy mind szigorúan téglalapok lehetnek, a pénz objektumoknak pedig vízszintes orientációban kell elhelyezkedniük a könnyű megkülönböztetés céljából. Ez nem azt jelenti, hogy a pénz maga nem lehet függőleges orientációban a táblán, hanem azt, hogy a kártya modul szerkesztés közben nem vehet fel más orientációt a vízszintesnél.
    /// </summary>
    public abstract class Cash : Card, ISpendable
    {
        public string CurrencyType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrencyValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Spend()
        {
            throw new NotImplementedException();
        }

        public override void Draw(float scale)
        {
            throw new NotImplementedException();
        }

    }
}
