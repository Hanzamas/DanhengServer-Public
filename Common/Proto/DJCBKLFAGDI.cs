// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DJCBKLFAGDI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DJCBKLFAGDI.proto</summary>
  public static partial class DJCBKLFAGDIReflection {

    #region Descriptor
    /// <summary>File descriptor for DJCBKLFAGDI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DJCBKLFAGDIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFESkNCS0xGQUdESS5wcm90byI3CgtESkNCS0xGQUdESRITCgtGTUlLTVBC",
            "T0JGRxgMIAEoDRITCgtISE1ESk5GRkpCSxgKIAEoCEIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DJCBKLFAGDI), global::EggLink.DanhengServer.Proto.DJCBKLFAGDI.Parser, new[]{ "FMIKMPBOBFG", "HHMDJNFFJBK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DJCBKLFAGDI : pb::IMessage<DJCBKLFAGDI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DJCBKLFAGDI> _parser = new pb::MessageParser<DJCBKLFAGDI>(() => new DJCBKLFAGDI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DJCBKLFAGDI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DJCBKLFAGDIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DJCBKLFAGDI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DJCBKLFAGDI(DJCBKLFAGDI other) : this() {
      fMIKMPBOBFG_ = other.fMIKMPBOBFG_;
      hHMDJNFFJBK_ = other.hHMDJNFFJBK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DJCBKLFAGDI Clone() {
      return new DJCBKLFAGDI(this);
    }

    /// <summary>Field number for the "FMIKMPBOBFG" field.</summary>
    public const int FMIKMPBOBFGFieldNumber = 12;
    private uint fMIKMPBOBFG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FMIKMPBOBFG {
      get { return fMIKMPBOBFG_; }
      set {
        fMIKMPBOBFG_ = value;
      }
    }

    /// <summary>Field number for the "HHMDJNFFJBK" field.</summary>
    public const int HHMDJNFFJBKFieldNumber = 10;
    private bool hHMDJNFFJBK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HHMDJNFFJBK {
      get { return hHMDJNFFJBK_; }
      set {
        hHMDJNFFJBK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DJCBKLFAGDI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DJCBKLFAGDI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FMIKMPBOBFG != other.FMIKMPBOBFG) return false;
      if (HHMDJNFFJBK != other.HHMDJNFFJBK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FMIKMPBOBFG != 0) hash ^= FMIKMPBOBFG.GetHashCode();
      if (HHMDJNFFJBK != false) hash ^= HHMDJNFFJBK.GetHashCode();
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
      if (HHMDJNFFJBK != false) {
        output.WriteRawTag(80);
        output.WriteBool(HHMDJNFFJBK);
      }
      if (FMIKMPBOBFG != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FMIKMPBOBFG);
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
      if (HHMDJNFFJBK != false) {
        output.WriteRawTag(80);
        output.WriteBool(HHMDJNFFJBK);
      }
      if (FMIKMPBOBFG != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FMIKMPBOBFG);
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
      if (FMIKMPBOBFG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FMIKMPBOBFG);
      }
      if (HHMDJNFFJBK != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DJCBKLFAGDI other) {
      if (other == null) {
        return;
      }
      if (other.FMIKMPBOBFG != 0) {
        FMIKMPBOBFG = other.FMIKMPBOBFG;
      }
      if (other.HHMDJNFFJBK != false) {
        HHMDJNFFJBK = other.HHMDJNFFJBK;
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
          case 80: {
            HHMDJNFFJBK = input.ReadBool();
            break;
          }
          case 96: {
            FMIKMPBOBFG = input.ReadUInt32();
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
          case 80: {
            HHMDJNFFJBK = input.ReadBool();
            break;
          }
          case 96: {
            FMIKMPBOBFG = input.ReadUInt32();
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
