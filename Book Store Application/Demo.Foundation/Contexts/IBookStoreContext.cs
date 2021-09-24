using Demo.Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Foundation.Contexts
{
    public interface IBookStoreContext
    {
        DbSet<Book> Books { get; set; }
    }
}