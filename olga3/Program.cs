﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());

switch (a) {
    case 1: 
       Console.WriteLine("Monday");  
       break;   
       case 2: 
       Console.WriteLine("Tuesday");  
       break;  
       case 3: 
       Console.WriteLine("Wednesday");  
       break;  
       case 4: 
       Console.WriteLine("Thursday");  
       break;   
       case 5: 
       Console.WriteLine("Friday");  
       break;   
       case 6: 
       Console.WriteLine("Saturday");  
       break;   
       case 7: 
       Console.WriteLine("Sunday");  
       break;   
    default:
       Console.WriteLine("There is no such a weekday");
       break;  
}
