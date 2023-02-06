using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblProduktKatergori")]
    public class ProductCategoryModel
    {
        [Key]
        public int PKID { get; set; }
        public string Produktkatergori { get; set; }
        public string Beskrivning { get; set; }
        public string AntalGjut { get; set; }
        public int EID { get; set; }
        public string Typ { get; set; }
    
    }
}
