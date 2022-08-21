// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// использовать индексы строк






// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// // Добавить к формуле + (Z2-Z1) в кадрате

Console.Write("Введите координату по оси оX точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оZ точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оX точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оZ точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2));

Console.WriteLine($"Расстояние = {d:f2}");




// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//Вместо квадрата - КУБ

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= N; count++) Console.WriteLine(Math.Pow(count,3));

    
