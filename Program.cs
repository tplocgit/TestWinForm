using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWinForm.Buttons;
using TestWinForm.Forms;
using TestWinForm.Factories;
using System.Drawing;
using TestWinForm.DataGridViews;

namespace TestWinForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<SEPButton> buttons = new();

            FactoryButton factory = new FactoryButtonInsert();
            buttons.Add(factory.CreateButton("btnInsert", new Point(x: 0, y: 0)));

            factory = new FactoryButtonDelete();
            buttons.Add(factory.CreateButton("btnUpdate", new Point(x: 0, y: 50)));

            List<Dictionary<string, string>> data = new()
            {
                new()
                {
                    ["col1"] = "cell1",
                    ["col2"] = "cell2",
                    ["col3"] = "cell3",
                    ["col4"] = "cell4",
                    ["col5"] = "cell5",
                },
                new()
                {
                    ["col1"] = "cell6",
                    ["col2"] = "cell7",
                    ["col3"] = "cell8",
                    ["col4"] = "cell9",
                    ["col5"] = "cell0",
                }
            };

            SEPDataGridView dataGridView = new(new Point(0, 0), new Size(800, 800), data);

            Application.Run(new SEPForm("Test", "TestForm",SEPForm.Type.Main, "Test", SEPForm.SEPFormDefaultSize, buttons, dataGridView));
        }
    }
}
