using System;

using AppKit;
using Foundation;

namespace pomodorotimer
{
    public partial class ViewController : NSViewController
    {
        private int numberOfClicks = 0;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            ClickedLabel.StringValue = "Button has not been pressed";


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

        partial void ClickedButton(NSObject sender)
        {
            ClickedLabel.StringValue = string.Format("The button" +
            	"has been clicked {0} time{1}",++numberOfClicks,(numberOfClicks < 2) ? "" : "s");
        }
    }
}
