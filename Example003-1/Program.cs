int numberA = new Random().Next(1,10); //вводим команду "новое случайное число в диапазоне от 1 до (10-1)" 
Console.WriteLine(numberA);//выводим какое было случайное первое число, также и со вторым
int numberB = new Random().Next(1,10); 
Console.WriteLine(numberB);
int result = numberA+numberB;
Console.WriteLine(result);