using Foundation;
using UIKit;

namespace LineUp
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization",
                (handler, _) => { handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None; });

            Microsoft.Maui.Handlers.ContentViewHandler.Mapper.AppendToMapping("Surface",
                (handler, _) => { handler.PlatformView.BackgroundColor = UIKit.UIColor.SystemGray6; });

            //for picker
            Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping("MyCustomization",
                (handler, _) =>
                {
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
                    handler.PlatformView.TextColor = UIKit.UIColor.SystemBlue;
                    //prefer contextmenu over action sheet
                });

            //for button text color
            // Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping("MyCustomization",
            //     (handler, _) =>
            //     {
            //         handler.PlatformView.SetTitleColor(UIKit.UIColor.SystemBlue, UIKit.UIControlState.Normal);
            //     });
            
            //for toolbar item text color
            // Microsoft.Maui.Handlers.ToolbarHandler.Mapper.AppendToMapping("MyCustomization",
            //     (handler, _) =>
            //     {
            //         handler.PlatformView.TopItem.RightBarButtonItem?.SetTitleTextAttributes(new UIKit.UIStringAttributes()
            //         {
            //             ForegroundColor = UIKit.UIColor.SystemBlue
            //         }, UIKit.UIControlState.Normal);
            //     });

            return MauiProgram.CreateMauiApp();
        }
    }
}