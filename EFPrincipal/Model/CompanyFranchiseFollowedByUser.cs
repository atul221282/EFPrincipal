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
    
    public partial class CompanyFranchiseFollowedByUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyFranchiseId { get; set; }
        public System.DateTime CompanyFranchiseFollwedDate { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedBy { get; set; }
        public System.DateTime AuditLastUpdatedDate { get; set; }
        public string AuditLastUpdatedBy { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual CompanyFranchise CompanyFranchise { get; set; }
        public virtual User User { get; set; }
    }
}
