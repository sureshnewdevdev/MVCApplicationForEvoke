using IndexersExampleProj;

class Program
{
    static void Main()
    {
        var tempRecord = new TempRecord();

        // Use the indexer's set accessor
        tempRecord[1] = 58.3F;



        tempRecord[5] = 60.1F;

        // Use the indexer's get accessor
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"Element #{i} = {tempRecord[i]}");
        //}

        Cars car = new Cars();

        car[0] = new CarParts 
                { 
                    Name = "M1", 
                    Part1 = "wwer", 
                    Part2 = "Horm", 
                    Part3 = "rets", 
                    Part4 = "navi" 
                };

        car[1] = new CarParts
        {
            Name = "M2",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };

        car[2] = new CarParts
        {
            Name = "M3",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };
        car[3] = new CarParts
        {
            Name = "M4",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };
        car[4] = new CarParts
        {
            Name = "M4",
            Part1 = "wwer",
            Part2 = "Horm",
            Part3 = "rets",
            Part4 = "navi"
        };

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine(car[i].Name + " " + car[i].Part1);
            Console.WriteLine("************************************************");
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    /* Output:
        Element #0 = 56.2
        Element #1 = 56.7
        Element #2 = 56.5
        Element #3 = 58.3
        Element #4 = 58.8
        Element #5 = 60.1
        Element #6 = 65.9
        Element #7 = 62.1
        Element #8 = 59.2
        Element #9 = 57.5
    */
}