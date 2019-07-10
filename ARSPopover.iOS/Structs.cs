using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace ARSPopover.iOS
{

    [StructLayout(LayoutKind.Sequential)]
    public struct UIEdgeInsets
    {
        public nfloat top;

        public nfloat left;

        public nfloat bottom;

        public nfloat right;
    }

}
