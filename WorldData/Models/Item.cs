using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.IO;
using System;
namespace WorldDataApp.Models
{
  public class WorldData
  {
    private int _id;
    private string _city;
    private string _country;


    public static List<city> GetAll()
    {
        List<city> allCity = new List<city> {};
        MySqlConnection conn = DB.Connection();
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM city;";
        MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        while(rdr.Read())
        {
          int cityId = rdr.GetInt32(0);
          string cityDescription = rdr.GetString(1);
          city newCity = new city(cityDescription, cityId);
          allcitys.Add(newCity);
        }
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }
        return allCaity;
    }
    // public city(string Description, int Id = 0)
    // {
    //   _id = Id;
    //   _description = Description;
    // }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    // public void Save()
    // {
    //   _instances.Add(this);
    // }
    //     public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
  }
}
