Console.Write("Введите число: ");
string number = Console.ReadLine();

  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else if (number?.Length == 5)
  {
    Console.WriteLine($"Введи правильное число");
  }
  else 
  {
    Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
  }

