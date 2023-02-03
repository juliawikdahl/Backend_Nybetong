using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Net.NetworkInformation;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblProduktKatergori")]
    public class ProductCategoryModel
    {
        public int PKID { get; set; }
        public int ProduktKategori { get; set; }
        public string Beskrivning { get; set; }
        public string AntalGjut { get; set; }
        public int EID { get; set; }
        public int Typ { get; set; }
    }
}
