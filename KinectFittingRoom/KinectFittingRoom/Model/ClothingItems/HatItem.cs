﻿using System.Windows.Media.Media3D;
using Microsoft.Kinect;

namespace KinectFittingRoom.Model.ClothingItems
{
    class HatItem : ClothingItemBase
    {
        /// <summary>
        /// The ratio
        /// </summary>
        private const double Ratio = 0.8;
        /// <summary>
        /// Initializes a new instance of the <see cref="HatItem"/> class.
        /// </summary>
        /// <param name="model">3D model of the hat</param>
        public HatItem(Model3DGroup model)
            : base(model, Ratio)
        {
            JointToTrackPosition = JointType.Head;
            LeftJointToTrackAngle = JointType.ShoulderLeft;
            RightJointToTrackAngle = JointType.ShoulderRight;
            LeftJointToTrackScale = JointType.Head;
            RightJointToTrackScale = JointType.ShoulderCenter;
        }
    }
}