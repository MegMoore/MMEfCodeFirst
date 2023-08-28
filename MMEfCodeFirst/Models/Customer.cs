using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMEfCodeFirst.Models // Creating new tables in SQl
//creating a table to add to sql server. First model.
{
    [Index("Code", IsUnique = true)] //[]means its an attribute
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]  //not required. setting amount for SQL
        public string Code { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal (11,2)")] //Must use this for decimals.PAY ATTENTION TO THE CLOSING PARENTHESIS!!! MUST BE BETWEEN THE CLOSING BRACKETS
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;


    }
}
