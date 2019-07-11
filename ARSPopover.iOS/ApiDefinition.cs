using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace ARSPopover.iOS
{

    // @protocol ARSPopoverDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ARSPopoverDelegate
    {
        // @optional -(void)popoverPresentationController:(UIPopoverPresentationController *)popoverPresentationController willRepositionPopoverToRect:(CGRect *)rect inView:(UIView **)view;
        [Export("popoverPresentationController:willRepositionPopoverToRect:inView:")]
        unsafe void PopoverPresentationController(UIPopoverPresentationController popoverPresentationController, CGRect rect, out UIView view);

        // @optional -(BOOL)popoverPresentationControllerShouldDismissPopover:(UIPopoverPresentationController *)popoverPresentationController;
        [Export("popoverPresentationControllerShouldDismissPopover:")]
        bool PopoverPresentationControllerShouldDismissPopover(UIPopoverPresentationController popoverPresentationController);

        // @optional -(void)popoverPresentationControllerDidDismissPopover:(UIPopoverPresentationController *)popoverPresentationController;
        [Export("popoverPresentationControllerDidDismissPopover:")]
        void PopoverPresentationControllerDidDismissPopover(UIPopoverPresentationController popoverPresentationController);
    }

    // @interface ARSPopover : UIViewController
    [BaseType(typeof(UIViewController))]
    interface ARSPopover
    {
        [Wrap("WeakDelegate")]
        ARSPopoverDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ARSPopoverDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) UIPopoverArrowDirection arrowDirection;
        [Export("arrowDirection", ArgumentSemantic.Assign)]
        UIPopoverArrowDirection ArrowDirection { get; set; }

        // @property (nonatomic, weak) UIView * sourceView;
        [Export("sourceView", ArgumentSemantic.Weak)]
        UIView SourceView { get; set; }

        // @property (assign, nonatomic) CGRect sourceRect;
        [Export("sourceRect", ArgumentSemantic.Assign)]
        CGRect SourceRect { get; set; }

        // @property (assign, nonatomic) CGSize contentSize;
        [Export("contentSize", ArgumentSemantic.Assign)]
        CGSize ContentSize { get; set; }

        // @property (nonatomic, strong) UIColor * backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) NSArray * passthroughViews;
        [Export("passthroughViews", ArgumentSemantic.Strong)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] PassthroughViews { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets popoverLayoutMargins;
        [Export("popoverLayoutMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets PopoverLayoutMargins { get; set; }

        // -(void)insertContentIntoPopover:(void (^)(ARSPopover *, CGSize, CGFloat))content;
        [Export("insertContentIntoPopover:")]
        void InsertContentIntoPopover(Action<ARSPopover, CGSize, nfloat> content);

        // -(void)closePopover;
        [Export("closePopover")]
        void ClosePopover();
    }
}
