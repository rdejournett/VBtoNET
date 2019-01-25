using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET {
    class MyTabControl {

        General general;
        Dictionary<string, string> controlNameMap;
        List<MyTabpage> tabList = new List<MyTabpage>();

        public MyTabControl Create(int beginline, int endline, string[] lines) {
            MyTabControl o = new MyTabControl();
            string key = "Begin TabDlg.SSTab ";
            o.General = VBtoNET.PopulateGeneral(key, lines, beginline, endline);
            // tab pages
            string tabPageNumStr = VBtoNET.GetProperty("Tabs", beginline, endline, lines);
            int tabPageCount = 0;
            if (tabPageNumStr == "")
            {
                bool foundTab = true;
                // can't find the tabs property
                for (int tabnum = 0; tabnum < 20; tabnum++)
                {
                    if (!foundTab) break;
                    for (int i = beginline; i < endline; i++)
                    {
                        string s = lines[i];
                        if (s.Contains("Tab(" + tabnum.ToString())) 
                        {
                            tabPageCount++;
                            break;
                        }
                        if (i == endline - 1) { 
                            foundTab = false;
                            break;
                        }

                    }
                }
            }
            else tabPageCount = Int16.Parse(tabPageNumStr);
            
            
            for (int i = 0; i < tabPageCount; i++) {
                MyTabpage page = new MyTabpage();
                
                page.General = new General();
                
                page.General.Name = o.General.Name + "TabPage" + i.ToString();
                page.General.Text = VBtoNET.GetProperty("TabCaption(" + i.ToString() + ")", beginline, endline, lines);
                page.Padding = 3;
                page.General.Tabindex = i.ToString();
                page.UseVisualStyleBackColor = true;
                // these needs to be fixed a bit, i'm not sure what the size and location should be
                page.General.Locationx = "4";
                page.General.Locationy = "22";
                int sizex = Int16.Parse(o.General.Sizex) - 8;
                int sizey = Int16.Parse(o.General.Sizey) - 26;
                page.General.Sizex = sizex.ToString();
                page.General.Sizey = sizey.ToString();
                o.tabList.Add(page);
            }

            o.ControlNameMap = PopulateControlNamesList(beginline, endline, lines, o.tabList);

            return o;

        }

        private Dictionary<string, string> PopulateControlNamesList(int beginline, int endline, string[] lines, List<MyTabpage> tabList) {
            controlNameMap = new Dictionary<string, string>();
            for (int i = 0; i < tabList.Count; i++) {
                for (int j = 0; j < 99; j++) {
                    string key = VBtoNET.GetProperty("Tab(" + i.ToString() + ").Control(" + j.ToString() + ")", beginline, endline, lines);
                    string value = tabList[i].General.Name;
                    if (!String.IsNullOrEmpty(key)) {

                        //if (VBtoNET.controlNameList.Contains(key)) {
                        //    // its an array
                        //    key = key + beginline.ToString(); // odd but guarantees uniqueness

                        //}
                        controlNameMap.Add(key, value);
                    } else break;
                }
            }
             
            return controlNameMap;
        }

        public string Convert(MyTabControl o, string s, List<string> controlVariableArray, List<string> controlFormArray,
            List<string> controlGBArray, object parentObj) {

            string name = o.General.Name;

            s = VBtoNET.CreateNETCode(s, o.General, "TabControl", controlVariableArray, controlFormArray, controlGBArray, parentObj);
            s += VBtoNET.padding + "Me." + name + ".SelectedIndex = 0\r";
            foreach (MyTabpage page in o.tabList)
                s += VBtoNET.padding + "Me." + name + ".Controls.Add(Me." + page.General.Name + ")\r";
            foreach (MyTabpage page in o.tabList)
                s = VBtoNET.CreateNETCode(s, page.General, "TabPage", controlVariableArray, controlFormArray, controlGBArray, parentObj);



            // do tab pages


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

        public Dictionary<string, string> ControlNameMap {
            get {
                return controlNameMap;
            }

            set {
                controlNameMap = value;
            }
        }
    }

}
