
using CCImpactAgriculture_2024_Api.Data.Models;
using CsvHelper.Configuration;
namespace CCImpactAgriculture_2024_Api.Models;
//this file is for mapping the Climate_Change_Impact_On_Agriculture_2024_Api_Item to the CSV file so that I can put the data in the
//MySQL database that I have set up.
public class CCImpactAgricultureItemMap : ClassMap<CCImpactAgricultureItem>
{
    public CCImpactAgricultureItemMap()
    {
        Map(m => m.Year).Name("Year");
        Map(m => m.Country).Name("Country");
        Map(m=> m.Region).Name("Region");
        Map(m => m.Crop_Type).Name("Crop_Type");
        Map(m => m.Average_Temperature_C).Name("Average_Temperature_C");
        Map(m => m.Total_Precipitation_mm).Name("Total_Precipitation_mm");
        Map(m => m.CO2_Emissions_MT).Name("CO2_Emissions_MT");
        Map(m => m.Crop_Yield_MT_per_HA).Name("Crop_Yield_MT_per_HA");
        Map(m => m.Extreme_Weather_Events).Name("Extreme_Weather_Events");
        Map(m => m.Irrigation_Access_Per).Name("Irrigation_Access_%");
        Map(m => m.Pesticide_Use_KG_per_HA).Name("Pesticide_Use_KG_per_HA");
        Map(m => m.Fertilizer_Use_KG_per_HA).Name("Fertilizer_Use_KG_per_HA");
        Map(m => m.Soil_Health_Index).Name("Soil_Health_Index");
        Map(m => m.Adaptation_Strategies).Name("Adaptation_Strategies");
        Map(m=> m.Economic_Impact_Million_USD).Name("Economic_Impact_Million_USD");
    }

}