using System.ComponentModel.DataAnnotations;

namespace SOFIA.Model
{
    public class TEST
    {
        [Key]
        public string PN_NUMBER { get; set; }
        public string APPL_CRM_CODE { get; set; }
    }
}
