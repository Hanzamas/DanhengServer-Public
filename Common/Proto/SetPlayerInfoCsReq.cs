// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetPlayerInfoCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetPlayerInfoCsReq.proto</summary>
  public static partial class SetPlayerInfoCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SetPlayerInfoCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetPlayerInfoCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTZXRQbGF5ZXJJbmZvQ3NSZXEucHJvdG8aDEdlbmRlci5wcm90byJSChJT",
            "ZXRQbGF5ZXJJbmZvQ3NSZXESEQoJaXNfbW9kaWZ5GAwgASgIEhcKBmdlbmRl",
            "chgOIAEoDjIHLkdlbmRlchIQCghuaWNrbmFtZRgLIAEoCUIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GenderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetPlayerInfoCsReq), global::EggLink.DanhengServer.Proto.SetPlayerInfoCsReq.Parser, new[]{ "IsModify", "Gender", "Nickname" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetPlayerInfoCsReq : pb::IMessage<SetPlayerInfoCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetPlayerInfoCsReq> _parser = new pb::MessageParser<SetPlayerInfoCsReq>(() => new SetPlayerInfoCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetPlayerInfoCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetPlayerInfoCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoCsReq(SetPlayerInfoCsReq other) : this() {
      isModify_ = other.isModify_;
      gender_ = other.gender_;
      nickname_ = other.nickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetPlayerInfoCsReq Clone() {
      return new SetPlayerInfoCsReq(this);
    }

    /// <summary>Field number for the "is_modify" field.</summary>
    public const int IsModifyFieldNumber = 12;
    private bool isModify_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsModify {
      get { return isModify_; }
      set {
        isModify_ = value;
      }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.Gender gender_ = global::EggLink.DanhengServer.Proto.Gender.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.Gender Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 11;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetPlayerInfoCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetPlayerInfoCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsModify != other.IsModify) return false;
      if (Gender != other.Gender) return false;
      if (Nickname != other.Nickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsModify != false) hash ^= IsModify.GetHashCode();
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) hash ^= Gender.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Nickname);
      }
      if (IsModify != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsModify);
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Gender);
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Nickname);
      }
      if (IsModify != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsModify);
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Gender);
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
      if (IsModify != false) {
        size += 1 + 1;
      }
      if (Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Gender);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetPlayerInfoCsReq other) {
      if (other == null) {
        return;
      }
      if (other.IsModify != false) {
        IsModify = other.IsModify;
      }
      if (other.Gender != global::EggLink.DanhengServer.Proto.Gender.None) {
        Gender = other.Gender;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
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
          case 90: {
            Nickname = input.ReadString();
            break;
          }
          case 96: {
            IsModify = input.ReadBool();
            break;
          }
          case 112: {
            Gender = (global::EggLink.DanhengServer.Proto.Gender) input.ReadEnum();
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
          case 90: {
            Nickname = input.ReadString();
            break;
          }
          case 96: {
            IsModify = input.ReadBool();
            break;
          }
          case 112: {
            Gender = (global::EggLink.DanhengServer.Proto.Gender) input.ReadEnum();
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
