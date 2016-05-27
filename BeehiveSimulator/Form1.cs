﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveSimulator {
    public partial class Form1 : Form {
        Queen queen;
        public Form1() {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];       // build an array of 4 elements and instantiate a Queen object, using it in the constructor
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }

        private void assignJob_Click(object sender, EventArgs e) {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value))             
                MessageBox.Show(workerBeeJob.Text + " will be done in " + (int)shifts.Value + " shifts.");
            else
                MessageBox.Show("There's no available worker for this job.");
        }

        private void nextShift_Click(object sender, EventArgs e) {
            queen.WorkNext();
        }
    }
}