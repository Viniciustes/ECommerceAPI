using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceAPI.Models
{
    public class ResultResponseModel
    {
        public bool Result { get; set; } = true;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
