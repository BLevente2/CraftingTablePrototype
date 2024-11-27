using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingTablePrototype.GameElements
{

    /// <summary>
    /// A csempe osztály egy lerakható, a felhasználó számára testre szabható sokszöget hoz létre, amik automatikusan egymás oldalaihoz illeszkednek, így akár játékmezőknek is felhasználhatóak, és ez volt az egyik nagyobb oka annak, amiért nem hoztunk létre egy játékmező osztályt. Implementálja az IDrawable és IColourable interfészeket.
    /// </summary>
    public abstract class Tile : IColourable, IDrawable
    {

        public byte[,,] Color { get; set; }

        public void ColourChange(byte[,,] newColor)
        {
            throw new NotImplementedException();
        }

        public void Draw(float scale)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Képek tárolására szánt mező
        /// </summary>
        public byte[] PictureField { get; set; }

        /// <summary>
        /// Egész számok tárolására szánt mező
        /// </summary>
        public List<int> IntField { get; set; }

        /// <summary>
        /// Szöveges input tárolására szánt mező
        /// </summary>
        public List<string> StringField { get; set; }

        /// <summary>
        /// ,,Csemperagasztó” metódus
        /// </summary>
        /// <param name="snapTo"></param>
        public abstract void Snap(float[] snapTo);

    }
}