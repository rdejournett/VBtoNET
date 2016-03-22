using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET {
    class MyDatagridview {

        General general;


        public MyDatagridview Create(int beginline, int endline, string[] lines) {
            MyDatagridview o = new MyDatagridview();
            string key = "Begin MSDBGrid.DBGrid ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);
            if (String.IsNullOrEmpty(o.General.Text)) o.General.Text = o.General.Name;

            int sizex = Int16.Parse(o.General.Sizex);
            o.General.Sizex = sizex.ToString();
            return o;

        }

        public string Convert(MyDatagridview l, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj) {

            string name = l.General.Name;

            s = VBtoNET.CreateNETCode(s, l.General, "DataGridView", controlVariableArray, controlFormArray, controlGBArray, parentObj);

            s += VBtoNET.padding + "Me." + name + ".ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize\r";

            return s;
        }




        public General General {
            get {
                return general;
            }

            set {
                general = value;
            }
        }

        //        'DataGridView1
        //'
        //Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        //Me.DataGridView1.Location = New System.Drawing.Point(356, 179)
        //Me.DataGridView1.Name = "DataGridView1"
        //Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        //Me.DataGridView1.TabIndex = 9
    }
}
