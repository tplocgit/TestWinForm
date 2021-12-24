using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWinForm.Buttons;
using TestWinForm.DataGridViews;

namespace TestWinForm.Forms
{
    public partial class SEPForm : Form
    {
        public enum Type
        {
            Main = 0,
            Add = 1,
            Update = 2
        };

        public static readonly Size SEPFormDefaultSize = new(width: 1000, height: 1000);
        private static readonly float t_defaultTitleFontSize = 20;
        private static readonly int t_defaultMargin = 10;
        private string _titleText;
        private Type _type;
        private List<SEPButton> _buttons;
        private Label _labelTitle = new();
        private Point _pointGridViewStart = new();
        private Point _pointControlButtonStart = new();
        private SEPDataGridView _dataGridView;

        public SEPForm()
        {
            InitializeComponent();
        }

        public SEPForm(string name, string titleText, Type type, string text, Size size, List<SEPButton> buttons, SEPDataGridView dataGridView)
        {
            InitializeComponent();
            _type = type;
            _buttons = buttons;
            _titleText = titleText;
            _dataGridView = dataGridView;
            Text = text;
            Size = size;
            Name = name;
            SetUpForm();
        }

        private void SetUpForm()
        {

            SetUpTitle();
            SetUpGridViewLocation();
            SetUpDataGridView();
            SetUpControlButtonsLocation();
            SetUpButtons();
        }

        private void SetUpButtons()
        {
            foreach (SEPButton button in _buttons)
            {
                Controls.Add(button);
                int pointXInformButtonLocation = _pointControlButtonStart.X + button.Location.X;
                int pointYInformButtonLocation = _pointControlButtonStart.Y + button.Location.Y;
                button.Location = new(x: pointXInformButtonLocation, y: pointYInformButtonLocation);
            }
        }

        private void SetUpGridViewLocation()
        {
            _pointGridViewStart = new(x: t_defaultMargin, y: (_labelTitle.Size.Height + _labelTitle.Location.Y + t_defaultMargin));
        }

        private void SetUpTitle()
        {
            Controls.Add(_labelTitle);
            _labelTitle.Text = _titleText;
            _labelTitle.AutoSize = true;
            _labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            _labelTitle.Location = new Point(x: (Size.Width - _labelTitle.Size.Width) / 2, y: t_defaultMargin);
            _labelTitle.Font = new(Font.FontFamily, t_defaultTitleFontSize, FontStyle.Bold);
        }

        private void SetUpControlButtonsLocation()
        {
            _pointControlButtonStart = new
            (
                x: _dataGridView.Location.X + _dataGridView.Size.Width + t_defaultMargin,
                y: _dataGridView.Location.Y
            );
        }

        private void SetUpDataGridView()
        {
            Controls.Add(_dataGridView);
            Point pointDataGridViewInFormLocation = new
            (
                x: (_pointGridViewStart.X + _dataGridView.Location.X),
                y: (_pointGridViewStart.Y + _dataGridView.Location.Y)
            );
            _dataGridView.Location = pointDataGridViewInFormLocation;
        }

        //private void wq(object sender, EventArgs e)
        //{

        //}
    }
}
