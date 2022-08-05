// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
    class Program
    {
         static void Main(string[] args)
         {
            string[] mas = new string[7];
mas[0] = "abc";
mas[1] = "mama";
mas[2] = "-0,5";
mas[3] = "12345";
mas[4] = "0";
mas[5] = "0,7";
mas[6] = "()";
Console.WriteLine($"Исходный массив:[{mas[0]}  {mas[1]}  {mas[2]}  {mas[3]}  {mas[4]}  {mas[5]}  {mas[6]}]");
         {
        var result = new string[mas.Length];
var count = 0;
foreach (var value in mas)
{
    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
} 
Console.WriteLine("Итог работы программы: ");
Console.WriteLine(string.Join(Environment.NewLine, result, 0, count));
         }
      }
  }  
