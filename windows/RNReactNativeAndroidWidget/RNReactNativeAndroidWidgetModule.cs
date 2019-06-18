using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Android.Widget.RNReactNativeAndroidWidget
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeAndroidWidgetModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeAndroidWidgetModule"/>.
        /// </summary>
        internal RNReactNativeAndroidWidgetModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeAndroidWidget";
            }
        }
    }
}
