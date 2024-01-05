using System;
using System.Collections.Generic;
using System.Linq;
using LineUp.Models;
using LineUp.Pages.Players.Widgets;
using LineUp.Services;
using MauiReactor;
using Microsoft.Extensions.DependencyInjection;

namespace LineUp.Pages.Players;

public class PlayerListPageState
{
    public IEnumerable<Player> Players { get; set; } = [];

     public IEnumerable<IGrouping<Position, Player>> GetGroupedPlayers()
    {
        return Players.GroupBy(p => p.Position);
    }

}

public class PlayerListPage : Component<PlayerListPageState>
{
    private const string Team = "Arsenal";

    protected override void OnMounted()
    {
        var playerService = Services.GetRequiredService<IPlayerService>();
        State.Players = playerService.GetPlayers();
        base.OnMounted();
    }

    public override VisualNode Render()
    {
        var groupedPlayers = State.GetGroupedPlayers();
        return new NavigationPage
            {
                new ContentPage
                    {
                        new ToolbarItem("Add Player").OnClicked(async () =>
                        {
                             await Navigation?.PushModalAsync<AddPlayerPage>()!;
                        }),

                        groupedPlayers.Any()
                            ? new ScrollView
                            {
                                groupedPlayers.Select(group =>new GroupedListItem(group.Key, group.ToList()
                                    )).ToArray(),
                            }
                            : new Label("No players found").Center()
                    }
                    .Set(MauiControls.Page.TitleProperty, Team)
                    .Padding(15, 5)
            }
            .BarBackgroundColor(Colors.Red)
            .BarTextColor(Colors.White);
    }

    private static VisualNode PlayerListItem(Player player)
    {
        return new PlayerListItem(player);
    }
}

