
Console.Write("Введите ФИО: ");
var name = Console.ReadLine();

Console.Write("Введите дату рождения: ");
var dateOfBirth = Console.ReadLine();

Console.Write("Введите номер телефона: ");
var number = Console.ReadLine();

Console.Write("Введите почту: ");
var email = Console.ReadLine();

DateTime birthDate = DateTime.Parse(dateOfBirth);
DateTime currentDate = DateTime.Now;
int age = currentDate.Year - birthDate.Year;
if (currentDate.Month < birthDate.Month ||
(currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
{
    age--;
}


Console.WriteLine($"Привет {name}\nДата: {dateOfBirth}\nНомер: {number}\nПочта: {email}\nВаш возраст: {age}");