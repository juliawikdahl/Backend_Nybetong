using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblBetongTyp")]
    public class ConcreteTypeModel
    {
        public int BTID { get; set; }
        public string BetongTyp { get; set; }
        public bool Active { get; set; }
    }
}
