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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.CompanyFollowedByUsers = new HashSet<CompanyFollowedByUser>();
            this.CompanyFranchises = new HashSet<CompanyFranchise>();
            this.CompanyFranchiseFollowedByUsers = new HashSet<CompanyFranchiseFollowedByUser>();
            this.CompanyFranchiseRatingsAndComments = new HashSet<CompanyFranchiseRatingsAndComment>();
            this.CompanyFranchiseSpecials = new HashSet<CompanyFranchiseSpecial>();
            this.CompanyFranchiseSpecialRatingsAndComments = new HashSet<CompanyFranchiseSpecialRatingsAndComment>();
            this.CompanyFranchiseSpecialVieweds = new HashSet<CompanyFranchiseSpecialViewed>();
            this.CompanyFranchiseVieweds = new HashSet<CompanyFranchiseViewed>();
            this.FriendInvitations = new HashSet<FriendInvitation>();
            this.ShareAnythingPosts = new HashSet<ShareAnythingPost>();
            this.ShareAnythingPostComments = new HashSet<ShareAnythingPostComment>();
            this.ShareAnythingPostLikes = new HashSet<ShareAnythingPostLike>();
            this.ShareAnythingReports = new HashSet<ShareAnythingReport>();
            this.ShareAnythingReports1 = new HashSet<ShareAnythingReport>();
            this.UserFriendLists = new HashSet<UserFriendList>();
            this.UserFriendLists1 = new HashSet<UserFriendList>();
            this.UsersInRoles = new HashSet<UsersInRole>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserGuid { get; set; }
        public string ContactNumber { get; set; }
        public bool CanContactUsers { get; set; }
        public int AddressId { get; set; }
        public Nullable<int> FileId { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime AuditCreatedDate { get; set; }
        public string AuditCreatedBy { get; set; }
        public System.DateTime AuditLastUpdatedDate { get; set; }
        public string AuditLastUpdatedBy { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFollowedByUser> CompanyFollowedByUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchise> CompanyFranchises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchiseFollowedByUser> CompanyFranchiseFollowedByUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchiseRatingsAndComment> CompanyFranchiseRatingsAndComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchiseSpecial> CompanyFranchiseSpecials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchiseSpecialRatingsAndComment> CompanyFranchiseSpecialRatingsAndComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchiseSpecialViewed> CompanyFranchiseSpecialVieweds { get; set; }
        public virtual CompanyFranchiseUser CompanyFranchiseUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyFranchiseViewed> CompanyFranchiseVieweds { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual File File { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FriendInvitation> FriendInvitations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareAnythingPost> ShareAnythingPosts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareAnythingPostComment> ShareAnythingPostComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareAnythingPostLike> ShareAnythingPostLikes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareAnythingReport> ShareAnythingReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareAnythingReport> ShareAnythingReports1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFriendList> UserFriendLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFriendList> UserFriendLists1 { get; set; }
        public virtual webpages_Membership webpages_Membership { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersInRole> UsersInRoles { get; set; }
    }
}
