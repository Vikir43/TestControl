# __Итоговая проверочная работа__
## Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых **меньше либо равна 3 символа**. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Описание алгоритма решения:
а) первоначальный массив _array1_  предлогается ввести пользователю самостоятельно через пробел, для того чтобы программа считывала пробел используется следующая команда команда, где в ковычках нами задано необходимое условие, а именно пробел:

     Split(" ", StringSplitOptions.RemoveEmptyEntries);

б) далее прописан метод _PrintArray_ для вывода заданного массиваи и результативного массива на пеать;
в) задаем переменные для нового массива, соразмерному длине заданного массива:

    string[] array2 = new string[array1.Length];

г) входим в цикл _for_(первоначально задав параметр _count_ равным нулю) для проверки условия _**<= 3**_, если да элемент первого массива заносится в _count_ элемент второго массива. После присвоения увеличиватся переменная _count_ на единицу и возвращается к циклу _for_ в котром переходим к следующему элементу массива и та проверяем до конца массива:

    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <=3 )
     {
        array2[count] = array1[i];
         count++;
            }
    }
