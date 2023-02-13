using static System.Console;
Clear();

Write("Введите массив строк  через пробел:  ");
string[]array1 = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintArray(array1);
WriteLine(); 

string[] array2 = new string[array1.Length];

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
if(array1[i].Length <=3 )
    {
      array2[count] = array1[i];
      count++;
    }
}
PrintArray(array2);

void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]} ");
    }
    WriteLine("");
}

