// // адача №18. Работа в группах
// // Напишите программу, которая по заданному номеру 
// // четверти, показывает диапазон возможных 
// // координат точек в этой четверти (x и y).

// // Мое решение
// int Promt(string message)
// {
// Console.Write(message);
// int result = Convert.ToInt32(Console.ReadLine());
// return result;
// }

// int number = Promt("Введите четверть ->");

//     switch (number)
//     {
//         case 1:
//         Console.WriteLine("Диапазон x > 0 и y > 0");
//         break;
//         case 2:
//         Console.WriteLine("Диапазон x < 0 и y > 0");
//         break;
//         case 3:
//         Console.WriteLine("Диапазон x < 0 и y < 0");
//         break;
//         case 4: 
//         Console.WriteLine("Диапазон x > 0 и y > 0");
//         break;
//         default:
//         Console.WriteLine("Я не понимаю тебя");
//         break;
//     }

//Решение преподователя

int Promt(string message)
{
Console.Write(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

bool Checked(int quater)
{
if(quater >= 1 && quater <= 4)
{
return true;
}
else
{
return false;
}
}

string[] quaters ={"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};

int quater = Promt("Введите четверть: ");

if(Checked(quater))
{
Console.Write(quaters[quater - 1]);
}
else
{
Console.Write("Неправильный номер четверти");
}