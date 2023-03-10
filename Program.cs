void Proverka(string[] array, string[] array2)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[i] = array[i];
        }
    }
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];
string[] array2 = new string[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

Proverka(array, array2);