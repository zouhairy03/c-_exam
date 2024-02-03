using System;
using ConsoleTables;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Bank Application!");

        // Adding clients
        AddClients();

        // Adding comptes
        AddComptes();

        // Making transactions
        MakeTransactions();

        // Displaying clients, comptes, and transactions
        DisplayClients();
        DisplayComptes();
        DisplayTransactions();
    }

    // ... (same AddClients, AddComptes, MakeTransactions methods)

    static void DisplayClients()
    {
        var clients = BankOperations.GetClients();
        Console.WriteLine("\nClients in the database:");

        var table = new ConsoleTable("Client ID", "Name", "Address", "Phone");
        foreach (var client in clients)
        {
            table.AddRow(client.ClientId, $"{client.Nom} {client.Prenom}", client.Adresse, client.NumeroTelephone);
        }

        table.Write();
    }

    static void DisplayComptes()
    {
        var comptes = BankOperations.GetComptes();
        Console.WriteLine("\nComptes in the database:");

        var table = new ConsoleTable("Compte ID", "Client ID", "Solde", "TypeCompte", "DateOuverture");
        foreach (var compte in comptes)
        {
            table.AddRow(compte.CompteId, compte.ClientId, compte.Solde, compte.TypeCompte, compte.DateOuverture);
        }

        table.Write();
    }

    static void DisplayTransactions()
    {
        var transactions = BankOperations.GetTransactions();
        Console.WriteLine("\nTransactions in the database:");

        var table = new ConsoleTable("Transaction ID", "Compte ID", "TypeTransaction", "Montant", "DateTransaction");
        foreach (var transaction in transactions)
        {
            table.AddRow(transaction.TransactionId, transaction.CompteId, transaction.TypeTransaction, transaction.Montant, transaction.DateTransaction);
        }

        table.Write();
    }
}
