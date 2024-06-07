// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpringRecoverConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpringRecoverConfig.proto</summary>
  public static partial class SpringRecoverConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for SpringRecoverConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpringRecoverConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTcHJpbmdSZWNvdmVyQ29uZmlnLnByb3RvGhRBdmF0YXJQcmVzZXRIcC5w",
            "cm90byJyChNTcHJpbmdSZWNvdmVyQ29uZmlnEhIKCmRlZmF1bHRfaHAYAyAB",
            "KA0SLgoVYXZhdGFyX3ByZXNldF9ocF9saXN0GAsgAygLMg8uQXZhdGFyUHJl",
            "c2V0SHASFwoPYXV0b19yZWNvdmVyX2hwGA4gASgIQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarPresetHpReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpringRecoverConfig), global::EggLink.DanhengServer.Proto.SpringRecoverConfig.Parser, new[]{ "DefaultHp", "AvatarPresetHpList", "AutoRecoverHp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpringRecoverConfig : pb::IMessage<SpringRecoverConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpringRecoverConfig> _parser = new pb::MessageParser<SpringRecoverConfig>(() => new SpringRecoverConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpringRecoverConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpringRecoverConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpringRecoverConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpringRecoverConfig(SpringRecoverConfig other) : this() {
      defaultHp_ = other.defaultHp_;
      avatarPresetHpList_ = other.avatarPresetHpList_.Clone();
      autoRecoverHp_ = other.autoRecoverHp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpringRecoverConfig Clone() {
      return new SpringRecoverConfig(this);
    }

    /// <summary>Field number for the "default_hp" field.</summary>
    public const int DefaultHpFieldNumber = 3;
    private uint defaultHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DefaultHp {
      get { return defaultHp_; }
      set {
        defaultHp_ = value;
      }
    }

    /// <summary>Field number for the "avatar_preset_hp_list" field.</summary>
    public const int AvatarPresetHpListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AvatarPresetHp> _repeated_avatarPresetHpList_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.AvatarPresetHp.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarPresetHp> avatarPresetHpList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarPresetHp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarPresetHp> AvatarPresetHpList {
      get { return avatarPresetHpList_; }
    }

    /// <summary>Field number for the "auto_recover_hp" field.</summary>
    public const int AutoRecoverHpFieldNumber = 14;
    private bool autoRecoverHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AutoRecoverHp {
      get { return autoRecoverHp_; }
      set {
        autoRecoverHp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpringRecoverConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpringRecoverConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DefaultHp != other.DefaultHp) return false;
      if(!avatarPresetHpList_.Equals(other.avatarPresetHpList_)) return false;
      if (AutoRecoverHp != other.AutoRecoverHp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DefaultHp != 0) hash ^= DefaultHp.GetHashCode();
      hash ^= avatarPresetHpList_.GetHashCode();
      if (AutoRecoverHp != false) hash ^= AutoRecoverHp.GetHashCode();
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
      if (DefaultHp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DefaultHp);
      }
      avatarPresetHpList_.WriteTo(output, _repeated_avatarPresetHpList_codec);
      if (AutoRecoverHp != false) {
        output.WriteRawTag(112);
        output.WriteBool(AutoRecoverHp);
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
      if (DefaultHp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DefaultHp);
      }
      avatarPresetHpList_.WriteTo(ref output, _repeated_avatarPresetHpList_codec);
      if (AutoRecoverHp != false) {
        output.WriteRawTag(112);
        output.WriteBool(AutoRecoverHp);
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
      if (DefaultHp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DefaultHp);
      }
      size += avatarPresetHpList_.CalculateSize(_repeated_avatarPresetHpList_codec);
      if (AutoRecoverHp != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpringRecoverConfig other) {
      if (other == null) {
        return;
      }
      if (other.DefaultHp != 0) {
        DefaultHp = other.DefaultHp;
      }
      avatarPresetHpList_.Add(other.avatarPresetHpList_);
      if (other.AutoRecoverHp != false) {
        AutoRecoverHp = other.AutoRecoverHp;
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
            DefaultHp = input.ReadUInt32();
            break;
          }
          case 90: {
            avatarPresetHpList_.AddEntriesFrom(input, _repeated_avatarPresetHpList_codec);
            break;
          }
          case 112: {
            AutoRecoverHp = input.ReadBool();
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
            DefaultHp = input.ReadUInt32();
            break;
          }
          case 90: {
            avatarPresetHpList_.AddEntriesFrom(ref input, _repeated_avatarPresetHpList_codec);
            break;
          }
          case 112: {
            AutoRecoverHp = input.ReadBool();
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
