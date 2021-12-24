using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TestWinForm.Buttons
{
    public abstract class SEPButton : Button
    {
        protected SEPButton(string name, string text, Size size, Point location)
        {
            Name = name;
            Text = text;
            Size = size;
            Location = location;
            TabIndex = 0;
            UseVisualStyleBackColor = true;
            Click += OnClick;
        }

        protected abstract void OnClick(object sender, EventArgs e);
    }
}
