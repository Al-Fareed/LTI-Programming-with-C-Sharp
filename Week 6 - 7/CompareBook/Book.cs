using System;
public class Book
{
    private string _title;
    private string _author;
    private double _amount;
    private int _noOfPages;

    public string Title{
        get=>_title;
        set => this._title = value;
    }public string Author{
        get=>_author;
        set => this._author = value;
    }public double Amount{
        get=>_amount;
        set => this._amount = value;
    }public int Pages{
        get=>_noOfPages;
        set => this._noOfPages = value;
    }
    public Book(string title, string author, double amount, int noOfPages)
    {
        _title = title;
        _author = author;
        _amount = amount;
        _noOfPages = noOfPages;
    }
    public int CompareBook(Book book1, Book book2){
        return book1._title.CompareTo(book2._title);
    }
}