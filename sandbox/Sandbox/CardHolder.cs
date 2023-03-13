using System;

public class CardHolder
{
    private string _firstName;
    private string _lastName;
    private int _cardNumber;
    private int _PIN;
    private double _balance;

    public CardHolder(string firstName, string lastName, int cardNumber, int PIN, double balance)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._cardNumber = cardNumber;
        this._PIN = PIN;
        this._balance = balance;
    }

    public string GetFirstName()
    {
        return this._firstName;
    }

    public string GetLastName()
    {
        return this._lastName;
    }

    public int GetCardNumber()
    {
        return this._cardNumber;
    }

    public int GetPIN()
    {
        return this._PIN;
    }

    public double GetBalance()
    {
        return this._balance;
    }

    public void SetBalance(double balance)
    {
        this._balance = balance;
    }
}