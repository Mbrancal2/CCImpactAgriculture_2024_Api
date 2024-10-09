using CCImpactAgriculture_2024_Api.Data;
using CCImpactAgriculture_2024_Api.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CCImpactAgriculture_2024_Api.Repository
{

    public class CCImpactAgricultureDbService : ICCImpactAgricultureDbService
    {
        private readonly CCImpactAgricultureContext _context;

        public CCImpactAgricultureDbService(CCImpactAgricultureContext context)
        {
            _context = context;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByYear_Id(int year)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where( c=> c.Year == year)
                .ToListAsync();
        
            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByYear_Range(int from, int to)
            {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where( c=> c.Year >= from && c.Year <= to)
                .ToListAsync();

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByCountry_Id(string country)
        {
        
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
            .Where(c => c.Country == country)
            .ToListAsync();

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByRegion_Id(string region)
        {
        
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Region == region)
                .ToListAsync();
        
            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByCrop_Type_Id(string crop_type)
        {

            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Crop_Type == crop_type)
                .ToListAsync();

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByAvgTemp_Id(decimal temp)
        {

            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Average_Temperature_C == temp)
                .ToListAsync();

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByAvgTempRange (decimal? min = null, decimal? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list;
            if(min == null)
            {
                result_list = await _context.CCItem
                    .Where(c=> c.Average_Temperature_C <= max)
                    .ToListAsync();
            }
            else if( max == null)
            {
                result_list = await _context.CCItem
                    .Where(c=> c.Average_Temperature_C >= min)
                    .ToListAsync();
            }
            else{
                result_list = await _context.CCItem
                    .Where(c => c.Average_Temperature_C >= min && c.Average_Temperature_C <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByTotalPrecipitation_Id(decimal total_precipitation_mm)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Total_Precipitation_mm == total_precipitation_mm)
                .ToListAsync();

            return result_list;
        }

        //test 
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByTotalPrecipitation_Range(decimal? min = null, decimal? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem> ();

            if(min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Total_Precipitation_mm >= min)
                    .ToListAsync();
            }
            else if(min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Total_Precipitation_mm <= max)
                    .ToListAsync();
            }
            else
            {
                result_list = await _context.CCItem
                    .Where(c => c.Total_Precipitation_mm >= min && c.Total_Precipitation_mm <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByCO2_Emissions_Id(decimal co2_emissions_mt)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.CO2_Emissions_MT == co2_emissions_mt)
                .ToListAsync();
            
            return result_list;

        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByCO2_Emissions_Range(decimal? min = null, decimal? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem>();

            if (min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.CO2_Emissions_MT <= max)
                    .ToListAsync();
            }
            else if (min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.CO2_Emissions_MT >= min)
                    .ToListAsync();
            }
            else
            {
                result_list = await _context.CCItem
                    .Where(c => c.CO2_Emissions_MT >= min && c.CO2_Emissions_MT <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByCrop_Yeild_Id(decimal crop_yield_mt_per_ha)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Crop_Yield_MT_per_HA == crop_yield_mt_per_ha)
                .ToListAsync();
            
            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByCrop_Yeild_Range(decimal? min = null, decimal? max = null)
        {
        
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem>();
            
            if(min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Crop_Yield_MT_per_HA <= max)
                    .ToListAsync();
            }
            else if(min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Crop_Yield_MT_per_HA >= min)
                    .ToListAsync();
            }
            else
            {
                result_list = await _context.CCItem
                    .Where(c => c.Crop_Yield_MT_per_HA >= min && c.Crop_Yield_MT_per_HA <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByExtreme_Weather_Event_By_Id(int extreme_weather_events)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Extreme_Weather_Events == extreme_weather_events)
                .ToListAsync();
            
            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByExtreme_Weather_Event_Range(int? min = null, int? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem>();

            
            if( min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Extreme_Weather_Events <= max)
                    .ToListAsync();
            }
            else if (min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Extreme_Weather_Events >= min)
                    .ToListAsync();
            }
            else{
                result_list = await _context.CCItem
                    .Where(c => c.Extreme_Weather_Events >= min && c.Extreme_Weather_Events <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByIrragation_Access_Percentage_Id(decimal irrigation_access_per)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Irrigation_Access_Per == irrigation_access_per)
                .ToListAsync();
            
            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByIrragation_Access_Percentage_Range(decimal? min = null, decimal? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem>();

            
            if( min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Irrigation_Access_Per <= max)
                    .ToListAsync();
            }
            else if (min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Irrigation_Access_Per >= min)
                    .ToListAsync();
            }
            else{
                result_list = await _context.CCItem
                    .Where(c => c.Irrigation_Access_Per >= min && c.Irrigation_Access_Per <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByPesticide_Useage_Id(decimal pesticide_use_kg_per_ha)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Pesticide_Use_KG_per_HA == pesticide_use_kg_per_ha)
                .ToListAsync();
                

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByPesticide_Useage_Range(decimal? min = null, decimal? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem>();

            
            if( min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Pesticide_Use_KG_per_HA <= max)
                    .ToListAsync();
            }
            else if (min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Pesticide_Use_KG_per_HA >= min)
                    .ToListAsync();
            }
            else{
                result_list = await _context.CCItem
                    .Where(c => c.Pesticide_Use_KG_per_HA >= min && c.Pesticide_Use_KG_per_HA <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetBySoil_Health_Index_Id(decimal soil_health_index)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Soil_Health_Index == soil_health_index)
                .ToListAsync();

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetBySoil_Health_Range(decimal? min = null, decimal? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem>();

            if( min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Soil_Health_Index <= max)
                    .ToListAsync();
            }
            else if (min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Soil_Health_Index >= min)
                    .ToListAsync();
            }
            else{
                result_list = await _context.CCItem
                    .Where(c => c.Soil_Health_Index >= min && c.Soil_Health_Index <= max)
                    .ToListAsync();
            }

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByAdaption_Strategies(string adaptation_strategies)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Adaptation_Strategies == adaptation_strategies)
                .ToListAsync();
            
            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByEconomic_Impact_Id(decimal economic_impact_million_USD)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = await _context.CCItem
                .Where(c => c.Economic_Impact_Million_USD == economic_impact_million_USD)
                .ToListAsync();

            return result_list;
        }

        //test
        public async Task<IEnumerable<CCImpactAgricultureItem>> GetByEconomic_Impact_Range(decimal? min = null, decimal? max = null)
        {
            IEnumerable<CCImpactAgricultureItem> result_list = new List<CCImpactAgricultureItem>();

            if( min == null && max != null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Economic_Impact_Million_USD <= max)
                    .ToListAsync();
            }
            else if (min != null && max == null)
            {
                result_list = await _context.CCItem
                    .Where(c => c.Economic_Impact_Million_USD >= min)
                    .ToListAsync();
            }
            else{
                result_list = await _context.CCItem
                    .Where(c => c.Economic_Impact_Million_USD >= min && c.Economic_Impact_Million_USD <= max)
                    .ToListAsync();
            }

            return result_list;
        }
    }
}