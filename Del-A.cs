List<string> nameOfItems = new List<string>();
List<int> priceOfItems = new List<int>();

while (true)
{   
    Console.WriteLine("Type 'D' for delete and 'ADD' to add");
    string choice = Console.ReadLine();
    if(choice == "ADD")
    {

        Console.WriteLine("Enter item name (numbers not accepted)");
        string item = Console.ReadLine();
    
        int number;

        if (!int.TryParse(item, out number))
        {   
            nameOfItems.Add(item);
            string priceOfItem = Console.ReadLine();

            if (int.TryParse(priceOfItem, out int newpriceOfItem))
            {
                priceOfItems.Add(newpriceOfItem);
                Console.Clear();
                for (int i = 0; i < nameOfItems.Count; i++)
                {   
                    Console.WriteLine($"{i + 1}. {nameOfItems[i]} - {priceOfItems[i]}kr");
                }
            }
        }  
    } 
    
}

