using System.Linq;

namespace ObjectMapper.ObjectMapper
{
    public static class Mapper
    {
        public static TResult Map<T, TResult>(T model) where TResult:class,new()
        {
            var result = new TResult();
            typeof(T).GetProperties().ToList().ForEach(p=> {
                var property = typeof(TResult).GetProperty(p.Name);
                if (property !=null)
                    property.SetValue(result, p.GetValue(model));
            });
            return result;
        }
    }
}
