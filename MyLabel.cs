using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyLabel
    {
        General general;


        public MyLabel Create(int beginline, int endline, string[] lines)
        {
            MyLabel o = new MyLabel();
            string key = "Begin VB.Label ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);
            if (String.IsNullOrEmpty(o.General.Text)) o.General.Text = o.General.Name;

            int sizex = Int16.Parse(o.General.Sizex);
            sizex += 10; // the font or size is a bit off in the conversion
            o.General.Sizex = sizex.ToString();
            return o;

        }

        public string Convert(MyLabel l, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj)
        {

            string name = l.General.Name;

            s = VBtoNET.CreateNETCode(s, l.General, "Label", controlVariableArray, controlFormArray, controlGBArray, parentObj);
            s += VBtoNET.padding + "Me." + name + ".Text = \"" + l.General.Text + "\"" + "\r";


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
