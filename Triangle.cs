

class Triangle : IShape
{
    int SideA { get; }
    int SideB { get; }
    int SideC { get; }

    public Triangle(int sideA, int sideB, int sideC)
    {
        this.SideA = sideA;
        this.SideB = sideB;
        this.SideC = sideC;
    }
    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool RightTriangle()
    {

        if (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(.SideC, 2))
        return true;
            
        
    }
}