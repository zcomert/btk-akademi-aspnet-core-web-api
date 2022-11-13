using Entities.DataTransferObjects;
using Entities.LinkModels;
using Microsoft.AspNetCore.Http;

namespace Services.Contracts
{
    public interface IBookLinks
    {
        LinkResponse TryGenerateLinks(IEnumerable<BookDto> booksDto,
            string fields, HttpContext httpContext);
    }
}
