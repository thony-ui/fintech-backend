// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/stub/hello_world_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.HelloWorld {

  #region Events
  public partial class UpdatedMessage : aelf::IEvent<UpdatedMessage>
  {
    public global::System.Collections.Generic.IEnumerable<UpdatedMessage> GetIndexed()
    {
      return new List<UpdatedMessage>
      {
      };
    }

    public UpdatedMessage GetNonIndexed()
    {
      return new UpdatedMessage
      {
        Value = Value,
      };
    }
  }

  #endregion
  public static partial class HelloWorldContainer
  {
    static readonly string __ServiceName = "HelloWorld";

    #region Marshallers
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Update = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Update",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> __Method_Read = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue>(
        aelf::MethodType.View,
        __ServiceName,
        "Read",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_StringValue);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.HelloWorld.HelloWorldContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.HelloWorld.HelloWorldContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class HelloWorldStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::Google.Protobuf.WellKnownTypes.Empty> Update
      {
        get { return __factory.Create(__Method_Update); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> Read
      {
        get { return __factory.Create(__Method_Read); }
      }

    }
  }
}
#endregion

