using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeehiveSimulator {
    class Queen {
        private Worker[] workers;
        private int shiftNumber = 0;
        public Queen(Worker[] workers) {      // constructor
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts) {        // check each worker, calling their DoThisJob() until one is found that can work the job
            foreach (var bee in workers) {
                if (bee.DoThisJob(job, shifts))                    
                    return true;
            }
            return false;  // return false if no bee can do the job
        }

        public string WorkNext() {
            shiftNumber++;
            string result = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++) {
                if (workers[i].DidYouFinish())
                    result += "Bee #" + (i + 1) + " finished the job\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    result += "Bee #" + (i + 1) + " is not working\r\n";
                else {
                    if (workers[i].ShiftsLeft > 0)
                        result += "Bee #" + (i + 1) + " is doing " + workers[i].CurrentJob + " for " + workers[i].ShiftsLeft + " more shifts\r\n";
                    else
                        result += "Worker #" + (i + 1) + " will be done with " + workers[i].CurrentJob + " after this shift\r\n";
                }
            }
            return result;  // return the constructed string, for the report
        }
    }
}