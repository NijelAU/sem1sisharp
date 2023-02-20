//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double Promt(string message)
{
Console.Write(message);
double result = Convert.ToDouble(Console.ReadLine());
return result;
}

double xa = Promt ("Введите кординату точки A по оси x - ");
double ya = Promt ("Введите кординату точки A по оси y - ");
double za = Promt ("Введите кординату точки A по оси z - ");

double xb = Promt ("Введите кординату точки B по оси x - ");
double yb = Promt ("Введите кординату точки B по оси y - "); 
double zb = Promt ("Введите кординату точки B по оси z - "); 

 double Distance2D(double xa, double ya, double xb, double yb, double za, double zb)
{
double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - yb, 2) + Math.Pow(zb - za,2));
return Math.Round(distance, 2);
}

double result = Distance2D(xa, ya, xb, yb, za, zb);
System.Console.WriteLine(result);