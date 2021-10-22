using System;

//Book class must be marked as Serializable
[Serializable]
public class Book : IComparable
{
    public string Title { get; set; }

    public int NumPages { get; set; }

    public double Price { get; set; }

    public Book()
    {
        Title = "";
        NumPages = 0;
        Price = 0;
    }
    public Book(string title, int pages, double price)
    {
        Title = title;
        NumPages = pages;
        Price = price;
    }
    public static Book operator +(Book first, Book second)
    {
        //Book newBook;
        const double EXTRA = 10.00;
        string newTitle = first.Title + " and " +
            second.Title;
        int newPages = first.NumPages + second.NumPages;
        double newPrice;
        if (first.Price > second.Price)
            newPrice = first.Price + EXTRA;
        else
            newPrice = second.Price + EXTRA;

        return (new Book(newTitle, newPages, newPrice));
    }

    int IComparable.CompareTo(Object o)
    {
        int returnVal;
        Book temp = (Book)o;
        if (this.Price > temp.Price)
            returnVal = 1;
        else
           if (this.Price < temp.Price)
            returnVal = -1;
        else
            returnVal = 0;
        return returnVal;
    }


}