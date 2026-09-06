
public sealed class CreditCard : Card
{
    private double _limit;
    public double Limit
    {
        get => _limit;
        set
        {
            if (!(value > 0))
            {
                Console.WriteLine("Limit must be positive!");
                return;
            }
            _limit = value;
        }
    }
    public CreditCard(string id, double balance, double bonus, string cardNumber, Bank bank) :base(id, balance, bonus, cardNumber, bank)
    {
        
    }
    public override bool WithDraw(double amount)
        {
        if (amount <= 0)
        {
            Console.WriteLine("Amount cannot be negative!");
            return false;
        }
        if (amount <= Balance)
        {
            Balance-= amount;
            return true;
        }
        else{
            double missingAmount = amount - Balance;
        if(missingAmount<= Limit)
            {
                Limit-= missingAmount;
                return true;
            }
        else
            return false;
            
             
        }}
}