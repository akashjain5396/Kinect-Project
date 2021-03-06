﻿using Microsoft.Kinect;

namespace PowerPoint_kinect.Gestures
{
    /// <summary>
    /// The first part of the swipe left gesture
    /// </summary>
    public class SwipeLeftSegment1 : IRelativeGestureSegment
    {
        /// <summary>
        /// Checks the gesture.
        /// </summary>
        /// <param name="skeleton">The skeleton.</param>
        /// <returns>GesturePartResult based on if the gesture part has been completed</returns>
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            bool isSpineTracked;
            if (skeleton.Joints[JointType.Spine].TrackingState == JointTrackingState.Tracked)
            {
                isSpineTracked = true;
            }
            else
            {
                isSpineTracked = false;
            }

            // right hand in front of right shoulder
            if (skeleton.Joints[JointType.HandRight].Position.Z <= skeleton.Joints[JointType.ShoulderCenter].Position.Z && skeleton.Joints[JointType.HandLeft].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y)
            {
                // right hand below shoulder height but above hip height
                if (isSpineTracked && skeleton.Joints[JointType.HandRight].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y && skeleton.Joints[JointType.HandRight].Position.Y >= skeleton.Joints[JointType.HipCenter].Position.Y)
                {
                    // right hand right of right shoulder
                    if (skeleton.Joints[JointType.HandRight].Position.X > skeleton.Joints[JointType.ShoulderRight].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }
                    return GesturePartResult.Pausing;
                }else if(!isSpineTracked && skeleton.Joints[JointType.HandRight].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y)
                {
                    // right hand right of right shoulder
                    if (skeleton.Joints[JointType.HandRight].Position.X > skeleton.Joints[JointType.ShoulderRight].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }
                    return GesturePartResult.Pausing;
                }
                return GesturePartResult.Fail;
            }
            return GesturePartResult.Fail;
        }
    }

    /// <summary>
    /// The second part of the swipe left gesture
    /// </summary>
    public class SwipeLeftSegment2 : IRelativeGestureSegment
    {
        /// <summary>
        /// Checks the gesture.
        /// </summary>
        /// <param name="skeleton">The skeleton.</param>
        /// <returns>GesturePartResult based on if the gesture part has been completed</returns>
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            bool isSpineTracked;
            if (skeleton.Joints[JointType.Spine].TrackingState == JointTrackingState.Tracked)
            {
                isSpineTracked = true;
            }
            else
            {
                isSpineTracked = false;
            }
            // right hand in front of right shoulder
            if (skeleton.Joints[JointType.HandRight].Position.Z <= skeleton.Joints[JointType.ShoulderCenter].Position.Z && skeleton.Joints[JointType.HandRight].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y)
            {
                // right hand below shoulder height but above hip height
                if (isSpineTracked && skeleton.Joints[JointType.HandRight].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y && skeleton.Joints[JointType.HandRight].Position.Y >= skeleton.Joints[JointType.HipCenter].Position.Y)
                {
                    // right hand left of right shoulder & right of left shoulder
                    if (skeleton.Joints[JointType.HandRight].Position.X < skeleton.Joints[JointType.ShoulderRight].Position.X && skeleton.Joints[JointType.HandRight].Position.X > skeleton.Joints[JointType.ShoulderLeft].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }
                    return GesturePartResult.Pausing;
                }else if(!isSpineTracked && skeleton.Joints[JointType.HandRight].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y)
                {
                    // right hand left of right shoulder & right of left shoulder
                    if (skeleton.Joints[JointType.HandRight].Position.X < skeleton.Joints[JointType.ShoulderRight].Position.X && skeleton.Joints[JointType.HandRight].Position.X > skeleton.Joints[JointType.ShoulderLeft].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }
                    return GesturePartResult.Pausing;
                }
                return GesturePartResult.Fail;
            }
            return GesturePartResult.Fail;
        }
    }

    /// <summary>
    /// The third part of the swipe left gesture
    /// </summary>
    public class SwipeLeftSegment3 : IRelativeGestureSegment
    {
        /// <summary>
        /// Checks the gesture.
        /// </summary>
        /// <param name="skeleton">The skeleton.</param>
        /// <returns>GesturePartResult based on if the gesture part has been completed</returns>
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            bool isSpineTracked;
            if (skeleton.Joints[JointType.Spine].TrackingState == JointTrackingState.Tracked)
            {
                isSpineTracked = true;
            }
            else
            {
                isSpineTracked = false;
            }
            // //Right hand in front of right Shoulder
            if (skeleton.Joints[JointType.HandRight].Position.Z < skeleton.Joints[JointType.ShoulderCenter].Position.Z)
            {
                // //right hand below shoulder height but above hip height
                if (isSpineTracked && skeleton.Joints[JointType.HandRight].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y && skeleton.Joints[JointType.HandRight].Position.Y > skeleton.Joints[JointType.HipCenter].Position.Y)
                {
                    // //right hand left of center hip
                    if (skeleton.Joints[JointType.HandRight].Position.X <= skeleton.Joints[JointType.HipCenter].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }

                    return GesturePartResult.Pausing;
                }else if(!isSpineTracked && skeleton.Joints[JointType.HandRight].Position.Y < skeleton.Joints[JointType.ShoulderCenter].Position.Y)
                {
                    // //right hand left of center hip
                    if (skeleton.Joints[JointType.HandRight].Position.X <= skeleton.Joints[JointType.ShoulderCenter].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }

                    return GesturePartResult.Pausing;
                }

                return GesturePartResult.Fail;
            }

            return GesturePartResult.Fail;
        }
    }
}
