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