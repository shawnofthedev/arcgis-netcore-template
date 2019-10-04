 using Microsoft.EntityFrameworkCore;

namespace arcgis_netcore.data
{
    public class SiteContext:DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options)
            : base(options) { }
    }
}
