using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBtoNET
{
    public class General
    {
         
        string locationx = "";
        string locationy = "";
        string name = "";
        string sizex = "";
        string sizey = "";
        string tabindex = "";
        string text = "";
        string arrayName = ""; // old VB6 name (in an array, duplicated)

        public General FixSizes(General g)
        {
            g.locationx = ConvertTwipsToXPixels(g.locationx);
            g.locationy = ConvertTwipsToXPixels(g.locationy);
            g.sizex = ConvertTwipsToXPixels(g.sizex);
            g.sizey = ConvertTwipsToXPixels(g.sizey);
            return g;
        }

        public static string ConvertTwipsToXPixels(string twipsStr)
        {
            if (String.IsNullOrEmpty(twipsStr)) return "";
            System.Windows.Forms.Form dummyForm = new System.Windows.Forms.Form();
            System.Drawing.Graphics formGraphics = dummyForm.CreateGraphics();

            float dpiy = formGraphics.DpiY;

            double twips = Double.Parse(twipsStr);
            if (twips < 0)
                twips = 0; // VB6 has huge negative numbers sometimes.  idk what this means

            int product = (int)Math.Round((twips * (1.0 / 1440.0) * dpiy), 0);
            
            formGraphics.Dispose();
            dummyForm.Dispose();
            
            return product.ToString();
        }


        public static string ConvertTwipsToYPixels(string twipsStr)
        {
            System.Windows.Forms.Form dummyForm = new System.Windows.Forms.Form();
            System.Drawing.Graphics formGraphics = dummyForm.CreateGraphics();
            
            float dpiy = formGraphics.DpiY;

            double twips = Double.Parse(twipsStr);

            int product = (int)Math.Round((twips * (1.0 / 1440.0) * dpiy),0);
            return product.ToString();
        }



        public string Locationx
        {
            get
            {
                return locationx;
            }

            set
            {
                locationx = value;
            }
        }

        public string Locationy
        {
            get
            {
                return locationy;
            }

            set
            {
                locationy = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Sizex
        {
            get
            {
                return sizex;
            }

            set
            {
                sizex = value;
            }
        }

        public string Sizey
        {
            get
            {
                return sizey;
            }

            set
            {
                sizey = value;
            }
        }

        public string Tabindex
        {
            get
            {
                return tabindex;
            }

            set
            {
                tabindex = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public string ArrayName {
            get {
                return arrayName;
            }

            set {
                arrayName = value;
            }
        }
    }
}
