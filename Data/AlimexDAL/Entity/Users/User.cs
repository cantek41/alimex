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
    public class User
    {
        public User()
        {
            Roles = new List<Role>();
            Organizations = new List<Organization>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }        
     
    }
}
