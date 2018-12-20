﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDevx
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class STOK_TAKIPEntities : DbContext
    {
        public STOK_TAKIPEntities()
            : base("name=STOK_TAKIPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<loanDetail> loanDetails { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<purchase> purchases { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<userType> userTypes { get; set; }
    
        public virtual int createNewProduct(string productName, string productFeatures, string purchasedDate, Nullable<int> purchasedByID, Nullable<int> purchasedPrice, Nullable<int> pieces)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var productFeaturesParameter = productFeatures != null ?
                new ObjectParameter("productFeatures", productFeatures) :
                new ObjectParameter("productFeatures", typeof(string));
    
            var purchasedDateParameter = purchasedDate != null ?
                new ObjectParameter("purchasedDate", purchasedDate) :
                new ObjectParameter("purchasedDate", typeof(string));
    
            var purchasedByIDParameter = purchasedByID.HasValue ?
                new ObjectParameter("purchasedByID", purchasedByID) :
                new ObjectParameter("purchasedByID", typeof(int));
    
            var purchasedPriceParameter = purchasedPrice.HasValue ?
                new ObjectParameter("purchasedPrice", purchasedPrice) :
                new ObjectParameter("purchasedPrice", typeof(int));
    
            var piecesParameter = pieces.HasValue ?
                new ObjectParameter("pieces", pieces) :
                new ObjectParameter("pieces", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("createNewProduct", productNameParameter, productFeaturesParameter, purchasedDateParameter, purchasedByIDParameter, purchasedPriceParameter, piecesParameter);
        }
    
        public virtual int addLoan(Nullable<int> userID, Nullable<int> loanByID, Nullable<int> productID, Nullable<System.DateTime> loanDate, Nullable<int> loanPieces)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var loanByIDParameter = loanByID.HasValue ?
                new ObjectParameter("loanByID", loanByID) :
                new ObjectParameter("loanByID", typeof(int));
    
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            var loanDateParameter = loanDate.HasValue ?
                new ObjectParameter("loanDate", loanDate) :
                new ObjectParameter("loanDate", typeof(System.DateTime));
    
            var loanPiecesParameter = loanPieces.HasValue ?
                new ObjectParameter("loanPieces", loanPieces) :
                new ObjectParameter("loanPieces", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addLoan", userIDParameter, loanByIDParameter, productIDParameter, loanDateParameter, loanPiecesParameter);
        }
    
        public virtual int removeProduct(Nullable<int> productID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("removeProduct", productIDParameter);
        }
    
        public virtual ObjectResult<loginCheck_Result> loginCheck(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<loginCheck_Result>("loginCheck", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<list_Result> list(Nullable<int> productID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("productID", productID) :
                new ObjectParameter("productID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<list_Result>("list", productIDParameter);
        }
    }
}
