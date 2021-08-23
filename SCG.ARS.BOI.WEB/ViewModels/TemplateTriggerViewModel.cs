using Quartzmin.Helpers;
using Quartzmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCG.ARS.BOI.WEB.ViewModels
{
    public class TemplateTriggerViewModel: IHasValidation
    {
        public TemplateTriggerPropertiesViewModel Trigger { get; set; }
        public JobDataMapModel DataMap { get; set; }
        public void Validate(ICollection<ValidationError> errors) => ModelValidator.ValidateObject(this, errors);

    }
}
