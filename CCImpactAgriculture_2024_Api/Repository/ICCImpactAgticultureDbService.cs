using CCImpactAgriculture_2024_Api.Data.Models;
using Microsoft.AspNetCore.Mvc;




namespace CCImpactAgriculture_2024_Api.Repository
{
    public interface ICCImpactAgricultureDbService
    {
        
        public  Task<IEnumerable<CCImpactAgricultureItem>> GetByYear_Id(int year);

        public  Task<IEnumerable<CCImpactAgricultureItem>> GetByYear_Range(int from, int to);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByCountry_Id(string country);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByRegion_Id(string region);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByCrop_Type_Id(string crop_type);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByAvgTemp_Id(decimal temp);
        
        public Task<IEnumerable<CCImpactAgricultureItem>> GetByAvgTempRange (decimal? min = null, decimal? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByTotalPrecipitation_Id(decimal total_precipitation_mm);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByTotalPrecipitation_Range(decimal? min = null, decimal? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByCO2_Emissions_Id(decimal co2_emissions_mt);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByCO2_Emissions_Range(decimal? min = null, decimal? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByCrop_Yeild_Id(decimal crop_yield_mt_per_ha);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByCrop_Yeild_Range(decimal? min = null, decimal? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByExtreme_Weather_Event_By_Id(int extreme_weather_events);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByExtreme_Weather_Event_Range(int? min = null, int? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByIrragation_Access_Percentage_Id(decimal irrigation_access_per);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByIrragation_Access_Percentage_Range(decimal? min = null, decimal? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByPesticide_Useage_Id(decimal pesticide_use_kg_per_ha);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByPesticide_Useage_Range(decimal? min = null, decimal? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetBySoil_Health_Index_Id(decimal soil_health_index);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetBySoil_Health_Range(decimal? min = null, decimal? max = null);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByAdaption_Strategies(string adaptation_strategies);
        public Task<IEnumerable<CCImpactAgricultureItem>> GetByEconomic_Impact_Id(decimal economic_impact_million_USD);

        public Task<IEnumerable<CCImpactAgricultureItem>> GetByEconomic_Impact_Range(decimal? min = null, decimal? max = null);
    }
}