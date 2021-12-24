using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWinForm.Buttons;
using System.Drawing;

namespace TestWinForm.Factories
{
    public class FactoryButtonInsert : FactoryButton
    {
        public override SEPButton CreateButton(string name, Point location)
        {
            return new ButtonInsert(name, DefaultSize, location);
        }
    }
}
