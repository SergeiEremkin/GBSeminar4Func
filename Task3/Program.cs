void MultiNumbers(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result * i;
    }
    System.Console.WriteLine(result);
}
MultiNumbers(2);
MultiNumbers(10);