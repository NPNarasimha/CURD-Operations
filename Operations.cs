using System;
using System.Collections.Generic;
using System.Text;

namespace CurdApp
{
    internal class Operations
    {
        public void Curd() { 
            //curd Operation Snipets





        /*  //=================================CREATE TABLE======================
           Console.WriteLine("Enter the table name");
           string tableName=Console.ReadLine();
           string createTable = "create table "+tableName+"(Id int,Name varchar(25),Branch varchar(30))";
           SqlCommand create = new SqlCommand(createTable, sqlCon);
           create.ExecuteNonQuery();
           Console.WriteLine("Create table");
        */

        /* //========================--INSERT INTO DIRECT VALUES--===================================
           string query = "Insert into student(Id,Name,Branch)values(1,'Krishna','CSE'),(2,'sai','ECE')";
           SqlCommand cmd = new SqlCommand(query,sqlCon);
           cmd.ExecuteNonQuery();
           Console.WriteLine("Insert data into student tables is success");
         */

        /*  //=========================INSERT INTO USER INPUT--=========================================
           Console.WriteLine("Enter the student Id");
           int stdid=int.Parse(Console.ReadLine());
           Console.WriteLine("Enter the student Name");
           string stdName = Console.ReadLine();
           Console.WriteLine("Enter the student Branch");
           string stdBranch = Console.ReadLine();
           string query = "Insert into student(Id,Name,Branch)values(" + stdid + ",'" + stdName + "','" + stdBranch + "')";
           SqlCommand cmd =new SqlCommand(query,sqlCon);
           cmd.ExecuteNonQuery();
           Console.WriteLine("data enter successfully") ;
         */

        /*   //===================== DISPLAY DATA====================
            string query = "select * from student";

            SqlCommand cmd=new SqlCommand(query, sqlCon);
            SqlDataReader reader =cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(reader.GetValue(0).ToString()+" "+reader.GetValue(1).ToString()+" "+reader.GetValue(2).ToString());
                Console.WriteLine();
            }
        */

        /*   //==========================update Id using Id=======================    
           Console.WriteLine("Enter student Set Id");
           int setId=int.Parse(Console.ReadLine());
           Console.WriteLine("Enter student Which id is change");
           int stdid= int.Parse(Console.ReadLine());
           string queryup = "UPDATE student SET Id = " + setId + " where Id=" + stdid + "";
           SqlCommand cmdup = new SqlCommand(queryup,sqlCon);
           cmdup.ExecuteNonQuery();
           Console.WriteLine("Udate success");
*/

        /*  //==========================update Name using using Id=======================    
              Console.WriteLine("Enter student Id where we can Change");
              int sId= int.Parse(Console.ReadLine());
              Console.WriteLine("Enter student Name");
              String stdName = Console.ReadLine();
              string query = "UPDATE student SET Name = '" + stdName + "' where Id=" + sId + "";
              SqlCommand cmd = new SqlCommand(query, sqlCon);
              cmd.ExecuteNonQuery();
              Console.WriteLine("Udate success");

              */
    }
    }
}
