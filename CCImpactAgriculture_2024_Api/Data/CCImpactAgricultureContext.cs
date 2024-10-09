using Microsoft.EntityFrameworkCore;
using  CCImpactAgriculture_2024_Api.Data.Models;
namespace CCImpactAgriculture_2024_Api.Data
{
    public class CCImpactAgricultureContext : DbContext
    {
        public CCImpactAgricultureContext(DbContextOptions<CCImpactAgricultureContext> options)
        :base(options)
        {

        }
        public DbSet<CCImpactAgricultureItem> CCItem {get; set;}
    }
}