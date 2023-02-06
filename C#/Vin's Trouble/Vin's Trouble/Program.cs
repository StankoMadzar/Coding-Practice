Arrow arrow = GetArrow();
Console.WriteLine($"That arrow costs {arrow.GetCost()}");

Arrow GetArrow()
{
    ArrowHead arrowhead = GetArrowHeadType();
    Fletch fletching = GetFletchingType();
    float length = GetLength();

    return new Arrow(arrowhead, fletching, length);
}

ArrowHead GetArrowHeadType()
{
    Console.WriteLine("Choose from (steel, wood, obsidian)");
    string input = Console.ReadLine().ToLower();

    return input switch
    {
        "steel" => ArrowHead.Steel,
        "wood" => ArrowHead.Wood,
        "obisidan" => ArrowHead.Obisidan
    };
}

Fletch GetFletchingType()
{
    Console.WriteLine("Choose fletching from: plastic, turkey feather, goose feather");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "plastic" => Fletch.Plastic,
        "turkey feather" => Fletch.TurkeyFeathers,
        "goose feather" => Fletch.GooseFeathers
    };
}

float GetLength()
{
    float length = 0;
    while(length < 60 || length > 100)
    {
        Console.WriteLine("Arrow length between 60 and 100:");
        length = Convert.ToSingle(Console.ReadLine());
    }

    return length;
}

internal class Arrow
{
    private ArrowHead _head;
    private Fletch _fletch;
    private float _length;
    private float _fletchCostPerCM = 0.05f;

    public Arrow (ArrowHead head, Fletch fletch, float length)
    {
        _head = head;
        _fletch = fletch;
        _length = length;
    }   

    public ArrowHead GetArrowHeadType()
    {
        return _head;
    }

    public Fletch GetFletchType()
    {
        return _fletch;
    }

    public float GetArrowLength()
    {
        return _length;
    }

    public float GetFletchCostPerCM()
    {
        return _fletchCostPerCM;
    }

    public float GetCost()
    {
        float arrowheadCost = _head switch
        {
            ArrowHead.Steel => 10,
            ArrowHead.Wood => 3,
            ArrowHead.Obisidan => 5
        };

        float fletchingCost = _fletch switch
        {
            Fletch.Plastic => 10,
            Fletch.TurkeyFeathers => 5,
            Fletch.GooseFeathers => 3
        };

        float shaftCost = _length * _fletchCostPerCM;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}

enum ArrowHead { Steel, Wood, Obisidan }
enum Fletch { Plastic, TurkeyFeathers, GooseFeathers}