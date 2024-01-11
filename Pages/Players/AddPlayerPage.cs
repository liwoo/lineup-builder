using System;
using System.Linq;
using MauiReactor;
using MauiReactor.Compatibility;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Entry = MauiReactor.Entry;
using NavigationPage = MauiReactor.NavigationPage;
using Picker = MauiReactor.Picker;

namespace LineUp.Pages.Players;

public class AddPlayerPage : Component
{
    public override VisualNode Render()
    {
        return new NavigationPage
            {
                new ContentPage
                    {
                        new ToolbarItem("Done").OnClicked(() => { Navigation?.PopModalAsync(); }).IsDestructive(true),

                        new Frame
                            {
                                new VStack(spacing: 10)
                                {
                                    new PlayerFormItem("Name"),
                                    new PlayerFormItem("Number", new Picker()
                                        .Title("Player Number")
                                        .ItemsSource(Enumerable.Range(1, 99).Select(x => x.ToString()).ToList())
                                        .VCenter()),
                                    new PlayerFormItem("Nationality"),
                                    new PlayerFormItem("Position"),
                                }
                            }
                            .BorderColor(Colors.Transparent)
                            .Padding(0)
                            .Margin(0, 80, 0, 0)
                            .VStart()
                    }
                    .Title("Add Player")
                    .Padding(10)
            }
            .BarTextColor(Colors.Black)
            .OniOS(page =>
                page.Set(MauiControls.PlatformConfiguration.iOSSpecific.Page.ModalPresentationStyleProperty,
                    UIModalPresentationStyle.Automatic));
    }
}

public class PlayerFormItem(string label, IVisualNodeWithAttachedProperties? control = null) : Component
{
    public override VisualNode Render()
    {
        return new Grid("*", ".4*, .6*")
            {
                new Label(label).FontSize(14).GridColumn(0).VCenter(),

                control == null
                    ? new Entry()
                        .Placeholder(label)
                        .VCenter()
                        .GridColumn(1)
                    : control.GridColumn(1)
            }
            .HeightRequest(50)
            .Padding(20, 5, 20, 5);
    }
}