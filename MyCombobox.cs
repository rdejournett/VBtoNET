using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyCombobox
    {

        string dataField = "";
        string dataSource = "";

        General general;


        public MyCombobox Create(int beginline, int endline, string[] lines)
        {
            MyCombobox o = new MyCombobox();
            
            string key = "Begin MSDBCtls.DBCombo ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);
            o.dataSource = VBtoNET.GetProperty("DataSource", beginline, endline, lines);
            o.dataField = VBtoNET.GetProperty("DataField", beginline, endline, lines);

            return o;

        }

        public string Convert(MyCombobox o, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj, List<string> datasourceArray)
        {

            string name = o.General.Name;
            s = VBtoNET.CreateNETCode(s, o.General, "ComboBox", controlVariableArray, controlFormArray, controlGBArray, parentObj);
            if (!String.IsNullOrEmpty(o.dataField))
                s += VBtoNET.padding + "'Datafield = \"" + o.dataField + "\"" + "\r";
            if (!String.IsNullOrEmpty(o.dataSource))
                s += VBtoNET.padding + "'Datasource = \"" + o.dataSource + "\"" + "\r";

            if (!String.IsNullOrEmpty(o.dataSource) && !String.IsNullOrEmpty(o.dataField))
                datasourceArray.Add(name + ".SelectedValue = " + o.dataSource.Replace("rdc", "dt") + ".Rows(0)(\"" + o.dataField + "\").toString");


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
