// Находит пересячение 2х прямых. Это было сложно х_Х, не знаю почему.

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if
      (j==0) Console.Write("Введите коэффициент k: ");
      else 
      Console.Write("Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if 
  (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write( "Прямые совпадают!" );
  }
  else if 
  (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write("Прямые параллельны!!!!!!");
  }
  else 
  {
    Decision(coeff);
    Console.WriteLine(crossPoint[0]);
    Console.WriteLine(crossPoint[1]);
  }
}

InputCoefficients();
OutputResponse(coeff);
