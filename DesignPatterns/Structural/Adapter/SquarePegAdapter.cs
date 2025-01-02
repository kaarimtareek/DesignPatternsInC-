namespace DesignPatterns.Structural.Adapter;

public class SquarePegAdapter : IRoundPeg
{
   private readonly SquarePeg _squarePeg;

   public SquarePegAdapter(SquarePeg squarePeg) 
   {
      _squarePeg = squarePeg;
   }

   public int GetRadius()
   {
      return (int)(_squarePeg.Width *  (Math.Sqrt(2) / 2));
   }
}