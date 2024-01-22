namespace Academy
{
	partial class AddGroup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.cbLearningFrom = new System.Windows.Forms.ComboBox();
			this.cbTime = new System.Windows.Forms.ComboBox();
			this.tbGroupName = new System.Windows.Forms.ComboBox();
			this.groupBoxDaysOfWeek = new System.Windows.Forms.GroupBox();
			this.cbnMon = new System.Windows.Forms.CheckBox();
			this.cbTew = new System.Windows.Forms.CheckBox();
			this.groupBoxDaysOfWeek.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(13, 12);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(325, 21);
			this.cbDirection.TabIndex = 0;
			this.cbDirection.Text = "Направление обученя";
			// 
			// cbLearningFrom
			// 
			this.cbLearningFrom.FormattingEnabled = true;
			this.cbLearningFrom.Location = new System.Drawing.Point(13, 39);
			this.cbLearningFrom.Name = "cbLearningFrom";
			this.cbLearningFrom.Size = new System.Drawing.Size(325, 21);
			this.cbLearningFrom.TabIndex = 1;
			this.cbLearningFrom.Text = "Форма обучения";
			// 
			// cbTime
			// 
			this.cbTime.FormattingEnabled = true;
			this.cbTime.Location = new System.Drawing.Point(13, 66);
			this.cbTime.Name = "cbTime";
			this.cbTime.Size = new System.Drawing.Size(325, 21);
			this.cbTime.TabIndex = 2;
			this.cbTime.Text = "Время обучения";
			// 
			// tbGroupName
			// 
			this.tbGroupName.FormattingEnabled = true;
			this.tbGroupName.Location = new System.Drawing.Point(12, 127);
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(325, 21);
			this.tbGroupName.TabIndex = 3;
			this.tbGroupName.Text = "Нзвание группы";
			// 
			// groupBoxDaysOfWeek
			// 
			this.groupBoxDaysOfWeek.Controls.Add(this.cbTew);
			this.groupBoxDaysOfWeek.Controls.Add(this.cbnMon);
			this.groupBoxDaysOfWeek.Location = new System.Drawing.Point(13, 93);
			this.groupBoxDaysOfWeek.Name = "groupBoxDaysOfWeek";
			this.groupBoxDaysOfWeek.Size = new System.Drawing.Size(325, 33);
			this.groupBoxDaysOfWeek.TabIndex = 4;
			this.groupBoxDaysOfWeek.TabStop = false;
			this.groupBoxDaysOfWeek.Text = "Дни недели";
			// 
			// cbnMon
			// 
			this.cbnMon.AutoSize = true;
			this.cbnMon.Location = new System.Drawing.Point(6, 16);
			this.cbnMon.Name = "cbnMon";
			this.cbnMon.Size = new System.Drawing.Size(40, 17);
			this.cbnMon.TabIndex = 0;
			this.cbnMon.Text = "Пн";
			this.cbnMon.UseVisualStyleBackColor = true;
			// 
			// cbTew
			// 
			this.cbTew.AutoSize = true;
			this.cbTew.Location = new System.Drawing.Point(52, 16);
			this.cbTew.Name = "cbTew";
			this.cbTew.Size = new System.Drawing.Size(38, 17);
			this.cbTew.TabIndex = 1;
			this.cbTew.Text = "Вт";
			this.cbTew.UseVisualStyleBackColor = true;
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 160);
			this.Controls.Add(this.groupBoxDaysOfWeek);
			this.Controls.Add(this.tbGroupName);
			this.Controls.Add(this.cbTime);
			this.Controls.Add(this.cbLearningFrom);
			this.Controls.Add(this.cbDirection);
			this.Name = "AddGroup";
			this.Text = "AddGroup";
			this.groupBoxDaysOfWeek.ResumeLayout(false);
			this.groupBoxDaysOfWeek.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.ComboBox cbLearningFrom;
		private System.Windows.Forms.ComboBox cbTime;
		private System.Windows.Forms.ComboBox tbGroupName;
		private System.Windows.Forms.GroupBox groupBoxDaysOfWeek;
		private System.Windows.Forms.CheckBox cbnMon;
		private System.Windows.Forms.CheckBox cbTew;
	}
}