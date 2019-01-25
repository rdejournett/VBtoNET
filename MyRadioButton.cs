using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBtoNET
{
    class MyRadioButton
    {
        General general;
        bool multiline = false;
        string dataField = "";
        string dataSource = "";


        public MyRadioButton Create(int beginline, int endline, string[] lines)
        {
            MyRadioButton o = new MyRadioButton();
            string key = "Begin VB.OptionButton ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);

            return o;

        }

        public string Convert(MyRadioButton o, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj)
        {

            string name = o.General.Name;
            s = VBtoNET.CreateNETCode(s, o.General, "RadioButton", controlVariableArray, controlFormArray, controlGBArray, parentObj);

            s += VBtoNET.padding + "Me." + name + ".Text = \"" + o.General.Text + "\"" + "\r";

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

        public bool Multiline
        {
            get
            {
                return multiline;
            }

            set
            {
                multiline = value;
            }
        }

        public string DataField
        {
            get
            {
                return dataField;
            }

            set
            {
                dataField = value;
            }
        }

        public string DataSource
        {
            get
            {
                return dataSource;
            }

            set
            {
                dataSource = value;
            }
        }
    }
}

