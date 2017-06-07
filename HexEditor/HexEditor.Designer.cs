namespace HexEditor
{
	partial class HexEditor
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.hexControl1 = new Bibl.HexControl();
			this.SuspendLayout();
			// 
			// hexControl1
			// 
			this.hexControl1.Location = new System.Drawing.Point(12, 12);
			this.hexControl1.Name = "hexControl1";
			this.hexControl1.Size = new System.Drawing.Size(482, 442);
			this.hexControl1.TabIndex = 0;
			// 
			// HexEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 460);
			this.Controls.Add(this.hexControl1);
			this.MaximizeBox = false;
			this.Name = "HexEditor";
			this.Text = "HexEditor";
			this.ResumeLayout(false);

		}

		#endregion

		private Bibl.HexControl hexControl1;
	}
}

