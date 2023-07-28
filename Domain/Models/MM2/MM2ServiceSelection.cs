using Domain.Dtos;

namespace Domain.Models.MM2;

public class MM2ServiceSelection : MM2
{
    public MM2ServiceSelection(MM2InputsDto inputs) : base(inputs)
    {
    }

    protected override void CalculateMetrics()
    {
        var r = SecondServiceValue / ServiceValue;
        var x1x2 = MakeQuadraticFormula(r);
        P = x1x2.Item1 < x1x2.Item2 ? x1x2.Item1 : x1x2.Item2;
        var a = (2 * ArriveValue + FullServiceValue) * (ServiceValue * SecondServiceValue) / FullServiceValue * (ArriveValue + SecondServiceValue);
        P0 = (1 - P) / (1 - P + (ArriveValue / a));
        Ls = ArriveValue / (1 - P) * (ArriveValue + (1 - P) * a);
        CalculateBaseMM2Metrics();
    }

    private Tuple<double, double> MakeQuadraticFormula(double r)
    {
        var aFactor = 1 + Math.Pow(r, 2);
        var bFactor = -(2 + Math.Pow(r, 2));
        var cFactor = -(2 * r - 1) * (1 + r);
        var discriminant = Math.Pow(bFactor, 2) - 4 * aFactor * cFactor;
        var x1 = (-bFactor - Math.Sqrt(discriminant)) / 2 * aFactor;
        var x2 = (-bFactor + Math.Sqrt(discriminant)) / 2 * aFactor;
        return new(x1, x2);
    }
}
