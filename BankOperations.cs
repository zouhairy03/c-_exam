using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public static class BankOperations
{
    private const string ConnectionString = "Server=localhost;Port=8889;Database=BankDatabase;User=root;Password=root;";

    public static void AddClient(Client client)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Clients (Nom, Prenom, Adresse, NumeroTelephone) VALUES (@Nom, @Prenom, @Adresse, @NumeroTelephone)";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Nom", client.Nom);
                    cmd.Parameters.AddWithValue("@Prenom", client.Prenom);
                    cmd.Parameters.AddWithValue("@Adresse", client.Adresse);
                    cmd.Parameters.AddWithValue("@NumeroTelephone", client.NumeroTelephone);

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Client added successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding client: {ex.Message}");
        }
    }

    public static void AddCompte(Compte compte)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Comptes (ClientId, Solde, TypeCompte, DateOuverture) VALUES (@ClientId, @Solde, @TypeCompte, @DateOuverture)";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ClientId", compte.ClientId);
                    cmd.Parameters.AddWithValue("@Solde", compte.Solde);
                    cmd.Parameters.AddWithValue("@TypeCompte", compte.TypeCompte);
                    cmd.Parameters.AddWithValue("@DateOuverture", compte.DateOuverture);

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Compte added successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding compte: {ex.Message}");
        }
    }

    public static void MakeTransaction(Transaction transaction)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Transactions (CompteId, TypeTransaction, Montant, DateTransaction) VALUES (@CompteId, @TypeTransaction, @Montant, @DateTransaction)";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@CompteId", transaction.CompteId);
                    cmd.Parameters.AddWithValue("@TypeTransaction", transaction.TypeTransaction);
                    cmd.Parameters.AddWithValue("@Montant", transaction.Montant);
                    cmd.Parameters.AddWithValue("@DateTransaction", transaction.DateTransaction);

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Transaction made successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error making transaction: {ex.Message}");
        }
    }

    public static List<Client> GetClients()
    {
        List<Client> clients = new List<Client>();

        try
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Clients";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client
                            {
                                ClientId = Convert.ToInt32(reader["ClientId"]),
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Adresse = reader["Adresse"].ToString(),
                                NumeroTelephone = reader["NumeroTelephone"].ToString()
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving clients: {ex.Message}");
        }

        return clients;
    }

    public static List<Compte> GetComptes()
    {
        List<Compte> comptes = new List<Compte>();

        try
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Comptes";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comptes.Add(new Compte
                            {
                                CompteId = Convert.ToInt32(reader["CompteId"]),
                                ClientId = Convert.ToInt32(reader["ClientId"]),
                                Solde = Convert.ToDecimal(reader["Solde"]),
                                TypeCompte = reader["TypeCompte"].ToString(),
                                DateOuverture = Convert.ToDateTime(reader["DateOuverture"])
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving comptes: {ex.Message}");
        }

        return comptes;
    }

    public static List<Transaction> GetTransactions()
    {
        List<Transaction> transactions = new List<Transaction>();

        try
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Transactions";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactions.Add(new Transaction
                            {
                                TransactionId = Convert.ToInt32(reader["TransactionId"]),
                                CompteId = Convert.ToInt32(reader["CompteId"]),
                                TypeTransaction = reader["TypeTransaction"].ToString(),
                                Montant = Convert.ToDecimal(reader["Montant"]),
                                DateTransaction = Convert.ToDateTime(reader["DateTransaction"])
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving transactions: {ex.Message}");
        }

        return transactions;
    }
}