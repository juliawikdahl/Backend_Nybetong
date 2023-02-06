using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblEnhet")]
    public class UnitModel
    {
        [Key]
        public int EID { get; set; }
        public string Enhet { get; set; }
        //public virtual ProductCategoryModel ProductCategory { get; set; } = null!;
        //public virtual ProjectContentModel ProjectContent { get; set; } = null!;
     
    }
}
