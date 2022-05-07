using System;
Console.Clear();

/*  Дан текст. В тексте нужно все
пробелы заменить черточками, маленькие буквы
“к” заменить большими “К”, а большие “С”
заменить маленькими “с”.

Что нужно сделать первым делом? → Уточнить
задачу и понять, ясна ли задача. Что значит “Дан
текст”? Что значит “черточками”? Какого алфавита?
Маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими“*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласия прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012...
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);