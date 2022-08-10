using RocWay.Application.DTO;

namespace RocWay.Api.Utils
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, PaginationDTO paginacionDTO)
        {
            return queryable
                .Skip((paginacionDTO.Page - 1) * paginacionDTO.RecordsByPages)
                .Take(paginacionDTO.RecordsByPages);
        }
    }
}
