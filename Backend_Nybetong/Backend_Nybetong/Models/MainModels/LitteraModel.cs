using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblLittera")]
    public class LitteraModel
    {
        [Key]
        public int LID { get; set; }
        public int PID { get; set; }
        public int FBID { get; set; }
        public int HID { get; set; }
        public int PKID { get; set; }
        public int  GPID { get; set; }
        public int PLID { get; set; }
        public int SID { get; set; }
        public int GSID { get; set; }
        public int BTID1 { get; set; }
        public int BTID2 { get; set; }
        public int BTID3 { get; set; }
        public DateTime Regdatum { get; set; }
        public string Etapp { get; set; }
        public string LitteralID { get; set; }
        public int Längd { get; set; }
        public int Bredd { get; set; }
        public int Höjd { get; set; }
        public decimal Vikt { get; set; }
        public decimal Gjut1 { get; set; }
  
        public decimal Gjut2 { get; set; }
        public decimal Gjut3 { get; set; }
        public int Antaleldosor { get; set; }
        public int Isolering { get; set; }
        public bool Inväntangjuntningsgods { get; set; }
        public string Anm { get; set; }
        public bool BeställBetong { get; set; }
        public bool Kvalitetssäkrad { get; set; }
        public int LagerPlatsID { get; set; }
        public int PIID { get; set; }
        public int AntalGjut { get; set; }
        public bool Kundkostnad { get; set; }
        public int Antalräckefästen { get; set; }
        public int AntalVent { get; set; }
        public int AntalComax { get; set; }
        public int AntalÖvrigt { get; set; }
        public int Building { get; set; }
        public int FLoor { get; set; }
        public int Phase { get; set; }
        public bool VändVägg { get; set; }
        public string Revision { get; set; }
        public DateTime RevisionsDatum { get; set; }
        public string SökvägRitning { get; set; }
        public string ExposureClass_Innerlayer { get; set; }
        public string ExposureClass_OuterLayer { get; set; }
    }
}
