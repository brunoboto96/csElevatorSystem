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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ElevatorSystem eSystem;
        OleDbConnection con;
        OleDbCommand cmd;
        public Form1()
        {
            InitializeComponent();
            
            
            Console.WriteLine("Hellooo");
            eSystem = new ElevatorSystem(this.elevator.Location.Y);

            con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ElevatorDB.mdb");

            cmd = con.CreateCommand();
            
        }

        private void timerCheckCalls_Tick(object sender, EventArgs e)
        {
            
            Console.WriteLine("\n\n*** Checking System ***\n");

            if (this.eSystem.isBusy()) {
                Console.WriteLine("System is busy at the moment trying again later..\n");
                return;
            }

            eSystem.setFloor();
            Console.WriteLine("Current floor: " + eSystem.getFloor() );
            Console.WriteLine(eSystem.isMovingUp());

            if (eSystem.hasCalls(eSystem.getFloor()))
            {
                //this.timerTransition.Start();
                this.eSystem.setBusy(true);
                setLights(getFloorLights(), Color.Green);
                doorOpenAnim.Start();


                this.elevator.Visible = false;
                //this.doorOpen.Visible = true;
                this.doorR.Visible = true;
                this.doorL.Visible = true;
                this.doorOpen.Location = new Point(elevator.Location.X, elevator.Location.Y);
                this.doorL.Location = new Point(elevator.Location.X, elevator.Location.Y);
                this.doorR.Location = new Point(elevator.Location.X, elevator.Location.Y);




                timerDoorOpen.Start();
                con.Open();
                cmd.CommandText = "INSERT INTO `ElevatorDB` ( `Time`, `Event`) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', 'doors opened');";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record Submitted", "Congrats");
                con.Close();

            } else {
                int floor = eSystem.getFloor();
                setAllLights(Color.DeepSkyBlue);
                if (floor == 1)
                {
                    if(eSystem.hasCalls(0))
                    {
                        this.eSystem.setBusy(true);
                        this.eSystem.clearFloorCalls(0);
                        startTransition();
                    } else {
                        setLights(getFloorLights(), Color.Green);
                    }
                } else {
                    if (eSystem.hasCalls(1))
                    {
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
            //this.timerCheckCalls.Stop();
            //redundancy timers stop doors closed timer let this handle or stop this timer and start after doors closed timer
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
                eSystem.setFloor();
                updateLabels(Convert.ToString(eSystem.getFloor()));
                timerTransition.Stop();
                
                setLights(getFloorLights(), Color.Green);
                timerDoorOpen.Start();
                Console.WriteLine(this.eSystem.getY());
            } else {
                if (eSystem.getY() > 350 || eSystem.getY() < 50)
                {
                    eSystem.setMoving(false);

                    if (eSystem.getY() > 350) eSystem.setY(eSystem.getY() - 1);
                    else if(eSystem.getY() < 50) eSystem.setY(eSystem.getY() + 1);

                    this.elevator.Location = new System.Drawing.Point(135, eSystem.getY());
                    return;
                }

                if (eSystem.isMovingUp())
                {
                    Console.WriteLine(this.elevator.Location.Y.ToString());
                    int y = this.elevator.Location.Y;
                    this.elevator.Location = new Point(elevator.Location.X, y - 1);
                    this.eSystem.setY(this.elevator.Location.Y);
                } else {
                    Console.WriteLine(this.elevator.Location.Y.ToString());
                    int y = this.elevator.Location.Y;
                    this.elevator.Location = new Point(elevator.Location.X, y + 1);
                    this.eSystem.setY(this.elevator.Location.Y);
                }
            }
            
        }
        
        private void timerDoorOpen_Tick(object sender, EventArgs e)
        {
            doorOpenAnim.Stop();
            this.elevator.SizeMode = PictureBoxSizeMode.Normal;
            timerDoorOpen.Stop();
            timerDoorClosing.Start();
            eSystem.clearFloorCalls(eSystem.getFloor());
            
        }

        private void timerDoorClosing_Tick(object sender, EventArgs e)
        {
            timerDoorClosing.Stop();
            if (eSystem.hasCalls(eSystem.getFloor()))
            {
                timerDoorOpen.Start(); //method to start animation and timer
            } else {
                setLights(getFloorLights(), Color.Green);
            
                this.eSystem.setMoving(false);

                this.elevator.SizeMode = PictureBoxSizeMode.StretchImage;

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

        }

        private void doorOpenAnim_Tick(object sender, EventArgs e)
        {
            int newDoorW = this.doorR.Size.Width - (90 / (this.timerDoorOpen.Interval / this.doorOpenAnim.Interval)) + 2;
            this.doorR.Location = new Point(this.doorR.Location.X + (this.doorR.Size.Width / (this.timerDoorOpen.Interval / this.doorOpenAnim.Interval)) + 2, this.doorR.Location.Y);
            this.doorR.Size = new System.Drawing.Size(this.doorR.Size.Width - (this.doorR.Size.Width/(this.timerDoorOpen.Interval/this.doorOpenAnim.Interval)), 160);
            Console.WriteLine(newDoorW);
            Console.WriteLine(this.timerDoorOpen.Interval + " " + this.doorOpenAnim.Interval);

        }
    }

    public class ElevatorSystem
    {
        //field members
        private int Y, Floor, Calls0, Calls1;
        private bool Open, Moving, Call0, Call1, MovingUp, Busy;
        private string Floor0State, Floor1State; //array/construct floorstates
        
        //img

        //Constructor
        public ElevatorSystem(int y)
        {
            setY(y);
            this.Floor = 0;
            setMoving(false);
        }

        //Getters and Setters

        public int getY() => this.Y;

        public void setY(int y) => this.Y = y;

        public int getCalls0() => this.Calls0;
        public int getCalls1() => this.Calls1;


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
