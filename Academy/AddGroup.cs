using System;
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

namespace Academy
{
	public partial class AddGroup : Form
	{
		
		Form1 mainForm;
		private string connectionString;
		SqlConnection connection;
		SqlDataAdapter adapter;
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
		//mainForm.LoadDataToComboBox(cbDirection, "Directions", "direction_name", "Выберите напрвление обучения");
			mainForm.LoadDataToComboBox(cbLearningForm, "LearningForms", "form_name", "Выберите форму обучения");
			mainForm.LoadDataToComboBox(cbLearningTime, "LearningTimes", "time_name", "Выберите время обучения");
			cbWeek = new CheckBox[7];			
		}
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
			catch(Exception e)
			{
				MessageBox.Show(this, e.Message);
			}
		}
		string GenerateGroupName()
		{
			string group_name = "";
			if (cbLearningForm.SelectedItem.ToString() != "Годичные курсы")
			{
				if (cbLearningForm.SelectedItem.ToString() == "Полустационар") group_name += lcbWeek.SelectedItem.ToString();
				//if (cbDirection.SelectedItem.ToString() == "Разработка программного обеспечения")
				{
					//DataRow[] rows = set.Tables["Directions"].Select("direction_name='Разработка прогаммного обеспечения'");
					//DataRow row = rows[0];
					//group_name += row["direction_code_name"];
					group_name += set.Tables["Directions"]
						.Select($"direction_name='{cbDirection.SelectedItem.ToString()}'")[0]["direction_code_name"];
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
				//	mainForm.LoadDataToComboBox
			//				(
			//				cbDirection,
			//				"Directions, LearningForms, LearningFormsDirectionsRelation",
			//				"direction_name", 
			//				"Выберите форму обучения", 
			//				$@"
			//WHERE 
			//LearningFormsDirectionsRelation.learning_form = LearningForms.form_id
			//AND LearningFormsDirectionsRelation.direction = Directions.direction_id
			//AND direction_name = {cbLearningForm.SelectedItem.ToString()}
			//"
			//				);

			cbDirection.Items.Clear();
			if(cbLearningForm.SelectedIndex != 0)
			mainForm.LoadDataFromStorageToComboBox
				(
				cbDirection,
				"Directions, LearningForms, LearningFormsDirectionsRelation",
				"direction_name",
				"Выберите форму обучения",
				$@"

LearningFormsDirectionsRelation.learning_form = LearningForms.form_id
AND LearningFormsDirectionsRelation.direction = Directions.direction_id
AND form_name = '{cbLearningForm.SelectedItem.ToString()}'"
				);
		}

		
	}
}
