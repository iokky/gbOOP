namespace gbOOP.ls5;

public class RationalNumber
{
    public double Numerator { get; }
    public double Denominator { get; }

    public RationalNumber(double numerator, double denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public static bool operator ==(RationalNumber lhs, RationalNumber rhs) => lhs.Numerator == rhs.Numerator && lhs.Denominator == rhs.Denominator;
    public static bool operator !=(RationalNumber lhs, RationalNumber rhs) => lhs.Numerator != rhs.Numerator || lhs.Denominator != rhs.Denominator;
    public static bool operator >(RationalNumber lhs, RationalNumber rhs) => lhs.Numerator > rhs.Numerator && lhs.Denominator > rhs.Denominator;
    public static bool operator <(RationalNumber lhs, RationalNumber rhs) => lhs.Numerator < rhs.Numerator && lhs.Denominator < rhs.Denominator;
    public static RationalNumber operator +(RationalNumber lhs, RationalNumber rhs) => new RationalNumber(lhs.Numerator + rhs.Numerator, lhs.Denominator + rhs.Denominator);
    public static RationalNumber operator -(RationalNumber lhs, RationalNumber rhs) => new RationalNumber(lhs.Numerator - rhs.Numerator, lhs.Denominator - rhs.Denominator);
    public static RationalNumber operator *(RationalNumber lhs, RationalNumber rhs) => new RationalNumber(lhs.Numerator * rhs.Numerator, lhs.Denominator * rhs.Denominator);
    public static RationalNumber operator /(RationalNumber lhs, RationalNumber rhs) => new RationalNumber(lhs.Numerator / rhs.Numerator, lhs.Denominator / rhs.Denominator);
    public static RationalNumber operator %(RationalNumber lhs, RationalNumber rhs) => new RationalNumber(lhs.Numerator % rhs.Numerator, lhs.Denominator % rhs.Denominator);
    public static RationalNumber operator ++(RationalNumber lhs) => new RationalNumber(lhs.Numerator + 1, lhs.Denominator + 1);
    public static RationalNumber operator --(RationalNumber lhs) => new RationalNumber(lhs.Numerator - 1, lhs.Denominator - 1);

    public override bool Equals(object? obj)
    {
        if (obj is RationalNumber && obj is not null)
        {
            RationalNumber? rhs = obj as RationalNumber;
            return this == rhs!;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (Numerator / Denominator).GetHashCode();
    }

    public override string ToString()
    {
        return $"{Numerator / Denominator}";
    }
}
