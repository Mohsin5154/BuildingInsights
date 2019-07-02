﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insights.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InsightsDBEntities : DbContext
    {
        public InsightsDBEntities()
            : base("name=InsightsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Mechanics> Mechanics { get; set; }
        public virtual DbSet<YearlyRecordBook> YearlyRecordBooks { get; set; }
    
        public virtual int CreateUpdateMechanicsCostByType(Nullable<short> year, string type, Nullable<long> cost, Nullable<int> buildingId, Nullable<bool> isActive, Nullable<System.DateTime> createdOn, Nullable<System.DateTime> updatedOn)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(short));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("Cost", cost) :
                new ObjectParameter("Cost", typeof(long));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var updatedOnParameter = updatedOn.HasValue ?
                new ObjectParameter("UpdatedOn", updatedOn) :
                new ObjectParameter("UpdatedOn", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_CreateUpdateMechanicsCostByType", yearParameter, typeParameter, costParameter, buildingIdParameter, isActiveParameter, createdOnParameter, updatedOnParameter);
        }
    
        public virtual int CreateUpdateMechanicsFailureByType(Nullable<short> year, string type, Nullable<long> failure, Nullable<int> buildingId, Nullable<bool> isActive, Nullable<System.DateTime> createdOn, Nullable<System.DateTime> updatedOn)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(short));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var failureParameter = failure.HasValue ?
                new ObjectParameter("Failure", failure) :
                new ObjectParameter("Failure", typeof(long));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var updatedOnParameter = updatedOn.HasValue ?
                new ObjectParameter("UpdatedOn", updatedOn) :
                new ObjectParameter("UpdatedOn", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_CreateUpdateMechanicsFailureByType", yearParameter, typeParameter, failureParameter, buildingIdParameter, isActiveParameter, createdOnParameter, updatedOnParameter);
        }
    
        public virtual ObjectResult<stp_GetAllMechanics_Result> GetAllMechanics()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_GetAllMechanics_Result>("stp_GetAllMechanics");
        }
    
        public virtual ObjectResult<stp_GetMechanicsCostByType_Result> GetMechanicsCostByType(string type)
        {
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_GetMechanicsCostByType_Result>("stp_GetMechanicsCostByType", typeParameter);
        }
    
        public virtual ObjectResult<stp_GetMechanicsFailureByType_Result> GetMechanicsFailureByType(string type)
        {
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_GetMechanicsFailureByType_Result>("stp_GetMechanicsFailureByType", typeParameter);
        }
    
        public virtual ObjectResult<stp_GetRecordsByYear_Result> GetRecordsByYear(Nullable<short> year, Nullable<int> buildingId)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(short));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_GetRecordsByYear_Result>("stp_GetRecordsByYear", yearParameter, buildingIdParameter);
        }
    
        public virtual ObjectResult<stp_GetTotalCost_Result> GetTotalCost(Nullable<short> year, Nullable<int> buildingId)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(short));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_GetTotalCost_Result>("stp_GetTotalCost", yearParameter, buildingIdParameter);
        }
    
        public virtual ObjectResult<stp_GetTotalSaving_Result> GetTotalSaving(Nullable<short> year, Nullable<int> buildingId)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(short));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_GetTotalSaving_Result>("stp_GetTotalSaving", yearParameter, buildingIdParameter);
        }
    
        public virtual int SaveTotalCost(Nullable<short> year, Nullable<long> totalCost, Nullable<int> buildingId, Nullable<bool> isActive, Nullable<System.DateTime> createdOn, Nullable<System.DateTime> updatedOn)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(short));
    
            var totalCostParameter = totalCost.HasValue ?
                new ObjectParameter("TotalCost", totalCost) :
                new ObjectParameter("TotalCost", typeof(long));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var updatedOnParameter = updatedOn.HasValue ?
                new ObjectParameter("UpdatedOn", updatedOn) :
                new ObjectParameter("UpdatedOn", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_SaveTotalCost", yearParameter, totalCostParameter, buildingIdParameter, isActiveParameter, createdOnParameter, updatedOnParameter);
        }
    
        public virtual int SaveTotalSaving(Nullable<short> year, Nullable<long> totalSaving, Nullable<int> buildingId, Nullable<bool> isActive, Nullable<System.DateTime> createdOn, Nullable<System.DateTime> updatedOn)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(short));
    
            var totalSavingParameter = totalSaving.HasValue ?
                new ObjectParameter("TotalSaving", totalSaving) :
                new ObjectParameter("TotalSaving", typeof(long));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var updatedOnParameter = updatedOn.HasValue ?
                new ObjectParameter("UpdatedOn", updatedOn) :
                new ObjectParameter("UpdatedOn", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_SaveTotalSaving", yearParameter, totalSavingParameter, buildingIdParameter, isActiveParameter, createdOnParameter, updatedOnParameter);
        }  
    }
}