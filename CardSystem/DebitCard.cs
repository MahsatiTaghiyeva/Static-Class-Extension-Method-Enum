
public sealed class DebitCard : Card
{
    public DebitCard(string id, double balance, double bonus, string cardNumber, Bank bank) :base(id, balance, bonus, cardNumber, bank)
    {
        public override bool WithDraw(double amount)
        {   
            if(amount<=Balance ||amount<=0){
                return false;
            }
            Balance-= amount;
            return true; 
        }
    }
}