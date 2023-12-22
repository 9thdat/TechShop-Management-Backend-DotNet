﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PhoneShopManagementBackend.Models;

[Table("parameter_adapter")]
[Index("ProductId", Name = "FK_parameter_adapter_PRODUCT_ID")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class ParameterAdapter
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PRODUCT_ID")]
    public int ProductId { get; set; }

    [Column("MODEL")]
    [StringLength(255)]
    public string Model { get; set; }

    [Column("FUNCTION")]
    [StringLength(255)]
    public string Function { get; set; }

    [Column("INPUT")]
    [StringLength(255)]
    public string Input { get; set; }

    [Column("OUTPUT")]
    [StringLength(255)]
    public string Output { get; set; }

    [Column("MAXIMUM")]
    [StringLength(255)]
    public string Maximum { get; set; }

    [Column("SIZE")]
    [StringLength(255)]
    public string Size { get; set; }

    [Column("TECH")]
    [StringLength(255)]
    public string Tech { get; set; }

    [Column("MADEIN")]
    [StringLength(255)]
    public string Madein { get; set; }

    [Column("BRANDOF")]
    [StringLength(255)]
    public string Brandof { get; set; }

    [Column("BRAND")]
    [StringLength(255)]
    public string Brand { get; set; }
}