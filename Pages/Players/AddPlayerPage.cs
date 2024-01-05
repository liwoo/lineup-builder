using MauiReactor;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using NavigationPage = MauiReactor.NavigationPage;

namespace LineUp.Pages.Players;

public class AddPlayerPage : Component
{
    public override VisualNode Render()
    {
        return new NavigationPage
            {
                new ContentPage
                    {
                        new ToolbarItem("Done").OnClicked(async () =>
                        {
                            await Navigation?.PopModalAsync()!;
                        }).IsDestructive(true),
                        
                        new Label("Add Player").Center()
                    }
                    .Title("Add Player")
            }
            .BarTextColor(Colors.Black)
            .OniOS(page =>
                page.Set(MauiControls.PlatformConfiguration.iOSSpecific.Page.ModalPresentationStyleProperty,
                    UIModalPresentationStyle.Automatic));
    }
}