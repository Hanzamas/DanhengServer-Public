// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MELPLAHKANG.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MELPLAHKANG.proto</summary>
  public static partial class MELPLAHKANGReflection {

    #region Descriptor
    /// <summary>File descriptor for MELPLAHKANG.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MELPLAHKANGReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNRUxQTEFIS0FORy5wcm90bxoRTkJGREdMTUhDSVAucHJvdG8iWgoLTUVM",
            "UExBSEtBTkcSEwoLS0tOQU1BRU1IQ04YASABKA0SEwoLSENMTE5QSkhQSUwY",
            "AiABKAgSIQoLT0tGSERHQU5EUEgYAyABKAsyDC5OQkZER0xNSENJUEIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NBFDGLMHCIPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MELPLAHKANG), global::EggLink.DanhengServer.Proto.MELPLAHKANG.Parser, new[]{ "KKNAMAEMHCN", "HCLLNPJHPIL", "OKFHDGANDPH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MELPLAHKANG : pb::IMessage<MELPLAHKANG>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MELPLAHKANG> _parser = new pb::MessageParser<MELPLAHKANG>(() => new MELPLAHKANG());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MELPLAHKANG> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MELPLAHKANGReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MELPLAHKANG() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MELPLAHKANG(MELPLAHKANG other) : this() {
      kKNAMAEMHCN_ = other.kKNAMAEMHCN_;
      hCLLNPJHPIL_ = other.hCLLNPJHPIL_;
      oKFHDGANDPH_ = other.oKFHDGANDPH_ != null ? other.oKFHDGANDPH_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MELPLAHKANG Clone() {
      return new MELPLAHKANG(this);
    }

    /// <summary>Field number for the "KKNAMAEMHCN" field.</summary>
    public const int KKNAMAEMHCNFieldNumber = 1;
    private uint kKNAMAEMHCN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KKNAMAEMHCN {
      get { return kKNAMAEMHCN_; }
      set {
        kKNAMAEMHCN_ = value;
      }
    }

    /// <summary>Field number for the "HCLLNPJHPIL" field.</summary>
    public const int HCLLNPJHPILFieldNumber = 2;
    private bool hCLLNPJHPIL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HCLLNPJHPIL {
      get { return hCLLNPJHPIL_; }
      set {
        hCLLNPJHPIL_ = value;
      }
    }

    /// <summary>Field number for the "OKFHDGANDPH" field.</summary>
    public const int OKFHDGANDPHFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.NBFDGLMHCIP oKFHDGANDPH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NBFDGLMHCIP OKFHDGANDPH {
      get { return oKFHDGANDPH_; }
      set {
        oKFHDGANDPH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MELPLAHKANG);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MELPLAHKANG other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KKNAMAEMHCN != other.KKNAMAEMHCN) return false;
      if (HCLLNPJHPIL != other.HCLLNPJHPIL) return false;
      if (!object.Equals(OKFHDGANDPH, other.OKFHDGANDPH)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KKNAMAEMHCN != 0) hash ^= KKNAMAEMHCN.GetHashCode();
      if (HCLLNPJHPIL != false) hash ^= HCLLNPJHPIL.GetHashCode();
      if (oKFHDGANDPH_ != null) hash ^= OKFHDGANDPH.GetHashCode();
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
      if (KKNAMAEMHCN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KKNAMAEMHCN);
      }
      if (HCLLNPJHPIL != false) {
        output.WriteRawTag(16);
        output.WriteBool(HCLLNPJHPIL);
      }
      if (oKFHDGANDPH_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OKFHDGANDPH);
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
      if (KKNAMAEMHCN != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KKNAMAEMHCN);
      }
      if (HCLLNPJHPIL != false) {
        output.WriteRawTag(16);
        output.WriteBool(HCLLNPJHPIL);
      }
      if (oKFHDGANDPH_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OKFHDGANDPH);
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
      if (KKNAMAEMHCN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KKNAMAEMHCN);
      }
      if (HCLLNPJHPIL != false) {
        size += 1 + 1;
      }
      if (oKFHDGANDPH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OKFHDGANDPH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MELPLAHKANG other) {
      if (other == null) {
        return;
      }
      if (other.KKNAMAEMHCN != 0) {
        KKNAMAEMHCN = other.KKNAMAEMHCN;
      }
      if (other.HCLLNPJHPIL != false) {
        HCLLNPJHPIL = other.HCLLNPJHPIL;
      }
      if (other.oKFHDGANDPH_ != null) {
        if (oKFHDGANDPH_ == null) {
          OKFHDGANDPH = new global::EggLink.DanhengServer.Proto.NBFDGLMHCIP();
        }
        OKFHDGANDPH.MergeFrom(other.OKFHDGANDPH);
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
            KKNAMAEMHCN = input.ReadUInt32();
            break;
          }
          case 16: {
            HCLLNPJHPIL = input.ReadBool();
            break;
          }
          case 26: {
            if (oKFHDGANDPH_ == null) {
              OKFHDGANDPH = new global::EggLink.DanhengServer.Proto.NBFDGLMHCIP();
            }
            input.ReadMessage(OKFHDGANDPH);
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
            KKNAMAEMHCN = input.ReadUInt32();
            break;
          }
          case 16: {
            HCLLNPJHPIL = input.ReadBool();
            break;
          }
          case 26: {
            if (oKFHDGANDPH_ == null) {
              OKFHDGANDPH = new global::EggLink.DanhengServer.Proto.NBFDGLMHCIP();
            }
            input.ReadMessage(OKFHDGANDPH);
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
