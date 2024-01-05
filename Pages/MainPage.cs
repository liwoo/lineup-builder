using System.Collections.Generic;
using System.Linq;
using LineUp.Models;
using LineUp.Pages.Players;
using LineUp.Services;
using MauiReactor;
using Microsoft.Extensions.DependencyInjection;
using Label = MauiReactor.Label;

namespace LineUp.Pages;


internal class MainPage : Component
{
    protected override void OnMounted()
    {
        Routing.RegisterRoute<AddPlayerPage>("add-player");
        base.OnMounted();
    }

    public override VisualNode Render() => new PlayerListPage();
}



