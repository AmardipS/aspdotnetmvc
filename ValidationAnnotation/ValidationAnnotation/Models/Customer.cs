using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValidationAnnotation.Models
{
    public class Customer
    {
        // Validation Annotations []
        [DisplayName("Customer ID")]
        public int ID { get; set; }

        [DisplayName("Customer Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}