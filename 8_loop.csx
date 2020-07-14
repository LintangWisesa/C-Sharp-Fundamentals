
// for loop
for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}

for (int i = 0; i <= 10; i += 2) 
{
  Console.WriteLine(i);
}

// foreach
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}

// while loop
int i = 0;
while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}

// do while loop
int j = 0;
do 
{
  Console.WriteLine(j);
  j++;
}
while (j < 5);

// break
for (int k = 0; k < 10; k++) 
{
  if (k == 4) 
  {
    break;
  }
  Console.WriteLine(k);
}

// continue
for (int l = 0; l < 10; l++) 
{
  if (l == 4) 
  {
    continue;
  }
  Console.WriteLine(l);
}