using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyCombobox
    {



        General general;


        public MyCombobox Create(int beginline, int endline, string[] lines)
        {
            MyCombobox o = new MyCombobox();
            
            string key = "Begin MSDBCtls.DBCombo ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);
            return o;

        }

        public string Convert(MyCombobox o, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj)
        {

            string name = o.General.Name;
            s = VBtoNET.CreateNETCode(s, o.General, "ComboBox", controlVariableArray, controlFormArray, controlGBArray, parentObj);

            return s;
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
