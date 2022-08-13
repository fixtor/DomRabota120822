Console.Clear();
//первая точка
Console.WriteLine("Введите координату первой точки x");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки z");
int z1 = Convert.ToInt32(Console.ReadLine());

//вторая точка
Console.WriteLine("Введите координату второй точки x");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки y");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки z");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine($"d={d:f5}");