using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TestWinForm.Buttons;

namespace TestWinForm.Factories
{
    class FactoryButtonDelete : FactoryButton
    {
        public override SEPButton CreateButton(string name, Point location)
        {
            return new ButtonDelete(name, DefaultSize, location);
        }
    }
}
