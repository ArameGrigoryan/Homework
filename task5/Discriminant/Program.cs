class Program {

    public static void QuadraticEquation(ref double a, ref double b, ref double c, out double x1, out double x2) {
         double discriminant = b * b - 4 * a * c;

        if (discriminant < 0) 
        {
            x1 = double.NaN;
            x2 = double.NaN;
            Console.WriteLine("Discriminant lesser 0");
            return;
        }
        x1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
        x2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));

    }   
    public static void Main(string[] args) {
        Console.Write("Enter an A parametr: ");
        double a = Convert.ToDouble(Console.ReadLine());
        if (a == 0) {
            Console.WriteLine("A cannot be 0");
            return;
        }

        Console.Write("Enter a B parametr: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an C parametr: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double x1;
        double x2;

        QuadraticEquation(ref a, ref b, ref c, out x1, out x2);

        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");

    }
}
