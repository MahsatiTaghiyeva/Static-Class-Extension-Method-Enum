class Program
{
    static void Main()
    {
        DebitCard debit = new DebitCard(
            "D1",
            1000,
            0,
            "1234567890123456",
            Bank.ABB
        );

        CreditCard credit = new CreditCard(
            "C1",
            500,
            0,
            "9876543210987654",
            Bank.Kapital
        );

        credit.Limit = 1000;

        Console.WriteLine("----- DEBIT CARD -----");
        Console.WriteLine(debit);
        Console.WriteLine(debit.MaskCardNumber());

        Console.WriteLine("\n----- CREDIT CARD -----");
        Console.WriteLine(credit);
        Console.WriteLine(credit.MaskCardNumber());

        Console.WriteLine("\n----- WITHDRAW -----");

        Console.WriteLine(debit.WithDraw(200));
        Console.WriteLine($"Debit Balance: {debit.Balance}");

        Console.WriteLine(credit.WithDraw(800));
        Console.WriteLine($"Credit Balance: {credit.Balance}");
        Console.WriteLine($"Credit Limit: {credit.Limit}");

        Console.WriteLine("\n----- EXPENSE WITH BONUS -----");

        Console.WriteLine(debit.ExpenseWithBonus(100));
        Console.WriteLine($"Debit Bonus: {debit.Bonus}");

        Console.WriteLine(credit.ExpenseWithBonus(200));
        Console.WriteLine($"Credit Bonus: {credit.Bonus}");

        Console.WriteLine("\n----- CARD SERVICE -----");

        CardService service = new CardService();

        service.AddCard(debit);
        service.AddCard(credit);

        Card? searchCard = service.SearchCard("1234567890123456");

        Console.WriteLine(searchCard);

        Console.WriteLine("\n----- DUPLICATE CARD -----");

        service.AddCard(debit);
    }
}