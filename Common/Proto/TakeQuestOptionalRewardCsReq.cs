// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeQuestOptionalRewardCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TakeQuestOptionalRewardCsReq.proto</summary>
  public static partial class TakeQuestOptionalRewardCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeQuestOptionalRewardCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeQuestOptionalRewardCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJUYWtlUXVlc3RPcHRpb25hbFJld2FyZENzUmVxLnByb3RvIk8KHFRha2VR",
            "dWVzdE9wdGlvbmFsUmV3YXJkQ3NSZXESGgoSb3B0aW9uYWxfcmV3YXJkX2lk",
            "GA8gASgNEhMKC1BJSEZFQk9OUEJLGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TakeQuestOptionalRewardCsReq), global::EggLink.DanhengServer.Proto.TakeQuestOptionalRewardCsReq.Parser, new[]{ "OptionalRewardId", "PIHFEBONPBK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TakeQuestOptionalRewardCsReq : pb::IMessage<TakeQuestOptionalRewardCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeQuestOptionalRewardCsReq> _parser = new pb::MessageParser<TakeQuestOptionalRewardCsReq>(() => new TakeQuestOptionalRewardCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeQuestOptionalRewardCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TakeQuestOptionalRewardCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeQuestOptionalRewardCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeQuestOptionalRewardCsReq(TakeQuestOptionalRewardCsReq other) : this() {
      optionalRewardId_ = other.optionalRewardId_;
      pIHFEBONPBK_ = other.pIHFEBONPBK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeQuestOptionalRewardCsReq Clone() {
      return new TakeQuestOptionalRewardCsReq(this);
    }

    /// <summary>Field number for the "optional_reward_id" field.</summary>
    public const int OptionalRewardIdFieldNumber = 15;
    private uint optionalRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionalRewardId {
      get { return optionalRewardId_; }
      set {
        optionalRewardId_ = value;
      }
    }

    /// <summary>Field number for the "PIHFEBONPBK" field.</summary>
    public const int PIHFEBONPBKFieldNumber = 7;
    private uint pIHFEBONPBK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PIHFEBONPBK {
      get { return pIHFEBONPBK_; }
      set {
        pIHFEBONPBK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeQuestOptionalRewardCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeQuestOptionalRewardCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OptionalRewardId != other.OptionalRewardId) return false;
      if (PIHFEBONPBK != other.PIHFEBONPBK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OptionalRewardId != 0) hash ^= OptionalRewardId.GetHashCode();
      if (PIHFEBONPBK != 0) hash ^= PIHFEBONPBK.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (PIHFEBONPBK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PIHFEBONPBK);
      }
      if (OptionalRewardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OptionalRewardId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PIHFEBONPBK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PIHFEBONPBK);
      }
      if (OptionalRewardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OptionalRewardId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OptionalRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionalRewardId);
      }
      if (PIHFEBONPBK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PIHFEBONPBK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeQuestOptionalRewardCsReq other) {
      if (other == null) {
        return;
      }
      if (other.OptionalRewardId != 0) {
        OptionalRewardId = other.OptionalRewardId;
      }
      if (other.PIHFEBONPBK != 0) {
        PIHFEBONPBK = other.PIHFEBONPBK;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 56: {
            PIHFEBONPBK = input.ReadUInt32();
            break;
          }
          case 120: {
            OptionalRewardId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 56: {
            PIHFEBONPBK = input.ReadUInt32();
            break;
          }
          case 120: {
            OptionalRewardId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
