namespace Academy
{
	partial class Form1
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.lablSearch = new System.Windows.Forms.Label();
			this.cbSearch = new System.Windows.Forms.TextBox();
			this.rbStudents = new System.Windows.Forms.RadioButton();
			this.rbGroups = new System.Windows.Forms.RadioButton();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.lblStudCount = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.lblGroups = new System.Windows.Forms.Label();
			this.cbDirectionOnGroupTab = new System.Windows.Forms.ComboBox();
			this.btnGroupAdd = new System.Windows.Forms.Button();
			this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageStudents);
			this.tabControl1.Controls.Add(this.tabPageGroups);
			this.tabControl1.Controls.Add(this.tabPageTeachers);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(786, 442);
			this.tabControl1.TabIndex = 7;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.lablSearch);
			this.tabPageStudents.Controls.Add(this.cbSearch);
			this.tabPageStudents.Controls.Add(this.rbStudents);
			this.tabPageStudents.Controls.Add(this.rbGroups);
			this.tabPageStudents.Controls.Add(this.cbDirection);
			this.tabPageStudents.Controls.Add(this.lblStudCount);
			this.tabPageStudents.Controls.Add(this.btnAdd);
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Controls.Add(this.cbGroup);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(778, 416);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Студенты";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// lablSearch
			// 
			this.lablSearch.AutoSize = true;
			this.lablSearch.Location = new System.Drawing.Point(167, 41);
			this.lablSearch.Name = "lablSearch";
			this.lablSearch.Size = new System.Drawing.Size(94, 13);
			this.lablSearch.TabIndex = 8;
			this.lablSearch.Text = "Поиск Студентов";
			// 
			// cbSearch
			// 
			this.cbSearch.Location = new System.Drawing.Point(6, 38);
			this.cbSearch.Name = "cbSearch";
			this.cbSearch.Size = new System.Drawing.Size(145, 20);
			this.cbSearch.TabIndex = 7;
			this.cbSearch.TextChanged += new System.EventHandler(this.cbSearch_TextChanged);
			// 
			// rbStudents
			// 
			this.rbStudents.AutoSize = true;
			this.rbStudents.Location = new System.Drawing.Point(263, 68);
			this.rbStudents.Name = "rbStudents";
			this.rbStudents.Size = new System.Drawing.Size(73, 17);
			this.rbStudents.TabIndex = 6;
			this.rbStudents.TabStop = true;
			this.rbStudents.Text = "Студенты";
			this.rbStudents.UseVisualStyleBackColor = true;
			this.rbStudents.CheckedChanged += new System.EventHandler(this.rbStudents_CheckedChanged);
			// 
			// rbGroups
			// 
			this.rbGroups.AutoSize = true;
			this.rbGroups.Location = new System.Drawing.Point(170, 68);
			this.rbGroups.Name = "rbGroups";
			this.rbGroups.Size = new System.Drawing.Size(62, 17);
			this.rbGroups.TabIndex = 5;
			this.rbGroups.TabStop = true;
			this.rbGroups.Text = "Группы";
			this.rbGroups.UseVisualStyleBackColor = true;
			this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(6, 64);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(145, 21);
			this.cbDirection.TabIndex = 4;
			this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
			// 
			// lblStudCount
			// 
			this.lblStudCount.AutoSize = true;
			this.lblStudCount.Location = new System.Drawing.Point(167, 11);
			this.lblStudCount.Name = "lblStudCount";
			this.lblStudCount.Size = new System.Drawing.Size(120, 13);
			this.lblStudCount.TabIndex = 3;
			this.lblStudCount.Text = "Количество студентов";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAdd.Location = new System.Drawing.Point(685, 6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvStudents
			// 
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(0, 104);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(772, 306);
			this.dgvStudents.TabIndex = 1;
			// 
			// cbGroup
			// 
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(6, 6);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(145, 21);
			this.cbGroup.TabIndex = 0;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageGroups.Controls.Add(this.lblGroups);
			this.tabPageGroups.Controls.Add(this.cbDirectionOnGroupTab);
			this.tabPageGroups.Controls.Add(this.btnGroupAdd);
			this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(778, 416);
			this.tabPageGroups.TabIndex = 2;
			this.tabPageGroups.Text = "Группы";
			// 
			// lblGroups
			// 
			this.lblGroups.AutoSize = true;
			this.lblGroups.Location = new System.Drawing.Point(353, 11);
			this.lblGroups.Name = "lblGroups";
			this.lblGroups.Size = new System.Drawing.Size(100, 13);
			this.lblGroups.TabIndex = 3;
			this.lblGroups.Text = "Количество групп:";
			// 
			// cbDirectionOnGroupTab
			// 
			this.cbDirectionOnGroupTab.FormattingEnabled = true;
			this.cbDirectionOnGroupTab.Location = new System.Drawing.Point(7, 7);
			this.cbDirectionOnGroupTab.Name = "cbDirectionOnGroupTab";
			this.cbDirectionOnGroupTab.Size = new System.Drawing.Size(340, 21);
			this.cbDirectionOnGroupTab.TabIndex = 2;
			this.cbDirectionOnGroupTab.SelectedIndexChanged += new System.EventHandler(this.cbDirectionOnGroupTab_SelectedIndexChanged);
			// 
			// btnGroupAdd
			// 
			this.btnGroupAdd.Location = new System.Drawing.Point(686, 6);
			this.btnGroupAdd.Name = "btnGroupAdd";
			this.btnGroupAdd.Size = new System.Drawing.Size(75, 23);
			this.btnGroupAdd.TabIndex = 1;
			this.btnGroupAdd.Text = "Добавить";
			this.btnGroupAdd.UseVisualStyleBackColor = true;
			this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
			// 
			// dataGridViewGroups
			// 
			this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGroups.Location = new System.Drawing.Point(6, 45);
			this.dataGridViewGroups.Name = "dataGridViewGroups";
			this.dataGridViewGroups.Size = new System.Drawing.Size(766, 365);
			this.dataGridViewGroups.TabIndex = 0;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(778, 416);
			this.tabPageTeachers.TabIndex = 1;
			this.tabPageTeachers.Text = "Преподаватели";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.Label lblStudCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.RadioButton rbStudents;
		private System.Windows.Forms.RadioButton rbGroups;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.Button btnGroupAdd;
		private System.Windows.Forms.DataGridView dataGridViewGroups;
		private System.Windows.Forms.ComboBox cbDirectionOnGroupTab;
		private System.Windows.Forms.Label lblGroups;
		private System.Windows.Forms.Label lablSearch;
		private System.Windows.Forms.TextBox cbSearch;
	}
}

