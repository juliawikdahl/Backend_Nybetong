using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_Nybetong.Models.MainModels
{
    [Table("dbo.tblPlaneraLeverans")]
    public class PlanDeliveryModel
    {
        public int PlaneraLeveransID { get; set; }
        public DateTime Registreringsdatum { get; set; }
        public DateTime Leveransdatum { get; set; }
        public DateTime Leveranstid { get; set; }
        public string Projekt { get; set; }
        public int Leveransadress { get; set; }
        public int Kontaktuppgifter { get; set; }
        public DateTime Lastningsdatum { get; set; }
        public string Lastningstid { get; set; }
        public string GrovPlanering { get; set; }
        public int Referens { get; set; }
    }
}
