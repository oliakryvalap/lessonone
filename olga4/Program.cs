﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая на вход принимает одно число (N), а выходе показывает все целые числа в промежутке от - N до N.
// "4 - > 4,-3,-2,-1,0,1,2,3,4"
// "2 -> -2,-1,0,1,2"

Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

int i = -a;

while(i<=a){
    
    Console.WriteLine(i);

    i++;
       
}
