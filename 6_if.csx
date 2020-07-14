
// if statement
bool a = true;
if (a){
    Console.WriteLine("a == true");
}

// if else statement
int x = 12;
if(x < 10){
    Console.WriteLine("X kurang dari 10");
} else {
    Console.WriteLine("X lebih dari 10");
}

// if else if statement
int nilai = 92;
if (nilai > 90){
    Console.WriteLine("Awesome score!");
} else if (nilai > 70 && nilai <= 90){
    Console.WriteLine("Big score!");
} else if (nilai > 50 && nilai <= 70){
    Console.WriteLine("Cukuplah...");
} else {
    Console.WriteLine("Do it again!");
}

// ternary operator / short-hand if else
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);