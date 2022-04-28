// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше или равна 3 символа.

string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer since" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

void ModfiedArry(string[] array)
{
    int temporal = 0;
    int i = 0;

    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            temporal++;
        }
        i++;
    }

    string[] newArray = new string[temporal];

    temporal = 0;
    int j = 0;

    while (j < array.Length)
    {
        if (array[j].Length <= 3)
        {
            newArray[temporal] = array[j];
            System.Console.Write(newArray[temporal] + " ");
        }
        j++;
    }
}

ModfiedArry(array1);
ModfiedArry(array2);
ModfiedArry(array3);

