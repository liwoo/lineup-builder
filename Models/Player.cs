namespace LineUp.Models;

public enum Nationality
{
    England,
    Argentina,
    France,
    Germany,
    Spain,
    Nigeria,
    Brazil,
    Ukraine,
    Norway
}

public enum Position
{
    Goalkeeper,
    Defender,
    Midfielder,
    Forward,
}

public record Player(string Name, int Number, Nationality Nationality, Position Position);