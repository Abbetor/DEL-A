List<string> nameOfItems = new List<string>();
List<int> priceOfItems = new List<int>();

while (true)
{ 
    Console.Clear();
    int total = 0;
    if (nameOfItems.Count == 0)
    {
        Console.WriteLine("Listan är tom\n");
    }
    
    else
    {
        Console.WriteLine("Lista:");
        
        for(int i = 0; i < nameOfItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nameOfItems[i]} - {priceOfItems[i]}kr");
            total = total + priceOfItems[i];
        }
        
    }
    Console.WriteLine($"Totalt {total} kr");
    
    Console.WriteLine("\nSkriv quit för att stänga av programmet\nSkriv Varan du vill lägga till:");
    string Input = Console.ReadLine();
    {
        if (Input == "quit")
        {
            break;
        }

        if (string.IsNullOrWhiteSpace(Input))
        {
            Console.WriteLine("Du måste skriva något varunamn... tryck enter för att försöka igen");
            Console.ReadLine();
            continue;
        }

        if (int.TryParse(Input, out int index))
        {
            index = index - 1;
            
            if(index >= 0 && index < nameOfItems.Count)
            {
                nameOfItems.RemoveAt(index);
                priceOfItems.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Nummret i listan finns inte, tryck enter sen försök igen");
                Console.ReadLine();
            }
            continue;
        }
        else
        {
            {
                Console.Clear();
                Console.WriteLine("Skriv priset på varan");
                string PrisInput = Console.ReadLine();

                if(int.TryParse(PrisInput, out int NewPrisInput))
                {
                    priceOfItems.Add(NewPrisInput);
                    nameOfItems.Add(Input);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du skrev inte in ett nummer försök igen");
                    Console.WriteLine("Tryck enter");
                    Console.ReadLine();
                }
                
            }
        }
        
    }
    
}
