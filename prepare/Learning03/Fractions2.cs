using System;

public class Fraction2
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction2()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction2(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

    public Fraction2(int topNumber2, int bottomNumber2)
    {
        _topNumber = topNumber2;
        _bottomNumber = bottomNumber2;
    }

    public string GetFractionString2()
    {
        string getFractionString = $"{_topNumber} / {_bottomNumber}";
        return getFractionString;
    }

    public double GetDecimalValue2()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}