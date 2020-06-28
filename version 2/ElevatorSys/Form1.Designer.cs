namespace ElevatorSys
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.elevator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.callbtn0 = new System.Windows.Forms.Button();
            this.callbtn1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cpanel1 = new System.Windows.Forms.Label();
            this.cpanel0 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cpanelfloor = new System.Windows.Forms.Label();
            this.display1 = new System.Windows.Forms.Label();
            this.display0 = new System.Windows.Forms.Label();
            this.timermoving = new System.Windows.Forms.Timer(this.components);
            this.timerOpenDoor = new System.Windows.Forms.Timer(this.components);
            this.elevatorOpen = new System.Windows.Forms.PictureBox();
            this.timerCloseDoor = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELEVATOR SYSTEM";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ElevatorSys.Properties.Resources.edges;
            this.pictureBox3.Location = new System.Drawing.Point(600, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ElevatorSys.Properties.Resources.wall;
            this.pictureBox2.Location = new System.Drawing.Point(600, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // elevator
            // 
            this.elevator.Image = global::ElevatorSys.Properties.Resources.closed;
            this.elevator.Location = new System.Drawing.Point(618, 300);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(120, 150);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevator.TabIndex = 1;
            this.elevator.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ElevatorSys.Properties.Resources.edges;
            this.pictureBox1.Location = new System.Drawing.Point(600, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox4.Location = new System.Drawing.Point(565, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 33);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // callbtn0
            // 
            this.callbtn0.Location = new System.Drawing.Point(571, 371);
            this.callbtn0.Name = "callbtn0";
            this.callbtn0.Size = new System.Drawing.Size(23, 23);
            this.callbtn0.TabIndex = 5;
            this.callbtn0.Text = "C";
            this.callbtn0.UseVisualStyleBackColor = true;
            this.callbtn0.Click += new System.EventHandler(this.callbtn0_Click);
            // 
            // callbtn1
            // 
            this.callbtn1.Location = new System.Drawing.Point(571, 178);
            this.callbtn1.Name = "callbtn1";
            this.callbtn1.Size = new System.Drawing.Size(23, 23);
            this.callbtn1.TabIndex = 5;
            this.callbtn1.Text = "C";
            this.callbtn1.UseVisualStyleBackColor = true;
            this.callbtn1.Click += new System.EventHandler(this.callbtn1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox5.Location = new System.Drawing.Point(761, 356);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 80);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // cpanel1
            // 
            this.cpanel1.AutoSize = true;
            this.cpanel1.BackColor = System.Drawing.Color.YellowGreen;
            this.cpanel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cpanel1.Location = new System.Drawing.Point(769, 387);
            this.cpanel1.Name = "cpanel1";
            this.cpanel1.Size = new System.Drawing.Size(13, 13);
            this.cpanel1.TabIndex = 6;
            this.cpanel1.Text = "1";
            this.cpanel1.Click += new System.EventHandler(this.cpanel1_Click);
            // 
            // cpanel0
            // 
            this.cpanel0.AutoSize = true;
            this.cpanel0.BackColor = System.Drawing.Color.YellowGreen;
            this.cpanel0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cpanel0.Location = new System.Drawing.Point(769, 412);
            this.cpanel0.Name = "cpanel0";
            this.cpanel0.Size = new System.Drawing.Size(13, 13);
            this.cpanel0.TabIndex = 6;
            this.cpanel0.Text = "0";
            this.cpanel0.Click += new System.EventHandler(this.cpanel0_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox9.Location = new System.Drawing.Point(565, 173);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 33);
            this.pictureBox9.TabIndex = 4;
            this.pictureBox9.TabStop = false;
            // 
            // cpanelfloor
            // 
            this.cpanelfloor.AutoSize = true;
            this.cpanelfloor.BackColor = System.Drawing.SystemColors.Control;
            this.cpanelfloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cpanelfloor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cpanelfloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpanelfloor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cpanelfloor.Location = new System.Drawing.Point(766, 363);
            this.cpanelfloor.Name = "cpanelfloor";
            this.cpanelfloor.Size = new System.Drawing.Size(19, 19);
            this.cpanelfloor.TabIndex = 6;
            this.cpanelfloor.Text = "0";
            // 
            // display1
            // 
            this.display1.AutoSize = true;
            this.display1.BackColor = System.Drawing.SystemColors.Control;
            this.display1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.display1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.display1.Location = new System.Drawing.Point(669, 87);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(19, 19);
            this.display1.TabIndex = 6;
            this.display1.Text = "0";
            // 
            // display0
            // 
            this.display0.AutoSize = true;
            this.display0.BackColor = System.Drawing.SystemColors.Control;
            this.display0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.display0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display0.ForeColor = System.Drawing.Color.DodgerBlue;
            this.display0.Location = new System.Drawing.Point(669, 287);
            this.display0.Name = "display0";
            this.display0.Size = new System.Drawing.Size(19, 19);
            this.display0.TabIndex = 6;
            this.display0.Text = "0";
            // 
            // timermoving
            // 
            this.timermoving.Tick += new System.EventHandler(this.timermoving_Tick);
            // 
            // timerOpenDoor
            // 
            this.timerOpenDoor.Interval = 500;
            this.timerOpenDoor.Tick += new System.EventHandler(this.timeropendoor_Tick);
            // 
            // elevatorOpen
            // 
            this.elevatorOpen.Image = global::ElevatorSys.Properties.Resources.open;
            this.elevatorOpen.Location = new System.Drawing.Point(345, 246);
            this.elevatorOpen.Name = "elevatorOpen";
            this.elevatorOpen.Size = new System.Drawing.Size(120, 150);
            this.elevatorOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevatorOpen.TabIndex = 1;
            this.elevatorOpen.TabStop = false;
            this.elevatorOpen.Visible = false;
            // 
            // timerCloseDoor
            // 
            this.timerCloseDoor.Interval = 2500;
            this.timerCloseDoor.Tick += new System.EventHandler(this.timerCloseDoor_Tick);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(43, 106);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.Size = new System.Drawing.Size(446, 400);
            this.dataGridViewLogs.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(43, 513);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 561);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewLogs);
            this.Controls.Add(this.cpanel0);
            this.Controls.Add(this.display0);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.cpanelfloor);
            this.Controls.Add(this.cpanel1);
            this.Controls.Add(this.callbtn1);
            this.Controls.Add(this.callbtn0);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.elevatorOpen);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Elevator System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox elevator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button callbtn0;
        private System.Windows.Forms.Button callbtn1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label cpanel1;
        private System.Windows.Forms.Label cpanel0;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label cpanelfloor;
        private System.Windows.Forms.Label display1;
        private System.Windows.Forms.Label display0;
        private System.Windows.Forms.Timer timermoving;
        private System.Windows.Forms.Timer timerOpenDoor;
        private System.Windows.Forms.PictureBox elevatorOpen;
        private System.Windows.Forms.Timer timerCloseDoor;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

