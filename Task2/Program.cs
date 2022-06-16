void NumberCount(int Number)
{
    int count = 0;
    while (Number != 0)
    {
        Number = Number / 10;
        count++;
    }
    System.Console.WriteLine(count);
}
NumberCount(2345);
NumberCount(234534343);
NumberCount(2);
