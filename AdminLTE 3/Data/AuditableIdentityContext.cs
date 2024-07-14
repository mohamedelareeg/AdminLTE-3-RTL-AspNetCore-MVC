using AdminLTE.Enums;
using AdminLTE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE.Data
{
    public abstract class AuditableIdentityContext : IdentityDbContext<ApplicationUser>
    {
        public AuditableIdentityContext()
        {
        }
        public AuditableIdentityContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AuditLogs> AuditLogs { get; set; }
        //public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public virtual async Task<int> SaveChangesAsync()
        {
            OnBeforeSaveChanges();
            var result = await base.SaveChangesAsync();
            return result;
        }

        private void OnBeforeSaveChanges()
        {
            ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntry>();
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is AuditLogs || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;
                var auditEntry = new AuditEntry(entry);
                auditEntry.TableName = entry.Entity.GetType().Name;
                auditEntries.Add(auditEntry);
                foreach (var property in entry.Properties)
                {
                    string propertyName = property.Metadata.Name;
                    if (propertyName == "ModifiedBy" && property.CurrentValue != null)
                    {
                        auditEntry.UserId = property.CurrentValue.ToString();
                    }
                    else if (propertyName == "ModifiedBy" && property.OriginalValue != null)
                    {
                        auditEntry.UserId = property.OriginalValue.ToString();
                    }

                    if (property.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[propertyName] = property.CurrentValue;
                        continue;
                    }

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            auditEntry.AuditType = AuditType.Create;
                            auditEntry.NewValues[propertyName] = property.CurrentValue;
                            break;

                        case EntityState.Deleted:
                            auditEntry.AuditType = AuditType.Delete;
                            auditEntry.OldValues[propertyName] = property.OriginalValue;
                            break;

                        case EntityState.Modified:
                            if (property.IsModified)
                            {
                                auditEntry.ChangedColumns.Add(propertyName);
                                auditEntry.AuditType = AuditType.Update;
                                auditEntry.OldValues[propertyName] = property.OriginalValue;
                                auditEntry.NewValues[propertyName] = property.CurrentValue;
                            }
                            break;
                    }
                }
            }
            foreach (var auditEntry in auditEntries)
            {
                AuditLogs.Add(auditEntry.ToAudit());
            }
        }
    }
}
