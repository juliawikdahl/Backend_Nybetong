using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("BST_tblBehörighet")]
    public class AuthorizationModel
    {
        [Key]
        public int BehörighetID { get; set; }
        //public int ObjektID { get; set; }
        public int RollID { get; set; }
        public bool ÄndraData { get; set; }
        public bool VisaObjekt { get; set; }
    }
}
