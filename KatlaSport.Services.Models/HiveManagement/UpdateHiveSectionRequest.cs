using FluentValidation.Attributes;

namespace KatlaSport.Services.HiveManagement
{
    [Validator(typeof(UpdateHiveSectionRequestValidator))]
    public class UpdateHiveSectionRequest
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public int StoreHiveId { get; set; }
    }
}