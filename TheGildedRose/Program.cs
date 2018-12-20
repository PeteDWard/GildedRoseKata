using System;
using System.Collections.Generic;

namespace TheGildedRose
{
    public class Program
    {
        public IList<Item> Items;

        static void Main(string[] args)
        {
            Console.WriteLine("The Gilded Rose Inventory");

            var app = new Program()
            {
                Items = PopulateItems()
            };

            app.ShowInventory();

            app.UpdateQuality();

            app.ShowInventory();

            Console.ReadKey();
        }

        public void UpdateQuality()
        {
            int ItemQty = Items.Count;
            foreach (Item ThisItem in Items)
            {
                ItemQty -= 1;
                InventoriesInterface inventory = InventoriesFactory.Create(ThisItem, ItemQty);
                inventory.Update(ThisItem);
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("\n===== Inventory");

            foreach (Item ThisItem in Items)
            {
                Console.WriteLine(ThisItem.Name + " " + ThisItem.SellIn + " " + ThisItem.Quality);
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public int SellIn { get; set; }
            public int Quality { get; set; }

            public int QualityMax = 50;
        }

        public static List<Item> PopulateItems()
        {
            List<Item> Items = new List<Item>
                        {
                            new Item {Name = "Aged Brie", SellIn = 1, Quality = 1},
                            new Item {Name = "Backstage passes", SellIn = -1, Quality = 2},
                            new Item {Name = "Backstage passes", SellIn = 9, Quality = 2},
                            new Item {Name = "Sulfuras", SellIn = 2, Quality = 2},
                            new Item {Name = "Normal Item", SellIn = -1, Quality = 55},
                            new Item {Name = "Normal Item", SellIn = 2, Quality = 2},
                            new Item {Name = "INVALID ITEM", SellIn = 2, Quality = 2},
                            new Item {Name = "Conjured", SellIn = 2, Quality = 2},
                            new Item {Name = "Conjured", SellIn = -1, Quality = 5}
                        };
            return Items;
        }
    }
}
