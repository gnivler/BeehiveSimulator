using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSimulator {
    class Queen {
        private Worker workers;
        private int shiftNumber = 0;
        public Queen(Worker workers) {
            this.workers = workers;
        }

        public bool AssignWork(string job) {
            return true;  // return false if no bee can do the job
        }

        public string WorkNext() {
            string result = "";
            return result;  // return the constructed string, for the report
        }

    }
}
