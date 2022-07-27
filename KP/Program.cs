// Создание массива вручную 
//создаем метод нахождения нужных элементов массива (БЛОК - СХЕМА), первый for 
//перебирает первый массив и в count записывает количество элементов, то есть длину нового массива.
//Второй цикл for перебирает первый массив и записывает подходящие элементы в новый массив. 
//Далее создаем метод вывода через строки ( как показывали на практикуме).
//Печать массива.

string[] input =
{"23", "лес", "каникулы", "333", "облако"};
Console.WriteLine(PrintArray(LetterArray(input)));

string[] LetterArray(string[] input)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = string.Empty;
        temp = input[i];
        if (temp.Length <= 3)
        {
            count++;
        }
    }
    string[] letArray = new string[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temporary = string.Empty;
        temporary = input[i];
        if (temporary.Length <= 3)
        {
            letArray[index] = temporary;
            index++;
        }
    }
    return letArray;


}


string PrintArray(string[] array)
{
    string letters = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        letters = letters + array[i] + " ";
    }
    return letters;

}
