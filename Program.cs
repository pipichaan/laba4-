Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
sum(n);
void sum(int c)
{
    int s = 0;
    for (int i = 0; i <= n; i += 2)
    {
        s = s + i;

    }
    Console.WriteLine(s);
}
proiz(n);

void proiz(int d)
        {
            int p = 1;
            for (int i = 1; i <= n; i += 2)
            {
                p = p * i;
            }
            Console.WriteLine(p);
        }
