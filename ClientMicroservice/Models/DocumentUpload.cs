using System;
using System.Collections.Generic;

#nullable disable

namespace NotificationService.Data.Models
{
    public partial class DocumentUpload
    {
        public DocumentUpload()
        {
            BlogPostImages = new HashSet<BlogPostImage>();
            BundleCategories = new HashSet<BundleCategory>();
            Bundles = new HashSet<Bundle>();
            Clients = new HashSet<Client>();
            Prescriptions = new HashSet<Prescription>();
            Products = new HashSet<Product>();
            Testimonials = new HashSet<Testimonial>();
        }

        public int Id { get; set; }
        public string LocalPath { get; set; }
        public string CloudPath { get; set; }
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CreatorUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public int DocumentTypeId { get; set; }
        public string Title { get; set; }

        public virtual User CreatorUser { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<BlogPostImage> BlogPostImages { get; set; }
        public virtual ICollection<BundleCategory> BundleCategories { get; set; }
        public virtual ICollection<Bundle> Bundles { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
    }
}
