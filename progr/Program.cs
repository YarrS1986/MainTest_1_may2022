// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Пример: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

Console.Clear();
string[] arr = new string[SizeArray("Введи длину массива = ")];
FindArray(arr);
int sumNum = NumberOfTrueValues(arr);
FillArray(arr, arr.Length);

Console.Write(" -> ");

string[] newArr = FindTrueValues(arr);
FillArray(newArr, sumNum);



//--------------------------------------------
string[] FindTrueValues(string[] arrayInput)
{
    int len = arrayInput.Length;
    string[] arrayOutput = new string[len];
    int j = 0;
    for (int i = 0; i < len; i++)
    {
        if (arrayInput[i].Length <= 3)
        {
            arrayOutput[j] = arrayInput[i];
            j++;
        }
    }
    return arrayOutput;
}

int NumberOfTrueValues(string[] arrayNum)
{
    int sum = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if (arrayNum[i].Length <= 3)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

int SizeArray(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    int answer = int.Parse(strMassive);
    return answer;
}

string Promt(string messsage)
{
    Console.Write(messsage);
    string answer = Console.ReadLine();
    return answer;
}

void FindArray(string[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = Promt($"Введи {index} эллемент массива = ");
    }
}

void FillArray(string[] collection, int colLen)
{
    Console.Write($"[ ");
    for (int index = 0; index < colLen - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.Write($"{collection[colLen - 1]} ]");
}