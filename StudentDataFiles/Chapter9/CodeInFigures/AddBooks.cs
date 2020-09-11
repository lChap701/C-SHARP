using static System.Console;
class AddBooks
{
   static void Main()
   {
      Book book1 = new Book("Silas Marner", 350, 15.95);
      Book book2 = new Book("Moby Dick", 250, 16.00);
      Book book3;
      book3 = book1 + book2;
      WriteLine("The new book is \"{0}\"", book3.Title);
      WriteLine("It has {0} pages and costs {1}",
         book3.NumPages, book3.Price.ToString("C"));
   }
}
class Book
{
   public Book(string title, int pages, double price)
   {
      Title = title;
      NumPages = pages;
      Price = price;
   }
   public static Book operator+(Book first, Book second)
   {
      const double EXTRA = 10.00;
      string newTitle = first.Title + " and " +
         second.Title;
      int newPages = first.NumPages + second.NumPages;
      double newPrice;
      if(first.Price > second.Price)
        newPrice = first.Price + EXTRA;
      else
        newPrice = second.Price + EXTRA;
      return(new Book(newTitle, newPages, newPrice));
   }
   public string Title {get; set;}

   public int NumPages {get; set;}

   public double Price {get; set;}
}
