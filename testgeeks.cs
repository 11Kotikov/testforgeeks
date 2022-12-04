void CreateTestArrayOfThreeSymbols()
{
    System.Console.WriteLine("Input amount of the array's elements ");
    int elementsAmount = Convert.ToInt32(Console.ReadLine());
    string[] newArray = new string[elementsAmount];
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.WriteLine($"Please input your symbols which will be contained in array on the {i + 1} place");
        newArray[i] = Convert.ToString(Console.ReadLine());
    }
    System.Console.WriteLine("I'll show you only not more than 3-symbols string in each element, sorry");
    Thread.Sleep(1000); //можно было бы написать проверку на количество элементов
                        //содержащих более 3х символов, если таковых нет - то
                        //выводить - "в вашем массиве пусто", но такой задачи не стояло 
    System.Console.Write("[ ");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3)
            System.Console.Write($"{newArray[i]} ");
    }
    System.Console.Write(" \b\b ]");
}

CreateTestArrayOfThreeSymbols();

