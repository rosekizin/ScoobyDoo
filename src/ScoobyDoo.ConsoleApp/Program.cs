

// i % 5 && i % 7 -> ScoobyDoo
// i % 5 -> Scooby
// i % 7 -> Doo
// -> i

//while(number <= 100) { ... number ++; }


//for (var number in Enumerable.Range(1, 100)) { }

for (int number = 1; number <= 100; number++)
{
    if(number % 5 ==0 && number % 7 == 0)
    {
        Console.WriteLine("ScoobyDoo");
    }
    else if(number % 5 == 0)
    {
        Console.WriteLine("Scooby");
    }
    else if(number % 7 == 0)
    {
        Console.WriteLine("Doo");
    }
    else
    {
        Console.WriteLine(number);
    }
}
