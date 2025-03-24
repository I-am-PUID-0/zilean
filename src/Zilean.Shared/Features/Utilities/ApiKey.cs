using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Zilean.Shared.Features.Utilities
{
    public static class ApiKey
    {
        public static string Generate()
        {
            var bytes = new byte[32];

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && File.Exists("/dev/urandom"))
            {
                try
                {
                    using var fs = new FileStream("/dev/urandom", FileMode.Open, FileAccess.Read);
                    if (fs.Read(bytes, 0, bytes.Length) == bytes.Length)
                    {
                        return Convert.ToHexString(bytes).ToLowerInvariant();
                    }
                }
                catch
                {
                }
            }
            return $"{Guid.NewGuid():N}{Guid.NewGuid():N}";
        }
    }
}
