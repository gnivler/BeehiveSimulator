using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSimulator {
    class Worker {
        public string CurrentJob { get; }
        public int ShiftsLeft { get; }
        private int ShiftsToWork, shiftsWorked;
        private string[] mySkills;

        public Worker (string[] skills) {  // constructor adds array of strings from form inititalization
            mySkills = skills;
        }

        public bool DoThisJob() {
            // return true if bee can accept assigment
            return true;
        }

        public bool DidYouFinish() {
            // return true if bee finished job
            return true;
        }
    }
}