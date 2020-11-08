// using System;

// namespace MyApplication
// {
// 	class Program
// 	{
// 		static void Main(String[] args)
// 		{
// 			Console.Write("Enter name: ");
// 			string name = Console.ReadLine();
// 			Console.WriteLine("Name is: " + name);
// 		}
// 	}
// }


// using System;

// namespace MyApplication
// {
// 	class Program
// 	{
// 		static void Main(String[] args)
// 		{
// 			Hi();
// 		}
// 		static void Hi()
// 		{
// 			Console.Write("Hi");
// 		}
// 	}
// }



using System;
using dllLibrary;
namespace MyApplication
{
	class Program
	{
		static void Hi()
		{
			Console.Write(x);
			Console.Write("Hello");
		}
	}
}




































// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.IO;

// using MySql.Data;
// using MySql.Data.MySqlClient;


// // namespace ConsoleApp1
// // {
//     class Crud
//     {
//         public Crud()
//         {
//             string connStr;



//         }
//         static void Main(string[] args)
//         {
//             Crud obj = new Crud();

//             while(true)
//            {
//                 Console.WriteLine("\n--------------Big Bazar Item Details--------------");
//                 Console.WriteLine("\nPlease choose: \n1. Add New item\n2. Show all items\n3. Update an item\n4. Delete an item\n5. Search an item\n6. exit\n");
//                 Console.WriteLine("----------------------------------------------------");
//                 Console.WriteLine("Enter your choice: ");
//                 int choice;
//                 choice = Convert.ToInt32(Console.ReadLine());
//                 if(choice == 1)
//                 {
//                     Console.WriteLine("Insert");
//                     // insert();
//                 }
//                 if(choice == 2)
//                 {
//                     Console.WriteLine("Read");
//                     // obj.display();
//                 }
//                 if(choice == 3)
//                 {
//                     Console.WriteLine("Update");
//                     // obj.update();
//                 }
//                 if(choice == 4)
//                 {
//                     Console.WriteLine("Delete");
//                     // obj.delete();
//                 }
//                 if(choice == 5)
//                 {
//                     Console.WriteLine("Search");
//                     // obj.search();
//                 }
//                 if(choice == 6)
//                 {
//                     Console.WriteLine("Exit");
//                     // obj.exit();
//                 }
//             }

//             // class DataBaseConnection
//             // {
//             //     string connStr = "Server=165.22.14.77;User=rusheel;Password=rusheel;Database=dbRusheel ";
//             //     MySqlConnection conn = new MySqlConnection(connStr);
//             //     try
//             //     {
//             //         Console.WriteLine("Connecting to MySQL...");
//             //         conn.Open();

//             //         // string sql = "SELECT Item_Description, Unit_Price FROM Item WHERE Item_ID='SS55'";
//             //         // MySqlCommand cmd = new MySqlCommand(sql, conn);
//             //         // MySqlDataReader rdr = cmd.ExecuteReader();

//             //         // while (rdr.Read())
//             //         // {
//             //         //     Console.WriteLine(rdr[0] + " -- " + rdr[1]);
//             //         // }
//             //         // rdr.Close();
//             //     }
//             //     catch (Exception ex)
//             //     {
//             //         Console.WriteLine(ex.ToString());
//             //     }

//             //     conn.Close();
//             //     Console.WriteLine("Done.");
//             // }
//         }
//     }
// // }



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.IO;

// using MySql.Data;
// using MySql.Data.MySqlClient;

// class Display
// {
//     static void Main(string[] args)
//     {
//     string connStr = "Server=165.22.14.77;User=rusheel;Password=rusheel;Database=dbRusheel ";
//         MySqlConnection conn = new MySqlConnection(connStr);
//         try
//         {
//             Console.WriteLine("Connecting to MySQL...");
//             conn.Open();

//             string sql = "SELECT * FROM Item WHERE Status = 'Active';";
//             MySqlCommand cmd = new MySqlCommand(sql, conn);
//             MySqlDataReader rdr = cmd.ExecuteReader();
//            Console.WriteLine("Item_ID\t\tItem_Description\t\tUnit_Price\tStock_Quantity\tSupplier_ID\n");
//             while(rdr.Read())
//             {
//                 Console.WriteLine(rdr[1] + "\t\t" + rdr[2] + "\t\t" + rdr[3] + "\t\t" + rdr[4] + "\t\t" + rdr[5]);
//             }
//             rdr.Close();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.ToString());
//         }

//         conn.Close();
//         Console.WriteLine("Done.");
//     }
// }


// class Insert
// {
//     static void Main(string[] args)
//     {
//         string connStr = "Server=165.22.14.77;User=rusheel;Password=rusheel;Database=dbRusheel ";

//         MySqlConnection conn = new MySqlConnection(connStr);
//         try
//         {

//             Console.WriteLine("Connecting to MySQL...");
//             conn.Open();

//             string sql = "Insert into Item values(@Status,@Item_ID,@Item_Description,@Unit_Price,@Stock_Quantity,@Supplier_ID)";
//             MySqlCommand command = new MySqlCommand(sql, conn);

//             Console.WriteLine("Enter Status: ");
//             String Status = Console.ReadLine();
//             command.Parameters.AddWithValue("@Status", Status);

//             Console.WriteLine("Enter Item ID: ");
//             String Item_ID = Console.ReadLine();
//             command.Parameters.AddWithValue("@Item_ID", Item_ID);

//             Console.WriteLine("Enter Item Description: ");
//             String Item_Description = Console.ReadLine();
//             command.Parameters.AddWithValue("@Item_Description", Item_Description);

//             Console.WriteLine("Enter Unit Price: ");
//             float Unit_Price = Convert.ToSingle(Console.ReadLine());
//             command.Parameters.AddWithValue("@Unit_Price", Unit_Price);

