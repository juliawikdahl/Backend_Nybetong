using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.BST_tblBehörighet")]
    public class AuthorizationModel
    {
        public int BehörighetID { get; set; }
        public int ObjektID { get; set; }
        public int RollID { get; set; }
        public bool ÄndraData { get; set; }
        public bool VisaObjekt { get; set; }
    }
}
