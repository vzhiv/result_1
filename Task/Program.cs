Console.Clear();

string[] CreateStringArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[rows];
    for(int i = 0; i < rows; i++)
    {
        Console.Write($"Input {i+1} row and press Enter: ");
        array[i] = Console.ReadLine();
        if(array[i] == string.Empty)
        {
            Console.WriteLine($"An empty string is entered, try again!");
            i--;
        }
    }
        
    Console.WriteLine();
    return array;
}





