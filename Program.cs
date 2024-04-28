string[] array = {"123", "ABCD", "QWERty", "^-^", "V"};
string[] new_array = {};
foreach(string str in array)
{
    if (str.Length <= 3)
    {
        new_array.Append(str);
    }
}