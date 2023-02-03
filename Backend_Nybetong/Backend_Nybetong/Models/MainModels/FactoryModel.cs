using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblFabrik")]
    public class FactoryModel
    {
        [Key]
        public int FBID { get; set; }
        public string Fabrik { get; set; }
        public string LagerPlats { get; set; }
        public bool Aktiv { get; set; }
        public string NybetongFabrik { get; set; }
    }
}
