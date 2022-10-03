// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string InputString = Console.ReadLine();
    int value = Convert.ToInt32(InputString);
    return value;
}

int value = Prompt("Введите число >");
int square = value * value;
System.Console.WriteLine($"Квадрат числа {value} равен {square}");

