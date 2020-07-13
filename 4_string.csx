
string name = "Lintang Wisesa";
Console.WriteLine("My name is: " + name);
Console.WriteLine($"My name is: {name}");

Console.WriteLine("Jumlah karakter: " + name.Length);
Console.WriteLine("1st character: " + name[0]);
Console.WriteLine("Index huruf L: " + name.IndexOf("L"));

Console.WriteLine(name.Substring(8));
Console.WriteLine(name.Substring(name.IndexOf('W')));

Console.WriteLine("Uppercase: " + name.ToUpper());
Console.WriteLine("Lowercase: " + name.ToLower());   
