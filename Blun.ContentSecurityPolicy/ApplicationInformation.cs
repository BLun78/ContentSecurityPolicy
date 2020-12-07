using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Blun.ContentSecurityPolicy
{
    public static class ApplicationInformation
    {

        public static string LongDateString()
        {
            var buildTime = GetTimestamp();

            return buildTime.HasValue
                ? buildTime.Value.ToLongDateString()
                : string.Empty;
        }

        public static string LongTimeString()
        {
            var buildTime = GetTimestamp();

            return buildTime.HasValue
                ? buildTime.Value.ToLongTimeString()
                : string.Empty;
        }

        public static DateTime? GetTimestamp()
        {
            if (_cache.HasValue) return _cache;

            try
            {
                using (var stream = typeof(ApplicationInformation).Assembly.GetManifestResourceStream(typeof(ApplicationInformation).Namespace + ".BuildTimeStamp.txt"))
                using (var reader = new StreamReader(stream))
                {
                    var result = reader.ReadToEnd();
                    if (DateTime.TryParse(result, new CultureInfo("de"), DateTimeStyles.None, out DateTime buildTime))
                    {
                        _cache = buildTime;
                        return _cache;
                    }
                }
            }
            catch (Exception e)
            {
            }
            return null;
        }
        private static DateTime? _cache;
    }
}
