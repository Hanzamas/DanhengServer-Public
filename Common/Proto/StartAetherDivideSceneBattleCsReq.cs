// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartAetherDivideSceneBattleCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartAetherDivideSceneBattleCsReq.proto</summary>
  public static partial class StartAetherDivideSceneBattleCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for StartAetherDivideSceneBattleCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartAetherDivideSceneBattleCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTdGFydEFldGhlckRpdmlkZVNjZW5lQmF0dGxlQ3NSZXEucHJvdG8aHUFz",
            "c2lzdE1vbnN0ZXJFbnRpdHlJbmZvLnByb3RvItABCiFTdGFydEFldGhlckRp",
            "dmlkZVNjZW5lQmF0dGxlQ3NSZXESPAoaYXNzaXN0X21vbnN0ZXJfZW50aXR5",
            "X2luZm8YBiADKAsyGC5Bc3Npc3RNb25zdGVyRW50aXR5SW5mbxIdChVhdHRh",
            "Y2tlZF9ieV9lbnRpdHlfaWQYCSABKA0SIQoZaGl0X3RhcmdldF9lbnRpdHlf",
            "aWRfbGlzdBgEIAMoDRIWCg5jYXN0X2VudGl0eV9pZBgDIAEoDRITCgtza2ls",
            "bF9pbmRleBgHIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AssistMonsterEntityInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartAetherDivideSceneBattleCsReq), global::EggLink.DanhengServer.Proto.StartAetherDivideSceneBattleCsReq.Parser, new[]{ "AssistMonsterEntityInfo", "AttackedByEntityId", "HitTargetEntityIdList", "CastEntityId", "SkillIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartAetherDivideSceneBattleCsReq : pb::IMessage<StartAetherDivideSceneBattleCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartAetherDivideSceneBattleCsReq> _parser = new pb::MessageParser<StartAetherDivideSceneBattleCsReq>(() => new StartAetherDivideSceneBattleCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartAetherDivideSceneBattleCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartAetherDivideSceneBattleCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideSceneBattleCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideSceneBattleCsReq(StartAetherDivideSceneBattleCsReq other) : this() {
      assistMonsterEntityInfo_ = other.assistMonsterEntityInfo_.Clone();
      attackedByEntityId_ = other.attackedByEntityId_;
      hitTargetEntityIdList_ = other.hitTargetEntityIdList_.Clone();
      castEntityId_ = other.castEntityId_;
      skillIndex_ = other.skillIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartAetherDivideSceneBattleCsReq Clone() {
      return new StartAetherDivideSceneBattleCsReq(this);
    }

    /// <summary>Field number for the "assist_monster_entity_info" field.</summary>
    public const int AssistMonsterEntityInfoFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AssistMonsterEntityInfo> _repeated_assistMonsterEntityInfo_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.AssistMonsterEntityInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistMonsterEntityInfo> assistMonsterEntityInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistMonsterEntityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AssistMonsterEntityInfo> AssistMonsterEntityInfo {
      get { return assistMonsterEntityInfo_; }
    }

    /// <summary>Field number for the "attacked_by_entity_id" field.</summary>
    public const int AttackedByEntityIdFieldNumber = 9;
    private uint attackedByEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AttackedByEntityId {
      get { return attackedByEntityId_; }
      set {
        attackedByEntityId_ = value;
      }
    }

    /// <summary>Field number for the "hit_target_entity_id_list" field.</summary>
    public const int HitTargetEntityIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_hitTargetEntityIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> hitTargetEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HitTargetEntityIdList {
      get { return hitTargetEntityIdList_; }
    }

    /// <summary>Field number for the "cast_entity_id" field.</summary>
    public const int CastEntityIdFieldNumber = 3;
    private uint castEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CastEntityId {
      get { return castEntityId_; }
      set {
        castEntityId_ = value;
      }
    }

    /// <summary>Field number for the "skill_index" field.</summary>
    public const int SkillIndexFieldNumber = 7;
    private uint skillIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillIndex {
      get { return skillIndex_; }
      set {
        skillIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartAetherDivideSceneBattleCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartAetherDivideSceneBattleCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!assistMonsterEntityInfo_.Equals(other.assistMonsterEntityInfo_)) return false;
      if (AttackedByEntityId != other.AttackedByEntityId) return false;
      if(!hitTargetEntityIdList_.Equals(other.hitTargetEntityIdList_)) return false;
      if (CastEntityId != other.CastEntityId) return false;
      if (SkillIndex != other.SkillIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= assistMonsterEntityInfo_.GetHashCode();
      if (AttackedByEntityId != 0) hash ^= AttackedByEntityId.GetHashCode();
      hash ^= hitTargetEntityIdList_.GetHashCode();
      if (CastEntityId != 0) hash ^= CastEntityId.GetHashCode();
      if (SkillIndex != 0) hash ^= SkillIndex.GetHashCode();
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
      if (CastEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CastEntityId);
      }
      hitTargetEntityIdList_.WriteTo(output, _repeated_hitTargetEntityIdList_codec);
      assistMonsterEntityInfo_.WriteTo(output, _repeated_assistMonsterEntityInfo_codec);
      if (SkillIndex != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SkillIndex);
      }
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AttackedByEntityId);
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
      if (CastEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CastEntityId);
      }
      hitTargetEntityIdList_.WriteTo(ref output, _repeated_hitTargetEntityIdList_codec);
      assistMonsterEntityInfo_.WriteTo(ref output, _repeated_assistMonsterEntityInfo_codec);
      if (SkillIndex != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SkillIndex);
      }
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AttackedByEntityId);
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
      size += assistMonsterEntityInfo_.CalculateSize(_repeated_assistMonsterEntityInfo_codec);
      if (AttackedByEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttackedByEntityId);
      }
      size += hitTargetEntityIdList_.CalculateSize(_repeated_hitTargetEntityIdList_codec);
      if (CastEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CastEntityId);
      }
      if (SkillIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartAetherDivideSceneBattleCsReq other) {
      if (other == null) {
        return;
      }
      assistMonsterEntityInfo_.Add(other.assistMonsterEntityInfo_);
      if (other.AttackedByEntityId != 0) {
        AttackedByEntityId = other.AttackedByEntityId;
      }
      hitTargetEntityIdList_.Add(other.hitTargetEntityIdList_);
      if (other.CastEntityId != 0) {
        CastEntityId = other.CastEntityId;
      }
      if (other.SkillIndex != 0) {
        SkillIndex = other.SkillIndex;
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
          case 24: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            hitTargetEntityIdList_.AddEntriesFrom(input, _repeated_hitTargetEntityIdList_codec);
            break;
          }
          case 50: {
            assistMonsterEntityInfo_.AddEntriesFrom(input, _repeated_assistMonsterEntityInfo_codec);
            break;
          }
          case 56: {
            SkillIndex = input.ReadUInt32();
            break;
          }
          case 72: {
            AttackedByEntityId = input.ReadUInt32();
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
          case 24: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            hitTargetEntityIdList_.AddEntriesFrom(ref input, _repeated_hitTargetEntityIdList_codec);
            break;
          }
          case 50: {
            assistMonsterEntityInfo_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityInfo_codec);
            break;
          }
          case 56: {
            SkillIndex = input.ReadUInt32();
            break;
          }
          case 72: {
            AttackedByEntityId = input.ReadUInt32();
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
