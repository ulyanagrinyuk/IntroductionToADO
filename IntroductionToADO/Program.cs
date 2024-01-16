using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace IntroductionToADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();

			//Вставка:
			//string insert_string = @"INSERT INTO Authors(first_name, last_name) VALUES ('Steven', 'Hawking')";
			string insert_string = @"INSERT INTO Books(author, title, price, pages) VALUES (4, 'The Steven Hawkings Universe', 160, 850)";
			SqlCommand cmd = new SqlCommand(insert_string, connection);
			//cmd.ExecuteNonQuery();

			//Выборка:
			string select_string = @"SELECT * FROM Authors";
			cmd.CommandText = select_string;

			SqlDataReader rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");
			}
			connection.Close();
			rdr.Close();
			int choose = 1;
			Console.WriteLine($"\n\nВведите действие:\n[o] - добавить книгу\n[p] - выйти.\n");
			switch (choose)
			{
				case 0:
					break;
				case 1:
					{
						Console.WriteLine("Введите имя Автора книги:\n");
						string first_name = Console.ReadLine();
						Console.WriteLine("Введите Фамилию Автора книги:\n");
						string last_name = Console.ReadLine();

						SqlCommand author_cmd = new SqlCommand($"INSERT INTO Authors (first_name,last_name) VALUES ('{first_name}','{last_name}')", connection);
						author_cmd.ExecuteNonQuery();

						author_cmd.CommandText = ($"SELECT Authors.id FROM Authors WHERE Authors.first_name = '{first_name}' AND Authors.last_name = '{last_name}'");
						SqlDataReader author_rdr = author_cmd.ExecuteReader();
						author_rdr.Read();

						Console.WriteLine("Введите название книги:\n");
						string book = Console.ReadLine();
						Console.WriteLine("Введите стоимость книги:\n");
						string price = (Console.ReadLine());
						Console.WriteLine("Введите количество страниц книги:\n");
						string pages = (Console.ReadLine());

						SqlCommand book_cmd = new SqlCommand($"INSERT INTO Books (author,title,price,pages) VALUES ({author_rdr[0]},'{book}',{price},{pages})", connection);
						author_rdr.Close();
						book_cmd.ExecuteNonQuery();
					}
					break;
			}
			Thread.Sleep(100);

			connection.Close();
		}
	}

}
