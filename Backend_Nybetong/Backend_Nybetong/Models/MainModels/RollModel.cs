using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("BST_tblRoll")]
    public class RollModel
    {
        [Key]
        public int RollID { get; set; }
        public string RollNamn { get; set; }
        public bool Aktiv { get; set; }
       
    }
}
