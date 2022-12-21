using AutoMapper;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repositories.Contracts;
using Services.Contracts;


namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthenticationService _authencationService;

        public ServiceManager(IBookService bookService, 
            ICategoryService categoryService, 
            IAuthenticationService authencationService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _authencationService = authencationService;
        }

        public IBookService BookService => _bookService;

        public IAuthenticationService AuthenticationService => _authencationService;

        public ICategoryService CategoryService => _categoryService;
    }
}
