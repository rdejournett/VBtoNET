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
        List<string> datasourceArray = new List<string>();
        string codeText = "";
        //static public List<string> controlNameList = new List<string>();
        int mylinenumer = 0;
        int recurssion = 0;
        string FormListString = "";
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

        List<string> files = new List<string>();

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

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try {

                ClearData(false);
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
                    mylinenumer = i;  // this is used for debugging

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
                    if (s.Contains("Option Explicit")) {

                        for (int j = i; j < rtbVB.Lines.Count(); j++)
                            codeText = codeText + rtbVB.Lines[j] + "\r\n";
                        break;
                    }

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
                        if (form == null) return; // bad parsing, exit
                        txtFormName.Text = form.General.Name;
                        parentArray.Add((MyForm)form);
                    }

                    if (s.Contains("Begin VB.Frame ")) {

                        beginline = i;
                        do {
                            i++;
                            s = rtbVB.Lines[i];
                            if (s.Contains("BeginProperty")) SkipProperties(i, s);

                        } while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End ") && (s.Trim().Length >= 6 && !s.Trim().Substring(0, 6).Equals("Begin ")));
                        //while (!s.Trim().Equals("End") && i < rtbVB.Lines.Count() && controlEnd);
                        endline = i;
                        MyGroupBox o = new MyGroupBox();
                        o = o.Create(beginline, endline, rtbVB.Lines);
                        output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);
                        parentArray.Add(o);
                        inGroupBox = true;

                    } else if (s.Contains("Begin VB.CommandButton")) {
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
                        output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1], datasourceArray);
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
                        output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1], datasourceArray);
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
                        } while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End ") && (s.Trim().Length >= 6 && !s.Trim().Substring(0, 6).Equals("Begin ")));
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

                    } else if (s.Contains("Begin VB.OptionButton"))
                    {
                        beginline = i;
                        do
                        {
                            i++;
                            s = rtbVB.Lines[i];
                            if (s.Contains("BeginProperty")) SkipProperties(i, s);
                        }
                        while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                        endline = i;
                        MyRadioButton o = new MyRadioButton();
                        o = o.Create(beginline, endline, rtbVB.Lines);
                        output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);


                    } else if (s.Contains("Begin ComctlLib.ListView"))
                    {
                        beginline = i;
                        do
                        {
                            i++;
                            s = rtbVB.Lines[i];
                            if (s.Contains("BeginProperty")) SkipProperties(i, s);
                        }
                        while (i < rtbVB.Lines.Count() && s.Trim().Length >= 4 && !s.Trim().Substring(0, 4).Equals("End "));
                        endline = i;
                        MyDatagridview o = new MyDatagridview("Begin ComctlLib.ListView");
                        o = o.Create(beginline, endline, rtbVB.Lines);
                        output = o.Convert(o, output, controlVariableArray, controlFormArray, controlGBArray, parentArray[parentArray.Count - 1]);

                    }
                    else if (s.Contains("Begin")) {  // catches and removes unsupported things.

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


                    if (s.Trim().Equals("End") && rtbVB.Lines[i - 1].Trim().Equals("End")) // two Ends alone means end of a parent
                    {
                        // end of group box
                        if (parentArray.Count > 0)
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

                // end the file
                EndDesigner();
                this.Cursor = Cursors.Arrow;
                Clipboard.SetText(rtbNET.Text);
            } catch (Exception ex) {
                this.Cursor = Cursors.Arrow;
                MessageBox.Show("Exception in VB6 Parsing line: " + this.mylinenumer.ToString() + " " + ex.Message);
            }
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
            s += "End Class\r";
            output = output + s;
            rtbNET.Text = output;
        }


        public static string GetProperty(string s, int beginline, int endline, string[] lines)
        {
            string property = "";
            beginline++;
            string line = lines[beginline];
            int i = beginline;
            while (i < endline && i < lines.Count() && (line.IndexOf(s) == -1 || line.IndexOf(s) > line.IndexOf("=")))
            {
                i++;
                line = lines[i];
            }
            if (i == endline)
                property = "";
            else
                property = line.Substring(line.IndexOf('=') + 1).Trim().Replace("\"", "");
            return property;
        }

        public static string CreateNETCode(string s, General g, string objectName, List<string> controlVariableArray, List<string> controlFormArray,
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

        public static General PopulateGeneral(string key, string[] lines, int beginline, int endline)
        {
            General g = new General();

            int pos = lines[beginline].IndexOf(key) + key.Length;

            string name = lines[beginline].Substring(pos).Trim();

            // check if its a control array - same name
            string index = VBtoNET.GetProperty(" Index", beginline, endline, lines);
            if (!String.IsNullOrEmpty(index)) {
                // its an array
                g.ArrayName = name + "(" + index + ")";
                name = name + index; // odd but guarantees uniqueness

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
            if (!String.IsNullOrEmpty(rtbNET.Text))
                Clipboard.SetText(rtbNET.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(codeText))
            {
                string newcodeText = codeText;
                // make it pretty
                newcodeText = newcodeText.Replace(".value = True", ".Checked = True");
                newcodeText = newcodeText.Replace(".value = False", ".Checked = False");
                newcodeText = newcodeText.Replace(".value", ".Checked");
                newcodeText = newcodeText.Replace(".BoundText", ".SelectedValue");
                newcodeText = newcodeText.Replace(".Hide()", ".Close()");
                newcodeText = newcodeText.Replace(".Caption", ".Text");
                newcodeText = newcodeText.Replace(".Show vbModal", ".ShowDialog");
                newcodeText = newcodeText.Replace(".SelectedValue <> \"\"", ".SelectedIndex >= 0");


                newcodeText = newcodeText.Replace("Screen.MousePointer = vbHourglass", "Me.Cursor = Cursors.WaitCursor");
                newcodeText = newcodeText.Replace("Screen.MousePointer = vbDefault", "Me.Cursor = Cursors.Arrow");

                RichTextBox box = new RichTextBox();
                box.Text = newcodeText;
                newcodeText = "";
                foreach (string line in box.Lines)
                {
                    if (line.Contains("Private Sub")) {
                        if (line.Contains("_Click"))
                        {
                            newcodeText += ReplaceProcHandle(line, "Click");
                        }

                        else
                        {
                            newcodeText += line + "\r\n";
                        }
                    }
                    else if (line.Contains(".Resultset!"))
                    {
                        newcodeText += ReplaceResultset(line) + "\r\n";
                    }
                    else
                    {
                        newcodeText += line + "\r\n";
                    }
                }


                Clipboard.SetText(newcodeText);
            }
        }

        private string ReplaceResultset(string line)
        {
            string newline = "";
            string[] lineArray = line.Split(' ');
            int i = lineArray.Length - 1;
            string goodpart = lineArray[i]; // get the last part
            string newpart = goodpart;
            if (newpart.IndexOf(".Resultset!") <= 0) return line; // return if it's not what we are expecting - piece is in the last part of array
            //phBlockNo = rdcPhotonBlocks.Resultset!PH_BLOCK_CORR_NO
            newpart = System.Text.RegularExpressions.Regex.Replace(newpart, "^rdc", "dt");
            newpart = newpart.Replace(".Resultset!", ".Rows(0)(\"") + "\").toString)";
            lineArray[i] = newpart;
            //string field = goodpart.Substring(goodpart.IndexOf(".Resultset!") + ".Resultset!".Length);

            foreach (string s in lineArray)
                newline += s + " ";
            return newline + "\r\n";
        }

        private string ReplaceProcHandle(string line, string eventtype)
        {
            string newline = "";

            string[] lineArray = line.Split(' ');
            if (lineArray.Length == 3)
            {
                string procName = lineArray[2];
                procName = procName.Substring(0, procName.IndexOf("_"));
                newline = "\t Private Sub " + procName + "_" + eventtype + "(sender As Object, e As EventArgs) Handles " + procName + "." + eventtype + "\r\n";

                //Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
            }

            return newline;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearData(true);
        }

        private void ClearData(bool clearTextBoxes)
        {
            controlVariableArray = new List<string>();
            controlFormArray = new List<string>();
            controlGBArray = new List<string>();
            parentArray = new List<object>();
            datasourceArray = new List<string>();

            if (clearTextBoxes) {
                rtbNET.Text = "";
                rtbVB.Text = "";
            }
            codeText = "";
            //static public List<string> controlNameList = new List<string>();
            mylinenumer = 0;
            output = "";



        }

        private void btnDataBinding_Click(object sender, EventArgs e)
        {
            string output = "";
            foreach (string s in datasourceArray)
                output += "\t" + s + "\r";

            output = "Private Sub PopulateDatabinding() \r " + output + "\rEnd Sub\r";
            Clipboard.SetText(output);

        }

        private void btnFixSQL_Click(object sender, EventArgs e)
        {
            string sql = txtFixSQL.Text;
            sql = sql.Replace("& _", "").Replace("&", "").Replace("\"", "");
            txtFixedSQL.Text = sql;
            string output = "";
            foreach (string line in txtFixedSQL.Lines) {
                if (line.Contains("TRIM("))
                {
                    int start = line.IndexOf("(") + 1;
                    int end = line.LastIndexOf(")");
                    if (line.Contains(","))
                        output += line.Substring(start, end - start) + ", \r\n";
                    else
                        output += line.Substring(start, end - start) + "\r\n";

                }
                else output += line + "\r\n";
            }




            for (int i = 0; i < 10; i++)
            {
                output = output.Replace("  ", " ");
            }

            txtFixedSQL.Text = output;

            Clipboard.SetText(output);

        }

        private void txtFixSQL_KeyDown(object sender, KeyEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {
                // Alt+F pressed
                //System.Windows.Input.FocusManager.GetFocusedElement()
                //doSomething();
                if (txtFixedSQL.ContainsFocus)
                    txtFixedSQL.SelectAll();
                if (txtFixSQL.ContainsFocus)
                    txtFixSQL.SelectAll();

                if (rtbNET.ContainsFocus)
                    rtbNET.SelectAll();
                if (rtbVB.ContainsFocus)
                    rtbVB.SelectAll();


                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnRemoveText_Click(object sender, EventArgs e)
        {
            string path = "";
            folderBrowserDialog1.SelectedPath = @"D:\PhD Computer Consulting Inc\Steve\rads";
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            DirSearch(path);
            //string[] files = System.IO.Directory.GetFiles(path);
            int counter = 0;
            
            foreach (string file in files) {
                counter = DeleteFromFile(file, counter);

            } // foreach
            MessageBox.Show("Complete!  " + counter.ToString() + " files changed");

        }

        private void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in System.IO.Directory.GetDirectories(sDir))
                {
                    foreach (string f in System.IO.Directory.GetFiles(d))
                    {
                        files.Add(f);
                    }
                    DirSearch(d);
                }

                foreach (string f in System.IO.Directory.GetFiles(sDir)) // root
                {
                    files.Add(f);
                }

            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private int DeleteFromFile(string file, int counter) 
        {
            if (file.Contains(".vb"))
            {
                if (file.ToLower().Contains("designer")) return counter;
                // this is the one we want
                string[] contents = System.IO.File.ReadAllLines(file);
                string contentsout = null;
                bool modified = false;
                foreach (string line in contents)
                {
                    if (!line.Contains(txtRemoveText.Text))
                    {
                        contentsout += line + "\r\n";
                    }
                    else
                    {
                        modified = true;
                    }
                }

                if (modified)
                {
                    System.IO.File.WriteAllText(file + ".modified", contentsout);
                    counter++;
                }
            }
            return counter;
        }

        private int AddToLoadEvent(string file, int counter)
        {
            if (file.Contains(".vb"))
            {
                if (file.ToLower().Contains("designer")) return counter;
                // this is the one we want
                string[] contents = System.IO.File.ReadAllLines(file);
                string contentsout = null;
                bool modified = false;
                bool inLoadEvent = false;
                foreach (string line in contents)
                {
                    if (line.ToLower().Contains("handles me.load")) // && line.ToLower().Contains("_load ")
                    {
                        inLoadEvent = true;
                    }

                    if (inLoadEvent && line.ToLower().Contains("end sub"))
                    {
                        contentsout = contentsout + "\t" + txtAddText.Text + "\r\n";
                        inLoadEvent = false;
                        modified = true;
                    }
                    contentsout = contentsout + line + "\r\n";
                }

                if (modified)
                {
                    System.IO.File.WriteAllText(file + ".modified", contentsout);
                    counter++;
                }
            }
            return counter;
        }

        private int AddToDesigner(string file, int counter)
        {

            if (file.Contains(".vb") && file.ToLower().Contains("designer"))
            {
                //if (file.ToLower().Contains("designer")) return counter;
                // this is the one we want
                string[] contents = System.IO.File.ReadAllLines(file);
                List<string> controlList = new List<string>();
                
                // populate array of controls we want
                foreach (string line in contents)
                {
                    if (line.Contains("As System.Windows.Forms." + cmbControlType.Text)) // && line.ToLower().Contains("_load ")
                    {
                        int pos = "    ".Length;
                        string newline = line.Substring(pos);
                        string[] newlinearray = newline.Split(" ".ToCharArray());
                        if (newlinearray[0] == "Friend" && newlinearray[1] == "WithEvents") controlList.Add("Me." + newlinearray[2]);
                    }
                }

                // now go through the file again and add what we want to properties
                
                bool modified = false;
                string output = "";
                foreach (string line in contents)
                {
                    int i = ControlInLine(line, controlList, ".name");
                    int j = ControlInLine(line, controlList, txtAddControlText.Text.ToLower());
                    if (i >= 0)
                    {
                        // make modification and delete from array
                        string control = controlList[i];
                        controlList.RemoveAt(i);
                        output = output + "\r\n\t" + control +  txtAddControlText.Text + "\r\n" + line;
                        modified = true;
                    }
                    else if (j >= 0) { } // delete if found (duplicate)
                    else
                    {
                        output = output + "\r\n" + line;
                    }
                    

                }

                if (modified)
                {
                    System.IO.File.WriteAllText(file, output);
                    counter++;
                }


            }


            return counter;
        }

        private int DeleteFromDesigner(string file, int counter)
        {

            if (file.Contains(".vb") && file.ToLower().Contains("designer"))
            {
                // this is the one we want
                string[] contents = System.IO.File.ReadAllLines(file);
                List<string> controlList = new List<string>();

                // populate array of controls we want
                foreach (string line in contents)
                {
                    if (line.Contains("As System.Windows.Forms." + cmbDeleteControlType.Text)) // && line.ToLower().Contains("_load ")
                    {
                        int pos = "    ".Length;
                        string newline = line.Substring(pos);
                        string[] newlinearray = newline.Split(" ".ToCharArray());
                        if (newlinearray[0] == "Friend" && newlinearray[1] == "WithEvents") controlList.Add("Me." + newlinearray[2]);
                    }
                }

                // now go through the file again and add what we want to properties

                bool modified = false;
                string output = "";
                foreach (string line in contents)
                {
                    //int i = ControlInLine(line, controlList, "name");
                    int i = ControlInLine(line, controlList, txtDeleteControlText.Text);
                    if (i >= 0)
                    {
                        // make modification and delete from array
                        string control = controlList[i];
                        controlList.RemoveAt(i);
                        //output = output + "\r\n\t" + control + txtAddControlText.Text + "\r\n" + line;
                        modified = true;
                    }
                    else
                    {
                        output = output + "\r\n" + line;
                    }


                }

                if (modified)
                {
                    System.IO.File.WriteAllText(file, output);
                    counter++;
                }


            }


            return counter;
        }

        private int ControlInLine(string line, List<string> controlList, string appendText)
        {
            int i = -1;
            foreach (string s in controlList) {
                i++;
                if (line.ToLower().Contains(s.ToLower() + appendText.ToLower())) return i;
            }

            return -1;
        }



        private void btnAddText_Click(object sender, EventArgs e)
        {
            string path = "";
            folderBrowserDialog1.SelectedPath = @"D:\PhD Computer Consulting Inc\Steve\rads";
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            DirSearch(path);
            int counter = 0;

            foreach (string file in files)
            {
                counter = AddToLoadEvent(file, counter);

            } // foreach
            MessageBox.Show("Complete!  " + counter.ToString() + " files changed");
        }

        private void btnAddToDesigner_Click(object sender, EventArgs e)
        {

            if (cmbControlType.Text == "")
            {
                MessageBox.Show("A control must be selected from dropdown");
                return;
            }

            if (txtAddControlText.Text == "")
            {
                MessageBox.Show("You need to input the text to use");
                txtAddControlText.Focus();
                return;
            }


            string path = "";
            folderBrowserDialog1.SelectedPath = @"c:\test";
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            files = new List<string>();
            DirSearch(path);
            int counter = 0;

            

            foreach (string file in files)
            {
                counter = AddToDesigner(file, counter);

            } // foreach
            MessageBox.Show("Complete!  " + counter.ToString() + " files changed");
        }

        private void btnDeleteDesigner_Click(object sender, EventArgs e)
        {

            if (cmbDeleteControlType.Text == "")
            {
                MessageBox.Show("A control must be selected from dropdown");
                return;
            }

            if (txtDeleteControlText.Text == "")
            {
                MessageBox.Show("You need to input the text to use");
                txtDeleteControlText.Focus();
                return;
            }


            string path = "";
            folderBrowserDialog1.SelectedPath = @"c:\test";
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            files = new List<string>();
            DirSearch(path);
            int counter = 0;


            foreach (string file in files)
            {
                counter = DeleteFromDesigner(file, counter);

            } // foreach
            MessageBox.Show("Complete!  " + counter.ToString() + " files changed");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Dialog Flow

            string path = @"C:\rads\";
            string output = @"C:\temp\FileList.txt";
            //var codeFiles = new List<string>();

            string[] codeFiles = System.IO.Directory.GetFiles(path, "frm*.vb", System.IO.SearchOption.AllDirectories);
            int filenumber = 0;
            TreeNode roottreeNode = new TreeNode("Rads");
            treeView1.Nodes.Add(roottreeNode);

            foreach (string file in codeFiles)
            {
                recurssion = 0;
                
                if (file.ToLower().Contains("designer")) continue;
                filenumber++;
                FormListString = filenumber.ToString() + ": " + System.IO.Path.GetFileNameWithoutExtension(file) + "|";
                TreeNode treeNode = new TreeNode(System.IO.Path.GetFileNameWithoutExtension(file));
                //roottreeNode.Nodes.Add(new TreeNode(System.IO.Path.GetFileNameWithoutExtension(file)));
                var subforms = GetSubForms(file);
                treeNode = DisplaySubforms(file, subforms, treeNode);
                roottreeNode.Nodes.Add(treeNode);
                System.IO.File.AppendAllText(output, FormListString + "\r\n");
                //if (filenumber > 10) return;
            }

        }

        private TreeNode DisplaySubforms(string parentfile, List<string> subforms, TreeNode parentNode)
        {
            string path = @"C:\rads\";
            string output = @"C:\temp\FileList.txt";
            subforms = subforms.Distinct().ToList();
            foreach (string line in subforms)
            {
                // find this subform. 
                // I need to trim it.
                FormListString = line + "|";
                TreeNode node = new TreeNode(line);
                
                string[] subformfiles = System.IO.Directory.GetFiles(path, line + ".vb", System.IO.SearchOption.AllDirectories);
                // print out the reference
                foreach (string file in subformfiles)
                {
                    //parentNode.Nodes.Add(file);
                    List<string> newsubforms = GetSubForms(file);
                    if (recurssion > 5) { return parentNode; }
                    newsubforms = newsubforms.Distinct().ToList();
                    DisplaySubforms(file, newsubforms, node);
                }
                parentNode.Nodes.Add(node);

            }
            if (subforms.Count > 0) System.IO.File.AppendAllText(output, "\r\n");
            return parentNode;
        }
        private List<string> GetSubForms(string filein)
        {
            recurssion++;
            
            var subforms = new List<string>();
            if (recurssion > 10) { return subforms; }

            string path = @"C:\rads\";
            // find file
            string[] fileContents = System.IO.File.ReadAllLines(filein);
            foreach (string line in fileContents)
            {
                if (line.ToLower().Contains("new frm"))
                {

                    // trim 
                    int start = line.ToLower().IndexOf("new frm");
                    int end = line.Substring(start).IndexOf("(");
                    string s = "";
                    if (end > 0) { s = line.Substring(start + 4, end - 4); }
                    else { s = line.Substring(start + 4); }
                    subforms.Add(s);
                }
            }
            return subforms;
        }




    }


   




}
