using System;
enum Types { Накопляющий, Текущий };
public class Program
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        Random num = new Random();
        bank.n = num.Next(1, int.MaxValue);
        Console.WriteLine("Введите тип аккаунта: ");
        bank.t = Console.ReadLine();
        Console.WriteLine("Введите количество денег на счету: ");
        bank.q = int.Parse(Console.ReadLine());
        Console.WriteLine("Тип банковского аккаунта " + bank.t + ", номер счета " + bank.n + ", количество " + bank.q);
        Console.ReadKey();
    }
}
public class Bank
{
    private int number, count;
    private string type;
    public string t { get { return type; } set { type = value; } }
    public int n { get { return number; } set { number = value; } }
    public int q { get { return count; } set { count = value; } }
}