int numeroDigitado;

Console.Write("Numero digitado:");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Negativo!");

}
else if (numeroDigitado > 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Positivo!");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Zero!");
}
Console.ResetColor();