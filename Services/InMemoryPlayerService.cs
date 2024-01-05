using System.Collections.Generic;
using LineUp.Models;

namespace LineUp.Services;

public interface IPlayerService
{
    IEnumerable<Player> GetPlayers();
}

public class InMemoryPlayerService : IPlayerService
{
    public IEnumerable<Player> GetPlayers()
    {
        return
        [
            new Player("David Raya", 13, Nationality.Spain, Position.Goalkeeper),
            new Player("Ben White", 4, Nationality.England, Position.Defender),
            new Player("William Saliba", 2, Nationality.France, Position.Defender),
            new Player("Gabriel Maghalleas", 5, Nationality.Brazil, Position.Defender),
            new Player("Oleksander Zinchenko", 34, Nationality.Ukraine, Position.Defender),
            new Player("Declan Rice", 39, Nationality.England, Position.Midfielder),
            new Player("Kai Havertz", 29, Nationality.Germany, Position.Midfielder),
            new Player("Martin Odegaard", 10, Nationality.Norway, Position.Midfielder),
            new Player("Bukayo Saka", 7, Nationality.England, Position.Forward),
            new Player("Gabriel Martinelli", 11, Nationality.Brazil, Position.Forward),
            new Player("Gabriel Jesus", 9, Nationality.Brazil, Position.Forward),
        ];
    }
}