static string ReverseString(string str)
{
    char[] chars = str.ToCharArray();
    string strReverse = String.Empty;

    for(int i = chars.Length - 1; i >= 0; i--)
    {
        strReverse += chars[i];
    }
    return strReverse;
}

string valorString = "Coloque a string para reverter aqui!";
string reverseString = ReverseString(valorString);
Console.WriteLine(reverseString);
Console.ReadKey();