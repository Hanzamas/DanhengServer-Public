// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OpenTreasureDungeonGridScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OpenTreasureDungeonGridScRsp.proto</summary>
  public static partial class OpenTreasureDungeonGridScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for OpenTreasureDungeonGridScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpenTreasureDungeonGridScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJPcGVuVHJlYXN1cmVEdW5nZW9uR3JpZFNjUnNwLnByb3RvGhpUcmVhc3Vy",
            "ZUR1bmdlb25MZXZlbC5wcm90byJbChxPcGVuVHJlYXN1cmVEdW5nZW9uR3Jp",
            "ZFNjUnNwEg8KB3JldGNvZGUYAiABKA0SKgoLRkVDTkZFQktDREkYASABKAsy",
            "FS5UcmVhc3VyZUR1bmdlb25MZXZlbEIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TreasureDungeonLevelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.OpenTreasureDungeonGridScRsp), global::EggLink.DanhengServer.Proto.OpenTreasureDungeonGridScRsp.Parser, new[]{ "Retcode", "FECNFEBKCDI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OpenTreasureDungeonGridScRsp : pb::IMessage<OpenTreasureDungeonGridScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OpenTreasureDungeonGridScRsp> _parser = new pb::MessageParser<OpenTreasureDungeonGridScRsp>(() => new OpenTreasureDungeonGridScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OpenTreasureDungeonGridScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.OpenTreasureDungeonGridScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenTreasureDungeonGridScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenTreasureDungeonGridScRsp(OpenTreasureDungeonGridScRsp other) : this() {
      retcode_ = other.retcode_;
      fECNFEBKCDI_ = other.fECNFEBKCDI_ != null ? other.fECNFEBKCDI_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenTreasureDungeonGridScRsp Clone() {
      return new OpenTreasureDungeonGridScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "FECNFEBKCDI" field.</summary>
    public const int FECNFEBKCDIFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.TreasureDungeonLevel fECNFEBKCDI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TreasureDungeonLevel FECNFEBKCDI {
      get { return fECNFEBKCDI_; }
      set {
        fECNFEBKCDI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OpenTreasureDungeonGridScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OpenTreasureDungeonGridScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(FECNFEBKCDI, other.FECNFEBKCDI)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (fECNFEBKCDI_ != null) hash ^= FECNFEBKCDI.GetHashCode();
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
      if (fECNFEBKCDI_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FECNFEBKCDI);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
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
      if (fECNFEBKCDI_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FECNFEBKCDI);
      }
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (fECNFEBKCDI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FECNFEBKCDI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OpenTreasureDungeonGridScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.fECNFEBKCDI_ != null) {
        if (fECNFEBKCDI_ == null) {
          FECNFEBKCDI = new global::EggLink.DanhengServer.Proto.TreasureDungeonLevel();
        }
        FECNFEBKCDI.MergeFrom(other.FECNFEBKCDI);
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
          case 10: {
            if (fECNFEBKCDI_ == null) {
              FECNFEBKCDI = new global::EggLink.DanhengServer.Proto.TreasureDungeonLevel();
            }
            input.ReadMessage(FECNFEBKCDI);
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
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
          case 10: {
            if (fECNFEBKCDI_ == null) {
              FECNFEBKCDI = new global::EggLink.DanhengServer.Proto.TreasureDungeonLevel();
            }
            input.ReadMessage(FECNFEBKCDI);
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
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
