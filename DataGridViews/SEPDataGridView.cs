using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TestWinForm.DataGridViews
{
    public class SEPDataGridView: DataGridView
    {
        private List<Dictionary<string, string>> _data;
        
        public SEPDataGridView(Point location, Size size, List<Dictionary<string, string>> data)
        {
            _data = data;
            Location = location;
            Name = "dataGridView";
            AutoSize = true;
            InitDefault();
            InitColumns();
            InitRows();
        }

        private void InitDefault()
        {
            ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Font = new Font(base.Font.FontFamily, 14, FontStyle.Bold);
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GridColor = Color.Black;
            RowHeadersVisible = false;
        }

        private void InitColumns()
        {
            if (_data == null || _data.Count <= 0) return;

            Dictionary<string, string>.KeyCollection columnNames = _data.First().Keys;
            for(int i = 0; i < columnNames.Count; ++i)
            {
                string name = columnNames.ElementAt(i);
                Columns.Add(columnName: name.Replace(" ", ""), headerText: name);
            }
        }

        private void InitRows()
        {

        }
    }
}
