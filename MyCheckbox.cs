using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyCheckbox
    {

        bool UseVisualStyleBackColor = true;
        General general;


        public MyCheckbox CreateCheckbox(int beginline, int endline, string[] lines)
        {
            MyCheckbox o = new MyCheckbox();
            string key = "Begin VB.CheckBox ";

            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);
            o.UseVisualStyleBackColor1 = true;
            return o;

        }

        public string ConvertCheckbox(MyCheckbox c, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj)
        {

            string name = c.General.Name;
            
            s = VBtoNET.CreateNETCode(s, c.General, "CheckBox", controlVariableArray, controlFormArray, controlGBArray, parentObj);


            return s;
        }




        public bool UseVisualStyleBackColor1
        {
            get
            {
                return UseVisualStyleBackColor;
            }

            set
            {
                UseVisualStyleBackColor = value;
            }
        }

        public General General
        {
            get
            {
                return general;
            }

            set
            {
                general = value;
            }
        }


    }
}
