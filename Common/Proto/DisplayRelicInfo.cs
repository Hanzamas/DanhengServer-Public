// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DisplayRelicInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DisplayRelicInfo.proto</summary>
  public static partial class DisplayRelicInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DisplayRelicInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayRelicInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZEaXNwbGF5UmVsaWNJbmZvLnByb3RvGhBSZWxpY0FmZml4LnByb3RvIoUB",
            "ChBEaXNwbGF5UmVsaWNJbmZvEgsKA3RpZBgIIAEoDRIVCg1tYWluX2FmZml4",
            "X2lkGAYgASgNEg0KBWxldmVsGA8gASgNEgsKA2V4cBgBIAEoDRIMCgR0eXBl",
            "GAIgASgNEiMKDnN1Yl9hZmZpeF9saXN0GA4gAygLMgsuUmVsaWNBZmZpeEIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RelicAffixReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DisplayRelicInfo), global::EggLink.DanhengServer.Proto.DisplayRelicInfo.Parser, new[]{ "Tid", "MainAffixId", "Level", "Exp", "Type", "SubAffixList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DisplayRelicInfo : pb::IMessage<DisplayRelicInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DisplayRelicInfo> _parser = new pb::MessageParser<DisplayRelicInfo>(() => new DisplayRelicInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DisplayRelicInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DisplayRelicInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRelicInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRelicInfo(DisplayRelicInfo other) : this() {
      tid_ = other.tid_;
      mainAffixId_ = other.mainAffixId_;
      level_ = other.level_;
      exp_ = other.exp_;
      type_ = other.type_;
      subAffixList_ = other.subAffixList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayRelicInfo Clone() {
      return new DisplayRelicInfo(this);
    }

    /// <summary>Field number for the "tid" field.</summary>
    public const int TidFieldNumber = 8;
    private uint tid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tid {
      get { return tid_; }
      set {
        tid_ = value;
      }
    }

    /// <summary>Field number for the "main_affix_id" field.</summary>
    public const int MainAffixIdFieldNumber = 6;
    private uint mainAffixId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainAffixId {
      get { return mainAffixId_; }
      set {
        mainAffixId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 15;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 1;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private uint type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "sub_affix_list" field.</summary>
    public const int SubAffixListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RelicAffix> _repeated_subAffixList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.RelicAffix.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RelicAffix> subAffixList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RelicAffix>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RelicAffix> SubAffixList {
      get { return subAffixList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DisplayRelicInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DisplayRelicInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Tid != other.Tid) return false;
      if (MainAffixId != other.MainAffixId) return false;
      if (Level != other.Level) return false;
      if (Exp != other.Exp) return false;
      if (Type != other.Type) return false;
      if(!subAffixList_.Equals(other.subAffixList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Tid != 0) hash ^= Tid.GetHashCode();
      if (MainAffixId != 0) hash ^= MainAffixId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      hash ^= subAffixList_.GetHashCode();
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Type);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MainAffixId);
      }
      if (Tid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Tid);
      }
      subAffixList_.WriteTo(output, _repeated_subAffixList_codec);
      if (Level != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Level);
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Type);
      }
      if (MainAffixId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MainAffixId);
      }
      if (Tid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Tid);
      }
      subAffixList_.WriteTo(ref output, _repeated_subAffixList_codec);
      if (Level != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Level);
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
      if (Tid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tid);
      }
      if (MainAffixId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainAffixId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      size += subAffixList_.CalculateSize(_repeated_subAffixList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DisplayRelicInfo other) {
      if (other == null) {
        return;
      }
      if (other.Tid != 0) {
        Tid = other.Tid;
      }
      if (other.MainAffixId != 0) {
        MainAffixId = other.MainAffixId;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      subAffixList_.Add(other.subAffixList_);
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            Type = input.ReadUInt32();
            break;
          }
          case 48: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 64: {
            Tid = input.ReadUInt32();
            break;
          }
          case 114: {
            subAffixList_.AddEntriesFrom(input, _repeated_subAffixList_codec);
            break;
          }
          case 120: {
            Level = input.ReadUInt32();
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            Type = input.ReadUInt32();
            break;
          }
          case 48: {
            MainAffixId = input.ReadUInt32();
            break;
          }
          case 64: {
            Tid = input.ReadUInt32();
            break;
          }
          case 114: {
            subAffixList_.AddEntriesFrom(ref input, _repeated_subAffixList_codec);
            break;
          }
          case 120: {
            Level = input.ReadUInt32();
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
