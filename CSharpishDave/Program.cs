// [!] Session 1 ------------------------------------------------------------------- //

// Task 1 & 2 --------------------------------- //
/*
Console.Write("Please, enter your name: ");
string? Name = Console.ReadLine();
Console.Write("Now enter the year you were born in: ");
int year = Convert.ToInt32(Console.ReadLine());
int age = 2024 - year;
Console.WriteLine("Hello, " + Name + "!");
Console.WriteLine("And you are " + age + ", years old!");
*/
// ------------------------------------------- //

// Task 3 ------------------------------------ //
/*
Console.WriteLine("A duck's quack does not echo.");
Console.WriteLine(false);
Console.WriteLine("You can use camel antibodies to help fight cancer. These are called \"nanobodies\"\nand are much smaller than regular antibodies.");
Console.WriteLine(true);
*/
// ------------------------------------------- //

// --------------------------------------------------------------------------------- //

// [!] Session 2 ------------------------------------------------------------------- //

// Task 1 ------------------------------------ //
/*
Console.Write("Enter the 1st number: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the 2nd number: ");
double y = Convert.ToDouble(Console.ReadLine());
double z = x + y;
Console.WriteLine("The sum of two numbers you provided is: " + z);
*/
// ------------------------------------------- //

// I accidentally finished the Task 2 of session 2, in the first one as I thought it was already asking us to add user input, not literally write "[your name]"

// Task 3 ------------------------------------ //
/*
Console.Write("Please enter the temperature in Celsius: ");
double Celsius = Convert.ToDouble(Console.ReadLine());
double Fahrenheit = (Celsius * 9 / 5) + 32;
double Kelvin = Celsius + 273.15;
Console.WriteLine("Your temperature in Fahrenheit: {0}", Fahrenheit);
Console.WriteLine("Your temperature in Kelvin: {0} {1}", Kelvin, Celsius);
*/
// ------------------------------------------- //

// Task 4 ------------------------------------ //
Console.Write("Enter the 1st number: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the 2nd number: ");
double y = Convert.ToDouble(Console.ReadLine());
double sum = x + y;
sum = Math.Round(sum, 2);
double multiply = x * y;
multiply = Math.Round(multiply, 2);
double subtract = x - y;
subtract = Math.Round(subtract, 2);
double divide = x / y;
divide = Math.Round(divide, 2);
Console.WriteLine($"The sum of x and y: {sum}, The multiplication of x and y: {multiply}, \nThe subtraction of x and y: {subtract}, and The division of x and y: {divide}");
// ------------------------------------------- //

// --------------------------------------------------------------------------------- //