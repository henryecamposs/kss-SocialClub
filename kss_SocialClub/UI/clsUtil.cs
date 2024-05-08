using AutoMapper;

namespace kss_SocialClub.UI
{
    internal static class clsUtil
    { 
        /// <summary>
        /// Duplica Objeto con Automapper de Nuget
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T Copy<T>(this T source)
        {
            T copy = default(T);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<T, T>();
            });

            IMapper mapper = config.CreateMapper();
            copy = mapper.Map<T, T>(source);
            return copy;
        }
    }

}
