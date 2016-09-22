using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinAzureNotification
{
    class Constants
    {
        public const string SenderID = "957783663825"; // Google API Project Number
        public const string ListenConnectionString = "Endpoint=sb://notification-xamarin.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=r3/+XiOxW2IPZcOV8mECMV9ctOcJIEU/53Fpy1HSRFY=";
        public const string NotificationHubName = "SPXamarinHub";
    }
}