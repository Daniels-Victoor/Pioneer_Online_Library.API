using Microsoft.AspNetCore.Http;
using Pioneer_Online_Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Core.Interface
{
    public interface IImageService
    {
        Image Upload(IFormFile file);

        Image Get(string publicId);
    }
}
