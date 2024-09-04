using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Dragon.Dance.Training.Center.RNDragonDanceTrainingCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDragonDanceTrainingCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDragonDanceTrainingCenterModule"/>.
        /// </summary>
        internal RNDragonDanceTrainingCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDragonDanceTrainingCenter";
            }
        }
    }
}
