﻿Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("");
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Deploy to: ");
Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.WriteLine($"({targetRow - 1}, {targetColumn})");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow + 1}, {targetColumn})");
Console.Beep(440, 1000);
Console.ReadKey(true);



