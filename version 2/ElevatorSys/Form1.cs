using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ElevatorSys
{
    public partial class Form1 : Form
    {
        ControlPanel cPanel;
        private int xAxis;

        private DataSet ds = new DataSet();
        private string dbconnection;
        private string dbcommand;
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adapter;
        DataTable table;
        private string initialized, buttonPressed, cpbuttonPressed, floorReached;
        DataRow newRow;



        public Form1()
        {
            InitializeComponent();

            cPanel = new ControlPanel(elevator.Location.X, elevator.Location.Y); //Control Panel Object
            xAxis = elevator.Location.X; //sets the horizontal axis
            dbconnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
             + "ElevatorDB.mdb;User Id=Admin;Password=;"; //connection string
            dbcommand = "Select * from SystemLog;"; //gets table from db
            conn = new OleDbConnection(dbconnection);
            comm = new OleDbCommand(dbcommand, conn);
            adapter = new OleDbDataAdapter(comm);

            initialized = "insert into SystemLog(EventName, EventTime) values('Welcome,system ready!', '"+ DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";
            floorReached = "insert into SystemLog(EventName, EventTime) values('Elevator reached floor " + cPanel.getfloor().ToString() + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";

            adapter.DeleteCommand = new OleDbCommandBuilder(adapter).GetDeleteCommand(); //adds delete command to data adapter
            adapter.UpdateCommand = new OleDbCommandBuilder(adapter).GetUpdateCommand(); //adds update command to data adapter

            load_data_from_db_to_ds(); //grabs data from provided table from db

            table = ds.Tables[0]; // sets dataset table 

            dataGridViewLogs.DataSource = table; //fills gridview

            insert_to_db(initialized); //inserts in db new row
            
        }

        private void update_grid()
        {
            dataGridViewLogs.Update(); //refreshes the view with the new values
        }

        public void save_data_into_db() //save the change in dataset into the database
        {
            int number_of_row_updated = 0; //number or rows updated in the db
            if (ds.Tables[0].Rows.Count != 0)   //check the dataset is intitalised already or not
            {
                try
                {
                    
                    //update DB

                    conn.Open(); //opens connection
                    DataSet dataSetChanges = ds.GetChanges(); //gets changes 
                    number_of_row_updated = adapter.Update(dataSetChanges); //updates the dataadapter
                    ds.Tables[0].AcceptChanges(); //commits the changes
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close(); //closes connection
                reload_data_from_db_to_ds(); //reloads the newly saved data from db
                update_grid(); //updates the new data onto screen
            }
            if (number_of_row_updated < 1)          // the database is not updated as expected due to unexpected reasons
            {
                reload_data_from_db_to_ds();                         //the local copy is not up to date anymore, load it from database again
                
            }
        }

        private void insert_to_db(string cmd)
        {
            
            adapter.InsertCommand = new OleDbCommand(cmd, conn);

            newRow = table.NewRow();

            table.Rows.Add(newRow);
            //save changes to the db
            save_data_into_db();
        }
        public void reload_data_from_db_to_ds()             //force reload the data into the dataset
        {
            ds.Clear();
            load_data_from_db_to_ds();
            
        }
        public void load_data_from_db_to_ds()             //load the data into the dataset
        {
            try
            {
                conn.Open();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
            


        private class ControlPanel
        {
            private int x, y, speed;
            private int floor0Y, floor1Y, floor, direction;
            private bool ready = true;

            public ControlPanel(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.speed = 10;
                this.floor0Y = y;
                this.floor1Y = y - 200;
                this.direction = 1; // 1 up 0 down
                this.floor = 0;



            }

            internal int getfloor0Y() { return this.floor0Y; }
            internal int getfloor1Y() { return this.floor1Y; }
            internal int getfloor() { return this.floor; }
            internal void setfloor(int f) { this.floor = f; }
            internal int getSpeed() { return this.speed; }
            internal int getDirection() { return this.direction; }
            internal void setDirection(int d) { this.direction = d; }
            internal bool isReady() { return this.ready; }
            internal void setReady(bool s) { this.ready = s; }

        }

        private void cpanel0_Click(object sender, EventArgs e)
        {
            string b = "0";
            cpbuttonPressed = "insert into SystemLog(EventName, EventTime) values('Control Panel button pressed: " + b + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";
            insert_to_db(cpbuttonPressed);
            if (cPanel.isReady())
                moveElevator(0);
        }

        private void cpanel1_Click(object sender, EventArgs e)
        {
            string b = "1";
            cpbuttonPressed = "insert into SystemLog(EventName, EventTime) values('Control Panel button pressed: " + b + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";
            insert_to_db(cpbuttonPressed);
            if (cPanel.isReady())
                moveElevator(1);
        }

        private void callbtn0_Click(object sender, EventArgs e)
        {

            string b = "0";
            buttonPressed = "insert into SystemLog(EventName, EventTime) values('Call Button pressed " + b + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";
            insert_to_db(buttonPressed);
            if (cPanel.isReady())
                moveElevator(0);
        }

        private void callbtn1_Click(object sender, EventArgs e)
        {

            string b = "1";
            buttonPressed = "insert into SystemLog(EventName, EventTime) values('Call Button pressed " + b + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";
            insert_to_db(buttonPressed);
            if (cPanel.isReady())
                moveElevator(1);
        }

        private void moveElevator(int f)
        {
            cPanel.setReady(false); //prevents multiple actions
            switch (f) {
                case 0:
                    cPanel.setDirection(0); 
                    timermoving.Start();
                    
                    break;
                case 1:
                    cPanel.setDirection(1);
                    timermoving.Start();
                    
                    break;
            }
        }

        private void timermoving_Tick(object sender, EventArgs e)
        {
            switch (cPanel.getDirection()) {
                case 0:
                    if (elevator.Location.Y < cPanel.getfloor0Y())
                    {
                        elevator.Location = new System.Drawing.Point(xAxis, elevator.Location.Y + cPanel.getSpeed()); //moves elevator each tick
                        Console.WriteLine(elevator.Location.Y);
                    }
                    else //reached destination
                    {
                        cpanelfloor.Text = "0"; //updates labels
                        display0.Text = "0";
                        display1.Text = "0";
                        timermoving.Stop();
                        timerOpenDoor.Start(); //starts animation
                        cPanel.setfloor(0);
                        floorReached = "insert into SystemLog(EventName, EventTime) values('Elevator reached floor " + cPanel.getfloor().ToString() + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";

                        insert_to_db(floorReached); //saves event to db
                    }
                    break;

                case 1:
                    if (elevator.Location.Y > cPanel.getfloor1Y())
                    {
                        elevator.Location = new System.Drawing.Point(xAxis, elevator.Location.Y - cPanel.getSpeed());
                        Console.WriteLine(elevator.Location.Y);
                    } else {
                        cpanelfloor.Text = "1";
                        display0.Text = "1";
                        display1.Text = "1";
                        timermoving.Stop();
                        timerOpenDoor.Start();
                        cPanel.setfloor(1);
                        floorReached = "insert into SystemLog(EventName, EventTime) values('Elevator reached floor " + cPanel.getfloor().ToString() + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "')";
                        
                        insert_to_db(floorReached);
                    }
                    break;

            }
        }

        private void timeropendoor_Tick(object sender, EventArgs e)
        {
            elevatorOpen.Location = new System.Drawing.Point(xAxis, elevator.Location.Y);
            elevatorOpen.Visible = true;
            timerCloseDoor.Start();
        }

        private void timerCloseDoor_Tick(object sender, EventArgs e)
        {
            timerOpenDoor.Stop();
            elevatorOpen.Visible = false;
            cPanel.setReady(true);
            timerCloseDoor.Stop();
        }



        private void updatebtn_Click(object sender, EventArgs e)
        {
            save_data_into_db(); //the gridview fields are saved into the db
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.SystemLog' table. You can move, or remove it, as needed.
            

        }
    }
}
