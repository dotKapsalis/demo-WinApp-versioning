using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoTool.Desktop.Services
{
    public interface IDataService
    {
        Task<IEnumerable<object>> FetchDataAsync();
    }
}
