abstract class ParentAbs
{
   public abstract int doubleSum(int num1, int num2);
   public void show(string text){
      Console.WriteLine(text);
   }
}


class ChildTwo : ParentAbs
{
   public override int doubleSum(int num1, int num2)
   {
      return num1+num2*2;
   }
}
