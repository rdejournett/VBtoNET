using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyTextbox
    {
         
        General general;
        bool multiline = false;
        string dataField = "";
        string dataSource = "";
        

        public MyTextbox Create(int beginline, int endline, string[] lines)
        {
            MyTextbox o = new MyTextbox();
            string key = "Begin VB.TextBox ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);
            string multi = VBtoNET.GetProperty("MultiLine", beginline, endline, lines);
            if (multi.Contains("-1")) o.Multiline = true;
            o.dataSource = VBtoNET.GetProperty("DataSource", beginline, endline, lines);
            o.dataField = VBtoNET.GetProperty("DataField", beginline, endline, lines);

            return o;

        }

        public string Convert(MyTextbox o, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj, List<string> datasourceArray)
        {

            string name = o.General.Name;
            s = VBtoNET.CreateNETCode(s, o.General, "TextBox", controlVariableArray, controlFormArray, controlGBArray, parentObj);

            s += VBtoNET.padding + "Me." + name + ".Text = \"" + o.General.Text + "\"" + "\r";
            s += VBtoNET.padding + "Me." + name + ".Multiline = " + multiline.ToString() + "" + "\r";
            if (!String.IsNullOrEmpty(o.dataField))
                s += VBtoNET.padding + "'Datafield = \"" + o.dataField + "\"" + "\r";
            if (!String.IsNullOrEmpty(o.dataSource))
                s += VBtoNET.padding + "'Datasource = \"" + o.dataSource + "\"" + "\r";

            if (!String.IsNullOrEmpty(o.dataSource) && !String.IsNullOrEmpty(o.dataField))
                datasourceArray.Add(name + ".Text = " + o.dataSource.Replace("rdc", "dt") + ".Rows(0)(\"" + o.dataField + "\").toString");

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

        public string DataField {
            get {
                return dataField;
            }

            set {
                dataField = value;
            }
        }

        public string DataSource {
            get {
                return dataSource;
            }

            set {
                dataSource = value;
            }
        }
    }

}
