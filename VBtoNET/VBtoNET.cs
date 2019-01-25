using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBtoNET
{
    public partial class VBtoNET : Form
    {
        List<string> controlVariableArray = new List<string>();
        List<string> controlFormArray = new List<string>();
        List<string> controlGBArray = new List<string>();
        List<object> parentArray = new List<object>();
        static public List<string> controlDBList = new List<string>(); // stores databindings
        List<string> controlTypeList = new List<string>()
        {
            "VB.Form",
            "VB.Frame",
            "VB.CommandButton",
            "VB.CheckBox",
            "VB.Label",
            "VB.TextBox",
            "MSDBCtls.DBCombo",
            "VB.ListBox",
            "MSDBCtls.DBList"
        };

        public const string padding = "        ";
        string output = "";

        public VBtoNET()
        {
            InitializeComponent();
        }

        private void InitNetDesigner()
        {
            string s = @"<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ##REPLACENAME## ";
            s += "\r";
            s += System.IO.File.ReadAllText("DesignerTemplate.txt");
            output = s;

            controlVariableArray = new List<string>();
            controlFormArray = new List<string>();
            controlGBArray = new List<string>();
            parentArray = new List<object>();
            controlDBList = new List<string>(); // stores databindings
            controlTypeList = new List<string>();

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //try {
            rtbNET.Text = "";
            
            InitNetDesigner();
            int beginline = 0, endline = 0;
            MyForm form = new MyForm();
            bool formEnd = false;


            bool inGroupBox = false, inTabControl = false;
            string s = "";
            //object parentObj = new object();
            //object priorParentObj = new object();

            for (int i = 0; i < rtbVB.Lines.Count(); i++)
            {

                if (inGroupBox) // solves issue of the first control of the group box being skipped
                {
                    inGroupBox = false; // reset the flag
                    i--;
                }
                else if (inTabControl) {
                    inTabControl = false; // reset the flag
                    i--;
                } else
                    s = rtbVB.Lines[i];

                if (s.Contains("Begin VB.Form")) {

                    beginline = i;
                    do
                    {
                        i++;
                        s = rtbVB.Lines[i];
                        if (i > beginline && s.Contains("Begin")) formEnd = true;
                        
                    }
                    while (!formEnd && i < rtbVB.Lines.Count());
                    endline = i;
                    form = form.CreateForm(beginline, endline, rtbVB.Lines);
                    
                    if (form.General == null || String.IsNullOrEmpty(form.General.Name)) {
                        MessageBox.Show("Trouble parsing VB form, did you input a VB .frm file?");
                        return;
                    }
                    txtFormName.Text = form.General.Name;
                    parentArray.Add((MyForm)form);
                }  

                if (s.Contains("Begin VB.Frame ")) {

                    beginline = i;
                    do {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);

                    } while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End ") && (s.Trim().Length >= 6 && !s.Trim().Substring(0,6).Equals("Begin ")) );
                    //while (!s.Trim().Equals("End") && i < rtbVB.Lines.Count() && controlEnd);
                    endline = i;
                    MyGroupBox o = new MyGroupBox();
                    o = o.Create(beginline, endline, rtbVB.Lines);
                    output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count-1]);
                    parentArray.Add(o);
                    inGroupBox = true;

                }  else if (s.Contains("Begin VB.CommandButton")) {
                    beginline = i;
                    do
                    {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    }
                    while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                    endline = i;
                    MyButton button = new MyButton();
                    button = button.CreateButton(beginline, endline, rtbVB.Lines);
                    output = button.ConvertButton(button, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);

                } else if (s.Contains("Begin VB.CheckBox")) {
                    beginline = i;
                    do {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    } while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                    endline = i;
                    MyCheckbox c = new MyCheckbox();
                    c = c.CreateCheckbox(beginline, endline, rtbVB.Lines);
                    output = c.ConvertCheckbox(c, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);

                } else if (s.Contains("Begin VB.Label")) {
                    beginline = i;
                    do {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    } while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                    endline = i;
                    MyLabel l = new MyLabel();
                    l = l.Create(beginline, endline, rtbVB.Lines);
                    output = l.Convert(l, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);

                } else if (s.Contains("Begin VB.TextBox")) {
                    beginline = i;
                    do
                    {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    }
                    while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                    endline = i;
                    MyTextbox o = new MyTextbox();
                    o = o.Create(beginline, endline, rtbVB.Lines);
                    output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);
                } else if (s.Contains("Begin MSDBCtls.DBCombo")) {
                    beginline = i;
                    do
                    {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    }
                    while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                    endline = i;
                    MyCombobox o = new MyCombobox();
                    o = o.Create(beginline, endline, rtbVB.Lines);
                    output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);
                } else if (s.Contains("Begin VB.ListBox") || s.Contains("Begin MSDBCtls.DBList")) {
                    beginline = i;
                    do
                    {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    }
                    while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                    endline = i;
                    MyListbox o = new MyListbox();
                    o = o.Create(beginline, endline, rtbVB.Lines);
                    output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);
                
                } else if (s.Contains("Begin TabDlg.SSTab ")) { // tab control
                    beginline = i;
                    do
                    {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    } while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End ") && (s.Trim().Length >= 6 && !s.Trim().Substring(0, 6).Equals("Begin "))) ;
                    endline = i;
                    MyTabControl o = new MyTabControl();
                    o = o.Create(beginline, endline, rtbVB.Lines);
                    output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);
                    parentArray.Add(o);
                    inTabControl = true; // not sure if we need another variable specifically for tabcontrols.
                } else if (s.Contains("Begin MSDBGrid.DBGrid")) {
                    beginline = i;
                    do {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    }
                    while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                    endline = i;
                    MyDatagridview o = new MyDatagridview();
                    o = o.Create(beginline, endline, rtbVB.Lines);
                    output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);

                } else if (s.Contains("Begin")) {  // catches and removes unsupported things.
                
                    bool knownControl = false;
                    foreach (string ctrl in controlTypeList) {
                        if (s.Contains(ctrl))
                            knownControl = true;
                    }
                    do {
                        i++;
                        s = rtbVB.Lines[i];
                        if (s.Contains("BeginProperty")) SkipProperties(i, s);
                    } while (!knownControl && i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                }

                if (s.Trim().Equals("End") && rtbVB.Lines[i-1].Trim().Equals("End")) // two Ends alone means end of a parent
                {
                    if (i > 1500 || parentArray.Count == 1)
                    {
                        string foo = "bar";
                    }


                    // end of group box
                    parentArray.RemoveAt(parentArray.Count - 1); //pop
                    foreach (string ctrlstr in controlGBArray)
                    {
                        output += VBtoNET.padding + ctrlstr;
                    }

                    controlGBArray = new List<string>();
                }

            }
            // set up form


            output = form.ConvertForm(form, output, controlFormArray); 
            if (String.IsNullOrEmpty(output)) {
                MessageBox.Show("Trouble parsing VB form, did you input a VB .frm file?");
                return;
            }
            // end the file
            EndDesigner();
            this.Cursor = Cursors.Arrow;
            //} catch (Exception ex) {
            //    this.Cursor = Cursors.Arrow;
            //    MessageBox.Show("Exception in VB6 Parsing: " + ex.Message);
            //}
        }

        private void SkipProperties(int i, string s)
        {
            do
            {
                i++;
                s = rtbVB.Lines[i];
            } while (!s.Contains("EndProperty"));
        }

        private void EndDesigner()
        {
            string s = "\r\r  End Sub\r";
            foreach (string ctrl in controlVariableArray)
            {
                s += ctrl;
            }
            s += "\r\r\r'     -----Control Databindings-----\r";
            foreach (string ctrl in controlDBList) {
                s += "'" + ctrl;
            }

            s += "End Class\r";
            output = output + s;
            rtbNET.Text = output;
        }

        public static string GetFirstWord(string line) {
            line = line.Trim();
            if (line.IndexOf(" ") >0)
                line = line.Substring(0, line.IndexOf(" "));
            return line;
        }
        public static string GetProperty(string target, int beginline, int endline, string[] lines)
        {
            string property = "";
            beginline++;
            string line = GetFirstWord(lines[beginline]);
            //string firstWord = line.Trim().Substring(0, line.IndexOf(" "));
            //if (String.IsNullOrEmpty(firstWord)) return ""; // we are not in the right spot, abort.
            int i = beginline;
            while (!line.Contains(target) && i < endline && i < lines.Count()) 
            {
                i++;
                line = GetFirstWord(lines[i]);
            }
            if (i == endline)
                property = "";
            else
                property = lines[i].Substring(lines[i].IndexOf('=') + 1).Trim().Replace("\"", "");
            return property;
        }

     public static string CreateNETCode (string s, General g, string objectName, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj)
        {
            string name = g.Name;
            s += VBtoNET.padding + "'\r";
            s += VBtoNET.padding + "'" + name + "\r";
            s += VBtoNET.padding + "'\r";
            s += VBtoNET.padding + "Me." + name + " = New System.Windows.Forms." + objectName + "()\r";
            s += VBtoNET.padding + "Me." + name + ".Location = new System.Drawing.Point(" + g.Locationx + "," + g.Locationy + ")" + "\r";
            s += VBtoNET.padding + "Me." + name + ".Name = \"" + name + "\"\r";
            s += VBtoNET.padding + "Me." + name + ".Size = new System.Drawing.Size(" + g.Sizex + "," + g.Sizey + ")" + "\r";
            s += VBtoNET.padding + "Me." + name + ".TabIndex = " + g.Tabindex + "\r";
            s += VBtoNET.padding + "Me." + name + ".Text = \"" + g.Text + "\"" + "\r";

            controlVariableArray.Add("Friend WithEvents " + name + " As " + objectName + "\r");

            Type t = parentObj.GetType();
            if (objectName.Equals("TabPage")) {
                // don't add to the form if a tabpage
            }
            else if (t.Equals(typeof(MyForm)))
                controlFormArray.Add("Me.Controls.Add(Me." + name + ")\r");
            else if (t.Equals(typeof(MyGroupBox))) {
                MyGroupBox gb = (MyGroupBox)parentObj;
                controlGBArray.Add("Me." + gb.General.Name + ".Controls.Add(Me." + name + ")\r");
                //Me.GroupBox1.Controls.Add(Me.TextBox1)

            } else if (t.Equals(typeof(MyTabControl))) {
                // need to figure out which tabpage it belongs to
                MyTabControl tc = (MyTabControl)parentObj;
                string parent = "";
                string key = "";
                key = !String.IsNullOrEmpty(g.ArrayName) ? g.ArrayName : g.Name;

                tc.ControlNameMap.TryGetValue(key, out parent);
                controlGBArray.Add("Me." + parent + ".Controls.Add(Me." + name + ")\r");

            }
            return s;
        }

        public static General PopulateGeneral (string key, string[] lines, int beginline, int endline)
        {
            General g = new General();
            
            int pos = lines[beginline].IndexOf(key) + key.Length;

            string name = lines[beginline].Substring(pos).Trim();

            // check if its a control array - same name
            string index = VBtoNET.GetProperty(" Index", beginline, endline, lines);
            if (!String.IsNullOrEmpty(index)) {
                // its an array
                g.ArrayName = name + "(" + index + ")";
                name = name + beginline.ToString(); // odd but guarantees uniqueness

            }

            //controlNameList.Add(name);
            g.Name = name;

            g.Sizey = VBtoNET.GetProperty("Height", beginline, endline, lines);
            g.Locationx = VBtoNET.GetProperty("Left", beginline, endline, lines);
            g.Tabindex = VBtoNET.GetProperty("TabIndex", beginline, endline, lines);
            g.Locationy = VBtoNET.GetProperty("Top", beginline, endline, lines);
            g.Sizex = VBtoNET.GetProperty("Width", beginline, endline, lines);
            g.Text = VBtoNET.GetProperty("Caption", beginline, endline, lines);

            g = g.FixSizes(g);
            return g;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e) {
            Clipboard.SetText(rtbNET.Text);
        }
    }




   
   
}
