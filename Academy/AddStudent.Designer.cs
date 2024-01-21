namespace Academy
{
	partial class AddStudent
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
			this.lableFullName = new System.Windows.Forms.TextBox();
			this.labelFullName = new System.Windows.Forms.Label();
			this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
			this.labelBitrhDate = new System.Windows.Forms.Label();
			this.labelGroupName = new System.Windows.Forms.Label();
			this.comboBoxGroup = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lableFullName
			// 
			this.lableFullName.Location = new System.Drawing.Point(9, 21);
			this.lableFullName.Name = "lableFullName";
			this.lableFullName.Size = new System.Drawing.Size(330, 20);
			this.lableFullName.TabIndex = 1;
			// 
			// labelFullName
			// 
			this.labelFullName.AutoSize = true;
			this.labelFullName.Location = new System.Drawing.Point(12, 5);
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Size = new System.Drawing.Size(91, 13);
			this.labelFullName.TabIndex = 2;
			this.labelFullName.Text = "Ф.И.О. студента";
			// 
			// dateTimePickerBirthDate
			// 
			this.dateTimePickerBirthDate.Location = new System.Drawing.Point(12, 69);
			this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
			this.dateTimePickerBirthDate.Size = new System.Drawing.Size(330, 20);
			this.dateTimePickerBirthDate.TabIndex = 3;
			// 
			// labelBitrhDate
			// 
			this.labelBitrhDate.AutoSize = true;
			this.labelBitrhDate.Location = new System.Drawing.Point(12, 53);
			this.labelBitrhDate.Name = "labelBitrhDate";
			this.labelBitrhDate.Size = new System.Drawing.Size(86, 13);
			this.labelBitrhDate.TabIndex = 4;
			this.labelBitrhDate.Text = "Дата рождения";
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(12, 104);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(45, 13);
			this.labelGroupName.TabIndex = 5;
			this.labelGroupName.Text = "Группа:";
			// 
			// comboBoxGroup
			// 
			this.comboBoxGroup.FormattingEnabled = true;
			this.comboBoxGroup.Location = new System.Drawing.Point(12, 120);
			this.comboBoxGroup.Name = "comboBoxGroup";
			this.comboBoxGroup.Size = new System.Drawing.Size(327, 21);
			this.comboBoxGroup.TabIndex = 6;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(183, 170);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 7;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(264, 170);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// AddStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 200);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.comboBoxGroup);
			this.Controls.Add(this.labelGroupName);
			this.Controls.Add(this.labelBitrhDate);
			this.Controls.Add(this.dateTimePickerBirthDate);
			this.Controls.Add(this.labelFullName);
			this.Controls.Add(this.lableFullName);
			this.Name = "AddStudent";
			this.Text = "Cancel";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox lableFullName;
		private System.Windows.Forms.Label labelFullName;
		private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
		private System.Windows.Forms.Label labelBitrhDate;
		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.ComboBox comboBoxGroup;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}