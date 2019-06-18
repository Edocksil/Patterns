using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab
{
    //singletone class
    class Journal
    {
        private static Journal instance = null;

        private string log = "";
        private int logCount = 1;
        private string lastLog = "";
        readonly string nl = "\r\n";

        private Journal() { }

        public string LogFull { get { return log; } }

        public string LastLog()
        {
            return lastLog;
        }

        public void LogNow(Player player, string message)
        {
            logCount++;
            log += nl + logCount + ": " + player.ToString() + ": " + message;
            lastLog = nl + (logCount - 1).ToString() + ": " + player.ToString() + ": " + message;
        }

        public void Clear()
        {
            logCount = 1;
            lastLog = "";
            log = "";
        }

        public static Journal getInstance()
        {
            if (instance == null)
                instance = new Journal();
            return instance;
        }
    }
}
