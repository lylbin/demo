using Polly;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Polly.CircuitBreaker;

namespace PollyDemo
{
    public class Test
    {
        /// <summary>
        /// �����쳣��ÿ��2��������ԣ�����3��
        /// </summary>
        [Fact]
        public async Task Handle_HttpRequestException_And_Retry_Test()
        {
            var httpClient = new HttpClient();
            var maxRetryAttempts = 3;
            var pauseBetweenFailures = TimeSpan.FromSeconds(2);

            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .WaitAndRetryAsync(maxRetryAttempts, i => pauseBetweenFailures);

            try
            {
                await retryPolicy.ExecuteAsync(async () =>
                {
                    var response = await httpClient.GetAsync("http://tms.sowl.cn/232");
                    response.EnsureSuccessStatusCode();
                });
            }
            catch (HttpRequestException ex)
            {
                
            }
        }

        /// <summary>
        /// �����쳣��ÿ��2��4��8�����ԣ�����3��
        /// </summary>
        [Fact]
        public async Task Handle_HttpRequestException_And_Retry_CustomeTimeSpan_Test()
        {
            var httpClient = new HttpClient();

            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(2),
                    TimeSpan.FromSeconds(4),
                    TimeSpan.FromSeconds(8)
                });

            try
            {
                await retryPolicy.ExecuteAsync(async () =>
                {
                    var response = await httpClient.GetAsync("http://tms.sowl.cn/212");
                    response.EnsureSuccessStatusCode();
                });
            }
            catch(HttpRequestException ex)
            {

            }
        }

        /// <summary>
        /// �����쳣��ÿ��2�����Դ�������ʱ��������ԣ�����3��
        /// </summary>
        [Fact]
        public async Task Handle_HttpRequestException_And_Retry_Pow_Test()
        {
            var httpClient = new HttpClient();

            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

            try
            {
                await retryPolicy.ExecuteAsync(async () =>
                {
                    var response = await httpClient.GetAsync("http://tms.sowl.cn/212");
                    response.EnsureSuccessStatusCode();
                });
            }
            catch(HttpRequestException ex)
            {

            }
        }

        /// <summary>
        /// �����ض�����µ��쳣������
        /// </summary>
        [Fact]
        public async Task Handle_Exception_With_Details_Retry_Test()
        {
            var retryPolicy = Policy
                .Handle<ArgumentException>(ex => ex.ParamName == "url")
                .Or<HttpRequestException>()
                .WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(2));

            try
            {
                await retryPolicy.ExecuteAsync(async () =>
                {
                    throw new ArgumentNullException("url");
                    await Task.FromResult(3);
                });
            }
            catch(ArgumentNullException ex)
            {

            }
        }

        /// <summary>
        /// �����ض�������쳣������
        /// </summary>
        [Fact]
        public async Task Handle_HttpResponseMessage_And_Retry_Test()
        {
            var httpClient = new HttpClient();

            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .OrResult<HttpResponseMessage>(r => r.StatusCode == System.Net.HttpStatusCode.NotFound)
                .OrResult(r => r.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                .WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(1));

            await retryPolicy.ExecuteAsync(async () =>
            {
                var response = await httpClient.GetAsync("http://tms.sowl.cn/213");
                return response;
            });
        }

        /// <summary>
        /// �����쳣��������һ��
        /// </summary>
        [Fact]
        public async Task Handle_HttpRequestException_And_Retry_NoWait_Test()
        {
            var httpClient = new HttpClient();

            var retryPolicy = Policy
                .Handle<HttpRequestException>()
                .RetryAsync();
                // �������β���ÿ������ʱ�ص��ڶ�������
                //.RetryAsync(3, (ex, retryCount) => { })
                //.RetryAsync(3, (ex, retryCount, context) => { })
                // һֱ���Ե��ɹ�
                //.RetryForeverAsync();

            try
            {
                await retryPolicy.ExecuteAsync(async () =>
                {
                    var response = await httpClient.GetAsync("http://tms.sowl.cn/212");
                    response.EnsureSuccessStatusCode();
                });
            }
            catch(HttpRequestException ex)
            {

            }
        }

        /// <summary>
        /// �����۶�����ֹ�ڷ��������Դ��������������Դ��������
        /// </summary>
        [Fact]
        public async Task Handle_HttpRequestException_And_CircuitBraker_Test()
        {
            var httpClient = new HttpClient();

            var circuitPolicy = Policy
                .Handle<HttpRequestException>()
                .CircuitBreakerAsync(2, TimeSpan.FromSeconds(8));

            var retryPolicy = Policy
                .Handle<BrokenCircuitException>()
                .Or<HttpRequestException>()
                .WaitAndRetryAsync(5, i => TimeSpan.FromSeconds(2));

            try
            {
                await retryPolicy.ExecuteAsync(async () =>
                {
                    await circuitPolicy.ExecuteAsync(async () =>
                    {
                        var response = await httpClient.GetAsync("http://tms.sowl.cn/212");
                        response.EnsureSuccessStatusCode();
                    });
                });
            }
            catch(Exception ex)
            {

            }
        }

        /// <summary>
        /// �ڴﵽ���Դ����󷵻�Ĭ��ֵ
        /// </summary>
        [Fact]
        public async Task Handle_ArgumentException_And_Fallback()
        {
            var fallbackPolicy = Policy<string>
                .Handle<ArgumentException>()
                .FallbackAsync("Ĭ��ֵ");

            var retryPolicy = Policy
                .Handle<ArgumentException>()
                .WaitAndRetryAsync(2, i => TimeSpan.FromSeconds(2));

            var wrapPolicy = fallbackPolicy.WrapAsync(retryPolicy);

            string result = await wrapPolicy.ExecuteAsync(async () =>
            {
                throw new ArgumentException("123");
                return await Task.FromResult("123213");
            });

            Assert.Equal("Ĭ��ֵ", result);
        }
    }
}
