// Задача 19. Проверка пятизначного числа на полиндромность
Console.Clear();

string n = Console.ReadLine() ?? "";

if (n[0] == n[4] && n[1] == n[3])
{
    Console.Write("да");
}
else
    Console.Write("нет");

// Задача 21. Принимает координаты 2ух точек и находит расстояние в 3D  пространстве
Console.Clear();
int x1,y1,z1,x2,y2,z2;

x1 = Cords("Введите координату x первого числа: ");
y1 = Cords("Введите координату y первого числа: ");
z1 = Cords("Введите координату z первого числа: ");
x2 = Cords("Введите координату x второго числа: ");
y2 = Cords("Введите координату y второго числа: ");
z2 = Cords("Введите координату z второго числа: ");

double distanse = getdistance(x1,y1,z1,x2,y2,z2);
Console.WriteLine(distanse);

static int Cords(string message) // метод возвращает введеные пользователем координаты точек
{
    Console.Write(message); 
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double getdistance(int x1, int y1, int z1, int x2, int y2, int z2) //метод возвращает росстояние между точками
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
    return result;
}

// Задача 23. Напишите программу которая принимает число N и выдает таблицу кубов от 1 до N

int n = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{n} -> ");

for(int i = 1; i < n; i++)
{
    Console.Write($"{i*i*i}, ");
}

Console.Write(n*n*n); //Делаем красивый вывод, избавляясь от запятой на конце
