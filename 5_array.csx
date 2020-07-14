
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
int[] myNum = {10, 2, 13, 9};

// element & length
Console.WriteLine(cars);
Console.WriteLine(cars[0]);
Console.WriteLine(cars[2]);
Console.WriteLine(cars.Length);

// sort
Array.Sort(cars);
Array.Sort(myNum);
Console.WriteLine(cars[0]);
Console.WriteLine(myNum[0]);

// max min sum
Console.WriteLine(myNum.Max());
Console.WriteLine(myNum.Min());
Console.WriteLine(myNum.Sum());

// ways to create array
string[] w = new string[4];
string[] x = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
string[] y = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
string[] z = {"Volvo", "BMW", "Ford", "Mazda"};