//             Console.WriteLine("Enter Stock Quantity: ");
//             int Stock_Quantity = Convert.ToInt32(Console.ReadLine());
//             command.Parameters.AddWithValue("@Stock_Quantity", Stock_Quantity);

//             Console.WriteLine("Enter Supplier ID: ");
//             String Supplier_ID = Console.ReadLine();
//             command.Parameters.AddWithValue("@Supplier_ID", Supplier_ID);

//             command.ExecuteNonQuery();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.ToString());
//         }

//         conn.Close();
//     }
// }






// class Update
// {
//     static void Main(string[] args)
//     {
//         string connStr = "Server=165.22.14.77;User=rusheel;Password=rusheel;Database=dbRusheel ";

//         MySqlConnection conn = new MySqlConnection(connStr);
//         try
//         {

//             Console.WriteLine("Connecting to MySQL...");
//             conn.Open();

//             Console.WriteLine("Enter Item ID to update: ");
//             String Item_ID = Console.ReadLine();
//             Console.WriteLine("\n1. To Update Item Description");
//             Console.WriteLine("2. To Update Unit Price");
//             Console.WriteLine("3. To Update Stock Quantity");
//             Console.WriteLine("Enter your choice: ");
//             int choice;
//             choice = Convert.ToInt32(Console.ReadLine());
//             if(choice == 1)
//             {
//                 String sql = "UPDATE Item SET Item_Description = @Item_Description WHERE Item_ID = @Item_ID and Status = 'Active'";
//                 MySqlCommand command = new MySqlCommand(sql, conn);
//                 Console.WriteLine("\nEnter Item Description: ");
//                 String Item_Description = Console.ReadLine();
//                 command.Parameters.AddWithValue("@Item_Description", Item_Description);
//                 command.Parameters.AddWithValue("@Item_ID", Item_ID);

//                 command.ExecuteNonQuery();
//             }
//              if(choice == 2)
//             {
//                 String sql = "UPDATE Item SET Unit_Price = @Unit_Price WHERE Item_ID = @Item_ID and Status = 'Active'";
//                 MySqlCommand command = new MySqlCommand(sql, conn);
//                 Console.WriteLine("\nEnter Unit Price: ");
//                 String Unit_Price = Console.ReadLine();
//                 command.Parameters.AddWithValue("@Unit_Price", Unit_Price);
//                 command.Parameters.AddWithValue("@Item_ID", Item_ID);

//                 command.ExecuteNonQuery();
//             }
//              if(choice == 3)
//             {
//                 String sql = "UPDATE Item SET Stock_Quantity = @Stock_Quantity WHERE Item_ID = @Item_ID and Status = 'Active'";
//                 MySqlCommand command = new MySqlCommand(sql, conn);
//                 Console.WriteLine("\nEnter Stock Quantity: ");
//                 String Stock_Quantity = Console.ReadLine();
//                 command.Parameters.AddWithValue("@Stock_Quantity", Stock_Quantity);
//                 command.Parameters.AddWithValue("@Item_ID", Item_ID);

//                 command.ExecuteNonQuery();
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.ToString());
//         }

//         conn.Close();
//     }
// }


// class Delete
// {
//     static void Main(string[] args)
//     {
//         string connStr = "Server=165.22.14.77;User=rusheel;Password=rusheel;Database=dbRusheel ";

//         MySqlConnection conn = new MySqlConnection(connStr);
//         try
//         {

//             Console.WriteLine("Connecting to MySQL...");
//             conn.Open();

//             Console.WriteLine("Enter Item ID to Delete: ");
//             String Item_ID = Console.ReadLine();
//             String sql = "DELETE FROM Item WHERE Item_ID = @Item_ID and Status = 'Active'";
//             MySqlCommand command = new MySqlCommand(sql, conn);
//             command.Parameters.AddWithValue("@Item_ID", Item_ID);

//             command.ExecuteNonQuery();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.ToString());
//         }

//         conn.Close();
//     }
// }



// class Search
// {
//     static void Main(string[] args)
//     {
//         string connStr = "Server=165.22.14.77;User=rusheel;Password=rusheel;Database=dbRusheel ";

//         MySqlConnection conn = new MySqlConnection(connStr);
//         try
//         {

//             Console.WriteLine("Connecting to MySQL...");
//             conn.Open();

//             Console.WriteLine("Enter Item ID to Search: ");
//             String Item_ID = Console.ReadLine();
//             String sql = "SELECT * FROM Item WHERE Item_ID = @Item_ID AND Status = 'Active'";
//             MySqlCommand command = new MySqlCommand(sql, conn);
//             command.Parameters.AddWithValue("@Item_ID", Item_ID);
//             MySqlDataReader rdr = command.ExecuteReader();
//             Console.WriteLine("Item_ID\t\tItem_Description\t\tUnit_Price\tStock_Quantity\tSupplier_ID\n");
//             while(rdr.Read())
//             {
//                 Console.WriteLine(rdr[1] + "\t\t" + rdr[2] + "\t\t" + rdr[3] + "\t\t" + rdr[4] + "\t\t" + rdr[5]);
//             }
//             rdr.Close();
//             command.ExecuteNonQuery();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.ToString());
//         }

//         conn.Close();
//     }
// }















































// public void Insert()
// {
//     string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

//     //open connection
//     if (this.OpenConnection() == true)
//     {
//         //create command and assign the query and connection from the constructor
//         MySqlCommand cmd = new MySqlCommand(query, connection);
        
//         //Execute command
//         cmd.ExecuteNonQuery();

//         //close connection
//         this.CloseConnection();
//     }
// }