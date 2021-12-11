using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRobot
{
    //enum for directions
    public enum Direction { 
        North = 233,
        South = 234,
        East = 232,
        West = 231
    }

    //Delegate creation
    public delegate void RangeLimitEventHandler(object source, RangeLimitArgs re);

    //Class to use when delegate is called. 
    public class RangeLimitArgs : EventArgs
    {
        private string EventInfo; 

        public RangeLimitArgs(string text)
        {
            EventInfo = text;
        }
        public string GetInfo()
        {
            
            return EventInfo;
        }
    }

    //actual robot class
    public class Robot
    {
        //class variables to use in  the class. 
        public Point location;
        public Direction orientation;
        public event RangeLimitEventHandler OnRangeLimitExceeded; 

        //robot constructor
        public Robot()
        {
            //sets the location of the robot to 0,0
            this.location = new Point(0,0);
            //sets the orientaion of the robot to north.
            orientation = Direction.North;
            
        }

        //This part of the robot moves the robot depending on the distance and direction. 
        public void Move(int distance)
        {
            //creates new point for rob to go.
            Point newPoint = new Point();
            //Switch statement to keep code neat. This switch statement just takes the direction, and then depending on that it will change
            //the X or Y and moves the robot to the new location and then sets the new location of the robot. 
            switch (orientation)
            {

                case Direction.North:
                    newPoint.X = this.location.X;
                    newPoint.Y = this.location.Y - distance;
                    break;
                case Direction.South:
                    newPoint.X = this.location.X;
                    newPoint.Y = this.location.Y + distance;
                    break;
                case Direction.East:
                    newPoint.X = this.location.X + distance;
                    newPoint.Y = this.location.Y;
                    break;
                case Direction.West:
                    newPoint.X = this.location.X - distance;
                    newPoint.Y = this.location.Y;
                    break;
            }
            //sets the new location.
            this.location = newPoint;
        }

        //This ToString() function overrides the original ToString() to make the rob look like an arrow.
        public override string ToString()
        {
            return ((char)orientation).ToString();
        }

        //a getter for location or the robot.
        public Point Location
        {
          get { return location;  }
        }
        
    }
}
