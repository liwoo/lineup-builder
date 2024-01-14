using LineUp.Models;
using MauiReactor;

namespace LineUp.Pages.Players.Widgets;

public class PlayerListItem(Player player) : Component
{
    public override VisualNode Render()
    {
        return new SwipeView
        {
             new VStack()
        {
            new Grid("*", ".1*, .25*, .6*, .05*")
            {
                new Label(player.Number)
                    .FontSize(16)
                    .FontAttributes(MauiControls.FontAttributes.Bold)
                    .VerticalOptions(MauiControls.LayoutOptions.Center)
                    .GridColumn(0),

                new Image("dotnet_bot.png")
                    .HeightRequest(100)
                    .HCenter()
                    .Set(MauiControls.SemanticProperties.DescriptionProperty, "Cute dot net bot waving hi to you!")
                    .GridColumn(1),

                new VStack
                    {
                        new Label(player.Name)
                            .FontSize(16)
                            .FontAttributes(MauiControls.FontAttributes.Bold),

                        new Label(player.Nationality.ToString)
                            .FontSize(12),
                    }
                    .VerticalOptions(MauiControls.LayoutOptions.Center)
                    .GridColumn(2),

                new Label("→")
                    .FontSize(12)
                    .VerticalOptions(MauiControls.LayoutOptions.Center)
                    .GridColumn(3),
            }.BackgroundColor(Colors.White).Padding(10),
            BoxView()
                .Color(Colors.Silver)
                .Margin(0, 0, 0, 0)
                .HeightRequest(1)
        }
            .VCenter()
        }
        .LeftItems(new SwipeItems
        {
            new SwipeItem()
                //.IconImageSource("delete.png")
                .Text("Delete")
                .BackgroundColor(Colors.Red)
                //.OnInvoked(()=>State.Persons.Remove(person))
        });
    }
}