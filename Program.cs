// Учебный проект для лекции «Командная работа с GitHub»
Console.Write("Как тебя зовут? ");
string? name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name)) name = "гость";
Console.WriteLine($"Привет, {name}! Это team-demo.");
