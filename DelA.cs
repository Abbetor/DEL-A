List<string> nameOfItems = new List<string>();
List<int> priceOfItems = new List<int>();

while (true)
{ 
    Console.Clear();
    if (nameOfItems.Count == 0)
    {
        Console.WriteLine("Listan är tom");
    }
    else
    {
        Console.WriteLine("Lista:");
        for(int i = 0; i < nameOfItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {nameOfItems[i]} - {priceOfItems[i]}kr");
        }
    }
    
    Console.WriteLine("\nSkriv Varan du vill lägga till, därefter skriv priset på den.");
    string Input = Console.ReadLine();
    {
        if (string.IsNullOrWhiteSpace(Input) || int.TryParse(Input, out int VariableNoOneCaresAbout))
        {
            Console.Clear();
            Console.WriteLine("Du kan inte skriva siffor som varunamn försök igen");
            Console.WriteLine("Tryck enter");
            Console.ReadLine();
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
