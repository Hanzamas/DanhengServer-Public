// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyBuff.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyBuff.proto</summary>
  public static partial class MonopolyBuffReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyBuff.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyBuffReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJNb25vcG9seUJ1ZmYucHJvdG8iSQoMTW9ub3BvbHlCdWZmEhMKC05LRUlE",
            "TUtESkRMGAQgASgNEg8KB2J1ZmZfaWQYCSABKA0SEwoLRlBMTEpMSk5KSkUY",
            "DiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyBuff), global::EggLink.DanhengServer.Proto.MonopolyBuff.Parser, new[]{ "NKEIDMKDJDL", "BuffId", "FPLLJLJNJJE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyBuff : pb::IMessage<MonopolyBuff>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyBuff> _parser = new pb::MessageParser<MonopolyBuff>(() => new MonopolyBuff());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyBuff> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyBuffReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyBuff() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyBuff(MonopolyBuff other) : this() {
      nKEIDMKDJDL_ = other.nKEIDMKDJDL_;
      buffId_ = other.buffId_;
      fPLLJLJNJJE_ = other.fPLLJLJNJJE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyBuff Clone() {
      return new MonopolyBuff(this);
    }

    /// <summary>Field number for the "NKEIDMKDJDL" field.</summary>
    public const int NKEIDMKDJDLFieldNumber = 4;
    private uint nKEIDMKDJDL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NKEIDMKDJDL {
      get { return nKEIDMKDJDL_; }
      set {
        nKEIDMKDJDL_ = value;
      }
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 9;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "FPLLJLJNJJE" field.</summary>
    public const int FPLLJLJNJJEFieldNumber = 14;
    private uint fPLLJLJNJJE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FPLLJLJNJJE {
      get { return fPLLJLJNJJE_; }
      set {
        fPLLJLJNJJE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyBuff);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyBuff other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NKEIDMKDJDL != other.NKEIDMKDJDL) return false;
      if (BuffId != other.BuffId) return false;
      if (FPLLJLJNJJE != other.FPLLJLJNJJE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NKEIDMKDJDL != 0) hash ^= NKEIDMKDJDL.GetHashCode();
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (FPLLJLJNJJE != 0) hash ^= FPLLJLJNJJE.GetHashCode();
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
      if (NKEIDMKDJDL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NKEIDMKDJDL);
      }
      if (BuffId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BuffId);
      }
      if (FPLLJLJNJJE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FPLLJLJNJJE);
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
      if (NKEIDMKDJDL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NKEIDMKDJDL);
      }
      if (BuffId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BuffId);
      }
      if (FPLLJLJNJJE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FPLLJLJNJJE);
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
      if (NKEIDMKDJDL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NKEIDMKDJDL);
      }
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (FPLLJLJNJJE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FPLLJLJNJJE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyBuff other) {
      if (other == null) {
        return;
      }
      if (other.NKEIDMKDJDL != 0) {
        NKEIDMKDJDL = other.NKEIDMKDJDL;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.FPLLJLJNJJE != 0) {
        FPLLJLJNJJE = other.FPLLJLJNJJE;
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
          case 32: {
            NKEIDMKDJDL = input.ReadUInt32();
            break;
          }
          case 72: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 112: {
            FPLLJLJNJJE = input.ReadUInt32();
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
          case 32: {
            NKEIDMKDJDL = input.ReadUInt32();
            break;
          }
          case 72: {
            BuffId = input.ReadUInt32();
            break;
          }
          case 112: {
            FPLLJLJNJJE = input.ReadUInt32();
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
