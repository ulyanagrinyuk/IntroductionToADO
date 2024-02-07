﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Academy
{
	public partial class AddGroup : Form
	{
		Form1 mainForm;
		private string connectionString;
		SqlConnection connection;
		SqlDataAdapter adapter;     //Вытягивает результаты запросов из Базы, и сохраняет их в DataSet
		DataSet set;
		SqlCommandBuilder builder;
		public System.Windows.Forms.ComboBox CBDirection { get => cbDirection; }
		public System.Windows.Forms.ComboBox CBLearningForm { get => cbLearningForm; }
		public System.Windows.Forms.ComboBox CBLearningTime { get => cbLearningTime; }
		string[] week = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		CheckBox[] cbWeek;
		public AddGroup(Form1 mainForm)
		{
			this.mainForm = mainForm;
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			GetDataFromBase();
			mainForm.LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
			//mainForm.LoadDataToComboBox(cbDirection, "Directions", "direction_name", "Выберите направление обучения");
			mainForm.LoadDataToComboBox(cbLearningTime, "LearningTimes", "time_name", "Выберите время обучения");
			cbWeek = new CheckBox[7];
		}
		public AddGroup(Form1 mainForm, string group_name, byte direction, byte learning_time, byte learning_days):this(mainForm)
		{
			TableStorage storage = new TableStorage();
			storage.GetDataFromBase("Direcitons");
			storage.GetDataFromBase("LearningFormsDirectionsRelation");

			tbGroupName.Text = group_name;
			cbLearningForm.SelectedIndex =
				Convert.ToInt32(storage.Set.Tables["LearningFormsDirectionsRelation"].Select($"direction = {direction}")[0]["learning_form"]);
			cbDirection.SelectedItem = storage.Set.Tables["Directions"].Select($"direction={direction}")[0]["direction_name"];
			cbLearningTime.SelectedIndex = learning_time;
		}
		byte GetBitSet()
		{
			byte days = 0;

			#region PrintInConsole
			//AllocConsole();
			//Console.Write("Days:\t");
			//for (int i = 0; i < clbWeek.CheckedItems.Count; i++)
			//{
			//	Console.Write(clbWeek.CheckedItems[i] + "\t");
			//}
			//Console.WriteLine();
			//Console.Write("Nums:\t");
			//for (int i = 0; i < clbWeek.CheckedIndices.Count; i++)
			//{
			//	Console.Write(clbWeek.CheckedIndices[i]+"\t");
			//}
			//Console.WriteLine();
			//Console.WriteLine("\n-------------------------------------\n"); 
			#endregion

			for (int i = 0; i < lcbWeek.CheckedIndices.Count; i++)
			{
				//byte day = (byte)Math.Pow(2, clbWeek.CheckedIndices[i]);
				//days += day;
				byte day = 1;
				day <<= lcbWeek.CheckedIndices[i];
				days |= day;
			}

			return days;
		}
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		void GetDataFromBase()
		{
			try
			{
				set = new DataSet();
				string cmd = $@"SELECT * FROM Directions";
				adapter = new SqlDataAdapter(cmd, connection);
				builder = new SqlCommandBuilder(adapter);
				adapter.Fill(set, "Directions");

				adapter.SelectCommand.CommandText = $@"SELECT * FROM LearningTimes";
				builder.DataAdapter = adapter;
				adapter.Fill(set, "LearningTimes");
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message);
			}
		}
		string GenerateGroupName()
		{
			//if (cbLearningForm.SelectedIndex == 0) return "Выберите форму обучения";
			//if (cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения") return "Выберите направление обучения";
			//if (cbTime.SelectedIndex == 0) return "Выберите время обучения";
			if (!AllCombosOK()) return "Что-то пошло не так :-(";
			string group_name = "";
			if (cbLearningForm.SelectedItem.ToString() != "Годичные курсы")
			{
				if (cbLearningForm.SelectedItem.ToString() == "Полустационар") group_name += lcbWeek.SelectedItem.ToString() == "Сб" ? "S" : "V" ;
				//if (cbDirection.SelectedItem.ToString() == "Разработка программного обеспечения")
				{
					//DataRow[] rows = set.Tables["Directions"].Select("direction_name='Разработка программного обеспечения'");
					//DataRow row = rows[0];
					//group_name += row["direction_code_name"];
					group_name +=
						set.Tables["Directions"].Select($"direction_name='{cbDirection.SelectedItem.ToString()}'")[0]["direction_code_name"];
					group_name +=
						set.Tables["LearningTimes"].Select($"time_name='{CBLearningTime.SelectedItem.ToString()}'")[0]["time_code_name"];
				}
			}
			group_name += "_";
			return group_name;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			tbGroupName.Text = GenerateGroupName();
		}

		private void cbLearningForm_SelectedIndexChanged(object sender, EventArgs e)
		{
			//			mainForm.LoadDataToComboBox
			//				(
			//				cbDirection,
			//				"Directions, LearningForms, LearningFormsDirectionsRelation",
			//				"direction_name",
			//				"Выберите форму обучения",
			//				$@"
			//WHERE	LearningFormsDirectionsRelation.learning_form	= LearningForms.form_id
			//AND		LearningFormsDirectionsRelation.direction		= Directions.direction_id
			//AND		form_name = {cbLearningForm.SelectedItem.ToString()}
			//"
			//				);

			int selectedIndexInDirection = cbDirection.SelectedIndex;
			string directionName = cbDirection.SelectedItem?.ToString();

			cbDirection.Items.Clear();
			if (cbLearningForm.SelectedIndex != 0)
				mainForm.LoadDataFromStorageToComboBox
								(
								cbDirection,
								"Directions, LearningForms, LearningFormsDirectionsRelation",
								"direction_name",
								"Выберите форму обучения",
								$@"  
		LearningFormsDirectionsRelation.learning_form	= LearningForms.form_id
AND		LearningFormsDirectionsRelation.direction		= Directions.direction_id
AND		form_name = '{cbLearningForm.SelectedItem.ToString()}'
"
								);
			//cbDirection.SelectedIndex = selectedIndexInDirection < cbDirection.Items.Count ? selectedIndexInDirection : -1;
			bool badDirection = false;
			if(selectedIndexInDirection < cbDirection.Items.Count)
			{
				cbDirection.SelectedIndex = selectedIndexInDirection;
			}
			else
			{
				badDirection = true;
			}
			if (directionName != cbDirection.SelectedItem?.ToString()) badDirection = true;
			if(badDirection)		
			{
				cbDirection.SelectedIndex = -1;
				cbDirection.Text = "Выберите направление обучения";
				MessageBox.Show(this, "На данной форме обучения не такого напрвления", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cbDirection.Select();
			}
		}

		private void lcbWeek_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblLearningDaysCode.Text = $"Дни обучения: {GetBitSet()}";
		}
		bool ComboBoxOK(ComboBox comboBox)
		{
			if (comboBox.SelectedItem == null) return false;
			if (comboBox.SelectedItem.ToString().Contains(" обучения")) return false;
			return true;
		}
		bool AllCombosOK()
		{
			string message = "";
			if (cbLearningForm.SelectedItem.ToString() == "Выберите форму обучения") message = "Выберите форму обучения";
			else if (cbDirection.SelectedItem == null || cbDirection.SelectedItem.ToString() == "Выберите направление обучения") message = "Выберите направление обучения";
			else if (cbLearningTime.SelectedIndex == 0) message = "Выберите время обучения";
			if (message.Length > 0)
			{
				MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void btnCreateGroup_Click(object sender, EventArgs e)
		{
			if (AllCombosOK() == false) return;
			//if (
			//	!ComboBoxOK(cbLearningForm) && 
			//	!ComboBoxOK(cbDirection) &
			//	!ComboBoxOK(cbTime)
			//	)
			//{
			//	MessageBox.Show(this, "Ничего не выбрано", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return;
			//}
			bool wrong_days = false;
			if (cbLearningForm.SelectedItem.ToString() == "Стационар" && lcbWeek.CheckedItems.Count != 3) wrong_days = true;
			if (cbLearningForm.SelectedItem.ToString() == "Полустационар" && lcbWeek.CheckedItems.Count != 1) wrong_days = true;
			if (cbLearningForm.SelectedItem.ToString() == "Годичные курсы" && lcbWeek.CheckedItems.Count != 2) wrong_days = true;
			if (wrong_days) MessageBox.Show(this, "Проверьте дни обучения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//else			MessageBox.Show(this, "Все хорошо ;-)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			if (wrong_days) return;

			TableStorage storage = new TableStorage();
			storage.GetDataFromBase("Directions");
			storage.GetDataFromBase("LearningTimes");
			storage.GetDataFromBase("Groups");
			//string insert = $@"
			//	INSERT INTO Groups(group_name, direction, learning_time, learning_days)
			//	VALUES (
			//	'{tbGroupName.Text}'
			//	 {set.Tables["Directions"].Select($"direction_name={cbDirection.SelectedItem.ToString()}")[0]["direction_id"]}
			//	{set.Tables["cbLearningTimes"].Select($"time_name={cbLearningTime.SelectedItem.ToString()}")[0]["time_id"]}
			//	{GetBitSet()}
			//	)";
			////	storage.Adapter.Update(storage.Set);
			////storage.Adapter.InsertCommand.ExecuteNonQuery();
			//storage.Insert(insert_cmd);

			if (storage.Set.Tables["Groups"].Select($"group_name = '{tbGroupName.Text}'").Length == 0) 
			{
				DataRow row = storage.Set.Tables["Groups"].NewRow();
				row["group_name"] = tbGroupName.Text;
				row["direction"] = storage.Set.Tables["Directions"].Select($"direction_name='{cbDirection.SelectedItem.ToString()}'")[0]["direction_id"];
				row["learning_time"] = storage.Set.Tables["LearningTimes"].Select($"time_name='{cbLearningTime.SelectedItem.ToString()}'")[0][0];
				row["learning_days"] = GetBitSet();
				storage.Set.Tables["Groups"].Rows.Add(row);
				storage.Adapter.Update(storage.Set, "Groups"); 
			}
			else
			{
				MessageBox.Show(this, "Такая группа уже есть", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
			this.Close();
		}

		}
}	