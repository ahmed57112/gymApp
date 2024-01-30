using Microsoft.AspNetCore.Mvc;

namespace gymApi
{
    public class scaffold : Controller
    {
        public IActionResult Index()
        {
            return View();

            //Scaffold-DbContext "data source=DESKTOP-GFUAK89;initial catalog=GYM;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -UseDatabaseNames -outputdir Models/Domain -context GYMDbContext -contextdir Repository  -DataAnnotations 
        }
    }
}
