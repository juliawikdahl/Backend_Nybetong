using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblKontaktKategori")]
    public class MainKontaktKategori
    {
        public int KKID { get; set; }
        public string Roll {get; set;}
        
    }
}
