List<string> nameOfItems = new List<string>();
List<int> priceOfItems = new List<int>();

while (true)
{
    Console.WriteLine("Skriv Varan du vill lägga till, därefter skriv priset på den.");
    string Input = Console.ReadLine();
    {
        if (string.IsNullOrWhiteSpace(Input) || int.TryParse(Input, out int VariableNoOneCaresAbout))
        {
            Console.WriteLine("Du kan inte skriva siffor som varunamn försök igen");
            continue;
        }
        else
        {
            {
                Console.WriteLine("Skriv priset på varan");
                string PrisInput = Console.ReadLine();

                if(int.TryParse(PrisInput, out int NewPrisInput))
                {
                    priceOfItems.Add(NewPrisInput);
                    nameOfItems.Add(Input);
                }
                else
                {
                    Console.WriteLine("Du skrev inte in ett nummer försök igen");
                }
            }  
        }
        

        

        
    }
    
}