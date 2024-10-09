using System.ComponentModel.DataAnnotations;

namespace CCImpactAgriculture_2024_Api.Data.Models;

public class CCImpactAgricultureItem
{
    public int Id { get; set; }
    public int Year {get; set; }
    public string Country {get; set; }
    public string Region {get; set; }
    public string Crop_Type {get; set; }
    public decimal Average_Temperature_C {get; set; }
    public decimal Total_Precipitation_mm {get; set; }
    public decimal CO2_Emissions_MT {get; set; }
    public decimal Crop_Yield_MT_per_HA {get; set; }
    public int Extreme_Weather_Events {get; set; }
    //Irrigation_Access_%
    public decimal Irrigation_Access_Per {get; set; }
    public decimal Pesticide_Use_KG_per_HA { get; set; }
    public decimal Fertilizer_Use_KG_per_HA { get; set; }
    public decimal Soil_Health_Index {get; set; }
    public string Adaptation_Strategies {get; set; }
    public decimal Economic_Impact_Million_USD {get; set; }

    // public CCImpactAgricultureItem()
    // {

    // }
}