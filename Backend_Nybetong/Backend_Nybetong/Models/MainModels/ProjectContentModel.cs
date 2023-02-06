using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblProjektInnehåll")]
    public class ProjectContentModel
    {
        [Key]
        public int PIID { get; set; }
        public int PID { get; set; }
        public int PKID { get; set; }
        public int EID  { get; set; }
        public int Mått { get; set; }
        public int Försäljningspris { get; set; }
        public int Fabrikspris { get; set; }
        public int TotalMängd { get; set; }
        public string KategoriTyp { get; set; }
        public decimal TidsÅtgång { get; set; }

    }
}
