using Proto;
using Proto.Mailbox;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProtoActorDemo
{
    class Hello
    {
        public string Who;
        public int Number;
    }

    class HelloActor : IActor
    {
        public Task ReceiveAsync(IContext context)
        {
            var msg = context.Message;
            if (msg is Hello r)
            {
                Console.WriteLine($"The Number is {r.Number}");
                Assert.Equal("Alex", r.Who);
            }
            return Actor.Done;
        }
    }

    public class HelloWorld
    {
        [Fact]
        public void Normal_Test()
        {
            var props = Actor.FromProducer(() => new HelloActor());
            var pid = Actor.Spawn(props);
            pid.Tell(new Hello
            {
                Who = "Alex"
            });
        }

        [Fact]
        public void Func_Test()
        {
            var props = Actor.FromFunc(context =>
            {
                var msg = context.Message;
                if (msg is Hello r)
                {
                    Assert.Equal("Alex", r.Who);
                }
                return Actor.Done;
            });

            var pid = Actor.Spawn(props);
            pid.Tell(new Hello
            {
                Who = "Alex"
            });
        }

        [Fact]
        public void Props_With_Producer_Test()
        {
            var props = new Props()
                .WithProducer(() => new HelloActor());

            var pid = Actor.Spawn(props);
            pid.Tell(new Hello
            {
                Who = "Alex"
            });
        }

        [Fact]
        public void Props_With_Dispatcher_Test()
        {
            var props = new Props()
                .WithProducer(() => new HelloActor())
                .WithDispatcher(Dispatchers.DefaultDispatcher);

            var pid = Actor.Spawn(props);

            Enumerable.Range(1, 100).AsParallel().ForAll(x =>
            {

            });
        }
    }
}
