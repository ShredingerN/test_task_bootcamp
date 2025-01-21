

class Triangle : Shape
{
    double SideA { get; }
    double SideB { get; }
    double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.SideA = sideA;
        this.SideB = sideB;
        this.SideC = sideC;
    }
    public override double CalculateArea()

    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC);
    }

    public bool RightTriangle()
    {
        List<double> sides = new List<double> { SideA, SideB, SideC };
        sides.Sort();
        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    
    }
}