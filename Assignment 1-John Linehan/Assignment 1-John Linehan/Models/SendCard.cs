using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment_1_John_Linehan.Models
{
    public class SendCard
    {
        [Required(ErrorMessage = "Please enter Sender's Name")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter Recipient's Name")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        public string Message { get; set; }
    }
}