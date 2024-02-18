using Newtonsoft.Json;

namespace HTMX_MVC.Controllers.ControllerUtils
{
    public static class ControllerUtils
    {
        public static T GetCreateModel<T>(this HttpContext httpContext) where T : class, new()
        {
            var modelName = typeof(T).Name;
            var modelJson = httpContext.Session.GetString(modelName);

            if (modelJson == null)
            {
                return new T();
            }

            return JsonConvert.DeserializeObject<T>(modelJson)
                ?? new T(); ;
        }

        public static void SaveModel<T>(this HttpContext httpContext, T model) where T : class
        {
            var modelName = typeof(T).Name;
            var modelJson = JsonConvert.SerializeObject(model);

            httpContext.Session.SetString(
                key: modelName,
                value: modelJson);
        }

    }
}
