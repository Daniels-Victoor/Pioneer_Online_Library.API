using CloudinaryDotNet;
using Microsoft.AspNetCore.Mvc;
using Pioneer_Online_Library.Core.Interface;

namespace Pioneer_Online_Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        
       private readonly IImageService _imageService;
        private readonly Cloudinary _cloudinaryService;

        public ImageController(IImageService imageService, Cloudinary cloudinaryService)
        {
            
            _imageService = imageService;
            _cloudinaryService = cloudinaryService;
        }


        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
           var image = _imageService.Upload(file);

            return Ok(image);
        }

        [HttpGet]
        public IActionResult Get(string publicId)
        {
            var image = _imageService.Get(publicId);

            return Ok(image);
        }


    }
}
