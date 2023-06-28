using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace P6.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split().ToList();
            List<Box> boxList = new List<Box>();
            List<Item> itemList = new List<Item>();


            while (inputList[0] != "end")
            {

                string serialNumber = inputList[0];
                string itemName = inputList[1];
                string itemQuantity = inputList[2];
                string itemPrice = inputList[3];

                Box box = new Box();
                box.Item = new Item();

                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.ItemQuantity = int.Parse(itemQuantity);
                box.Item.Price = decimal.Parse(itemPrice);
                box.PriceForABox = box.ItemQuantity * box.Item.Price;

                boxList.Add(box);
                itemList.Add(box.Item);

                inputList = Console.ReadLine().Split().ToList();

                if (inputList[0] == "end")
                {
                    List<Box> SortDescendingByPrice = boxList.OrderByDescending(o => o.PriceForABox).ToList();
                    for (int i = 0; i < SortDescendingByPrice.Count; i++)
                    {
                        Console.WriteLine($"{SortDescendingByPrice[i].SerialNumber}");
                        Console.WriteLine($"-- {box.Item.Name} – ${box.Item.Price}: {box.ItemQuantity}");
                        Console.WriteLine($"-- ${box.PriceForABox:f2}");

                    }
                }
                
            }
            
            

        }
    }
}
