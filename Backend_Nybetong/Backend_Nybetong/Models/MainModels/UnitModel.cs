﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblEnhet")]
    public class UnitModel
    {
        [Key]
        public int EID { get; set; }
        public string Enhet { get; set; }
    }
}
