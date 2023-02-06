using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblBetongTyp")]
    public class ConcreteTypeModel
    {
        [Key]
        public int BTID { get; set; }
        public string BetongTyp { get; set; }
        public bool Active { get; set; }
    }
}
