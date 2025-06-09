using System;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        string[] part = str.Split(" ");
        for (int i = 0; i < part.Length; i++)
        {
            string original = part[i];
            char[] chars = original.ToCharArray();
            Array.Reverse(chars);
            part[i] = new string(chars); // Gán lại chuỗi đã đảo ngược
        }
        return string.Join(" ", part);
    }
}
