using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models
{
    [Table("dbo.tblKontaktInformation")]
    public class ContactInformationModel
    {
        public int KIID { get; set; }
        public int FID { get; set; }
        public int KKID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Gatuadress { get; set; }
        public string Postadress { get; set; }
        public string Telefon { get; set; }
        public string Mejl { get; set; }
        public bool Aktiv { get; set; }

    }
}
