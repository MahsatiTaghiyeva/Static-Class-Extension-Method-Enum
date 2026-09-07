public class CardService : ICardService
{
    private static Card[] cards = new Card[0];

    public void AddCard(Card card)
    {
        foreach (Card item in cards)
        {
            if (item.CardNumber == card.CardNumber)
            {
                Console.WriteLine("This card number already exists!");
                return;
            }
        }

        Array.Resize(ref cards, cards.Length + 1);
        cards[^1] = card;

        Console.WriteLine("Card added successfully!");
    }

    public Card? SearchCard(string cardNumber)
    {
        foreach (Card card in cards)
        {
            if (card.CardNumber == cardNumber)
            {
                return card;
            }
        }

        Console.WriteLine("Card not found!");
        return null;
    }
}