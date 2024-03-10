namespace Ispit.Konzola.Sucelja;

public interface ITelefon
{
    public string Model { get; }
    public string Poziv(string telefonski_broj);

}