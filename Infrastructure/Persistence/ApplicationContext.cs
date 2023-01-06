using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using Domain.Common;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>, IApplicationContext
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

        public DbSet<Product> Product { get; set; }

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

            return base.SaveChangesAsync(cancellationToken);
        }

        public override DbSet<TEntity> Set<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>()
        {
            return base.Set<TEntity>();
        }

        public override DbSet<TEntity> Set<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.NonPublicFields | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties | DynamicallyAccessedMemberTypes.Interfaces)] TEntity>(string name)
        {
            return base.Set<TEntity>(name);
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
