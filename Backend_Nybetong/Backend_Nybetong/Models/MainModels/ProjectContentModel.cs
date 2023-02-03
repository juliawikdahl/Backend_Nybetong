using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblProjektInnehåll")]
    public class ProjectContentModel
    {
        public int PIID { get; set; }
        public int PID { get; set; }
        public int PKID { get; set; }
        public int EID  { get; set; }
        public int Mått { get; set; }
        public int Försäljningspris { get; set; }
        public int Fabrikspris { get; set; }
        public int TotalMängd { get; set; }
        public int KategoriTyp { get; set; }
        public int TidsÅtgång { get; set; }
    }
}
