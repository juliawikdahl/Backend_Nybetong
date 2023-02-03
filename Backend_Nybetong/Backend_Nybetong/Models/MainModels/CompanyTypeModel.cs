using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblFöretagsTyp")]
    public class CompanyTypeModel
    {
        [Key]
        public int FBID { get; set; }
        public string Typ { get; set; }
       
    }
}
