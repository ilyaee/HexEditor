namespace Bibl
{
	partial class HexControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.datagv = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.datagv)).BeginInit();
			this.SuspendLayout();
			// 
			// datagv
			// 
			this.datagv.AllowUserToAddRows = false;
			this.datagv.AllowUserToDeleteRows = false;
			this.datagv.AllowUserToResizeColumns = false;
			this.datagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagv.ColumnHeadersVisible = false;
			this.datagv.Location = new System.Drawing.Point(0, 0);
			this.datagv.Name = "datagv";
			this.datagv.RowHeadersVisible = false;
			this.datagv.Size = new System.Drawing.Size(699, 446);
			this.datagv.TabIndex = 0;
			this.datagv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagv_CellValueChanged);
			// 
			// HexControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.datagv);
			this.Name = "HexControl";
			this.Size = new System.Drawing.Size(702, 449);
			((System.ComponentModel.ISupportInitialize)(this.datagv)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView datagv;
	}
}
