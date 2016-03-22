using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    class MyButton
    {
        bool UseVisualStyleBackColor = true;
        General general;


        public MyButton CreateButton(int beginline, int endline, string[] lines)
        {
            MyButton o = new MyButton();

            o.General = VBtoNET.PopulateGeneral("Begin VB.CommandButton ", lines, beginline, endline);

            if (String.IsNullOrEmpty(o.General.Text))
                o.General.Text = o.General.Name;

            o.UseVisualStyleBackColor1 = true;
            return o;

        }

        public string ConvertButton(MyButton b, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj)
        {
            string name = b.General.Name;
            s = VBtoNET.CreateNETCode(s, b.General, "Button", controlVariableArray, controlFormArray, controlGBArray, parentObj);
            
            s += VBtoNET.padding + "Me." + name + ".UseVisualStyleBackColor = " + b.UseVisualStyleBackColor1.ToString() + "\r";

            //Me.Button1 = New System.Windows.Forms.Button()
            //Me.SuspendLayout()
            //'
            //'Button1
            //'
            //Me.Button1.Location = New System.Drawing.Point(34, 79)
            //Me.Button1.Name = "Button1"
            //Me.Button1.Size = New System.Drawing.Size(75, 23)
            //Me.Button1.TabIndex = 0
            //Me.Button1.Text = "Button1"
            //Me.Button1.UseVisualStyleBackColor = True

            // TODO rest of it



            //Friend WithEvents Button1 As Button

            // do these get updated??

            
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
