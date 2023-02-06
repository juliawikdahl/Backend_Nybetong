using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("BST_tblAnvändare")]
    public class UserModel
    {
        [Key]
        public int AnvändarID { get; set; }
        public string LoginNamn { get; set; }
        public string AnvändarNamn { get; set; }
        public int AnvändarRollID { get; set; }
        public bool Aktiv { get; set; }
    }
}
