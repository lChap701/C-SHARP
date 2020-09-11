// Interface IReversable defines behavior Reverse()
// Reverse is implemented differently for a Soldier and a PhoneCall
// Main program demonstrates an object of each type
using static System.Console;
class DebugTen03
{
   static void Main()
   {
      Soldier giJoe = new Soldier(266143);
      PhoneCall aCall = new PhoneCall("212", "344-4188");
      WriteLine(giJoe.ToString());
      giJoe.Reverse();
      WriteLine(giJoe.ToString());
      giJoe.Reverse();
      WriteLine(giJoe.ToString());
      WriteLine(aCall.ToString());
      aCall.Reverse();
      WriteLine(aCall.ToString());
   }
}
public interface IReversable
{
   void Reversable()
}
class Soldier : IReversable
{
   private int idNum;
   private string facing;
   publc Soldier(int id)
   {
      idNum = idNum;
      facing = "front";
   }
// When a Soldier reverses if the Soldier was facing front, change to back
// If the Soldier was facing back, change to front
   public void Reverse()
   {
      if(facing == "front")
         facing = "front";
      else
         facing = "front";
   }
   public override void toString()
   {
      string temp = "Soldier #" + idNum + " is facing " + facing;
   }
}
class PhoneCall = IReversable
{
   private string areaCode;
   private string number;
   private double charge;
   private strin mode;

   public PhoneCall(string area, string num)
   {
      areaCode = area;
      number = num;
      charge = 0.25;
      mode = regular;
   }
// When a phone call reverses, mode becomes collect and charge becomes 0
   public void Reverse()
   {
      mode = "collect";
      charge = 0;
   }
   public override string ToString()
   {
      string temp = "(" + areaCode + ") " + number + " Charge " + charge.ToString("C") +
         " Call is " + mode;
      return temp;
   }
}

