using Pet;
using Pet;

try
{
    var pet = new Lizard();
    while (true)
    {
        Console.WriteLine("Lizard");
        Console.Write("Hunger: ");
        Console.WriteLine(pet.Hunger);
        Console.Write("Boredom: ");
        Console.WriteLine(pet.Boredom);

        var toss = pet.Do();
        Console.WriteLine($"Toss was {toss}");
        if (toss > 0)
        {
            var action = Console.ReadLine();
            while (action != "exit")
            {
            if (action == "P")
            {
                pet.Play();
                    break;
            }

            if (action == "F")
            {
                pet.Feed();
                    break;
            }
            }
        }
        Thread.Sleep(500);
    }
}
catch (DeadPetException)
{
    Console.WriteLine("");
}
//