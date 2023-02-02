// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumber(string text)
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int collection)
{
    return new int[collection];
}

void GetProd(int[] figure)
{
    int sum = 0;
    int count = figure.Length;

    for (int i = 0; i < count; i++) ;
    {
        if (figure[i] > 0)
        {
            sum++;
        }
    }
}

string PrintArray(int[] origine)
{
    string output = String.Empty;
    int size = origine.Length;

    for (int i = 0; i < size; i++)
    {
        output = output + $"{origine[i]}";

    }
    return output;
}
