using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bibl
{
	public partial class HexControl : UserControl
	{
		public byte[] Bytes
		{
			get
			{
				char[] c = new char[datagv.RowCount * datagv.ColumnCount];
				int k = 0;
				for (int i = 0; i < datagv.RowCount; i++)
					for (int j = 0; j < datagv.ColumnCount; j++)
					{
						c[k] = Convert.ToChar(array[i, j]);
						k++;
					}

				byte[] ArrByte = Encoding.Default.GetBytes(c);

				return ArrByte;
			}
			set
			{
				int k = 0;
				for (int i = 0; i < datagv.RowCount; i++)
					for (int j = 0; j < datagv.ColumnCount; j++)
					{
						array[i, j] = value[k].ToString();
						k++;
					}
			}
		}


		string[,] array;
		public HexControl()
		{
			InitializeComponent();
			datagv.ColumnCount = 16;
			datagv.RowCount = 20;
			array = new string[datagv.RowCount, datagv.ColumnCount];
			for (int i = 0; i < datagv.RowCount; i++)
				for (int j = 0; j < datagv.ColumnCount; j++)
				{
					datagv.Rows[i].Cells[j].Value = "00";
					datagv.Columns[j].Width = 30;
				}
		}

		private void datagv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			var pattern = "^[0-9A-F]{2}$";
			var checker = new Regex(pattern, RegexOptions.IgnoreCase);
			if (checker.IsMatch(datagv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
			{
				array[e.RowIndex, e.ColumnIndex] = datagv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
			}
			else
			{
				datagv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "00";
				MessageBox.Show("incorrect input");
			}
		}
	}
}