using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace ASPNET.Helpers
{
    public static class SessionHelper
    {
        static SessionHelper()
        {

        }
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
