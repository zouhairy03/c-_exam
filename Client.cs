using System;

public class Client
{
    public int ClientId { get; set; }
    public string Nom { get; set; } = "";
    public string Prenom { get; set; } = "";
    public string Adresse { get; set; } = "";
    public string NumeroTelephone { get; set; } = "";
    // Constructeur par défaut
 
    public override string ToString()
    {
        return $"Client ID: {ClientId}, Name: {Nom} {Prenom}, Address: {Adresse}, Phone: {NumeroTelephone}";
    }
}
