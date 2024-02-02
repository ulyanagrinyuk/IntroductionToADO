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
			this.cbLearningForm = new System.Windows.Forms.ComboBox();
			this.cbLearningTime = new System.Windows.Forms.ComboBox();
			this.tbGroupName = new System.Windows.Forms.ComboBox();
			this.lcbWeek = new System.Windows.Forms.CheckedListBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblLearningDaysCode = new System.Windows.Forms.Label();
			this.btnCreateGroup = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(12, 39);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(325, 21);
			this.cbDirection.TabIndex = 0;
			this.cbDirection.Text = "Выберите направление обученя";
			// 
			// cbLearningForm
			// 
			this.cbLearningForm.FormattingEnabled = true;
			this.cbLearningForm.Location = new System.Drawing.Point(12, 12);
			this.cbLearningForm.Name = "cbLearningForm";
			this.cbLearningForm.Size = new System.Drawing.Size(325, 21);
			this.cbLearningForm.TabIndex = 1;
			this.cbLearningForm.Text = "Форма обучения";
			this.cbLearningForm.SelectedIndexChanged += new System.EventHandler(this.cbLearningForm_SelectedIndexChanged);
			// 
			// cbLearningTime
			// 
			this.cbLearningTime.FormattingEnabled = true;
			this.cbLearningTime.Location = new System.Drawing.Point(13, 66);
			this.cbLearningTime.Name = "cbLearningTime";
			this.cbLearningTime.Size = new System.Drawing.Size(325, 21);
			this.cbLearningTime.TabIndex = 2;
			this.cbLearningTime.Text = "Время обучения";
			// 
			// tbGroupName
			// 
			this.tbGroupName.FormattingEnabled = true;
			this.tbGroupName.Location = new System.Drawing.Point(12, 144);
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(325, 21);
			this.tbGroupName.TabIndex = 3;
			this.tbGroupName.Text = "Нзвание группы";
			// 
			// lcbWeek
			// 
			this.lcbWeek.CheckOnClick = true;
			this.lcbWeek.ColumnWidth = 45;
			this.lcbWeek.FormattingEnabled = true;
			this.lcbWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пн",
            "Сб",
            "Вс"});
			this.lcbWeek.Location = new System.Drawing.Point(12, 93);
			this.lcbWeek.MultiColumn = true;
			this.lcbWeek.Name = "lcbWeek";
			this.lcbWeek.Size = new System.Drawing.Size(326, 19);
			this.lcbWeek.TabIndex = 5;
			this.lcbWeek.SelectedIndexChanged += new System.EventHandler(this.lcbWeek_SelectedIndexChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(263, 170);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 6;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblLearningDaysCode
			// 
			this.lblLearningDaysCode.AutoSize = true;
			this.lblLearningDaysCode.Location = new System.Drawing.Point(12, 125);
			this.lblLearningDaysCode.Name = "lblLearningDaysCode";
			this.lblLearningDaysCode.Size = new System.Drawing.Size(77, 13);
			this.lblLearningDaysCode.TabIndex = 7;
			this.lblLearningDaysCode.Text = "Дни обучения";
			// 
			// btnCreateGroup
			// 
			this.btnCreateGroup.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnCreateGroup.Location = new System.Drawing.Point(16, 170);
			this.btnCreateGroup.Name = "btnCreateGroup";
			this.btnCreateGroup.Size = new System.Drawing.Size(98, 23);
			this.btnCreateGroup.TabIndex = 8;
			this.btnCreateGroup.Text = "Создать группу";
			this.btnCreateGroup.UseVisualStyleBackColor = true;
			this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 206);
			this.Controls.Add(this.btnCreateGroup);
			this.Controls.Add(this.lblLearningDaysCode);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lcbWeek);
			this.Controls.Add(this.tbGroupName);
			this.Controls.Add(this.cbLearningTime);
			this.Controls.Add(this.cbLearningForm);
			this.Controls.Add(this.cbDirection);
			this.Name = "AddGroup";
			this.Text = "AddGroup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.ComboBox cbLearningForm;
		private System.Windows.Forms.ComboBox cbLearningTime;
		private System.Windows.Forms.ComboBox tbGroupName;
		private System.Windows.Forms.CheckedListBox lcbWeek;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblLearningDaysCode;
		private System.Windows.Forms.Button btnCreateGroup;
	}
}