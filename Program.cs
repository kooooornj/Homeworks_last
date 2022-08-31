string[] ThreeCharacters(string[] words)
{
    string[] result = new string[words.Length];

    int numelement = 0;

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            result[numelement] = words[i];
            numelement++;
        }
    }

    return result;
}

void ShowString(string[] words)
{
    for (int i = 0; i < words.Length; i++)
        Console.Write($"{words[i]}  ");
    Console.WriteLine();
}

string[] nani = { "ohayo", "hi", "Naruto", "pain", "si" };

ShowString(ThreeCharacters(nani));
