// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterSceneCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterSceneCsReq.proto</summary>
  public static partial class EnterSceneCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterSceneCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterSceneCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVFbnRlclNjZW5lQ3NSZXEucHJvdG8iYgoPRW50ZXJTY2VuZUNzUmVxEhMK",
            "C0JGUEdDT0RMT0NGGAQgASgIEhAKCGVudHJ5X2lkGAIgASgNEhMKC3RlbGVw",
            "b3J0X2lkGA0gASgNEhMKC0RKREJLRk5FS1BGGAEgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterSceneCsReq), global::EggLink.DanhengServer.Proto.EnterSceneCsReq.Parser, new[]{ "BFPGCODLOCF", "EntryId", "TeleportId", "DJDBKFNEKPF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterSceneCsReq : pb::IMessage<EnterSceneCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterSceneCsReq> _parser = new pb::MessageParser<EnterSceneCsReq>(() => new EnterSceneCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterSceneCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterSceneCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterSceneCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterSceneCsReq(EnterSceneCsReq other) : this() {
      bFPGCODLOCF_ = other.bFPGCODLOCF_;
      entryId_ = other.entryId_;
      teleportId_ = other.teleportId_;
      dJDBKFNEKPF_ = other.dJDBKFNEKPF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterSceneCsReq Clone() {
      return new EnterSceneCsReq(this);
    }

    /// <summary>Field number for the "BFPGCODLOCF" field.</summary>
    public const int BFPGCODLOCFFieldNumber = 4;
    private bool bFPGCODLOCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BFPGCODLOCF {
      get { return bFPGCODLOCF_; }
      set {
        bFPGCODLOCF_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 2;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "teleport_id" field.</summary>
    public const int TeleportIdFieldNumber = 13;
    private uint teleportId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TeleportId {
      get { return teleportId_; }
      set {
        teleportId_ = value;
      }
    }

    /// <summary>Field number for the "DJDBKFNEKPF" field.</summary>
    public const int DJDBKFNEKPFFieldNumber = 1;
    private uint dJDBKFNEKPF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DJDBKFNEKPF {
      get { return dJDBKFNEKPF_; }
      set {
        dJDBKFNEKPF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterSceneCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterSceneCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BFPGCODLOCF != other.BFPGCODLOCF) return false;
      if (EntryId != other.EntryId) return false;
      if (TeleportId != other.TeleportId) return false;
      if (DJDBKFNEKPF != other.DJDBKFNEKPF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BFPGCODLOCF != false) hash ^= BFPGCODLOCF.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      if (TeleportId != 0) hash ^= TeleportId.GetHashCode();
      if (DJDBKFNEKPF != 0) hash ^= DJDBKFNEKPF.GetHashCode();
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
      if (DJDBKFNEKPF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DJDBKFNEKPF);
      }
      if (EntryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntryId);
      }
      if (BFPGCODLOCF != false) {
        output.WriteRawTag(32);
        output.WriteBool(BFPGCODLOCF);
      }
      if (TeleportId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TeleportId);
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
      if (DJDBKFNEKPF != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DJDBKFNEKPF);
      }
      if (EntryId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntryId);
      }
      if (BFPGCODLOCF != false) {
        output.WriteRawTag(32);
        output.WriteBool(BFPGCODLOCF);
      }
      if (TeleportId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TeleportId);
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
      if (BFPGCODLOCF != false) {
        size += 1 + 1;
      }
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      if (TeleportId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TeleportId);
      }
      if (DJDBKFNEKPF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DJDBKFNEKPF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterSceneCsReq other) {
      if (other == null) {
        return;
      }
      if (other.BFPGCODLOCF != false) {
        BFPGCODLOCF = other.BFPGCODLOCF;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      if (other.TeleportId != 0) {
        TeleportId = other.TeleportId;
      }
      if (other.DJDBKFNEKPF != 0) {
        DJDBKFNEKPF = other.DJDBKFNEKPF;
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
          case 8: {
            DJDBKFNEKPF = input.ReadUInt32();
            break;
          }
          case 16: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 32: {
            BFPGCODLOCF = input.ReadBool();
            break;
          }
          case 104: {
            TeleportId = input.ReadUInt32();
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
          case 8: {
            DJDBKFNEKPF = input.ReadUInt32();
            break;
          }
          case 16: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 32: {
            BFPGCODLOCF = input.ReadBool();
            break;
          }
          case 104: {
            TeleportId = input.ReadUInt32();
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
