// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int SumNum(int number)
{
  int result = 0;
  while (number != 0)
  {
    result = result + 1;
    number = number / 10;
  }
  return result;
}

int PromptNumber(string text)
{
  Console.WriteLine(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int number = PromptNumber("Введите число: ");
int res = SumNum(number);
Console.WriteLine(res);