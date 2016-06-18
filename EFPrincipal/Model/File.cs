//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFPrincipal.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            this.CompanyFranchiseSpecialFiles = new HashSet<CompanyFranchiseSpecialFile>();
            this.ShareAnythingPostFiles = new HashSet<ShareAnythingPostFile>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string OriginalFileName { get; set; }
        public string UniqueFileName { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string ContentType { get; set; }
        public int Length { get; set; }
        public bool IsDeleted { get; set; }
        public string AuditCreatedBy { get; set; }
        public System.DateTime AuditCreatedDate { get; set; }
        public System.DateTime AuditLastUpdatedDate { get; set; }
        public string AuditLastUpdatedBy { get; set; }
        public byte[] RowVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchiseSpecialFile> CompanyFranchiseSpecialFiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareAnythingPostFile> ShareAnythingPostFiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}