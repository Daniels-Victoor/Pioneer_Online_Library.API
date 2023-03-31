using Pioneer_Online_Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Core.Interface
{
    public interface IBookService
    {
        Book GetByISBN(string ISBN);

        Book GetByTitle(string title);
        Book GetByAuthor(string author);
        Book GetByPublisher(string publisher);
        Book GetByDatePublished(string datePublished);
    }
}
