using csgrundlage.Application.Common.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgrundlage.Infrastructure.Persistence
{
    public class GrundlageDbContext : DbContext, IGrundlageDbContext
    {
        public GrundlageDbContext(DbContextOptions<GrundlageDbContext> options)
            : base(options)
        {
        }
        //TODO: Audit logic or some logging
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
