int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(1, 15));
Console.WriteLine(Sum(4, 8));