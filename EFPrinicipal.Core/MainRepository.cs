﻿using EFPrincipal.Contracts;
using EFPrinicipal.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFPrinicipal.Core
{
    public class MainRepository<T> : IMainRepository<T> where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <exception cref="System.ArgumentNullException">dbContext</exception>
        public MainRepository(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }

        /// <summary>
        /// Gets or sets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        protected DbContext DbContext { get; set; }

        /// <summary>
        /// Gets or sets the database set.
        /// </summary>
        /// <value>
        /// The database set.
        /// </value>
        protected DbSet<T> DbSet { get; set; }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetAll()
        {

            return DbSet;
        }

        /// <summary>
        /// Gets all including.
        /// </summary>
        /// <param name="includedProperties">The included properties.</param>
        /// <returns></returns>
        public virtual IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includedProperties)
        {
            IQueryable<T> query = DbSet;
            foreach (var includedProperty in includedProperties)
            {
                query = query.Include(includedProperty);
            }
            return query;
        }

        /// <summary>
        /// Gets T class by the identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Add(T entity)
        {

            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);

            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;

        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return; // not found; assume already deleted.
            Delete(entity);
        }
    }
}
