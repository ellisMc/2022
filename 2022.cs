using System.Collections.Generic;
string vowels = "aeiou";
string reverseVowels(string test)
{
    Stack<char> stack = new Stack<char>();
    foreach(char c in test)
    {
        if (vowels.Contains(c))
        {
            stack.Push(c);
        }
    }
    string s = "";
    foreach(char c in test)
    {
        if (vowels.Contains(c))
        {
            s += stack.Pop();
        }
        else
        {
            s += c;
        }
    }
    return s;
}

Console.WriteLine(reverseVowels("ate"));
Console.WriteLine(reverseVowels("pinkfairyarmadillo "));
