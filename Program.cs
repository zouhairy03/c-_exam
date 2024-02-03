// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Bank Application!\n");

        // Adding clients and comptes
        AddClientsAndComptes();

        // Making transactions
        MakeTransactions();

        // Displaying clients, comptes, and transactions
        DisplaySection("Clients in the database:", BankOperations.GetClients());
        DisplaySection("Comptes in the database:", BankOperations.GetComptes());
        DisplaySection("Transactions in the database:", BankOperations.GetTransactions());
    }

    static void AddClientsAndComptes()
    {
        // Adding a client
        Client newClient = new Client
        {
            Nom = "roe",
            Prenom = "nxnc",
            Adresse = "456 Oak St",
            NumeroTelephone = "233-5232"
        };

        BankOperations.AddClient(newClient);

        // Adding another client
        Client anotherClient = new Client
        {
            Nom = "alssa",
            Prenom = "aowew",
            Adresse = "789 jsjdds 22",
            NumeroTelephone = "555-222e"
        };

        BankOperations.AddClient(anotherClient);

        // Adding a compte for the first client
        Compte newCompte = new Compte
        {
            ClientId = 1,
            Solde = 1500.00m,
            TypeCompte = "Checking",
            DateOuverture = DateTime.Now
        };

        BankOperations.AddCompte(newCompte);

        // Adding a compte for the second client
        Compte anotherCompte = new Compte
        {
            ClientId = 2,
            Solde = 2000.00m,
            TypeCompte = "Savings",
            DateOuverture = DateTime.Now
        };

        BankOperations.AddCompte(anotherCompte);

        Console.WriteLine("Clients and comptes added successfully.\n");
    }

    static void MakeTransactions()
    {
        // Making a transaction for the first client
        Transaction newTransaction = new Transaction
        {
            CompteId = 1,
            TypeTransaction = "Withdrawal",
            Montant = 200.00m,
            DateTransaction = DateTime.Now
        };

        BankOperations.MakeTransaction(newTransaction);

        // Making a transaction for the second client
        Transaction anotherTransaction = new Transaction
        {
            CompteId = 2,
            TypeTransaction = "Deposit",
            Montant = 500.00m,
            DateTransaction = DateTime.Now
            
        };

        BankOperations.MakeTransaction(anotherTransaction);

        Console.WriteLine("Transactions made successfully.\n");
    }

    static void DisplaySection<T>(string title, IEnumerable<T> items)
    {
        Console.WriteLine($"\n{title}");
        if (items.Any())
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
        else
        {
            Console.WriteLine("No records found.");
        }
        Console.WriteLine(new string('-', 40) + "\n");
    }
}
