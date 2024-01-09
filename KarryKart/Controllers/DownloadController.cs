using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private readonly IDownload _iDownloadRepository;
        public DownloadController(IDownload iDownloadRepository)
        {
            _iDownloadRepository = iDownloadRepository;
        }
        [HttpGet(" GetDownloadableProduct")]
        public async Task<IEnumerable<DownloadableProduct>> GetDownloadableProducts()
        {
            var product = await _iDownloadRepository.GetDownloadableProducts();
            return product;
        }
        [HttpGet("GetDownloadableProductbyId")]
        public async Task<ActionResult<DownloadableProduct>> GetDownloadableProductById(int Id)
        {
            var product = await _iDownloadRepository.GetDownloadableProductById(Id);
            return product;
        }

        [HttpPost("AddDownloadableProduct")]
        public async Task<ActionResult<DownloadableProduct>> AddDownloadableProduct(DownloadableProduct downloadableProduct)
        {
            DownloadableProduct Response = new DownloadableProduct();
            if (downloadableProduct != null)
            {
                downloadableProduct.Id = 0;
                Response = await _iDownloadRepository.AddDownloadableProduct(downloadableProduct);
            }

            return Response;
        }
        [HttpPut("UpdateDownloadbleProduct/{id}")]
        public async Task<ActionResult<DownloadableProduct>> UpdateDownloadableProduct(DownloadableProduct downloadableProduct)
        {
            var update = await _iDownloadRepository.UpdateDownloadableProduct(downloadableProduct);
            return update;
        }
        [HttpDelete("DeleteDownloadbleProduct/{id}")]
        public async Task<IActionResult> DeleteDownloadableProduct(int Id)
        {
            await _iDownloadRepository.DeleteDownloadableProduct(Id);
            return NoContent();
        }
    }
}