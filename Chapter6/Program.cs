namespace Chapter6;

public class Program
{
    static void Main(string[] args)
    {
        var myBoard = new BoardFromBook(10, 10);
        var myUnit = new Unit(1000);

        myBoard.AddUnit(myUnit, 1, 10);

        var allUnitsAtPosition = myBoard.GetUnits(2, 1);
        Console.WriteLine("All units at position (2, 1): " + allUnitsAtPosition);
    }
}