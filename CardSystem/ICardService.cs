public interface ICardService
{
    void AddCard(Card card);

    Card? SearchCard(string cardNumber);
}