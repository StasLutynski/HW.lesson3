// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ведите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите радиус окружности");
double R = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;
double power = Math.Pow(num2, num1);
double difference = power - sum;
double sqRoot = Math.Sqrt(difference);
double P = 2 * Math.PI * R;

Console.WriteLine(num1 + " + " + num2 + " = " + sum);
Console.WriteLine(num2 + " в степени " + num1 + " = " + power);
Console.WriteLine(power + " - " + sum + " = " +difference);
Console.WriteLine("Квадратный корень из " + difference + " - " + sqRoot);
Console.WriteLine("Длина окружности с радиусом " + R + " - " + P);
