// Задача 14: Найти третью цифру числа или сообщить, что её нет.
int GetRandom()
{
    int number = new Random().Next(0,200);
    return number;
}
int randomazer = GetRandom();
Console.WriteLine($"Случайное число: {randomazer}");
int result = randomazer / 10;
if(result >= 10)
{
    Console.WriteLine(randomazer % 10);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}