
// nama function sama, namun beda parameters
static int PlusMethod(int x, int y)
{
  return x + y;
}

static double PlusMethod(double x, double y)
{
  return x + y;
}

Console.WriteLine(PlusMethod(1, 3));
Console.WriteLine(PlusMethod(12.1, 2.4));
Console.WriteLine(PlusMethod(1, 3.4));