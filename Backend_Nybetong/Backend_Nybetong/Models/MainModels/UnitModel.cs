using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblEnhet")]
    public class UnitModel
    {
        public int EID { get; set; }
        public string Enhet { get; set; }
    }
}
