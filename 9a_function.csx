
// c# method / function
static void hello() 
{
  Console.WriteLine("Hello!");
}

hello();

// c# method / function with a parameter
static void hi(string nama) 
{
  Console.WriteLine("Hi " + nama);
}

hi("Andi");

// c# method / function with multiple parameters
static void lothere(string nama, int usia) 
{
  Console.WriteLine("Lo there " + nama + " you're " + usia);
}

lothere("Budi", 22);
lothere("Caca", 28);

// c# method / function with named parameters
static void ok(string nama, int usia, bool jomblo) 
{
  Console.WriteLine("Usia anda " + usia);
}

ok(usia:22, nama:"Zainul", jomblo:true);

// c# method / function with a default parameter value
static void hola(string nama = "amigos!") 
{
  Console.WriteLine("Hola " + nama);
}

hola();
hola("Deni");

// c# return function
static int kuadrat(int i) 
{
  return i * i;
}

int a = kuadrat(6);
int b = kuadrat(12);
Console.WriteLine(a);
Console.WriteLine(b);