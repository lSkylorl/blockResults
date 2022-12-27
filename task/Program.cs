string[] enterArr = new string[7] {"hello", "world", "hi", "123", "7","name" ,"gb"};
string[] exitArr = new string[enterArr.Length];

arrFiltering(enterArr, exitArr);
void arrFiltering(string[] enterArr, string[] exitArr)
{
    int count = 0;
    for (int i = 0; i < enterArr.Length; i++)
    {
        if (enterArr[i].Length <= 3)
        {
            exitArr[count] = enterArr[i];
            count++;
        }
    }
}

PrintArray(exitArr);
void PrintArray(string[] enterArr)
{
    for (int i = 0; i < enterArr.Length; i++)
    {
        Console.Write($"{enterArr[i]} ");
    }
    Console.WriteLine();
}