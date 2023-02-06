using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblFöretagsTyp")]
    public class CompanyTypeModel
    {
        [Key]
        public int FTID { get; set; }
        public string Typ { get; set; }
    

    }
}
