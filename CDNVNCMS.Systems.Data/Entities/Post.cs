using System.ComponentModel.DataAnnotations.Schema;
using CDNVNONE.Entities;
using System;
using System.Collections.Generic;
namespace CDNVNCMS.Systems.Data
{
    public class Post:Entity<int>
    {
        public string CustomName { get; set; }
        public string CustomDescription { get; set; }
        public bool Publish { get; set; }
        public DateTime PublishDate { get; set; }
        public string Display { get; set; }
        public int ApplicationId { get; set; }
        public int ParentId { get; set; }
    
        public virtual ICollection<Post> Children { get; set; }
        [ForeignKey("ParentId")]
        public virtual Post Parent { get; set; }
        public virtual ICollection<TermRelationship> TermRelationships { get; set; }
    }
}
