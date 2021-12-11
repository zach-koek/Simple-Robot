using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRobot
{
    public partial class frmRobot : Form
    {
        //creates a new instance of rob the robot.
        Robot rob = new Robot();

        public frmRobot()
        {
            InitializeComponent();
        }

        //the delegate event that will be called if a range is met. 
        private void HandleRangeExceeded(object sender, EventArgs e)
        {
            MessageBox.Show("Your robot tried to go too far " + rob.orientation);
        }

        // form load event.
        private void frmRobot_Load(object sender, EventArgs e)
        {
            //sets the label to a default lable.
            lblCoord.Text = "{X = 0 , Y = 0}";
            //sets the robots location to the lbl location that is supposed to represent the robot.
            rob.location = lblRobot.Location;
            //uses my overrode ToSring() to set the arrow.
            lblRobot.Text = rob.ToString();
            //this creates a new event of OnRangeLimitExceeded from the RobotClass.
            rob.OnRangeLimitExceeded += new RangeLimitEventHandler(HandleRangeExceeded);
        }

        //all the direction button clicks are in this one event.
        private void Direction_Click(object sender, EventArgs e)
        {
            //creates a variable to find out which button was clicked.
            Button directionClicked = sender as Button;
            
            //all the if statements will look at the Text of the button and will do the logic within that directional statemnt.
            if (directionClicked.Text == "N")
            {
                //all if statements do the same logic except orientation and arrow is different. 
                //sets the orientation to North
                rob.orientation = Direction.North;
                //sets label that represents the robot to the direction arrow that the orientation is set to.
                lblRobot.Text = rob.ToString();
            }
            if (directionClicked.Text == "S")
            {
                rob.orientation = Direction.South;
                lblRobot.Text = rob.ToString();
            }
            if (directionClicked.Text == "E")
            {
                rob.orientation = Direction.East;
                lblRobot.Text = rob.ToString();
            }
            if (directionClicked.Text == "W")
            {
                rob.orientation = Direction.West;
                lblRobot.Text = rob.ToString();
            }

        }

        //This lab I feel like could have been done a 100 different ways. I tried to stick to the general outline or what the lab requested. Except this part. I think 
        //it probably would have been neater to do the location checking in the robot class but with the Panel being at 0,0 in the top left corner. and I need the robot to 
        //Technically be at 0,0 I couldnt wrap my head around how to do that even though its probably super simple. So instead I trouble shot the robot to find the exact pixels 
        // the boundary would be. 
        private void btnGoTen_Click(object sender, EventArgs e)
        {
            //goes through an if statement that checks the location of the robot before it moves again just so it can check to make sure the boundary is good. 
             if ((rob.location.Y <= 17 && rob.orientation == Direction.North) | (rob.location.Y >= 199 && rob.orientation == Direction.South) | 
                (rob.location.X <= 34 && rob.orientation == Direction.West) | (rob.location.X >= 216 && rob.orientation == Direction.East))
                {
                //delegate event... I think...
                HandleRangeExceeded(this, e);
                }
                else
                {
                    //moves the robot
                    rob.Move(10);
                    //updates robs location
                    lblRobot.Location = rob.Location;
                    //creates the coordinates you want to see in the upper label. 
                    lblCoord.Text = coordString();
                }
        }
        private void btnGoOne_Click(object sender, EventArgs e)
        {
            //goes through an if statement that checks the location of the robot before it moves again just so it can check to make sure the boundary is good.
            if ((rob.location.Y <= 8 && rob.orientation == Direction.North) | (rob.location.Y >= 208 && rob.orientation == Direction.South) |
                (rob.location.X <= 35 && rob.orientation == Direction.West) | (rob.location.X >= 225 && rob.orientation == Direction.East))
            {
                //again I think this is the delegate event. 
                HandleRangeExceeded(this, e);
            }
            else
            {
                //moves the robot
                rob.Move(1);
                //updates robs location
                lblRobot.Location = rob.Location;
                //creates the coordinates you want to see in the upper label. 
                lblCoord.Text = coordString();
            }

        }
        
        //converts the robots actuall coordinates to the coordinates that are easy to read. 
        private string coordString()
        {
            string newCoord = "{X = " + (rob.Location.X - 125) + " , " + "Y = " + ((rob.Location.Y - 108)* -1) + "}";

            return newCoord;
        }

        //closes the form when the exit button is clicked.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}
