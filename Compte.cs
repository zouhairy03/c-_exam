using System;

public class Compte
{
    public int CompteId { get; set; }
    public int ClientId { get; set; }
    public decimal Solde { get; set; }
    public string TypeCompte { get; set; } = "";
    public DateTime DateOuverture { get; set; }

    public override string ToString()
    {
        return $"Compte ID: {CompteId}, Client ID: {ClientId}, Solde: {Solde}, TypeCompte: {TypeCompte}, DateOuverture: {DateOuverture}";
    }
}
