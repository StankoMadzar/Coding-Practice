int CardColorEnumCount = Enum.GetNames(typeof(CardColor)).Length;
int CardRankEnumCount = Enum.GetNames(typeof(CardRank)).Length;
int deckSize = CardColorEnumCount * CardRankEnumCount;

Card[,] deck = new Card[CardColorEnumCount, CardRankEnumCount];


foreach (var color in Enum.GetValues(typeof(CardColor)))
    foreach (var rank in Enum.GetValues(typeof(CardRank)))
    {
        Card 
    }


//for (int i = 0; i < CardColorEnumCount; i++)
//    for (int j = 0; j < CardRankEnumCount; j++)
//    {
//        deck[i, j] = new Card()
//    }

public class Card
{
    public CardColor Color { get; }
    public CardRank Rank { get; }


    public Card (CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }



    bool IsFaceCard(Card CardToCheck)
    {
        int rank = (int)CardToCheck.Rank;
        if (rank <= 9)
            return true;

        return false;
    }
}

public enum CardColor { Red, Green, Blue, Yellow }
public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollarsign, Percent, Caret, Ampersand }