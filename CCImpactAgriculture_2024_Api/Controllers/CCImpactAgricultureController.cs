using System.ComponentModel.DataAnnotations;
using CCImpactAgriculture_2024_Api.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using CCImpactAgriculture_2024_Api.Repository;


namespace CCImpactAgriculture_2024_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CCImpactAgricultureController : ControllerBase
{
    private ICCImpactAgricultureDbService _repository;
    public CCImpactAgricultureController(ICCImpactAgricultureDbService repository)
    {
        _repository = repository;
    }

    //test
    [HttpGet("Years/{year:int}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByYear_Id(int year)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByYear_Id(year);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }
    //test
    [HttpGet("Years")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByYear_Range(int from, int to)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByYear_Range(from, to);
        
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }
    //test
    [HttpGet("Countries/{country}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByCountry_Id(string country)
    {
        
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByCountry_Id(country);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Regions/{region}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByRegion_Id(string region)
    {
        
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByRegion_Id(region);
        
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Crop_Types/{crop_type}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByCrop_Type_Id(string crop_type)
    {

        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByCrop_Type_Id(crop_type);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        } 

        return Ok(result_list);
    }

    //test
    [HttpGet("Average_Temperatures/{temp:decimal}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByAvgTemp_Id(decimal temp)
    {

        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByAvgTemp_Id(temp);
        
        if (!result_list.Any())
        {
            return NotFound();
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Average_Temperatures")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByAvgTempRange (decimal? min = null, decimal? max = null)
    {
        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }

        IEnumerable<CCImpactAgricultureItem> result_List = await _repository.GetByAvgTempRange (min, max);
        
        if (!result_List.Any())
        {
            return NotFound(ModelState);
        }
        
        return Ok(result_List);
    }

    //test
    [HttpGet("Total_Precipitation/{Total_Precipitation_mm}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByTotalPrecipitation_Id(decimal total_precipitation_mm)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByTotalPrecipitation_Id(total_precipitation_mm);
            
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test 
    [HttpGet("Total_Precipitation")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByTotalPrecipitation_Range(decimal? min = null, decimal? max = null)
    {
        
        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }
        
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByTotalPrecipitation_Range(min, max);
      
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);

    }

    [HttpGet("CO2_Emissions/{CO2_Emissions_MT}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByCO2_Emissions_Id(decimal co2_emissions_mt)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByCO2_Emissions_Id(co2_emissions_mt);
            
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("CO2_Emissions")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByCO2_Emissions_Range(decimal? min = null, decimal? max = null)
    {

        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }
        
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByCO2_Emissions_Range(min, max);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    [HttpGet("Crop_Yeild/{Crop_Yield_MT_per_HA}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByCrop_Yeild_Id(decimal crop_yield_mt_per_ha)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByCrop_Yeild_Id(crop_yield_mt_per_ha);
            
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Crop_Yeilds")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByCrop_Yeild_Range(decimal? min = null, decimal? max = null)
    {
        
        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }
        
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByCrop_Yeild_Range(min, max);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Extreme_Weather_Event/{Extreme_Weather_Events:int}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByExtreme_Weather_Event_By_Id(int extreme_weather_events)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByExtreme_Weather_Event_By_Id(extreme_weather_events);
        
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }
        
        return Ok(result_list);
    }

    //test
    [HttpGet("Extreme_Weather_Event")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByExtreme_Weather_Event_Range(int? min = null, int? max = null)
    {

        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }
        
         IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByExtreme_Weather_Event_Range(min, max);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Irragation_Access_Percentage/{ Irrigation_Access_Per:decimal}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByIrragation_Access_Percentage_Id(decimal irrigation_access_per)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByIrragation_Access_Percentage_Id(irrigation_access_per);
            
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Irragation_Access_Percentage")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByIrragation_Access_Percentage_Range(decimal? min = null, decimal? max = null)
    {

        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }
       
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByIrragation_Access_Percentage_Range(min, max);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Pesticide_Useage/{Pesticide_Use_KG_per_HA:decimal}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByPesticide_Useage_Id(decimal pesticide_use_kg_per_ha)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByPesticide_Useage_Id(pesticide_use_kg_per_ha);
            
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Pesticide_Useage")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByPesticide_Useage_Range(decimal? min = null, decimal? max = null)
    {

        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByPesticide_Useage_Range(min, max);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }
    
    //test
    [HttpGet("Soil_Health_Index/{Soil_Health_Index:decimal}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetBySoil_Health_Index_Id(decimal soil_health_index)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetBySoil_Health_Index_Id(soil_health_index);
            
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Soil_Health_Index")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetBySoil_Health_Range(decimal? min = null, decimal? max = null)
    {

        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }
       
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetBySoil_Health_Range(min, max);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Adaptation_Strategies/{adaptation_strategies}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByAdaption_Strategies(string adaptation_strategies)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByAdaption_Strategies(adaptation_strategies);
        
        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }
        return Ok(result_list);
    }

    //test
    [HttpGet("Economic_Impact/{Economic_Impact_Million_USD:decimal}")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByEconomic_Impact_Id(decimal economic_impact_million_USD)
    {
        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByEconomic_Impact_Id(economic_impact_million_USD);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }

    //test
    [HttpGet("Economic_Impact")]
    public async Task<ActionResult<IEnumerable<CCImpactAgricultureItem>>> GetByEconomic_Impact_Range(decimal? min = null, decimal? max = null)
    {

        if(min == null && max == null)
        {
            return BadRequest("Both min and max must not be null");
        }

        IEnumerable<CCImpactAgricultureItem> result_list = await _repository.GetByEconomic_Impact_Range(min, max);

        if(!result_list.Any())
        {
            return NotFound(ModelState);
        }

        return Ok(result_list);
    }
}