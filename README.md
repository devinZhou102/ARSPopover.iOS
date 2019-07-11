# ARSPopover.iOS
Universal popover for iPhone and iPad.

library from : https://github.com/soberman/ARSPopover

## Screen-Shots

<img src="images/img20190711150038.jpg" width = "50%" height = "50%"/>

## Example

```C#
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
```
