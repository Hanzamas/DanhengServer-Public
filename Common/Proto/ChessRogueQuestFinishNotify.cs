// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueQuestFinishNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueQuestFinishNotify.proto</summary>
  public static partial class ChessRogueQuestFinishNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueQuestFinishNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueQuestFinishNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDaGVzc1JvZ3VlUXVlc3RGaW5pc2hOb3RpZnkucHJvdG8iRwobQ2hlc3NS",
            "b2d1ZVF1ZXN0RmluaXNoTm90aWZ5EhMKC1BJSEZFQk9OUEJLGAUgASgNEhMK",
            "C0hNSkhHUEFFRUJOGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueQuestFinishNotify), global::EggLink.DanhengServer.Proto.ChessRogueQuestFinishNotify.Parser, new[]{ "PIHFEBONPBK", "HMJHGPAEEBN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueQuestFinishNotify : pb::IMessage<ChessRogueQuestFinishNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueQuestFinishNotify> _parser = new pb::MessageParser<ChessRogueQuestFinishNotify>(() => new ChessRogueQuestFinishNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueQuestFinishNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueQuestFinishNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQuestFinishNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQuestFinishNotify(ChessRogueQuestFinishNotify other) : this() {
      pIHFEBONPBK_ = other.pIHFEBONPBK_;
      hMJHGPAEEBN_ = other.hMJHGPAEEBN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQuestFinishNotify Clone() {
      return new ChessRogueQuestFinishNotify(this);
    }

    /// <summary>Field number for the "PIHFEBONPBK" field.</summary>
    public const int PIHFEBONPBKFieldNumber = 5;
    private uint pIHFEBONPBK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PIHFEBONPBK {
      get { return pIHFEBONPBK_; }
      set {
        pIHFEBONPBK_ = value;
      }
    }

    /// <summary>Field number for the "HMJHGPAEEBN" field.</summary>
    public const int HMJHGPAEEBNFieldNumber = 7;
    private uint hMJHGPAEEBN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HMJHGPAEEBN {
      get { return hMJHGPAEEBN_; }
      set {
        hMJHGPAEEBN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueQuestFinishNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueQuestFinishNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PIHFEBONPBK != other.PIHFEBONPBK) return false;
      if (HMJHGPAEEBN != other.HMJHGPAEEBN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PIHFEBONPBK != 0) hash ^= PIHFEBONPBK.GetHashCode();
      if (HMJHGPAEEBN != 0) hash ^= HMJHGPAEEBN.GetHashCode();
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
        output.WriteRawTag(40);
        output.WriteUInt32(PIHFEBONPBK);
      }
      if (HMJHGPAEEBN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HMJHGPAEEBN);
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
        output.WriteRawTag(40);
        output.WriteUInt32(PIHFEBONPBK);
      }
      if (HMJHGPAEEBN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HMJHGPAEEBN);
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
      if (PIHFEBONPBK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PIHFEBONPBK);
      }
      if (HMJHGPAEEBN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HMJHGPAEEBN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueQuestFinishNotify other) {
      if (other == null) {
        return;
      }
      if (other.PIHFEBONPBK != 0) {
        PIHFEBONPBK = other.PIHFEBONPBK;
      }
      if (other.HMJHGPAEEBN != 0) {
        HMJHGPAEEBN = other.HMJHGPAEEBN;
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
          case 40: {
            PIHFEBONPBK = input.ReadUInt32();
            break;
          }
          case 56: {
            HMJHGPAEEBN = input.ReadUInt32();
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
          case 40: {
            PIHFEBONPBK = input.ReadUInt32();
            break;
          }
          case 56: {
            HMJHGPAEEBN = input.ReadUInt32();
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
