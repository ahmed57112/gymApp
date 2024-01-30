using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace gymApi.Models.Domain;

[Table("MEMBER_TYPES_LK")]
public partial class MEMBER_TYPES_LK
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TYPE { get; set; }

    [InverseProperty("MEMBER_TYPENavigation")]
    public virtual ICollection<MEMBER> MEMBERs { get; set; } = new List<MEMBER>();
}
