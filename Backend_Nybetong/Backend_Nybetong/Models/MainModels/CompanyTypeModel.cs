using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblF�retagsTyp")]
    public class CompanyTypeModel
    {
        public int FBID { get; set; }
        public string Typ { get; set; }
       
    }
}
