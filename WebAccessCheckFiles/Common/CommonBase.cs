using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAccessCheckFiles
{
    class CommonBase
    {
        public static string szIniFileName { get; set; }

        public static string szNodeLoaction { get; set; }

        //public static string szIniExtFileName { get; set; }

        public static string szIniLogFileName { get; set; }

        public List<string> szLocalFiles { get; set; }
        public List<string> szLocalChecksum { get; set; }

        public List<string> szTargetFiles { get; set; }
        public List<string> szTargetChecksum { get; set; }

        public List<string> szFailFiles { get; set; }

        public CommonBase() {

            szIniFileName = "template.ini";

            szNodeLoaction = "C:\\WebAccess\\Node"; // defalut

            //szIniExtFileName = "export.ini";

            szIniLogFileName = "log.ini";

            szLocalFiles = new List<string>();
            szLocalChecksum = new List<string>();

            szTargetFiles = new List<string>();
            szTargetChecksum = new List<string>();

            szFailFiles = new List<string>();
        }
    }
}
