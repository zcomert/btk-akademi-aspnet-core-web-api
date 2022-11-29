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
        private readonly Lazy<IBookService> _bookService;
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IAuthenticationService> _authencationService;
        
        public ServiceManager(IRepositoryManager repositoryManager,
            ILoggerService logger,
            IMapper mapper,
            IConfiguration configuration,
            UserManager<User> userManager,
            IBookLinks bookLinks)
        {

            _categoryService = new Lazy<ICategoryService>(() =>
            new CategoryManager(repositoryManager));

            _bookService = new Lazy<IBookService>(() => 
            new BookManager(repositoryManager, logger, mapper, bookLinks, _categoryService.Value));

            _authencationService = new Lazy<IAuthenticationService>(() => 
            new AuthenticationManager(logger, mapper,userManager, configuration));
        }
        public IBookService BookService => 
            _bookService.Value;

        public IAuthenticationService AuthenticationService => 
            _authencationService.Value;

        public ICategoryService CategoryService => 
            _categoryService.Value;
    }
}
