using System;
using AvanadeLogin.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace AvanadeLogin.iOS.Views
{
    public partial class NewAccountView : MvxViewController<NewAccountViewModel>
    {
        public NewAccountView() : base("NewAccountView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

