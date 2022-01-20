using SmartRestaurant.Culture;
using System;
using System.ComponentModel.DataAnnotations;

namespace SmartRestaurant.Model
{
    public class BaseModel
    {
        //[Display(Name = "DELETE_REASON", ResourceType = typeof(Resource))]
        //[Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "DELETE_REASON_REQUIRED")]
        public string DELETE_REASON { get; set; }
        public int STATUS_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE_TIME { get; set; }
        public string APPROVED_BY { get; set; }
        public DateTime APPROVED_DATE_TIME { get; set; }        
        public string CHANGE_BY { get; set; }
        public string CHANGE_DATE_TIME { get; set; }
    }

}
