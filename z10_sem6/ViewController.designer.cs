// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace z10_sem6
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField labelInfo { get; set; }

        [Action ("HelloPress:")]
        partial void HelloPress (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (labelInfo != null) {
                labelInfo.Dispose ();
                labelInfo = null;
            }
        }
    }
}
