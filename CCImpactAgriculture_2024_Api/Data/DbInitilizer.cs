using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Drawing.Printing;
using CCImpactAgriculture_2024_Api.Data.Models;
using CCImpactAgriculture_2024_Api.Models;
namespace CCImpactAgriculture_2024_Api.Data;

public static class Dbinitilizer
{
    public static void Initilize(CCImpactAgricultureContext context)
    {
        context.Database.EnsureCreated();
        if(!context.CCItem.Any())
        {
            using (var reader = new StreamReader("Data/climate_change_impact_on_agriculture_2024.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<CCImpactAgricultureItemMap>();
                var records = csv.GetRecords<CCImpactAgricultureItem>();
                Console.WriteLine("\n\n");
                foreach (CCImpactAgricultureItem temp in records)
                {
                    // Console.WriteLine($"year: {temp.Year}, Country: {temp.Country}, Region: {temp.Region}, Crop_Type: {temp.Crop_Type}\n");
                    context.CCItem.Add(temp);
                }
                context.SaveChanges();
            }
        }



    }
}