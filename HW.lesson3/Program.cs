// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double R = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;
double power = Math.Pow(num2, num1);
double difference = power - sum;
double sqRoot = Math.Sqrt(difference);
double P = 2 * Math.PI * R;

Console.WriteLine(sum);
Console.WriteLine(power);
Console.WriteLine(difference);
Console.WriteLine(sqRoot);
Console.WriteLine(P);