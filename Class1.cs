using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_FInder
{
    enum PartType
    {
        Resistor,
        Capacitor,
        Transistor,
    }
    internal class InventoryItem
    {
        public PartType Type;
        public int PartNum;
        public int Quantity;
        public string Description;
    }

}





