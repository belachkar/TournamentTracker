﻿using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers {
  public static class TextConnectorProcessor {
    public static string FullFilePath(this string fileName) {
      string DataDirPath = ConfigurationManager.AppSettings["filePAth"];

      if (!Directory.Exists(DataDirPath)) {
        Directory.CreateDirectory(DataDirPath);
      }
      return $"{DataDirPath}\\{fileName}";
    }

    public static List<string> LoadFile(this string file) {
      if (!File.Exists(file)) {
        return new List<string>();
      }
      return File.ReadAllLines(file).ToList();
    }

    public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines) {
      List<PrizeModel> output = new List<PrizeModel>();

      foreach (var line in lines) {
        string[] cols = line.Split(',');

        PrizeModel p = new PrizeModel();
        p.id = int.Parse(cols[0]);
        p.PlaceNumber = int.Parse(cols[1]);
        p.PlaceName = cols[2];
        p.PrizeAmount = decimal.Parse(cols[3]);
        p.PrizePercentage = double.Parse(cols[4]);
        output.Add(p);
      }
      return output;
    }

    public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName) {
      List<string> lines = new List<string>();

      foreach (PrizeModel p in models) {
        lines.Add($"{p.id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
      }
      File.WriteAllLines(fileName.FullFilePath(), lines);
    }

    public static List<PersonModel> ConvertToPersonModels(this List<string> lines) {
      List<PersonModel> output = new List<PersonModel>();

      foreach (var line in lines) {
        string[] cols = line.Split(',');

        PersonModel p = new PersonModel();
        p.id = int.Parse(cols[0]);
        p.FirstName = cols[1];
        p.LastName = cols[2];
        p.EmailAddress = cols[3];
        p.CellPhoneNbr = cols[4];
        output.Add(p);
      }
      return output;
    }

    public static void SaveToPeopleFile(this List<PersonModel> models, string fileName) {
      List<string> lines = new List<string>();

      foreach (PersonModel p in models) {
        lines.Add($"{p.id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellPhoneNbr}");
      }
      File.WriteAllLines(fileName.FullFilePath(), lines);
    }
  }
}
