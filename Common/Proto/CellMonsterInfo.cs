// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CellMonsterInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CellMonsterInfo.proto</summary>
  public static partial class CellMonsterInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CellMonsterInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CellMonsterInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDZWxsTW9uc3RlckluZm8ucHJvdG8aEUNlbGxNb25zdGVyLnByb3RvIl4K",
            "D0NlbGxNb25zdGVySW5mbxIWCg5zZWxlY3RfYm9zc19pZBgNIAEoDRIPCgdp",
            "c19kb25lGAggASgIEiIKDG1vbnN0ZXJfbGlzdBgGIAMoCzIMLkNlbGxNb25z",
            "dGVyQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CellMonsterReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CellMonsterInfo), global::EggLink.DanhengServer.Proto.CellMonsterInfo.Parser, new[]{ "SelectBossId", "IsDone", "MonsterList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CellMonsterInfo : pb::IMessage<CellMonsterInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CellMonsterInfo> _parser = new pb::MessageParser<CellMonsterInfo>(() => new CellMonsterInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CellMonsterInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CellMonsterInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellMonsterInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellMonsterInfo(CellMonsterInfo other) : this() {
      selectBossId_ = other.selectBossId_;
      isDone_ = other.isDone_;
      monsterList_ = other.monsterList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CellMonsterInfo Clone() {
      return new CellMonsterInfo(this);
    }

    /// <summary>Field number for the "select_boss_id" field.</summary>
    public const int SelectBossIdFieldNumber = 13;
    private uint selectBossId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectBossId {
      get { return selectBossId_; }
      set {
        selectBossId_ = value;
      }
    }

    /// <summary>Field number for the "is_done" field.</summary>
    public const int IsDoneFieldNumber = 8;
    private bool isDone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDone {
      get { return isDone_; }
      set {
        isDone_ = value;
      }
    }

    /// <summary>Field number for the "monster_list" field.</summary>
    public const int MonsterListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CellMonster> _repeated_monsterList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.CellMonster.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CellMonster> monsterList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CellMonster>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CellMonster> MonsterList {
      get { return monsterList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CellMonsterInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CellMonsterInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SelectBossId != other.SelectBossId) return false;
      if (IsDone != other.IsDone) return false;
      if(!monsterList_.Equals(other.monsterList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SelectBossId != 0) hash ^= SelectBossId.GetHashCode();
      if (IsDone != false) hash ^= IsDone.GetHashCode();
      hash ^= monsterList_.GetHashCode();
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
      monsterList_.WriteTo(output, _repeated_monsterList_codec);
      if (IsDone != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsDone);
      }
      if (SelectBossId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SelectBossId);
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
      monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
      if (IsDone != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsDone);
      }
      if (SelectBossId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SelectBossId);
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
      if (SelectBossId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectBossId);
      }
      if (IsDone != false) {
        size += 1 + 1;
      }
      size += monsterList_.CalculateSize(_repeated_monsterList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CellMonsterInfo other) {
      if (other == null) {
        return;
      }
      if (other.SelectBossId != 0) {
        SelectBossId = other.SelectBossId;
      }
      if (other.IsDone != false) {
        IsDone = other.IsDone;
      }
      monsterList_.Add(other.monsterList_);
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
          case 50: {
            monsterList_.AddEntriesFrom(input, _repeated_monsterList_codec);
            break;
          }
          case 64: {
            IsDone = input.ReadBool();
            break;
          }
          case 104: {
            SelectBossId = input.ReadUInt32();
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
          case 50: {
            monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
            break;
          }
          case 64: {
            IsDone = input.ReadBool();
            break;
          }
          case 104: {
            SelectBossId = input.ReadUInt32();
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
