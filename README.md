## 演示项目
用于演示各类库使用方式方法和注意点，还包括与其他语言或平台的不兼容问题以及解决方案。   


## 项目结构
* [Polly自动重试框架](https://github.com/CSharpCross/demo/tree/master/polly/PollyDemo)
* [Scrutor依赖注入扫描](https://github.com/CSharpCross/demo/tree/master/scrutor/ScrutorDemo)


## 常用类库
* [Scrutor依赖注入扫描](https://github.com/khellang/Scrutor)   
* [Dapper数据库访问](https://github.com/StackExchange/Dapper)   
* [Xunit单元测试](https://github.com/xunit/xunit)   
* [RabbitMQ事件总线](http://www.rabbitmq.com/)   
* [NLog日志](https://github.com/NLog/NLog)   

## 经验积累   
以下内容将会记录在使用.Net Core中出现的一些兼容问题，比如与Java通信过程中出现的算法不统一问题以及其他兼容问题。   

#### UTF-8字节   
在使用.Net Core如果将字符串转换成字节并传输给Java程序将会出现无法解析的问题，因为Java下的字节是采用的有符号的格式，所以
需要将Byte转换成SByte进行传输，对应接收Java也需要使用SByte接收并转换成Byte才行。   



#### 更新记录
初始化开始迁移现有项目 by y-z-f 18/06/08
增加Scrutor演示代码 by y-z-f 18/06/12