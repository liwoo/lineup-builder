using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineUp.Models;
using MauiReactor;

namespace LineUp.Pages;

internal class MainPageState
{
    public int Counter { get; set; }
}

internal class MainPage : Component<MainPageState>
{
    private readonly Player _player = new("Lionel Messi", 10, Nationality.Argentina, Position.Forward);

    public override VisualNode Render()
    {
        return new ContentPage
        {
            new ScrollView
            {
                new VerticalStackLayout
                    {
                        // new Image("dotnet_bot.png")
                        //     .HeightRequest(200)
                        //     .HCenter()
                        //     .Set(MauiControls.SemanticProperties.DescriptionProperty, "Cute dot net bot waving hi to you!"),

                        new PlayerListItem(_player),

                        // new Label("Hello, Liwu!")
                        //     .FontSize(32)
                        //     .HCenter(),
                        //
                        // new Label("Welcome to the Lineup App! Here we are going to test Hot Reload Properties!")
                        //     .FontSize(16)
                        //     .TextColor(Colors.Navy)
                        //     .HorizontalTextAlignment(TextAlignment.Center)
                        //     .HCenter(),
                        //
                        // new Button(State.Counter == 0 ? "Click me" : $"Pressed {State.Counter} times!")
                        //     .OnClicked(() => SetState(s => s.Counter++))
                        //     .HCenter()
                    }
                    .VCenter()
                    .Spacing(25)
                    .Padding(30, 0)
            }
        };
    }
}

internal class PlayerListItem(Player player) : Component
{
    public override VisualNode Render()
    {
        return new HStack(spacing: 12)
        {
            new Label(player.Number),
            
            new Label("Image"),

            new VStack
            {
                new Label(player.Name)
                    .FontSize(18),

                new Label(player.Nationality.ToString)
                    .FontSize(12),
            }
        };
    }
}