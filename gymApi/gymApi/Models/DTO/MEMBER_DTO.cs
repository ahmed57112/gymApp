using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace gymApi.Models.DTO
{
    public class MEMBER_DTO_BASE
    {

        public string? NAME { get; set; }

        public int? NATIONAL_ID { get; set; }

        public int? MEMBER_TYPE { get; set; }

    }  
    
    public class MEMBER_DTO_GET : MEMBER_DTO_BASE
    {
        public int ID { get; set; }

    }
}
