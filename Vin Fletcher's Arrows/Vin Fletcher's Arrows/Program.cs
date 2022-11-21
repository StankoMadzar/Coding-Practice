Console.WriteLine("Choose your arrowhead type. Steel, wood or obisidian?");
string input = Console.ReadLine().ToLower();

ArrowHead HeadType = input switch
{
    "steel" => ArrowHead.Steel,
    "wood" => ArrowHead.Wood,
    "obisidan" => ArrowHead.Obsidian
};


Console.WriteLine("Choose your fletch type. Plastic, turkey feathers or goose feathers?");
input = Console.ReadLine().ToLower();
Fletch FletchType = input switch
{
    "plastic" => Fletch.Plastic,
    "turkey feathers" => Fletch.Turkey_Feathers,
    "goose feathers" => Fletch.Goose_Feathers
};


int ShaftLength;

while (true)
{
    Console.WriteLine("Choose your shaft length, anywhere from 60cm to 100cm.");
    ShaftLength = Convert.ToInt32(Console.ReadLine());
    if (ShaftLength <= 100 && ShaftLength >= 60)
        break;
}


Arrow FirstArrow = new (HeadType, FletchType, ShaftLength);
float valueOfEntireArrow = FirstArrow.GetCost();
Console.WriteLine($"Your arrow costs {valueOfEntireArrow} gold.");

class Arrow
{
    ArrowHead _arrowHeadType;
    Fletch _fletchType;
    int _length;
    float _fletchCostperCM = 0.05f;

    public Arrow(ArrowHead arrowHeadtype, Fletch fletchType, int length)
    {
        _arrowHeadType = arrowHeadtype;
        _fletchType = fletchType;
        _length = length;
    }

    public float GetCost()
    {
        int arrowHeadValue = (int)_arrowHeadType;
        int fletchValue = (int)_fletchType;
        float shaftValue = _length * _fletchCostperCM;
        return arrowHeadValue + fletchValue + shaftValue;
    }
}


enum ArrowHead { Steel = 10, Wood = 3, Obsidian = 5 }
enum Fletch { Plastic = 10, Turkey_Feathers = 5, Goose_Feathers = 3 }