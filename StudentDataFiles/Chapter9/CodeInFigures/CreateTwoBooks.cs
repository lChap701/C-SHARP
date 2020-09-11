using static System.Console;
class CreateTwoBooks
{
   static void Main()
   {
      Book myBook = new Book();
      Book yourBook = new Book();
      myBook.Title = "Silas Marner";
      yourBook.Title = "The Time Traveler's Wife";
      myBook.AdvertisingMessage();
      yourBook.AdvertisingMessage();
   }
}
class Book
{
   private string title;
   private int numPages;
   private double price;
   public string Title
   {
     get
     {
        return this.title;
     }
     set
     {
        this.title = value;
     }
   }
   public void AdvertisingMessage()
   {
      WriteLine("Buy it now: {0}", this.Title);
   }
}
