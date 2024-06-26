﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models;

[Table("Prescription_Medicament")]
public class Prescription_Medicament
{
    [Key]
    [Column(Order = 1)]
    public int IdMedicament { get; set; }
    
    [Key]
    [Column(Order = 2)]
    public int IdPrescription { get; set; }
    
    public int Dose { get; set; }
    
    [Required]
    [MaxLength(100)]
    public String Details { get; set; }
    
    public Prescription Prescription { get; set; }
    public Medicament Medicament { get; set; }
}