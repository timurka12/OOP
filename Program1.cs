using System;
enum Types{ Накопляющий, Текущий };
    public class Program
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        Console.WriteLine("Введите номер аккаунта: ");
        bank.number = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите тип аккаунта: ");
        bank.type = Console.ReadLine();
        Console.WriteLine("Введите количество денег на счету: ");
        bank.quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("Тип банковского аккаунта " + bank.type + ", номер счета " + bank.number + ", количество " + bank.quantity);
        Console.ReadKey();
    }
}
public class Bank
{
    private int amount , count;
    private string style;
    public string type { get { return style; } set { style = value; } }
    public int number { get { return amount; } set { amount = value; } }
    public int quantity { get { return count; } set { count = value; } }

    public override bool Equals(object obj)
    {
        return obj is Bank bank &&
               amount == bank.amount &&
               count == bank.count &&
               style == bank.style &&
               type == bank.type &&
               number == bank.number &&
               quantity == bank.quantity;
    }
}
