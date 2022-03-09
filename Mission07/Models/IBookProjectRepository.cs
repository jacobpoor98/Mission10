using System;
using System.Linq;

namespace Mission07.Models
{
    // creates the IBookProjectRepository and allows its contents to be queryable
    public interface IBookProjectRepository
    {
        IQueryable<Book> Books { get; }

        // add methods
        public void SaveProject(Book b);
        public void CreateProject(Book b);
        public void DeleteProject(Book b);
    }
}
