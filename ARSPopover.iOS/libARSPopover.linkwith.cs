using System;
using ObjCRuntime;

//[assembly: LinkWith ("libARSPopover.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
[assembly: LinkWith("libARSPopover.a", SmartLink = true, ForceLoad = true)]
