using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.Security.Model
{
    public class CriteriaConfig
    {
        public int Id { get; set; }
        public string MenuCode { get; set; }
        public string CriteriaName { get; set; }
        public string DataRoute { get; set; }
        public string DataCriteria { get; set; }
    }
    public class UserCriteriaPermission
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string MenuCode { get; set; }
        public string CriteriaName { get; set; }
        public string CriteriaDisplay { get; set; }
        public string CriteriaValue { get; set; }
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
    public class UserCriteriaPermissionWithDisplay : UserCriteriaPermission
    {
        public string MenuDisplay { get; set; }

        public UserCriteriaPermissionWithDisplay()
        {

        }

        public UserCriteriaPermissionWithDisplay(UserCriteriaPermission up)
        {
            this.CreatedBy = up.CreatedBy;
            this.CreatedDate = up.CreatedDate;
            this.CriteriaDisplay = up.CriteriaDisplay;
            this.CriteriaName = up.CriteriaName;
            this.CriteriaValue = up.CriteriaValue;
            this.Id = up.Id;
            this.MenuCode = up.MenuCode;
            this.UpdatedBy = up.UpdatedBy;
            this.UpdatedDate = up.UpdatedDate;
            this.Username = up.Username;
        }
    }
    public class CriteriaPermissionModel
    {
        public string Key { get; set; } //user or role
        public List<CriteriaPermissionDetailModel> permissions { get; set; }
    }

    public class CriteriaPermissionDetailModel
    {
        public int? Id { get; set; }
        public string MenuCode { get; set; }
        public string CriteriaName { get; set; }
        public string CriteriaDisplay { get; set; }
        public string CriteriaValue { get; set; }
    }
    public class RoleCriteriaPermission
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string MenuCode { get; set; }
        public string CriteriaName { get; set; }
        public string CriteriaDisplay { get; set; }
        public string CriteriaValue { get; set; }
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
    public class RoleCriteriaPermissionWithDisplay : RoleCriteriaPermission
    {
        public string MenuDisplay { get; set; }

        public RoleCriteriaPermissionWithDisplay()
        {

        }

        public RoleCriteriaPermissionWithDisplay(RoleCriteriaPermission up)
        {
            this.CreatedBy = up.CreatedBy;
            this.CreatedDate = up.CreatedDate;
            this.CriteriaDisplay = up.CriteriaDisplay;
            this.CriteriaName = up.CriteriaName;
            this.CriteriaValue = up.CriteriaValue;
            this.Id = up.Id;
            this.MenuCode = up.MenuCode;
            this.UpdatedBy = up.UpdatedBy;
            this.UpdatedDate = up.UpdatedDate;
            this.RoleName = up.RoleName;
        }
    }
}
