using Foundation;
using System;
using UIKit;

namespace ARSPopoverDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
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

        partial void UIButton197_TouchUpInside(UIButton sender)
        {
            ARSPopover.iOS.ARSPopover popover = new ARSPopover.iOS.ARSPopover();
            popover.SourceView = sender;
            popover.ContentSize = new CoreGraphics.CGSize(100, 100);
            popover.ArrowDirection = UIPopoverArrowDirection.Down;

            PresentViewController(popover, true, new Action(()=> {
                popover.InsertContentIntoPopover((a,b,c)=> {
                    var button = new UIButton(UIButtonType.RoundedRect);
                    button.SetTitle("Close", UIControlState.Normal);
                    button.SizeToFit();
                    button.Center = new CoreGraphics.CGPoint(50,50);
                    a.View.AddSubview(button);
                    button.AddTarget((s,e) => { popover.ClosePopover(); }, UIControlEvent.TouchUpInside);
                });
            }));
        }
    }
}