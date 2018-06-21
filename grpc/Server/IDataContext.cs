using MongoDB.Driver;

namespace Server
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public interface IDataContext
    {
        IMongoDatabase Database { get; set; }
    }
}
