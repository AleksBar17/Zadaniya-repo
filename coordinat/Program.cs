Console.WriteLine("Введите номер четверти");
int numC = Convert.ToInt32(Console.ReadLine());
if (numC > 4) Console.WriteLine("Четверть состоит из номеров 1,2,3,4.Введите номер четверти повторно");
if (numC == 1) Console.WriteLine("Координаты 1 четврети: X > 0, Y > 0");
if (numC == 2) Console.WriteLine("Координаты 2й черверти: X < 0, Y > 0");
if (numC == 3) Console.WriteLine("Координаты 3й четверти: X < 0, Y < 0");
if (numC == 4) Console.WriteLine("Координаты 4й четверти: X > 0, Y < 0");