using System;
using Microsoft.Data.SqlClient;




namespace CurdApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlCon ;
            string connectionString = @"Data Source=DESKTOP-TUV7N20\SQLEXPRESS;Initial Catalog=BasicPrograms;Integrated Security=True;Trust Server Certificate=True";
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                Console.WriteLine("Connection Esatablish Successfully");
               

                while (true) {
                Console.WriteLine();
                Console.WriteLine("Enter your choice ==== 1 is create Table ==== 2 for Inserting data ==== 3 for updating ==== 4 for deleting ==== 5 for Deleting ==== 6 is Exit");
                int choice =int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the table name");
                            string tableName = Console.ReadLine();
                            
                            string createTable = "create table " + tableName + "(Id int,Name varchar(25),Branch varchar(30))";
                            SqlCommand create = new SqlCommand(createTable, sqlCon);
                            create.ExecuteNonQuery();
                            Console.WriteLine("Create table");
                            break;
                        case 2:
                            Console.WriteLine("Enter the student Id");
                            int stdid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the student Name");
                            string sName = Console.ReadLine();
                            Console.WriteLine("Enter the student Branch");
                            string stdBranch = Console.ReadLine();
                            string query = "Insert into student(Id,Name,Branch)values(" + stdid + ",'" + sName + "','" + stdBranch + "')";
                            SqlCommand cmd = new SqlCommand(query, sqlCon);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("data enter successfully");
                            break;
                        case 3:
                            Console.WriteLine("Enter student Id where we can Change");
                            int sId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter student Name");
                            String stdName = Console.ReadLine();
                            string queryUpdate = "UPDATE student SET Name = '" + stdName + "' where Id=" + sId + "";
                            SqlCommand updatecmd = new SqlCommand(queryUpdate, sqlCon);
                            updatecmd.ExecuteNonQuery();
                            Console.WriteLine("Udate success");
                            break;
                        case 4:
                            Console.WriteLine("Enter the student Id");
                            int sid = int.Parse(Console.ReadLine());
                            string deleteQuery = "DELETE from student where Id=" + sid + "";
                            SqlCommand deletecmd = new SqlCommand(deleteQuery, sqlCon);
                            deletecmd.ExecuteNonQuery();
                            Console.WriteLine("Delete table success");
                            break;
                        case 5:
                            string displayquery = "select * from student";

                            SqlCommand displaycmd = new SqlCommand(displayquery, sqlCon);
                            SqlDataReader reader = displaycmd.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.Write(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString());
                                Console.WriteLine();
                            }
                            reader.Close();
                            break;
                        case 6:
                            return;
                            
                        default:
                            Console.WriteLine("Your choice is not valid");
                            break;
                            
                    }
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
