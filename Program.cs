using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_FInder
{
    internal static class Program
    {
        public static List<InventoryItem> InventoryList;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InventoryItem item;

            InventoryList = new List<InventoryItem>();

            //Add a resistor
            item = new InventoryItem();
            item.Type = PartType.Resistor;
            item.Quantity = 50;
            item.PartNum = 1;
            item.Description = "150 Ohm, size 1206";
            InventoryList.Add(item);

            //Add a capacitor
            item = new InventoryItem();
            item.Type = PartType.Capacitor;
            item.Quantity = 37;
            item.PartNum = 2;
            item.Description = "10uF, size 1206";
            InventoryList.Add(item);

            //Add a transistor
            item = new InventoryItem();
            item.Type = PartType.Transistor;
            item.Quantity = 67;
            item.PartNum = 3;
            item.Description = "TRANS PNP 30V 100MA DUAL SOT143B";
            InventoryList.Add(item);

           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

       
    }
}
