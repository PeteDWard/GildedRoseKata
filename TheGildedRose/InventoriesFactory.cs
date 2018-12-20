using System;
using System.Collections.Generic;
using System.Text;

namespace TheGildedRose
{
    class InventoriesFactory
    {
        public static InventoriesInterface Create(Program.Item item, int IndexValue)
        {
            if (item.Name == "Aged Brie")
            {
                return new UpdateAgedBrie();
            }
            else if (item.Name == "Backstage passes" && IndexValue == 7)
            {
                return new UpdateBackstagePass();
            }
            else if (item.Name == "Backstage passes" && IndexValue == 6)
            {
                return new UpdateBackstagePass();
            }
            else if (item.Name == "Normal Item" && IndexValue == 4)
            {
                return new UpdateNormalItem();
            }
            else if (item.Name == "Normal Item" && IndexValue == 3)
            {
                return new UpdateNormalItem();
            }
            else if (item.Name == "Conjured" && IndexValue == 1)
            {
                return new UpdateConjuredItem();
            }
            else if (item.Name == "Conjured" && IndexValue == 0)
            {
                return new UpdateConjuredItem();
            }
            else if (item.Name == "Sulfuras")
            {
                return new DoNothing();
            }
            else
            {
                return new InvalidItems();
            }
        }
    }

    interface InventoriesInterface
    {
        void Update(Program.Item item);
    }

    #region Inventory Update
    class UpdateAgedBrie : InventoriesInterface
    {
        public void Update(Program.Item item)
        {
            if (item.Quality < item.QualityMax)
            {
                item.Quality += 1;
            }

            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < item.QualityMax)
                {
                    item.Quality += 1;
                }
            }
        }
    }

    class UpdateBackstagePass : InventoriesInterface
    {
        public void Update(Program.Item item)
        {
            if (item.SellIn > 0)
            {
                if (item.Quality < item.QualityMax)
                {
                    item.Quality += 1;
                }
            }

            if (item.SellIn < 11)
            {
                if (item.Quality < item.QualityMax)
                {
                    item.Quality += 1;
                }
            }

            if (item.SellIn < 6)
            {
                if (item.Quality < item.QualityMax)
                {
                    item.Quality += 1;
                }
            }

            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }

    class UpdateNormalItem : InventoriesInterface
    {
        public void Update(Program.Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }
            
            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality -= 1;
                }
            }

            if (item.Quality > item.QualityMax)
            {
                item.Quality = item.QualityMax;
            }
        }
    }

    class UpdateConjuredItem : InventoriesInterface
    {
        public void Update(Program.Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 2;
            }
            
            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality -= 2;
                }
            }
        }
    }

    class InvalidItems : InventoriesInterface
    {
        public void Update(Program.Item item)
        {
            item.Name = "NO SUCH ITEM";
            item.SellIn = 0;
            item.Quality = 0;
        }
    }

    class DoNothing : InventoriesInterface
    {
        public void Update(Program.Item item)
        {

        }
    }
    #endregion
}
