using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimexDAL.Entity
{
    
    /// <summary>
    /// Base Entity class
    /// </summary>
    public abstract class Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string CreateUser{ get; set; }
        [Column(TypeName="datetime2")]
        public DateTime CreateDate { get; set; }
        [Column(TypeName="datetime2")]
        public DateTime CreateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
