using System;
using System.Collections.Generic;
using System.Linq;

namespace P6.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" ");
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                Box box = new Box
                {
                    Item = item,
                    ItemQuantity = itemQuantity,
                    SerialNumber = serialNumber,
                };

                boxes.Add(box);
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();
            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }
}



public class Item
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}

public class Box
{
    public Box()
    {
        Item = new Item();
    }

    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal PriceForABox
    {
        get { return ItemQuantity * Item.Price; }

    }
}
