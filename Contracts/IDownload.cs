using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDownload
    {
        Task<IEnumerable<DownloadableProduct>> GetDownloadableProducts();
        Task<DownloadableProduct> GetDownloadableProductById(int Id);
        Task<DownloadableProduct> AddDownloadableProduct(DownloadableProduct downloadableProduct);
        Task<DownloadableProduct> UpdateDownloadableProduct(DownloadableProduct downloadableProduct);
        Task DeleteDownloadableProduct(int Id);
    }
}
