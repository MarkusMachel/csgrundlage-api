using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgrundlage.Application.Common.Interfaces.Persistence
{
    public interface IGrundlageDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
