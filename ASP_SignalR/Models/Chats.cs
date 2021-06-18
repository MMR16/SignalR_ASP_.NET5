using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_SignalR.Model
{
    public class Chats
    { 
        [Key]
        public int Id { get; set; }
        [Display(Name ="Name")]
        public string Name { get; set; }
        [Display(Name = "Message")]
        public string Message { get; set; }
        [Display(Name = "Sent Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}