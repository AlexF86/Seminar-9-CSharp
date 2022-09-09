void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}
PrintNumber(1, 5);
PrintNumber(4, 8);