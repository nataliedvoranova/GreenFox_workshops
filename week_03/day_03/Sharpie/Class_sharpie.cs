using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    class Class_sharpie
    {
        public string Colour { get; set; }
        public double Width { get; set; }
        public double InkAmount { get; set; }

        public void UsingSharpie ()
        {
            InkAmount--;            //this.InkAmount = InkAmount--; >>>> Not working bc it sets the value to inkAmount first
        }


    }
}
