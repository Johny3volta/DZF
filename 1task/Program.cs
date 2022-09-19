//Сперва вводим кол-во чисел, потом вводим числа, программа вычисляет кол-во чисел больше нуля.

Console.Clear();
Console.Write("Введите количество чисел : ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write("Введите числа для проверки: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine(Comparison(massiveNumbers));