// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: msg.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Client {
  public static class MsgService
  {
    static readonly string __ServiceName = "Client.MsgService";

    static readonly Marshaller<global::Client.GetMsgListRequest> __Marshaller_GetMsgListRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.GetMsgListRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Client.GetMsgListReply> __Marshaller_GetMsgListReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.GetMsgListReply.Parser.ParseFrom);
    static readonly Marshaller<global::Client.GetMsgOneRequest> __Marshaller_GetMsgOneRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.GetMsgOneRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Client.GetMsgOneReply> __Marshaller_GetMsgOneReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.GetMsgOneReply.Parser.ParseFrom);
    static readonly Marshaller<global::Client.EditMsgRequest> __Marshaller_EditMsgRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.EditMsgRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Client.EditMsgReply> __Marshaller_EditMsgReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.EditMsgReply.Parser.ParseFrom);
    static readonly Marshaller<global::Client.RemoveMsgRequest> __Marshaller_RemoveMsgRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.RemoveMsgRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Client.RemoveMsgReply> __Marshaller_RemoveMsgReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Client.RemoveMsgReply.Parser.ParseFrom);

    static readonly Method<global::Client.GetMsgListRequest, global::Client.GetMsgListReply> __Method_GetList = new Method<global::Client.GetMsgListRequest, global::Client.GetMsgListReply>(
        MethodType.Unary,
        __ServiceName,
        "GetList",
        __Marshaller_GetMsgListRequest,
        __Marshaller_GetMsgListReply);

    static readonly Method<global::Client.GetMsgOneRequest, global::Client.GetMsgOneReply> __Method_GetOne = new Method<global::Client.GetMsgOneRequest, global::Client.GetMsgOneReply>(
        MethodType.Unary,
        __ServiceName,
        "GetOne",
        __Marshaller_GetMsgOneRequest,
        __Marshaller_GetMsgOneReply);

    static readonly Method<global::Client.EditMsgRequest, global::Client.EditMsgReply> __Method_Edit = new Method<global::Client.EditMsgRequest, global::Client.EditMsgReply>(
        MethodType.Unary,
        __ServiceName,
        "Edit",
        __Marshaller_EditMsgRequest,
        __Marshaller_EditMsgReply);

    static readonly Method<global::Client.RemoveMsgRequest, global::Client.RemoveMsgReply> __Method_Remove = new Method<global::Client.RemoveMsgRequest, global::Client.RemoveMsgReply>(
        MethodType.Unary,
        __ServiceName,
        "Remove",
        __Marshaller_RemoveMsgRequest,
        __Marshaller_RemoveMsgReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Client.MsgReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MsgService</summary>
    public abstract class MsgServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Client.GetMsgListReply> GetList(global::Client.GetMsgListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Client.GetMsgOneReply> GetOne(global::Client.GetMsgOneRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Client.EditMsgReply> Edit(global::Client.EditMsgRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Client.RemoveMsgReply> Remove(global::Client.RemoveMsgRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MsgService</summary>
    public class MsgServiceClient : ClientBase<MsgServiceClient>
    {
      /// <summary>Creates a new client for MsgService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MsgServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MsgService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MsgServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MsgServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MsgServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Client.GetMsgListReply GetList(global::Client.GetMsgListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetList(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Client.GetMsgListReply GetList(global::Client.GetMsgListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetList, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Client.GetMsgListReply> GetListAsync(global::Client.GetMsgListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetListAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Client.GetMsgListReply> GetListAsync(global::Client.GetMsgListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetList, null, options, request);
      }
      public virtual global::Client.GetMsgOneReply GetOne(global::Client.GetMsgOneRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOne(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Client.GetMsgOneReply GetOne(global::Client.GetMsgOneRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOne, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Client.GetMsgOneReply> GetOneAsync(global::Client.GetMsgOneRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOneAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Client.GetMsgOneReply> GetOneAsync(global::Client.GetMsgOneRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOne, null, options, request);
      }
      public virtual global::Client.EditMsgReply Edit(global::Client.EditMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Edit(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Client.EditMsgReply Edit(global::Client.EditMsgRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Edit, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Client.EditMsgReply> EditAsync(global::Client.EditMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return EditAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Client.EditMsgReply> EditAsync(global::Client.EditMsgRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Edit, null, options, request);
      }
      public virtual global::Client.RemoveMsgReply Remove(global::Client.RemoveMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Remove(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Client.RemoveMsgReply Remove(global::Client.RemoveMsgRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Remove, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Client.RemoveMsgReply> RemoveAsync(global::Client.RemoveMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Client.RemoveMsgReply> RemoveAsync(global::Client.RemoveMsgRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Remove, null, options, request);
      }
      protected override MsgServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MsgServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(MsgServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetList, serviceImpl.GetList)
          .AddMethod(__Method_GetOne, serviceImpl.GetOne)
          .AddMethod(__Method_Edit, serviceImpl.Edit)
          .AddMethod(__Method_Remove, serviceImpl.Remove).Build();
    }

  }
}
#endregion
