void CreateTestArray ()
{
    System.Console.WriteLine("Input amount of the array's elements ");
    int elementsAmount = Convert.ToInt32(Console.ReadLine());
    string[] newArray = new string[elementsAmount];
    for (int i = 0; i < newArray.Length; i++)
    {
     System.Console.WriteLine($"Please input your symbols which will be in array on the {i+1} place");   
        newArray[i] = Convert.ToString(Console.ReadLine());
    }
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.WriteLine(newArray[i]);
    }
}
CreateTestArray ();

