void OOO(string text)
{
if (string.IsNullOrEmpty(text))
{
    Console.WriteLine("Пустая строка");
    return; 
}
Console.WriteLine(text);
}


int Sum(int x, int y)
{
    return x + y;
}

OOO("");
OOO("Теперь не пустая строка");
int result = Sum(5, 8);
OOO(result.ToString());