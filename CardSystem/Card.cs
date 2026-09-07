public abstract class Card
{
    public string Id = "";
    public double Balance;
    public double Bonus;

    private string _cardNumber = "";

    public string CardNumber
    {
        get => _cardNumber;
        set
        {
            if (value == null || value.Length != 16)
            {
                Console.WriteLine("Card number must contain exactly 16 digits!");
                return;
            }

            foreach (char num in value)
            {
                if (!char.IsDigit(num))
                {
                    Console.WriteLine("Card number must contain only digits!");
                    return;
                }
            }

            _cardNumber = value;
        }
    }

    public Bank Bank { get; set; }

    public Card(
        string id,
        double balance,
        double bonus,
        string cardNumber,
        Bank bank)
    {
        Id = id;
        Balance = balance;
        Bonus = bonus;
        CardNumber = cardNumber;
        Bank = bank;
    }

    public abstract bool WithDraw(double amount);
}

public enum Bank
{
    ABB,
    Kapital,
    Leo
}