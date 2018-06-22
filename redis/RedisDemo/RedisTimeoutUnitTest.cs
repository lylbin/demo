using StackExchange.Redis;
using System.Linq;
using System;
using Xunit;

namespace RedisDemo
{
    public class RedisTimeoutUnitTest
    {
        [Fact]
        public void Set_Timeout_Test()
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("192.168.1.195");
            var db = redis.GetDatabase();

            Enumerable.Range(0, 1000000).AsParallel().ForAll(x =>
            {
                db.StringSet("K" + x, Guid.NewGuid().ToString() + Guid.NewGuid().ToString() + Guid.NewGuid().ToString() + Guid.NewGuid().ToString() + Guid.NewGuid().ToString());
            });

            Enumerable.Range(0, 1000000).AsParallel().ForAll(x =>
            {
                var value = db.StringGet("K" + x);
            });
        }

        [Fact]
        public void Platform_Test()
        {
            bool isMono = Type.GetType("Mono.Runtime") != null;

            Console.WriteLine($"IsMono {isMono}");

            bool isUnix = (int)Environment.OSVersion.Platform == 4
                || (int)Environment.OSVersion.Platform == 6
                || (int)Environment.OSVersion.Platform == 128;

            Console.WriteLine($"IsUnix {isUnix}");
        }
    }
}
