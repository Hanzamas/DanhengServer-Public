// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TravelBrochureApplyPasterListCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TravelBrochureApplyPasterListCsReq.proto</summary>
  public static partial class TravelBrochureApplyPasterListCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TravelBrochureApplyPasterListCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TravelBrochureApplyPasterListCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVyTGlzdENzUmVxLnByb3RvGhFL",
            "SkRETUFHREZJSC5wcm90byJZCiJUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVy",
            "TGlzdENzUmVxEiEKC0VOSENBQ0tORE9FGA8gAygLMgwuS0pERE1BR0RGSUgS",
            "EAoIZGlhcnlfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KJDDMAGDFIHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureApplyPasterListCsReq), global::EggLink.DanhengServer.Proto.TravelBrochureApplyPasterListCsReq.Parser, new[]{ "ENHCACKNDOE", "DiaryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TravelBrochureApplyPasterListCsReq : pb::IMessage<TravelBrochureApplyPasterListCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TravelBrochureApplyPasterListCsReq> _parser = new pb::MessageParser<TravelBrochureApplyPasterListCsReq>(() => new TravelBrochureApplyPasterListCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TravelBrochureApplyPasterListCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TravelBrochureApplyPasterListCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureApplyPasterListCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureApplyPasterListCsReq(TravelBrochureApplyPasterListCsReq other) : this() {
      eNHCACKNDOE_ = other.eNHCACKNDOE_.Clone();
      diaryId_ = other.diaryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureApplyPasterListCsReq Clone() {
      return new TravelBrochureApplyPasterListCsReq(this);
    }

    /// <summary>Field number for the "ENHCACKNDOE" field.</summary>
    public const int ENHCACKNDOEFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.KJDDMAGDFIH> _repeated_eNHCACKNDOE_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.KJDDMAGDFIH.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJDDMAGDFIH> eNHCACKNDOE_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJDDMAGDFIH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KJDDMAGDFIH> ENHCACKNDOE {
      get { return eNHCACKNDOE_; }
    }

    /// <summary>Field number for the "diary_id" field.</summary>
    public const int DiaryIdFieldNumber = 5;
    private uint diaryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiaryId {
      get { return diaryId_; }
      set {
        diaryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TravelBrochureApplyPasterListCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TravelBrochureApplyPasterListCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!eNHCACKNDOE_.Equals(other.eNHCACKNDOE_)) return false;
      if (DiaryId != other.DiaryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= eNHCACKNDOE_.GetHashCode();
      if (DiaryId != 0) hash ^= DiaryId.GetHashCode();
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
      if (DiaryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DiaryId);
      }
      eNHCACKNDOE_.WriteTo(output, _repeated_eNHCACKNDOE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (DiaryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DiaryId);
      }
      eNHCACKNDOE_.WriteTo(ref output, _repeated_eNHCACKNDOE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += eNHCACKNDOE_.CalculateSize(_repeated_eNHCACKNDOE_codec);
      if (DiaryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiaryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TravelBrochureApplyPasterListCsReq other) {
      if (other == null) {
        return;
      }
      eNHCACKNDOE_.Add(other.eNHCACKNDOE_);
      if (other.DiaryId != 0) {
        DiaryId = other.DiaryId;
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
            DiaryId = input.ReadUInt32();
            break;
          }
          case 122: {
            eNHCACKNDOE_.AddEntriesFrom(input, _repeated_eNHCACKNDOE_codec);
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
            DiaryId = input.ReadUInt32();
            break;
          }
          case 122: {
            eNHCACKNDOE_.AddEntriesFrom(ref input, _repeated_eNHCACKNDOE_codec);
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
