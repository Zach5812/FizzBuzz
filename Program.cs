// for (int i = 1; i<=255; i++)
// {
//     Console.WriteLine(i);
// };
// Console.WriteLine("==========");
// Random rand = new Random();
// int sum = 0;
// int j = 0;
// int q = 0;
// while(j <=4)
// {
//     q = rand.Next(10, 20);
//     sum += q;
//     j++;
// };
//     Console.WriteLine(sum);

// Console.WriteLine("==========");

int i = 1;
while(i<=100)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(i % 3 == 0 )
    {
    Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0)
    {
    Console.WriteLine("Buzz");
    }
    i++;
}
