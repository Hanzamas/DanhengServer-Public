// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionDataChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ExpeditionDataChangeScNotify.proto</summary>
  public static partial class ExpeditionDataChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ExpeditionDataChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpeditionDataChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJFeHBlZGl0aW9uRGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhFLS01DTUFG",
            "TENMRi5wcm90bxoYQWN0aXZpdHlFeHBlZGl0aW9uLnByb3RvIqoBChxFeHBl",
            "ZGl0aW9uRGF0YUNoYW5nZVNjTm90aWZ5EhMKC0lOTUlKSkdIS0VPGAsgASgN",
            "EhMKC0tFS05LR0NETk5EGAUgAygNEhMKC09QTUtGTkdHR0FOGAQgAygNEigK",
            "C05QS0NNTUxCSktEGAEgAygLMhMuQWN0aXZpdHlFeHBlZGl0aW9uEiEKC0lM",
            "RUtGUExGTURDGAkgAygLMgwuS0tNQ01BRkxDTEZCHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KKMCMAFLCLFReflection.Descriptor, global::EggLink.DanhengServer.Proto.ActivityExpeditionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ExpeditionDataChangeScNotify), global::EggLink.DanhengServer.Proto.ExpeditionDataChangeScNotify.Parser, new[]{ "INMIJJGHKEO", "KEKNKGCDNND", "OPMKFNGGGAN", "NPKCMMLBJKD", "ILEKFPLFMDC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExpeditionDataChangeScNotify : pb::IMessage<ExpeditionDataChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExpeditionDataChangeScNotify> _parser = new pb::MessageParser<ExpeditionDataChangeScNotify>(() => new ExpeditionDataChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExpeditionDataChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ExpeditionDataChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionDataChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionDataChangeScNotify(ExpeditionDataChangeScNotify other) : this() {
      iNMIJJGHKEO_ = other.iNMIJJGHKEO_;
      kEKNKGCDNND_ = other.kEKNKGCDNND_.Clone();
      oPMKFNGGGAN_ = other.oPMKFNGGGAN_.Clone();
      nPKCMMLBJKD_ = other.nPKCMMLBJKD_.Clone();
      iLEKFPLFMDC_ = other.iLEKFPLFMDC_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionDataChangeScNotify Clone() {
      return new ExpeditionDataChangeScNotify(this);
    }

    /// <summary>Field number for the "INMIJJGHKEO" field.</summary>
    public const int INMIJJGHKEOFieldNumber = 11;
    private uint iNMIJJGHKEO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint INMIJJGHKEO {
      get { return iNMIJJGHKEO_; }
      set {
        iNMIJJGHKEO_ = value;
      }
    }

    /// <summary>Field number for the "KEKNKGCDNND" field.</summary>
    public const int KEKNKGCDNNDFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_kEKNKGCDNND_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> kEKNKGCDNND_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KEKNKGCDNND {
      get { return kEKNKGCDNND_; }
    }

    /// <summary>Field number for the "OPMKFNGGGAN" field.</summary>
    public const int OPMKFNGGGANFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_oPMKFNGGGAN_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> oPMKFNGGGAN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OPMKFNGGGAN {
      get { return oPMKFNGGGAN_; }
    }

    /// <summary>Field number for the "NPKCMMLBJKD" field.</summary>
    public const int NPKCMMLBJKDFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ActivityExpedition> _repeated_nPKCMMLBJKD_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.ActivityExpedition.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ActivityExpedition> nPKCMMLBJKD_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ActivityExpedition>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ActivityExpedition> NPKCMMLBJKD {
      get { return nPKCMMLBJKD_; }
    }

    /// <summary>Field number for the "ILEKFPLFMDC" field.</summary>
    public const int ILEKFPLFMDCFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.KKMCMAFLCLF> _repeated_iLEKFPLFMDC_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.KKMCMAFLCLF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KKMCMAFLCLF> iLEKFPLFMDC_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KKMCMAFLCLF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KKMCMAFLCLF> ILEKFPLFMDC {
      get { return iLEKFPLFMDC_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExpeditionDataChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExpeditionDataChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (INMIJJGHKEO != other.INMIJJGHKEO) return false;
      if(!kEKNKGCDNND_.Equals(other.kEKNKGCDNND_)) return false;
      if(!oPMKFNGGGAN_.Equals(other.oPMKFNGGGAN_)) return false;
      if(!nPKCMMLBJKD_.Equals(other.nPKCMMLBJKD_)) return false;
      if(!iLEKFPLFMDC_.Equals(other.iLEKFPLFMDC_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (INMIJJGHKEO != 0) hash ^= INMIJJGHKEO.GetHashCode();
      hash ^= kEKNKGCDNND_.GetHashCode();
      hash ^= oPMKFNGGGAN_.GetHashCode();
      hash ^= nPKCMMLBJKD_.GetHashCode();
      hash ^= iLEKFPLFMDC_.GetHashCode();
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
      nPKCMMLBJKD_.WriteTo(output, _repeated_nPKCMMLBJKD_codec);
      oPMKFNGGGAN_.WriteTo(output, _repeated_oPMKFNGGGAN_codec);
      kEKNKGCDNND_.WriteTo(output, _repeated_kEKNKGCDNND_codec);
      iLEKFPLFMDC_.WriteTo(output, _repeated_iLEKFPLFMDC_codec);
      if (INMIJJGHKEO != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(INMIJJGHKEO);
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
      nPKCMMLBJKD_.WriteTo(ref output, _repeated_nPKCMMLBJKD_codec);
      oPMKFNGGGAN_.WriteTo(ref output, _repeated_oPMKFNGGGAN_codec);
      kEKNKGCDNND_.WriteTo(ref output, _repeated_kEKNKGCDNND_codec);
      iLEKFPLFMDC_.WriteTo(ref output, _repeated_iLEKFPLFMDC_codec);
      if (INMIJJGHKEO != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(INMIJJGHKEO);
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
      if (INMIJJGHKEO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(INMIJJGHKEO);
      }
      size += kEKNKGCDNND_.CalculateSize(_repeated_kEKNKGCDNND_codec);
      size += oPMKFNGGGAN_.CalculateSize(_repeated_oPMKFNGGGAN_codec);
      size += nPKCMMLBJKD_.CalculateSize(_repeated_nPKCMMLBJKD_codec);
      size += iLEKFPLFMDC_.CalculateSize(_repeated_iLEKFPLFMDC_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExpeditionDataChangeScNotify other) {
      if (other == null) {
        return;
      }
      if (other.INMIJJGHKEO != 0) {
        INMIJJGHKEO = other.INMIJJGHKEO;
      }
      kEKNKGCDNND_.Add(other.kEKNKGCDNND_);
      oPMKFNGGGAN_.Add(other.oPMKFNGGGAN_);
      nPKCMMLBJKD_.Add(other.nPKCMMLBJKD_);
      iLEKFPLFMDC_.Add(other.iLEKFPLFMDC_);
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
            nPKCMMLBJKD_.AddEntriesFrom(input, _repeated_nPKCMMLBJKD_codec);
            break;
          }
          case 34:
          case 32: {
            oPMKFNGGGAN_.AddEntriesFrom(input, _repeated_oPMKFNGGGAN_codec);
            break;
          }
          case 42:
          case 40: {
            kEKNKGCDNND_.AddEntriesFrom(input, _repeated_kEKNKGCDNND_codec);
            break;
          }
          case 74: {
            iLEKFPLFMDC_.AddEntriesFrom(input, _repeated_iLEKFPLFMDC_codec);
            break;
          }
          case 88: {
            INMIJJGHKEO = input.ReadUInt32();
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
            nPKCMMLBJKD_.AddEntriesFrom(ref input, _repeated_nPKCMMLBJKD_codec);
            break;
          }
          case 34:
          case 32: {
            oPMKFNGGGAN_.AddEntriesFrom(ref input, _repeated_oPMKFNGGGAN_codec);
            break;
          }
          case 42:
          case 40: {
            kEKNKGCDNND_.AddEntriesFrom(ref input, _repeated_kEKNKGCDNND_codec);
            break;
          }
          case 74: {
            iLEKFPLFMDC_.AddEntriesFrom(ref input, _repeated_iLEKFPLFMDC_codec);
            break;
          }
          case 88: {
            INMIJJGHKEO = input.ReadUInt32();
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
