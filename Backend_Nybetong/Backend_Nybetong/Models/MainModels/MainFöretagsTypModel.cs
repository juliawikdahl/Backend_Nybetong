using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblFöretagsTyp")]
    public class MainFöretagsTypModel
    {
        public int FBID { get; set; }
        public string Typ { get; set; }
       
    }
}
