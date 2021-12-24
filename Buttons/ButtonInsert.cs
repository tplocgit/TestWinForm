using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace TestWinForm.Buttons
{
    class ButtonInsert : SEPButton
    {
        public ButtonInsert(string name, Size size, Point location) : base(name, "Insert", size, location)
        {

        }

        protected override void OnClick(object sender, EventArgs e)
        {
            Debug.WriteLine("Insert");
        }
    }
}
