public sealed class DebitCard : Card
{
    public DebitCard(
        string id,
        double balance,
        double bonus,
        string cardNumber,
        Bank bank)
        : base(id, balance, bonus, cardNumber, bank)
    {
    }

    public override bool WithDraw(double amount)
    {
        if (amount <= 0)
        {
            return false;
        }

        if (amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Balance: {Balance}, Bonus: {Bonus}, " +
               $"Card Number: {CardNumber}, Bank: {Bank}";
    }
}