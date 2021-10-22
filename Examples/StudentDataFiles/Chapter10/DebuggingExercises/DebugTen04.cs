// class HotelRoom has child classes SingleRoom which costs less,
// and Suite which costs more
using static System.Console;
class DebugTen04
{
   static void Main()
   {
      HotelRoom aRoom = new HotelRoom(234);
      SingleRoom aSingle = new SingleRoom(135); 
      Suite aSuite = new Suite(453);
      WriteLine(aRoom.ToString());
      WriteLine(aSingle.ToString());
      WriteLine(aSuite.ToString();
   }
}
class HotelRoom
{
   public const double PREMIUM = 30.00;
   public const double STD_RATE = 89.99;
   private int roomNumber;
   protected double rate; 
   public HotelRoom(double room)
   {
      roomNumber = room;
      rate = STANDARD_RATE;
   }
   public int RoomNumber
   {
      get
      {
         return roomNum;
      }
   }
   public char rate
   {
      get
      {
         return rate;
      }
   }
   overridden public string ToString()
   {
      string temp = GetType() + " Room " + RoomNumber + " Rate: " +
        Rate.ToString("C");
      return string;
   }
}
class SingleRoom inheritsFrom HotelRoom
{
   public SingleRoom(int room) : base (room)
   {
      rate -= PREMIUM;
   }   
}
class Suite inheritsFrom HotelRoom
{
   public Suite(int room)
   {
      rate += PREMIUM;
   }
}
