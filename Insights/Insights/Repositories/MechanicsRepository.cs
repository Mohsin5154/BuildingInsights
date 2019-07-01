﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using System.Configuration;

namespace Repository
{
    public class MechanicsRepository
    {
        // Connection String which I provided in Web.config. Can be changed there.
        string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public List<Mechanics> GetFailures()
        {
            List<Mechanics> chartData = new List<Mechanics>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetAllMechanicsFailures", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Mechanics mechanics = new Mechanics();
                    mechanics.Type = rdr["Type"].ToString();
                    mechanics.Year = Convert.ToInt16(rdr["Year"]);
                    mechanics.Failure = Convert.ToInt64(rdr["Failure"]);
                    chartData.Add(mechanics);
                }
                con.Close();
            }
            return chartData;
        }
        public List<object> GetMechanicsFailureByType(Mechanics mechanics)
        {
            List<object> chartData = new List<object>();
            chartData.Add(new object[]
        {
            "Year", "Amount"
        });
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetMechanicsFailureByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    chartData.Add(new object[]
                    {
                        rdr["Year"].ToString(),
                      rdr["Failure"]
                      
                    });
                }
                con.Close();
            }
            return chartData;
        }
        public List<object> GetMechanicsCostByType(Mechanics mechanics)
        {
            List<object> chartData = new List<object>();
            chartData.Add(new object[]
        {
            "Year", "Amount"
        });
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetMechanicsCostByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    chartData.Add(new object[]
                    {
                        rdr["Year"].ToString(),
                      rdr["Cost"]

                    });
                }
                con.Close();
            }
            return chartData;
        }
        public void InsertUpdateMechanicsFailureByType(Mechanics mechanics)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_CreateUpdateMechanicsFailureByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BuildingId", mechanics.BuildingId);
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                cmd.Parameters.AddWithValue("@Failure", mechanics.Failure);
                cmd.Parameters.AddWithValue("@Year", mechanics.Year);
                cmd.Parameters.AddWithValue("@IsActive", true);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void InsertUpdateMechanicsCostByType(Mechanics mechanics)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_CreateUpdateMechanicsCostByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BuildingId", mechanics.BuildingId);
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                cmd.Parameters.AddWithValue("@Cost", mechanics.Cost);
                cmd.Parameters.AddWithValue("@Year", mechanics.Year);
                cmd.Parameters.AddWithValue("@IsActive", true);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
  }
}
