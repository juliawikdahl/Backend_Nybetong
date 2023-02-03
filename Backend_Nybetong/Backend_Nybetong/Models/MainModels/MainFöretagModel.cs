using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblFöretag")]
    public class MainFöretagModel
    {
        public int FID { get; set; }
        public int FTID { get; set; }
        public DateTime Registreringsdatum { get; set; }
        public string Företagsnamn { get; set; }
        public string Adress { get; set; }
        public string PostAdress { get; set; }
        public string VxlTelefon { get; set; }
        public string Fax { get; set; }
        public string Infomejl { get; set; }
        public bool Aktiv { get; set; }

    }
}
