//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project.Appliction.Services.utils
//{
//    public class SearchService<T>
//    {
//        public IQueryable<T> ApplySearch(IQueryable<T> query, string searchQuery, params Expression<Func<T, string>>[] searchProperties)
//        {
//            if (string.IsNullOrEmpty(searchQuery))
//                return query;

//            foreach (var searchProperty in searchProperties)
//            {
//                query = query.Where(entity => EF.Functions.Like(EF.Property<string>(entity, searchProperty.ToString()), $"%{searchQuery}%"));
//            }

//            return query;
//        }
//    }
//}
