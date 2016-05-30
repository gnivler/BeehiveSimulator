using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSimulator {
    class Worker {
        private string currentJob = "";     // backing field needed
        public string CurrentJob {
            get {
                return currentJob;      // if job return job string
            }                
        }

        public int ShiftsLeft {
            get { return shiftsToWork - shiftsWorked; }
        }

        private int shiftsToWork, shiftsWorked;
        private string[] mySkills;

        public Worker (string[] skills) {  // constructor adds array of strings from form inititalization
            mySkills = skills;
        }

        public bool DoThisJob(string job, int shifts) {     // see if this bee can perform a specific job (by string name)
            if (!String.IsNullOrEmpty(CurrentJob))      // false if still working shifts, no point in checking if they can do the job
                return false;
            /* foreach (var skill in mySkills) {
                if (skill == job)
                    this.shiftsToWork = shifts;
                    currentJob = job;
                    shiftsWorked = 0;
                    return true;        // ready and able to do the job
            } */
            for (int i = 0; i < mySkills.Length; i++) {
                if (mySkills[i] == job) {
                    currentJob = job;
                    this.shiftsToWork = shifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;       // bee isn't busy but can't do the job either
        }

        public bool DidYouFinish() {
            if (String.IsNullOrEmpty(currentJob))
                return false;       // currentJob is empty
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork) {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;        // all the shifts were worked so reset the fields and be ready for assigment
            }
            return false;
        }
    }
}