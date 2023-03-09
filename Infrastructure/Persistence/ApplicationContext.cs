using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using Domain.Common;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>, IApplicationContext
    {
        private readonly IPrincipalService _principalService;
        private readonly IDateTimeService _dateTimeService;
        private readonly IConfiguration _configuration;

        public ApplicationContext(DbContextOptions options, IPrincipalService principalService, IDateTimeService dateTimeService, IConfiguration configuration) : base(options)
        {
            _principalService = principalService;
            _dateTimeService = dateTimeService;
            _configuration = configuration;
        }

        public DbSet<AppMenu> AppMenu { get; set; }
        public DbSet<LanguageCulture> LanguageCulture { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }

        public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
        {
            return base.Add(entity);
        }

        public override EntityEntry Add(object entity)
        {
            return base.Add(entity);
        }

        public override ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default)
        {
            return base.AddAsync(entity, cancellationToken);
        }

        public override ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default)
        {
            return base.AddAsync(entity, cancellationToken);
        }

        public override void AddRange(params object[] entities)
        {
            base.AddRange(entities);
        }

        public override void AddRange(IEnumerable<object> entities)
        {
            base.AddRange(entities);
        }

        public override Task AddRangeAsync(params object[] entities)
        {
            return base.AddRangeAsync(entities);
        }

        public override Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default)
        {
            return base.AddRangeAsync(entities, cancellationToken);
        }

        public override EntityEntry<TEntity> Attach<TEntity>(TEntity entity)
        {
            return base.Attach(entity);
        }

        public override EntityEntry Attach(object entity)
        {
            return base.Attach(entity);
        }

        public override void AttachRange(params object[] entities)
        {
            base.AttachRange(entities);
        }

        public override void AttachRange(IEnumerable<object> entities)
        {
            base.AttachRange(entities);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override ValueTask DisposeAsync()
        {
            return base.DisposeAsync();
        }

        public override EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
        {
            return base.Entry(entity);
        }

        public override EntityEntry Entry(object entity)
        {
            return base.Entry(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override object Find([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] Type entityType, params object[] keyValues)
        {
            return base.Find(entityType, keyValues);
        }

        public override TEntity Find<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>(params object[] keyValues)
        {
            return base.Find<TEntity>(keyValues);
        }

        public override ValueTask<object> FindAsync([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] Type entityType, params object[] keyValues)
        {
            return base.FindAsync(entityType, keyValues);
        }

        public override ValueTask<object> FindAsync([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] Type entityType, object[] keyValues, CancellationToken cancellationToken)
        {
            return base.FindAsync(entityType, keyValues, cancellationToken);
        }

        public override ValueTask<TEntity> FindAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>(params object[] keyValues)
        {
            return base.FindAsync<TEntity>(keyValues);
        }

        public override ValueTask<TEntity> FindAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>(object[] keyValues, CancellationToken cancellationToken)
        {
            return base.FindAsync<TEntity>(keyValues, cancellationToken);
        }

        public override IQueryable<TResult> FromExpression<TResult>(Expression<Func<IQueryable<TResult>>> expression)
        {
            return base.FromExpression(expression);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override EntityEntry<TEntity> Remove<TEntity>(TEntity entity)
        {
            return base.Remove(entity);
        }

        public override EntityEntry Remove(object entity)
        {
            return base.Remove(entity);
        }

        public override void RemoveRange(params object[] entities)
        {
            base.RemoveRange(entities);
        }

        public override void RemoveRange(IEnumerable<object> entities)
        {
            base.RemoveRange(entities);
        }

        public override int SaveChanges()
        {
            foreach (var entity in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableIdentityEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableUserRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            foreach (var entity in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableIdentityEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableUserRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entity in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableIdentityEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableUserRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entity in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableIdentityEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            foreach (var entity in ChangeTracker.Entries<AuditableUserRoleEntity>())
            {
                switch (entity.State)
                {
                    case EntityState.Added:
                        entity.Entity.CreatedBy = _principalService.UserId;
                        entity.Entity.CreatedTime = _dateTimeService.UtcNow;
                        entity.Entity.RowStatus = 0;
                        break;
                    case EntityState.Modified:
                        entity.Entity.ModifiedBy = _principalService.UserId;
                        entity.Entity.ModifiedTime = _dateTimeService.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override DbSet<TEntity> Set<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>()
        {
            return base.Set<TEntity>();
        }

        public override DbSet<TEntity> Set<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>(string name)
        {
            return base.Set<TEntity>(name);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override EntityEntry<TEntity> Update<TEntity>(TEntity entity)
        {
            return base.Update(entity);
        }

        public override EntityEntry Update(object entity)
        {
            return base.Update(entity);
        }

        public override void UpdateRange(params object[] entities)
        {
            base.UpdateRange(entities);
        }

        public override void UpdateRange(IEnumerable<object> entities)
        {
            base.UpdateRange(entities);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                _configuration.GetConnectionString("DefaultConnection"),
                x =>
                {
                    x.MigrationsHistoryTable("__EFMigrationsHistory");
                }
            );
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.SeedData();
        }
    }
}
