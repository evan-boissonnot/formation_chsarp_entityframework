using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWCFCore.Models
{
    public class TestItem
    {
        [Key]
        public int Id { get; set; }
    }
}
