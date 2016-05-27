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
            string result = "";

            for (int i = 0; i < workers.Length; i++) {
                if (workers[i].DidYouFinish() {
                    result += "Bee #" + i + " is "
                }
            }

            return result;  // return the constructed string, for the report
        }
    }
}