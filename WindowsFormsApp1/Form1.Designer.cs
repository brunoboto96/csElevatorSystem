using System;
using System.Drawing;

namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerTransition = new System.Windows.Forms.Timer(this.components);
            this.call0 = new System.Windows.Forms.Button();
            this.call1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.elevator = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerDoorOpen = new System.Windows.Forms.Timer(this.components);
            this.timerDoorClosing = new System.Windows.Forms.Timer(this.components);
            this.light1 = new System.Windows.Forms.PictureBox();
            this.light0 = new System.Windows.Forms.PictureBox();
            this.timerCheckCalls = new System.Windows.Forms.Timer(this.components);
            this.labelFloor0 = new System.Windows.Forms.Label();
            this.labelFloor1 = new System.Windows.Forms.Label();
            this.controlPanelBody = new System.Windows.Forms.PictureBox();
            this.controlPanelStatus = new System.Windows.Forms.PictureBox();
            this.controlPanelLabel1 = new System.Windows.Forms.Label();
            this.controlPanelLabel0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doorOpen = new System.Windows.Forms.PictureBox();
            this.doorR = new System.Windows.Forms.PictureBox();
            this.doorL = new System.Windows.Forms.PictureBox();
            this.doorOpenAnim = new System.Windows.Forms.Timer(this.components);
            this.elevatorfacade = new System.Windows.Forms.PictureBox();
            this.elevatorfacade1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanelBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanelStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorfacade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorfacade1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTransition
            // 
            this.timerTransition.Interval = 20;
            this.timerTransition.Tick += new System.EventHandler(this.timerTransition_Tick);
            // 
            // call0
            // 
            this.call0.FlatAppearance.BorderSize = 2;
            this.call0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.call0.Location = new System.Drawing.Point(102, 432);
            this.call0.Name = "call0";
            this.call0.Size = new System.Drawing.Size(27, 23);
            this.call0.TabIndex = 1;
            this.call0.Text = "O";
            this.call0.UseVisualStyleBackColor = true;
            this.call0.Click += new System.EventHandler(this.call0_Click);
            // 
            // call1
            // 
            this.call1.FlatAppearance.BorderSize = 2;
            this.call1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.call1.Location = new System.Drawing.Point(102, 123);
            this.call1.Name = "call1";
            this.call1.Size = new System.Drawing.Size(27, 23);
            this.call1.TabIndex = 1;
            this.call1.Text = "O";
            this.call1.UseVisualStyleBackColor = true;
            this.call1.Click += new System.EventHandler(this.call1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(80, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox2.Location = new System.Drawing.Point(80, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // elevator
            // 
            this.elevator.Image = ((System.Drawing.Image)(resources.GetObject("elevator.Image")));
            this.elevator.Location = new System.Drawing.Point(135, 350);
            this.elevator.MaximumSize = new System.Drawing.Size(90, 160);
            this.elevator.MinimumSize = new System.Drawing.Size(90, 160);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(90, 160);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevator.TabIndex = 0;
            this.elevator.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(80, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 100);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // timerDoorOpen
            // 
            this.timerDoorOpen.Interval = 1000;
            this.timerDoorOpen.Tick += new System.EventHandler(this.timerDoorOpen_Tick);
            // 
            // timerDoorClosing
            // 
            this.timerDoorClosing.Interval = 1000;
            this.timerDoorClosing.Tick += new System.EventHandler(this.timerDoorClosing_Tick);
            // 
            // light1
            // 
            this.light1.BackColor = System.Drawing.Color.Lime;
            this.light1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.light1.Location = new System.Drawing.Point(95, 116);
            this.light1.Name = "light1";
            this.light1.Size = new System.Drawing.Size(40, 38);
            this.light1.TabIndex = 2;
            this.light1.TabStop = false;
            // 
            // light0
            // 
            this.light0.BackColor = System.Drawing.Color.Lime;
            this.light0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.light0.Location = new System.Drawing.Point(95, 425);
            this.light0.Name = "light0";
            this.light0.Size = new System.Drawing.Size(40, 38);
            this.light0.TabIndex = 2;
            this.light0.TabStop = false;
            // 
            // timerCheckCalls
            // 
            this.timerCheckCalls.Enabled = true;
            this.timerCheckCalls.Interval = 1000;
            this.timerCheckCalls.Tick += new System.EventHandler(this.timerCheckCalls_Tick);
            // 
            // labelFloor0
            // 
            this.labelFloor0.AutoSize = true;
            this.labelFloor0.BackColor = System.Drawing.Color.Black;
            this.labelFloor0.ForeColor = System.Drawing.Color.Red;
            this.labelFloor0.Location = new System.Drawing.Point(177, 332);
            this.labelFloor0.Name = "labelFloor0";
            this.labelFloor0.Size = new System.Drawing.Size(13, 13);
            this.labelFloor0.TabIndex = 3;
            this.labelFloor0.Text = "0";
            // 
            // labelFloor1
            // 
            this.labelFloor1.AutoSize = true;
            this.labelFloor1.BackColor = System.Drawing.Color.Black;
            this.labelFloor1.ForeColor = System.Drawing.Color.Red;
            this.labelFloor1.Location = new System.Drawing.Point(177, 33);
            this.labelFloor1.Name = "labelFloor1";
            this.labelFloor1.Size = new System.Drawing.Size(13, 13);
            this.labelFloor1.TabIndex = 3;
            this.labelFloor1.Text = "0";
            // 
            // controlPanelBody
            // 
            this.controlPanelBody.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlPanelBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlPanelBody.Location = new System.Drawing.Point(455, 228);
            this.controlPanelBody.Name = "controlPanelBody";
            this.controlPanelBody.Size = new System.Drawing.Size(63, 117);
            this.controlPanelBody.TabIndex = 4;
            this.controlPanelBody.TabStop = false;
            // 
            // controlPanelStatus
            // 
            this.controlPanelStatus.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.controlPanelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanelStatus.Location = new System.Drawing.Point(473, 243);
            this.controlPanelStatus.Name = "controlPanelStatus";
            this.controlPanelStatus.Size = new System.Drawing.Size(30, 30);
            this.controlPanelStatus.TabIndex = 5;
            this.controlPanelStatus.TabStop = false;
            // 
            // controlPanelLabel1
            // 
            this.controlPanelLabel1.AutoSize = true;
            this.controlPanelLabel1.BackColor = System.Drawing.Color.Black;
            this.controlPanelLabel1.Location = new System.Drawing.Point(481, 292);
            this.controlPanelLabel1.Name = "controlPanelLabel1";
            this.controlPanelLabel1.Size = new System.Drawing.Size(13, 13);
            this.controlPanelLabel1.TabIndex = 3;
            this.controlPanelLabel1.Text = "0";
            // 
            // controlPanelLabel0
            // 
            this.controlPanelLabel0.AutoSize = true;
            this.controlPanelLabel0.BackColor = System.Drawing.Color.Chartreuse;
            this.controlPanelLabel0.Location = new System.Drawing.Point(481, 317);
            this.controlPanelLabel0.Name = "controlPanelLabel0";
            this.controlPanelLabel0.Size = new System.Drawing.Size(13, 13);
            this.controlPanelLabel0.TabIndex = 3;
            this.controlPanelLabel0.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Control Panel";
            // 
            // doorOpen
            // 
            this.doorOpen.Image = ((System.Drawing.Image)(resources.GetObject("doorOpen.Image")));
            this.doorOpen.Location = new System.Drawing.Point(322, 350);
            this.doorOpen.Name = "doorOpen";
            this.doorOpen.Size = new System.Drawing.Size(90, 160);
            this.doorOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doorOpen.TabIndex = 7;
            this.doorOpen.TabStop = false;
            this.doorOpen.Visible = false;
            // 
            // doorR
            // 
            this.doorR.BackColor = System.Drawing.Color.Transparent;
            this.doorR.Image = ((System.Drawing.Image)(resources.GetObject("doorR.Image")));
            this.doorR.Location = new System.Drawing.Point(135, 51);
            this.doorR.Name = "doorR";
            this.doorR.Size = new System.Drawing.Size(90, 160);
            this.doorR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doorR.TabIndex = 7;
            this.doorR.TabStop = false;
            // 
            // doorL
            // 
            this.doorL.BackColor = System.Drawing.Color.Transparent;
            this.doorL.Image = ((System.Drawing.Image)(resources.GetObject("doorL.Image")));
            this.doorL.Location = new System.Drawing.Point(135, 51);
            this.doorL.Name = "doorL";
            this.doorL.Size = new System.Drawing.Size(90, 160);
            this.doorL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doorL.TabIndex = 7;
            this.doorL.TabStop = false;
            // 
            // doorOpenAnim
            // 
            this.doorOpenAnim.Interval = 50;
            this.doorOpenAnim.Tick += new System.EventHandler(this.doorOpenAnim_Tick);
            // 
            // elevatorfacade
            // 
            this.elevatorfacade.Image = ((System.Drawing.Image)(resources.GetObject("elevatorfacade.Image")));
            this.elevatorfacade.Location = new System.Drawing.Point(128, 345);
            this.elevatorfacade.Name = "elevatorfacade";
            this.elevatorfacade.Size = new System.Drawing.Size(103, 166);
            this.elevatorfacade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevatorfacade.TabIndex = 7;
            this.elevatorfacade.TabStop = false;
            this.elevatorfacade.Visible = false;
            // 
            // elevatorfacade1
            // 
            this.elevatorfacade1.BackColor = System.Drawing.Color.Transparent;
            this.elevatorfacade1.Image = ((System.Drawing.Image)(resources.GetObject("elevatorfacade1.Image")));
            this.elevatorfacade1.Location = new System.Drawing.Point(128, 45);
            this.elevatorfacade1.Name = "elevatorfacade1";
            this.elevatorfacade1.Size = new System.Drawing.Size(103, 166);
            this.elevatorfacade1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevatorfacade1.TabIndex = 7;
            this.elevatorfacade1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox4.Location = new System.Drawing.Point(231, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 198);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 623);
            this.Controls.Add(this.call1);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.doorR);
            this.Controls.Add(this.doorL);
            this.Controls.Add(this.elevatorfacade1);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.elevatorfacade);
            this.Controls.Add(this.doorOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlPanelLabel0);
            this.Controls.Add(this.controlPanelLabel1);
            this.Controls.Add(this.controlPanelStatus);
            this.Controls.Add(this.controlPanelBody);
            this.Controls.Add(this.call0);
            this.Controls.Add(this.light0);
            this.Controls.Add(this.labelFloor1);
            this.Controls.Add(this.labelFloor0);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "\\";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanelBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanelStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorfacade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorfacade1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        private void call0_Click(object sender, EventArgs e)
        {

            //timer1.Start();
            eSystem.callFloor0();
            
        }

        private void call1_Click(object sender, EventArgs e)
        {
            //timerTransition.Start();

            eSystem.callFloor1();
        }
        

       

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerTransition;
        private System.Windows.Forms.Button call0;
        private System.Windows.Forms.Button call1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox elevator;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerDoorOpen;
        private System.Windows.Forms.Timer timerDoorClosing;
        private System.Windows.Forms.PictureBox light1;
        private System.Windows.Forms.PictureBox light0;
        private System.Windows.Forms.Timer timerCheckCalls;
        private System.Windows.Forms.Label labelFloor0;
        private System.Windows.Forms.Label labelFloor1;
        private System.Windows.Forms.PictureBox controlPanelBody;
        private System.Windows.Forms.PictureBox controlPanelStatus;
        private System.Windows.Forms.Label controlPanelLabel1;
        private System.Windows.Forms.Label controlPanelLabel0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox doorOpen;
        private System.Windows.Forms.PictureBox doorR;
        private System.Windows.Forms.PictureBox doorL;
        private System.Windows.Forms.Timer doorOpenAnim;
        private System.Windows.Forms.PictureBox elevatorfacade;
        private System.Windows.Forms.PictureBox elevatorfacade1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }

   
}

