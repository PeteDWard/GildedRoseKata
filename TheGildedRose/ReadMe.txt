Coding Challenge - 'Gilded Rose problem adapted from Gilded Rose Kata by https://twitter.com/TerryHughes'

The Requirements of this task...

Your task is to write a program to automate the inventory management based on the following rules:

Rules :
1. All items have a SellIn value which denotes the number of days we have to sell the item
2. All items have a Quality value which denotes how valuable the item is
3. At the end of each day our system lowers both values for every item
4. Once the sell by date has passed, Quality degrades twice as fast
5. The Quality of an item is never negative
6. "Aged Brie" actually increases in Quality the older it gets
7. "Normal Item" decreases in Quality by 1
8. The Quality of an item is never more than 50
9. "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
10. "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches; Its quality increases by 2 when there are 10 days or less and by 3 when
there are 5 days or less but quality drops to 0 after the concert 
11. "Conjured" items degrade in Quality twice as fast as normal items

Input: A list of items in the current inventory. Each line in the input represents an inventory item with Item name, its sell-in value and quality e.g. “Backstage passes -1 2” => Backstage
passes is past sellin value by 1 day with quality 2. 

Output : Updated inventory after adjusting the quality and sellin days for each item after a day.

Test Input...
Aged Brie 1 1
Backstage passes -1 2
Backstage passes 9 2
Sulfuras 2 2
Normal Item -1 55
Normal Item 2 2
INVALID ITEM 2 2
Conjured 2 2
Conjured -1 5

Expected Output..
Aged Brie 0 2
Backstage passes -2 0
Backstage passes 8 4
Sulfuras 2 2
Normal Item -2 50
Normal Item 1 1
NO SUCH ITEM
Conjured 1 0
Conjured -2 1

** How to use...

Load the Solution using Visual Studio 2017 and compile/run.

** Whats Included in the Solution...

Program.cs ... Sets the Inventory Items and displays the results in the console.

InventoriesFactory.cs ... Updates the Inventories.

This solution runs in the console and has no executables as stipulated in the task.

There are no other dependencies outside the .NET Core 2.1 framework.

** Considerations

This was an interesting challenge and with some small changes/additions could easily populate the inventory from an external datasource. The Factory would need some 
work as it is currently limited to the products listed.