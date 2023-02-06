using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("tblProjekt")]
    public class ProjectModel
    {
        [Key]
        public int PID { get; set; }
        public int FID { get; set; }
        public int ProjektNummer { get; set; }
        public string Projekt { get; set; }
        public string Startvecka { get; set; }
        public string Stoppvecka { get; set; }
        public string Levadress { get; set; }
        public string LevPostAdress { get; set; }
        public int KundKIID { get; set; }
        public int KonstruktörKIID { get; set; }
        public int MontörKIID { get; set; }
        public bool Avslutat { get; set; }
        public bool Eldosor { get; set; }
        public bool Räckefästen { get; set; }
        public bool Vent { get; set; }
        public bool Comax { get; set; }
        public bool Övrigt { get; set; }
        public string Info { get; set; }

      


    }
}
