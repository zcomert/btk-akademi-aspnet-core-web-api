namespace Entities.Exceptions
{
    public sealed class CategoryNotFoundException
        : NotFoundException
    {
        public CategoryNotFoundException(int id) 
            : base($"Category with id : {id} could not found.")
        {

        }
    }
}
