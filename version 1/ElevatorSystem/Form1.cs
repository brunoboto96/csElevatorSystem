using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class Form1 : Form
    {
        ElevatorSystem eSystem;
        OleDbConnection con;
        OleDbCommand cmd;

        ElevatorDBDataSet.ElevatorDBRow newESystemDBRow;
        ElevatorDBDataSetTableAdapters.ElevatorDBTableAdapter eSystemTableAdapter;


        public Form1()
        {
            InitializeComponent();
            
            //Instatiate new ElevatorSystem
            eSystem = new ElevatorSystem(this.elevator.Location.Y, this.elevator.Location.X);

            //Adjustments
            this.elevator.Location = new Point(elevator.Location.X, this.elevator.Location.Y - 1);
            this.eSystem.setY(this.elevator.Location.Y);
            //

            //DB Connection
            con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ElevatorDB.mdb");

            cmd = con.CreateCommand();

            
            con.Open();
            cmd.CommandText = "INSERT INTO `ElevatorDB` ( `Time`, `Event`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', 'All systems initialized!');";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            


            // Create a new row.
            /*
            newESystemDBRow = elevatorDBDataSet.ElevatorDB.NewElevatorDBRow();
            newESystemDBRow.Time = DateTime.Now;
            newESystemDBRow.Event= "All systems initialized!";

            // Add the row to the Region table
            elevatorDBDataSet.ElevatorDB.Rows.Add(newESystemDBRow);

            // Save the new row to the database
            this.elevatorDBTableAdapter.Update(this.elevatorDBDataSet.ElevatorDB);
            */

            //elevatorDBTableAdapter.Insert(DateTime.Now, "All systems initialized!");

            //elevatorDBTableAdapter.InsertQueryTest();
            //elevatorDBDataSet.ElevatorDB.Rows.Add(DateTime.Now, "All systems initialized!");
            //elevatorDBDataSet.ElevatorDB.NewRow();



            try
            {
                newESystemDBRow = elevatorDBDataSet.ElevatorDB.NewElevatorDBRow();
                newESystemDBRow.Time = DateTime.Now;
                newESystemDBRow.Event = "All systems initialized!";

                // Add the row to the Region table
                elevatorDBDataSet.ElevatorDB.Rows.Add(newESystemDBRow);
                this.Validate();
                elevatorDBBindingSource.EndEdit();
                elevatorDBTableAdapter.Update(elevatorDBDataSet.ElevatorDB);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void timerCheckCalls_Tick(object sender, EventArgs e)
        {
            //checks if system is busy
            if (this.eSystem.isBusy()) {
                Console.WriteLine("System is busy at the moment trying again later..\n");
                return;
            }

            //system not busy
            //sets current floor and moving direction
            eSystem.setFloor();
            Console.WriteLine("Current floor: " + eSystem.getFloor() );
            Console.WriteLine(eSystem.isMovingUp());


            //checks calls for current floor
            if (eSystem.hasCalls(eSystem.getFloor()))
            {
                //locks system actions and sets lights accordingly
                this.eSystem.setBusy(true);
                setLights(getFloorLights(), Color.Green);
                setLights(this.controlPanelStatus, Color.Green);

                //starts doors timer and animation
                doorOpenAnim.Start();
                timerDoorOpen.Start();
                
                

            } else {
                //checks calls for other floor and sets lights to standby
                int floor = eSystem.getFloor();
                setAllLights(Color.DeepSkyBlue);
                if (floor == 1)
                {
                //defines which floor to interact
                    if(eSystem.hasCalls(0))
                    {
                        //locks system actions and starts moving
                        this.eSystem.setBusy(true);
                        this.eSystem.clearFloorCalls(0);
                        startTransition();
                    } else {
                        setLights(getFloorLights(), Color.Green);
                    }
                } else {
                    if (eSystem.hasCalls(1))
                    {
                        //locks system actions and starts moving
                        this.eSystem.setBusy(true);
                        this.eSystem.clearFloorCalls(1);
                        startTransition();
                    }
                    else
                    {
                        setLights(getFloorLights(), Color.Green);
                    }
                }
            }
        }

        public void startTransition()
        { 
            this.timerTransition.Start();
            eSystem.setMoving(true);
        }

        private void timerTransition_Tick(object sender, EventArgs e)
        {
            this.eSystem.setBusy(true);
            if (!eSystem.isMoving())
            {
                //movement has stoped
                //updates the floor
                eSystem.setFloor();

                //updates the labels to show current floor
                updateLabels(Convert.ToString(eSystem.getFloor()));

                //stops the transition timer, disables the xray elevator from view
                this.elevator.Visible = false;
                timerTransition.Stop();
                Console.WriteLine("X-ray Elevator is now: " + this.elevator.Visible);

                //updates lights and DB
                setLights(getFloorLights(), Color.Green);
                setLights(this.controlPanelStatus, Color.Green);
                updateDBFloor();

                //opens doors animation and timer
                timerDoorOpen.Start();
                doorOpenAnim.Start();
            } else {
                //elevator is moving
                //sets control panel lights accordingly and enables xray view
                setLights(this.controlPanelStatus, Color.Red);
                Console.WriteLine("X-ray Elevator is currently: " + this.elevator.Visible);
                this.elevator.Visible = true;

                //sets boundaries between floors to prevent shooting of the sky or falling bellow the ground
                if (eSystem.getY() > 350 || eSystem.getY() < 50)
                {
                    eSystem.setMoving(false);

                    //adjusts elevator to be ready to be moved again and breaks method execution
                    if (eSystem.getY() > 350) eSystem.setY(eSystem.getY() - 1);
                    else if(eSystem.getY() < 50) eSystem.setY(eSystem.getY() + 1);
                    this.elevator.Location = new System.Drawing.Point(135, eSystem.getY());
                    return;
                }

                if (eSystem.isMovingUp())
                {
                    //translates the elevator up
                    Console.WriteLine(this.elevator.Location.Y.ToString());
                    int y = this.elevator.Location.Y;
                    this.elevator.Location = new Point(elevator.Location.X, y - 1);
                    this.eSystem.setY(this.elevator.Location.Y);
                } else {
                    //translates the elevator down
                    Console.WriteLine(this.elevator.Location.Y.ToString());
                    int y = this.elevator.Location.Y;
                    this.elevator.Location = new Point(elevator.Location.X, y + 1);
                    this.eSystem.setY(this.elevator.Location.Y);
                }
            }
            
        }

        private void doorOpenAnim_Tick(object sender, EventArgs e)
        {
            //defines which door to interact
            if (eSystem.getFloor() == 1)
            {
                //sets boundaries and starts animation
                if (doorR1.Size.Width > 0)
                {
                    this.doorR1.Size = new System.Drawing.Size(this.doorR1.Size.Width - 10, 160);
                    this.doorR1.Location = new Point(this.doorR1.Location.X + 10, this.doorR1.Location.Y);
                    this.doorL1.Size = new System.Drawing.Size(this.doorL1.Size.Width - 10, 160);

                }
                else
                {
                    this.doorR1.Size = new System.Drawing.Size(0, 160);
                    this.doorR1.Location = new Point(eSystem.getDoorRx() + eSystem.getDoorW(), this.doorR1.Location.Y);
                    this.doorL1.Size = new System.Drawing.Size(0, 160);
                    this.doorL1.Location = new Point(eSystem.getDoorLx(), this.doorL1.Location.Y);

                }
            } else {
                //sets boundaries and starts animation
                if (doorR0.Size.Width > 0)
                {
                    this.doorR0.Size = new System.Drawing.Size(this.doorR0.Size.Width - 10, 160);
                    this.doorR0.Location = new Point(this.doorR0.Location.X + 10, this.doorR0.Location.Y);
                    this.doorL0.Size = new System.Drawing.Size(this.doorL0.Size.Width - 10, 160);

                }
                else
                {
                    this.doorR0.Size = new System.Drawing.Size(0, 160);
                    this.doorR0.Location = new Point(eSystem.getDoorRx() + eSystem.getDoorW(), this.doorR0.Location.Y);
                    this.doorL0.Size = new System.Drawing.Size(0, 160);
                    this.doorL0.Location = new Point(eSystem.getDoorLx(), this.doorL0.Location.Y);
                }
            }
        }

        private void timerDoorOpen_Tick(object sender, EventArgs e)
        {
            //stops the animation and stops itself from running again
            doorOpenAnim.Stop();
            timerDoorOpen.Stop();

            //starts animation and starts timer
            timerDoorClosing.Start();
            doorCloseAnim.Start();

            //Clears calls for that floor and starts accepting switch presses again
            eSystem.clearFloorCalls(eSystem.getFloor());
            
        }

        private void doorCloseAnim_Tick(object sender, EventArgs e)
        {
            //defines which door to interact
            if (eSystem.getFloor() == 1)
            {
                //sets boundaries and starts animation
                if (doorR1.Size.Width <= eSystem.getDoorW())
                {
                    this.doorR1.Size = new System.Drawing.Size(this.doorR1.Size.Width + 5, 160);
                    this.doorR1.Location = new Point(this.doorR1.Location.X - 5, this.doorR1.Location.Y);
                    this.doorL1.Size = new System.Drawing.Size(this.doorL1.Size.Width + 5, 160);

                }
                else
                {
                    this.doorR1.Size = new System.Drawing.Size(eSystem.getDoorW(), 160);
                    this.doorR1.Location = new Point(eSystem.getDoorRx(), this.doorR1.Location.Y);
                    this.doorL1.Size = new System.Drawing.Size(eSystem.getDoorW(), 160);
                }
            }
            else
            {
                //sets boundaries and starts animation
                if (doorR0.Size.Width <= eSystem.getDoorW())
                {
                    this.doorR0.Size = new System.Drawing.Size(this.doorR0.Size.Width + 5, 160);
                    this.doorR0.Location = new Point(this.doorR0.Location.X - 5, this.doorR0.Location.Y);
                    this.doorL0.Size = new System.Drawing.Size(this.doorL0.Size.Width + 5, 160);

                }
                else
                {
                    this.doorR0.Size = new System.Drawing.Size(eSystem.getDoorW(), 160);
                    this.doorR0.Location = new Point(eSystem.getDoorRx(), this.doorR0.Location.Y);
                    this.doorL0.Size = new System.Drawing.Size(eSystem.getDoorW(), 160);
                }
            }
        }

        private void timerDoorClosing_Tick(object sender, EventArgs e)
        {
            //stops the animation and stops itself from running again
            timerDoorClosing.Stop();
            doorCloseAnim.Stop();

            //checks if the doors needs to be reopen
            if (eSystem.hasCalls(eSystem.getFloor()))
            {
                setLights(this.controlPanelStatus, Color.Green);
                timerDoorOpen.Start();
                doorOpenAnim.Start();
            } else {
                //no calls for that floor
                //sets the lights accordingly
                setLights(getFloorLights(), Color.Green);
                setLights(this.controlPanelStatus, Color.DeepSkyBlue);
            
                //liberates the system to act upon new calls
                this.eSystem.setMoving(false);
                this.eSystem.setBusy(false); 
            }
            
        }

        private PictureBox getFloorLights()
        {
            if (eSystem.getFloor() == 0) return light0;
            else return light1;
        }

        private void setAllLights(Color c)
        {
            light0.BackColor = c;
            light1.BackColor = c;
        }

        private void setLights(PictureBox light, Color c)
        {
            light.BackColor = c;
        }

        private void updateLabels(string t)
        {
            this.labelFloor0.Text = t;
            this.labelFloor1.Text = t;
            if (t == "1") {
                this.controlPanelLabel0.BackColor = Color.Black;
                this.controlPanelLabel1.BackColor = Color.Chartreuse;
            } else {
                this.controlPanelLabel0.BackColor = Color.Chartreuse;
                this.controlPanelLabel1.BackColor = Color.Black;
            }

        }

        private void updateDBFloor()
        {
            con.Open();
            cmd.CommandText = "INSERT INTO `ElevatorDB` ( `Time`, `Event`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', 'Elevator is now on Floor: " + eSystem.getFloor() + "');";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("db floor");
        }

        private void updateDBCall(int floor)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO `ElevatorDB` ( `Time`, `Event`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', 'The floor " + floor + " switch has been pressed. Adding a call. Calls for floor 0:  "
                + eSystem.getCalls0() + " | Calls for floor 1: " + eSystem.getCalls1() + "');";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine( "DB call ");
        }

        private void elevatorDBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.elevatorDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elevatorDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elevatorDBDataSet.ElevatorDB' table. You can move, or remove it, as needed.
            this.elevatorDBTableAdapter.Fill(this.elevatorDBDataSet.ElevatorDB);

        }

        private void labelFloor1_Click(object sender, EventArgs e)
        {

        }
    }

    public class ElevatorSystem
    {
        //field members
        private int Y, Floor, Calls0, Calls1, DoorW, DoorRx, DoorLx;
        private bool Moving, Call0, Call1, MovingUp, Busy;
        private string Floor0State, Floor1State; //array/construct floorstates
        
       

        //Constructor
        public ElevatorSystem(int y, int x)
        {
            setY(y);
            this.Floor = 0;
            setMoving(false);
            this.DoorW = 45;
            this.setFloor();
            this.DoorLx = x;
            this.DoorRx = x + DoorW;
        }

        //Getters and Setters

        public int getY() => this.Y;

        public void setY(int y) => this.Y = y;

        public int getCalls0() => this.Calls0;
        public int getCalls1() => this.Calls1;

        public int getDoorW() => this.DoorW;

        public int getDoorLx() => this.DoorLx;
        public int getDoorRx() => this.DoorRx;


        public int getFloor() => this.Floor;

        

        public bool isMoving() => this.Moving; 

        public void setMoving(bool moving) => this.Moving = moving;

        public bool isCalled0() => this.Call0;

        public void setCall0(bool call) => this.Call0 = call;

        public bool isCalled1() => this.Call1;

        public void setCall1(bool call) => this.Call1 = call;

        public bool isMovingUp() => this.MovingUp;

        public void setMovingUp(bool mu) => this.MovingUp = mu;

        public bool isBusy() => this.Busy;

        public void setBusy(bool state) => this.Busy = state;

        public string getFloor0State() => this.Floor0State;

        public void setFloor0State(string state) => this.Floor0State = state;

        public string getFloor1State() => this.Floor1State;

        public void setFloor1State(string state) => this.Floor1State = state;

        //logic
        public void callFloor0()
        {
            this.setCall0(true);
            this.Calls0++;
        }

        public void callFloor1()
        {
            this.Calls1++;
            this.setCall1(true);
        }

        public void setFloor()
        {
            if (getY() < 250)
            {
                this.Floor = 1;
                setMovingUp(false);
            }
            else
            {
                this.Floor = 0;
                setMovingUp(true);
            }
        }

        public bool hasCalls(int floor)
        {
            switch(floor)
            {
                case 0:
                    return isCalled0();
                case 1:
                    return isCalled1();
                default:
                    MessageBox.Show("There is a problem with the system.\nThe current floor is incorrect!");
                    return true;
            }
        }

        public void clearFloorCalls(int floor)
        {
            switch (floor)
            {
                case 0:
                    this.Calls0 = 0;
                    setCall0(false);
                    break;
                case 1:
                    this.Calls1 = 1;
                    setCall1(false);
                    break;
                default:
                    MessageBox.Show("There is a problem with the system.\nThe current floor is incorrect!");
                    break;
            }
        }
    }
}
