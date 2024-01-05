using LineUp.Models;
using MauiReactor;
using System.Collections.Generic;

namespace LineUp.Pages.Players.Widgets;

public class GroupedListItem(Position position, IEnumerable<Player> Players) : Component
{
    public override VisualNode Render()
    {
        return new VStack()
        {
             new Label(position.ToString())
             .FontSize(25)
             .FontAttributes(MauiControls.FontAttributes.Bold)
             .VerticalOptions(MauiControls.LayoutOptions.Center).Margin(0, 15, 0, 5),
            new CollectionView().ItemsSource(Players, PlayerListItem)
        };
    }

    private static VisualNode PlayerListItem(Player player)
    {
        return new PlayerListItem(player);
    }
}