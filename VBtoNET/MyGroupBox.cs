using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyGroupBox
    {

        General general;
        


        public MyGroupBox Create(int beginline, int endline, string[] lines)
        {
            MyGroupBox o = new MyGroupBox();
            string key = "Begin VB.Frame ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);

            return o;

        }

        public string Convert(MyGroupBox o, string s, List<string> controlVariableArray, List<string> controlFormArray, List<string> controlGBArray, object parentObj)
        {

            string name = o.General.Name;
            s = VBtoNET.CreateNETCode(s, o.General, "GroupBox", controlVariableArray, controlFormArray, controlGBArray, parentObj);


            

            //    '
            //'ListBox1
            //'
            //Me.ListBox1.FormattingEnabled = True
            //Me.ListBox1.Location = New System.Drawing.Point(131, 24)
            //Me.ListBox1.Name = "ListBox1"
            //Me.ListBox1.Size = New System.Drawing.Size(120, 43)
            //Me.ListBox1.TabIndex = 5


            //controlVariableArray.Add("Friend WithEvents " + name + " As GroupBox\r");
            //controlFormArray.Add("Me.Controls.Add(Me." + name + ")\r");
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
