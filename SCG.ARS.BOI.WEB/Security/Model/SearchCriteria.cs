using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class SearchCriteria
    {
        [Required]
        [MaxLength(50)]
        public string ScreenID { get; set; }
        [Required]
        public int Index { get; set; }
        [Required]
        [MaxLength(320)]
        public string Username { get; set; }
        [Required]
        [MaxLength(100)]
        public string CriteriaName { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Criteria { get; set; }
        public bool DefaultCriteria { get; set; }
        [Required]
        [MaxLength(320)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(320)]
        public string UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
    }
    
    public class SearchCriteriaModel
    {
        public string ScreenID { get; set; }
        public int Index { get; set; }
        public string CriteriaName { get; set; }
        public string Criteria { get; set; }
        public bool DefaultCriteria { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Username { get; set; }
    }

    public class SaveCriteria
    {
        public List<SearchCriteriaModel> AllCriteria {get;set;}
    }
}
