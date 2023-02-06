using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblKontaktKategori")]
    public class ContactCategoryModel
    {
        [Key]
        public int KKID { get; set; }
        public string Roll {get; set;}

    }
}
