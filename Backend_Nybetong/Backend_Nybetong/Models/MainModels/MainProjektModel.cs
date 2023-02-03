using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblProjekt")]
    public class MainProjektModel
    {
        public int PID { get; set; }
        public int FID { get; set; }
        public int ProjektNummer { get; set; }
        public string Projekt { get; set; }
        public string StartVecka { get; set; }
        public string StoppVecka { get; set; }
        public string Levadress { get; set; }
        public string LevPostAdress { get; set; }
        public int KundKIID { get; set; }
        public int KundKonstruktörKIID { get; set; }
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
