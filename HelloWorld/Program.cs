
Console.WriteLine("Добро пожаловать в анкету!");
Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();

Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш год рождения: ");
int birthYear = int.Parse(Console.ReadLine());

Console.Write("Введите ваш средний балл (например, 4.5): ");
double gpa = double.Parse(Console.ReadLine());

int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;

string status;
if (isExcellent == true) status = "Отличник";
else status = "Хорошист";
Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя:          {name} {surname}");
Console.WriteLine($"Группа:       {group}");
Console.WriteLine($"Возраст:      {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Статус:       {status}");
Console.WriteLine($"Лет до 30:    {30 - age}");

Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();