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

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
    Console.WriteLine();
}

string[] LengthLess(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) // ищем количество элементов в массиве, где длина строки меньше или равна 3-м символам. Делаем это для инициализации нового массива необходимого размера
        if(array[i].Length <= 3) count++; 
    
    string[] resultArray = new string[count];
    for(int i = 0, j = 0; i < array.Length; i++, j++)
        if(array[i].Length <= 3) resultArray[j] = array[i];
        else j--;
    
    return resultArray;
}



