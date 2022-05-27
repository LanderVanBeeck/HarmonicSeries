int i, n;
double s = 0.0;

Console.WriteLine("input: ");
n = Convert.ToInt32(Console.ReadLine());
for ( i = 1; i <= n; i++)
{
    Console.Write("1/{0} + ", i);
    s += 1 / (float)i;
}
Console.Write("\ninput {0} returns output {1} \n", n, s.ToString("0.0000"));