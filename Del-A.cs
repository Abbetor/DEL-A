List<string> nameOfItems = new List<string>();
List<int> priceOfItems = new List<int>();

while (true)
{   
    Console.WriteLine("Type 'D' for delete and 'ADD' to add (case sensitive)");
    string choice = Console.ReadLine();

    if (choice == "ADD")
    {
        Console.WriteLine("Enter item name (numbers not accepted)");
        string item = Console.ReadLine();

        int number;

        if (!int.TryParse(item, out number))
        {   
            string priceOfItem = Console.ReadLine();

            if (int.TryParse(priceOfItem, out int newpriceOfItem))
            {
                nameOfItems.Add(item);
                priceOfItems.Add(newpriceOfItem);
            }
        }  
    } 

    if (choice == "D")
    {
        Console.WriteLine("Type the number in the list that you want to delete.");  
        string input = Console.ReadLine();

        if (int.TryParse(input, out int itemNumber))
        {
            if (itemNumber >= 1 && itemNumber <= nameOfItems.Count)
            {
                int itemPostion = itemNumber - 1;
                nameOfItems.RemoveAt(itemPostion);
                priceOfItems.RemoveAt(itemPostion);
            }
        }       
    }

    Console.Clear();

    int total = 0;
    for (int i = 0; i < nameOfItems.Count; i++)
    {   
        total = total + priceOfItems[i];
        Console.WriteLine($"{i + 1}. {nameOfItems[i]} - {priceOfItems[i]}kr");
    }
    Console.WriteLine($"Total: {totalt}kr");
}