using System;

public class Transaction
{
    public int TransactionId { get; set; }
    public int CompteId { get; set; }
    public string TypeTransaction { get; set; } = "";
    public decimal Montant { get; set; }
    public DateTime DateTransaction { get; set; }

    public override string ToString()
    {
        return $"Transaction ID: {TransactionId}, Compte ID: {CompteId}, TypeTransaction: {TypeTransaction}, Montant: {Montant}, DateTransaction: {DateTransaction}";
    }
}
