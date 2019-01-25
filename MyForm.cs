using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBtoNET;

namespace VBtoNET
{
    class MyForm
    {

        General general;
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


        public MyForm CreateForm(int beginline, int endline, string[] lines)
        {
            
                MyForm frm = new MyForm();
                General g = new General();
            try
            {
                string key = "Begin VB.Form ";
                int pos = lines[beginline].IndexOf(key) + key.Length;

                string name = lines[beginline].Substring(pos).Trim();
                g.Name = name;


                g.Sizex = VBtoNET.GetProperty("ClientWidth", beginline, endline, lines);
                g.Sizey = VBtoNET.GetProperty("ClientHeight", beginline, endline, lines);

                g.Text = VBtoNET.GetProperty("Caption", beginline, endline, lines);
                if (String.IsNullOrEmpty(g.Text)) g.Text = name;

                g.FixSizes(g);
                frm.General = g;
            }
            catch (Exception e)
            {
                MessageBox.Show("General error - did you load a VB6 form?");
                return null;
                
            }
            return frm;

        }
        public string ConvertForm(MyForm form, string s, List<string> controlFormArray)
        {

            string name = form.General.Name;

                // first replace the form name

                s = s.Replace("##REPLACENAME##", name);
                s += VBtoNET.padding + "'\r";
                s += VBtoNET.padding + "'" + name + "\r";
                s += VBtoNET.padding + "'\r";
                s += VBtoNET.padding + "Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)\r";
                s += VBtoNET.padding + "Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font\r";
                s += VBtoNET.padding + "Me.ClientSize = New System.Drawing.Size(" + form.General.Sizex + "," + form.General.Sizey + ")" + "\r";
                s += VBtoNET.padding + "Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent" + "\r";


            // add controls
            foreach (string ctrlstr in controlFormArray)
                {
                    s += VBtoNET.padding + ctrlstr;
                }
                s += VBtoNET.padding + "Me.Name = \"" + name + "\"\r";
                s += VBtoNET.padding + "Me.Text = \"" + name + "\"\r";
                s += VBtoNET.padding + "Me.ResumeLayout(False)\r";


            return s;
            //        '
            //'Form1
            //'
            //Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            //Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            //Me.ClientSize = New System.Drawing.Size(284, 261)
            //Me.Controls.Add(Me.Button1)
            //Me.Name = "Form1"
            //Me.Text = "Form1"
            //Me.ResumeLayout(False)

        }

    }
}
