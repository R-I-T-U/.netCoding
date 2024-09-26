﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

public class q5
{
    public static void Main(string[] args){

        MySqlConnection conn = new MySqlConnection("server=localhost; database=bank; uid=root; password='';");
        conn.Open();
        string sql = "insert into customer  values (1,'ritu','bkt',1000), (2,'minu','ktm',20000), (3,'sonu','lalitpur',400)";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        int row = cmd.ExecuteNonQuery();
        if (row > 0)
            Console.WriteLine(row+" row inserted.");
        else
            Console.WriteLine("insertion failed");

        string sql2 = "delete from customer where amt<500";
        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
        int row2 = cmd2.ExecuteNonQuery();
        if (row2 >0)
            Console.WriteLine(row2 + " row deleted.");
        else
            Console.WriteLine("deletion failed");

        conn.Close();
        Console.ReadKey();
    }
}