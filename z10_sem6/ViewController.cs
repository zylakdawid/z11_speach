using System;

using AppKit;
using Foundation;

namespace z10_sem6
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
		partial void HelloPress(NSObject sender)
		{
            labelInfo.StringValue="Hello world!";

            NSSpeechSynthesizer synth = new NSSpeechSynthesizer();
            synth.StartSpeakingString("Hello world!");

          
		}
	}
}
