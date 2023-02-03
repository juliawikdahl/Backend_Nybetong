using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.BST_tblRoll")]
    public class RollModel
    {
        public int RollID { get; set; }
        public string RollNamn { get; set; }
        public bool Aktiv { get; set; }
    }
}
