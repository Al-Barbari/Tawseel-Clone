using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tawseel.CrossCutting.Common.Pagination
{
    public class Pagination
    {
        /// <summary>
        /// The current page number (1-based index).
        /// </summary>
        public int CurrentPage { get; private set; }

        /// <summary>
        /// The number of items per page.
        /// </summary>
        public int PageSize { get; private set; }

        /// <summary>
        /// The total number of items.
        /// </summary>
        public int TotalItems { get; private set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        /// <summary>
        /// The zero-based starting index of the items for the current page.
        /// </summary>
        public int StartIndex => (CurrentPage - 1) * PageSize;

        /// <summary>
        /// Indicates if there is a next page.
        /// </summary>
        public bool HasNextPage => CurrentPage < TotalPages;

        /// <summary>
        /// Indicates if there is a previous page.
        /// </summary>
        public bool HasPreviousPage => CurrentPage > 1;

        /// <summary>
        /// The data for the current page.
        /// </summary>
        public IEnumerable<object> Items { get; private set; }

        private Pagination(IEnumerable<object> items, int totalItems, int currentPage, int pageSize)
        {
            Items = items;
            TotalItems = totalItems;
            PageSize = pageSize;
            CurrentPage = currentPage;
        }

        /// <summary>
        /// Creates a new paginated response.
        /// </summary>
        /// <typeparam name="T">The type of data in the items list.</typeparam>
        /// <param name="source">The full data source.</param>
        /// <param name="currentPage">The current page number.</param>
        /// <param name="pageSize">The number of items per page.</param>
        /// <returns>A paginated response.</returns>
        public static Pagination Create<T>(IEnumerable<T> source, int currentPage, int pageSize)
        {
            if (currentPage < 1)
                throw new ArgumentException("Current page must be greater than or equal to 1.", nameof(currentPage));

            if (pageSize < 1)
                throw new ArgumentException("Page size must be greater than or equal to 1.", nameof(pageSize));

            var totalItems = source is ICollection<T> collection ? collection.Count : source.Count();
            var items = source.Skip((currentPage - 1) * pageSize).Take(pageSize);

            return new Pagination(items.Cast<object>(), totalItems, currentPage, pageSize);
        }
    }
}
