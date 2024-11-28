using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// A dominó osztály egyenesen a Tile osztályt örökli, azzal a megszabással, hogy szigorúan téglalap alakúak lehetnek.
    /// </summary>
    public abstract class TraditionalDomino : Tile
    {

        public override void Draw(float scale)
        {
            throw new NotImplementedException();
        }

    }
}
