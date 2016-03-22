using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyListbox
    {

        General general;


        public MyListbox Create(int beginline, int endline, string[] lines)
        {
            MyListbox o = new MyListbox();

            if (lines[beginline].Contains("MSDBCtls.DBList "))
                o.General = VBtoNET.PopulateGeneral("Begin MSDBCtls.DBList ", lines, beginline, endline);
            else
                o.General = VBtoNET.PopulateGeneral("Begin VB.ListBox ", lines, beginline, endline);


            return o;

        }

        public string Convert(MyListbox o, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj)
        {
            string name = o.General.Name;
            s = VBtoNET.CreateNETCode(s, o.General, "ListBox", controlVariableArray, controlFormArray, controlGBArray, parentObj);
            s += VBtoNET.padding + "Me." + name + ".FormattingEnabled = True\r";

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
