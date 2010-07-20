using System;
using MonoTouch.UIKit;

namespace DetectTouch
{
	public partial class EventUIWindow : UIWindow
	{
		public EventUIWindow () : base() {}
		
		public EventUIWindow (IntPtr handle) : base(handle) {}
		
		public override void SendEvent (UIEvent evt)
		{
			// Send the event to its original destination
			base.SendEvent (evt);
			// Get touchs from the event
			var touchs = evt.AllTouches;
			// Count will be one most of the time (single touch) but multitouch will appear here. E.g. Pinch touchs.Count = 2
			if (touchs.Count > 0)
			{
				// Get one touch event from the array 
				UITouch touch = touchs.AnyObject as UITouch;
				if (touch != null)
				{	
					// You can get the touch phase
					// UITouchPhase.Began || UITouchPhase.Cancelled || UITouchPhase.Ended || UITouchPhase.Moved || UITouchPhase.Stationary
					// touch.Phase;
					
					// How many taps the click had
					// touch.TapCount
					
					// Target view
					// touch.View
						
					// Target Window
					// touch.Window
					
					// Touch event timestamp
					// touch.Timestamp
					
					// And a few more things
				}	
			}
		}
	}
}

