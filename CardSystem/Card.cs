public abstract class Card
{ 
    public string Id = "";
    public double Balance;
    public double Bonus;
    private string _cardNumber;
    public string CardNumber{
        get => _cardNumber;
        set{
            if(!(value.Length == 16)){
                Console.WriteLine("Mütləq 16 rəqəmdən ibarət olmalıdır!");
                return;
            }
            foreach(char num in value)
            {
                if(!char.IsDigit(num)){
                    System.Console.WriteLine("Must contain only digits!");
                    return;
                }
            }
            _cardNumber = value;
        }
    }
    public Bank Bank { get; set; }
    public Card(string id,  double balance, double bonus, string cardNumber,Bank bank)
    {
        Id = id;
        Balance = balance;
        Bonus = bonus;
        CardNumber = cardNumber;
        Bank = bank;

    }
    public abstract bool WithDraw(double amount);

   

}