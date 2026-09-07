public static class CardExtensions
{
    public static string MaskCardNumber(this Card card)
    {
        return $"{card.CardNumber[..4]} **** **** {card.CardNumber[^4..]}";
    }

    public static bool ExpenseWithBonus(this Card card, double amount)
    {
        bool result = card.WithDraw(amount);

        if (!result)
        {
            return false;
        }

        switch (card.Bank)
        {
            case Bank.ABB:
                card.Bonus += amount * 0.02;
                break;

            case Bank.Leo:
                card.Bonus += amount * 0.04;
                break;

            case Bank.Kapital:
                card.Bonus += amount * 0.05;
                break;
        }

        return true;
    }
}