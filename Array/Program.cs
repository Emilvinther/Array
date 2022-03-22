int [] number = new int [9];

for (int i = 0; i < number.Length; i++)
{
    number[i] = i+1;
    if (i == 5)
    {
        Console.WriteLine(number[i]);
        number[i] = 12;
        Console.WriteLine(number[i]);
    }
}

//Console.WriteLine (number[0]);

Console.ReadKey();