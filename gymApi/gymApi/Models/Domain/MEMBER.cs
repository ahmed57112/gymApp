using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace gymApi.Models.Domain;

[Table("MEMBER")]
public partial class MEMBER
{
    [Key]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAME { get; set; }

    public int? NATIONAL_ID { get; set; }

    public int? MEMBER_TYPE { get; set; }

    [ForeignKey("MEMBER_TYPE")]
    [InverseProperty("MEMBERs")]
    public virtual MEMBER_TYPES_LK? MEMBER_TYPENavigation { get; set; }
}
