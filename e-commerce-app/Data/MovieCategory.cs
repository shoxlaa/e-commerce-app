using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Data
{
    public enum MovieCategory
    {
        Action=1  , 
        Comedy , 
        Drama , 
        Documentary 
    }

    public class AppDbContext :DbContext
    {

    }
}
