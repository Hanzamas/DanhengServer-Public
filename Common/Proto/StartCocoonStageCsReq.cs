// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartCocoonStageCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartCocoonStageCsReq.proto</summary>
  public static partial class StartCocoonStageCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for StartCocoonStageCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartCocoonStageCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtTdGFydENvY29vblN0YWdlQ3NSZXEucHJvdG8iZQoVU3RhcnRDb2Nvb25T",
            "dGFnZUNzUmVxEhMKC3dvcmxkX2xldmVsGAEgASgNEhYKDnByb3BfZW50aXR5",
            "X2lkGAkgASgNEgwKBHdhdmUYAiABKA0SEQoJY29jb29uX2lkGAMgASgNQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartCocoonStageCsReq), global::EggLink.DanhengServer.Proto.StartCocoonStageCsReq.Parser, new[]{ "WorldLevel", "PropEntityId", "Wave", "CocoonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartCocoonStageCsReq : pb::IMessage<StartCocoonStageCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartCocoonStageCsReq> _parser = new pb::MessageParser<StartCocoonStageCsReq>(() => new StartCocoonStageCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartCocoonStageCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartCocoonStageCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartCocoonStageCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartCocoonStageCsReq(StartCocoonStageCsReq other) : this() {
      worldLevel_ = other.worldLevel_;
      propEntityId_ = other.propEntityId_;
      wave_ = other.wave_;
      cocoonId_ = other.cocoonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartCocoonStageCsReq Clone() {
      return new StartCocoonStageCsReq(this);
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 1;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "prop_entity_id" field.</summary>
    public const int PropEntityIdFieldNumber = 9;
    private uint propEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropEntityId {
      get { return propEntityId_; }
      set {
        propEntityId_ = value;
      }
    }

    /// <summary>Field number for the "wave" field.</summary>
    public const int WaveFieldNumber = 2;
    private uint wave_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Wave {
      get { return wave_; }
      set {
        wave_ = value;
      }
    }

    /// <summary>Field number for the "cocoon_id" field.</summary>
    public const int CocoonIdFieldNumber = 3;
    private uint cocoonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CocoonId {
      get { return cocoonId_; }
      set {
        cocoonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartCocoonStageCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartCocoonStageCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorldLevel != other.WorldLevel) return false;
      if (PropEntityId != other.PropEntityId) return false;
      if (Wave != other.Wave) return false;
      if (CocoonId != other.CocoonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (PropEntityId != 0) hash ^= PropEntityId.GetHashCode();
      if (Wave != 0) hash ^= Wave.GetHashCode();
      if (CocoonId != 0) hash ^= CocoonId.GetHashCode();
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (Wave != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Wave);
      }
      if (CocoonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CocoonId);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PropEntityId);
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (Wave != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Wave);
      }
      if (CocoonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CocoonId);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PropEntityId);
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
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (PropEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropEntityId);
      }
      if (Wave != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Wave);
      }
      if (CocoonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CocoonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartCocoonStageCsReq other) {
      if (other == null) {
        return;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.PropEntityId != 0) {
        PropEntityId = other.PropEntityId;
      }
      if (other.Wave != 0) {
        Wave = other.Wave;
      }
      if (other.CocoonId != 0) {
        CocoonId = other.CocoonId;
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            Wave = input.ReadUInt32();
            break;
          }
          case 24: {
            CocoonId = input.ReadUInt32();
            break;
          }
          case 72: {
            PropEntityId = input.ReadUInt32();
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            Wave = input.ReadUInt32();
            break;
          }
          case 24: {
            CocoonId = input.ReadUInt32();
            break;
          }
          case 72: {
            PropEntityId = input.ReadUInt32();
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
