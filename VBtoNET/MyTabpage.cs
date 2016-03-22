using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET {
    class MyTabpage {
        General general;
        int padding;
        List<string> controlNameList = new List<string>();

        bool useVisualStyleBackColor = true;


        public General General {
            get {
                return general;
            }

            set {
                general = value;
            }
        }

        public int Padding {
            get {
                return padding;
            }

            set {
                padding = value;
            }
        }

  

        public bool UseVisualStyleBackColor {
            get {
                return useVisualStyleBackColor;
            }

            set {
                useVisualStyleBackColor = value;
            }
        }

        public List<string> ControlNameList {
            get {
                return controlNameList;
            }

            set {
                controlNameList = value;
            }
        }
    }
}
