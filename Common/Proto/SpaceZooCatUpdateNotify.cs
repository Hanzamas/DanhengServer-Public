// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooCatUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooCatUpdateNotify.proto</summary>
  public static partial class SpaceZooCatUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooCatUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooCatUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TcGFjZVpvb0NhdFVwZGF0ZU5vdGlmeS5wcm90bxoRTUpOQkdGSUhKQk4u",
            "cHJvdG8iZgoXU3BhY2Vab29DYXRVcGRhdGVOb3RpZnkSEwoLTEZPR0JDR0VE",
            "Qk0YBSABKAgSIQoLT01EREhERkVOTUwYDyADKAsyDC5NSk5CR0ZJSEpCThIT",
            "CgtGTUVHRUxHTU9LShgKIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MJNBGFIHJBNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooCatUpdateNotify), global::EggLink.DanhengServer.Proto.SpaceZooCatUpdateNotify.Parser, new[]{ "LFOGBCGEDBM", "OMDDHDFENML", "FMEGELGMOKJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooCatUpdateNotify : pb::IMessage<SpaceZooCatUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooCatUpdateNotify> _parser = new pb::MessageParser<SpaceZooCatUpdateNotify>(() => new SpaceZooCatUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooCatUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooCatUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooCatUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooCatUpdateNotify(SpaceZooCatUpdateNotify other) : this() {
      lFOGBCGEDBM_ = other.lFOGBCGEDBM_;
      oMDDHDFENML_ = other.oMDDHDFENML_.Clone();
      fMEGELGMOKJ_ = other.fMEGELGMOKJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooCatUpdateNotify Clone() {
      return new SpaceZooCatUpdateNotify(this);
    }

    /// <summary>Field number for the "LFOGBCGEDBM" field.</summary>
    public const int LFOGBCGEDBMFieldNumber = 5;
    private bool lFOGBCGEDBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LFOGBCGEDBM {
      get { return lFOGBCGEDBM_; }
      set {
        lFOGBCGEDBM_ = value;
      }
    }

    /// <summary>Field number for the "OMDDHDFENML" field.</summary>
    public const int OMDDHDFENMLFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN> _repeated_oMDDHDFENML_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.MJNBGFIHJBN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN> oMDDHDFENML_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN> OMDDHDFENML {
      get { return oMDDHDFENML_; }
    }

    /// <summary>Field number for the "FMEGELGMOKJ" field.</summary>
    public const int FMEGELGMOKJFieldNumber = 10;
    private bool fMEGELGMOKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FMEGELGMOKJ {
      get { return fMEGELGMOKJ_; }
      set {
        fMEGELGMOKJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooCatUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooCatUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LFOGBCGEDBM != other.LFOGBCGEDBM) return false;
      if(!oMDDHDFENML_.Equals(other.oMDDHDFENML_)) return false;
      if (FMEGELGMOKJ != other.FMEGELGMOKJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LFOGBCGEDBM != false) hash ^= LFOGBCGEDBM.GetHashCode();
      hash ^= oMDDHDFENML_.GetHashCode();
      if (FMEGELGMOKJ != false) hash ^= FMEGELGMOKJ.GetHashCode();
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
      if (LFOGBCGEDBM != false) {
        output.WriteRawTag(40);
        output.WriteBool(LFOGBCGEDBM);
      }
      if (FMEGELGMOKJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(FMEGELGMOKJ);
      }
      oMDDHDFENML_.WriteTo(output, _repeated_oMDDHDFENML_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LFOGBCGEDBM != false) {
        output.WriteRawTag(40);
        output.WriteBool(LFOGBCGEDBM);
      }
      if (FMEGELGMOKJ != false) {
        output.WriteRawTag(80);
        output.WriteBool(FMEGELGMOKJ);
      }
      oMDDHDFENML_.WriteTo(ref output, _repeated_oMDDHDFENML_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LFOGBCGEDBM != false) {
        size += 1 + 1;
      }
      size += oMDDHDFENML_.CalculateSize(_repeated_oMDDHDFENML_codec);
      if (FMEGELGMOKJ != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooCatUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.LFOGBCGEDBM != false) {
        LFOGBCGEDBM = other.LFOGBCGEDBM;
      }
      oMDDHDFENML_.Add(other.oMDDHDFENML_);
      if (other.FMEGELGMOKJ != false) {
        FMEGELGMOKJ = other.FMEGELGMOKJ;
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
            LFOGBCGEDBM = input.ReadBool();
            break;
          }
          case 80: {
            FMEGELGMOKJ = input.ReadBool();
            break;
          }
          case 122: {
            oMDDHDFENML_.AddEntriesFrom(input, _repeated_oMDDHDFENML_codec);
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
            LFOGBCGEDBM = input.ReadBool();
            break;
          }
          case 80: {
            FMEGELGMOKJ = input.ReadBool();
            break;
          }
          case 122: {
            oMDDHDFENML_.AddEntriesFrom(ref input, _repeated_oMDDHDFENML_codec);
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
