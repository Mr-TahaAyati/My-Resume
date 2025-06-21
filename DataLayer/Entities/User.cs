using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class User : BaseEntity
    {

        [Required]
        public string UserName { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }

        #region Relations
        public ICollection<PostComment> PostComments { get; set; }
        public ICollection<Post> Posts { get; set; }
        #endregion
    }
    enum UserRole
    {
        Admin,
        User,
        Writer
    }
}
