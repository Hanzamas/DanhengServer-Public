// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CJCANMDEBFC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CJCANMDEBFC.proto</summary>
  public static partial class CJCANMDEBFCReflection {

    #region Descriptor
    /// <summary>File descriptor for CJCANMDEBFC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CJCANMDEBFCReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDSkNBTk1ERUJGQy5wcm90bxoZUm9ndWVEaWFsb2d1ZVJlc3VsdC5wcm90",
            "bxoOSXRlbUxpc3QucHJvdG8ifgoLQ0pDQU5NREVCRkMSEwoLRkRBQ0xCTktQ",
            "TUoYCiADKA0SKQoLQkFISVBHTkNGSk8YAiABKA4yFC5Sb2d1ZURpYWxvZ3Vl",
            "UmVzdWx0EiAKC0xCSExNTEFISE1FGA0gASgLMgkuSXRlbUxpc3RIAEINCgtP",
            "Tk5NSkRGTERJSkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueDialogueResultReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CJCANMDEBFC), global::EggLink.DanhengServer.Proto.CJCANMDEBFC.Parser, new[]{ "FDACLBNKPMJ", "BAHIPGNCFJO", "LBHLMLAHHME" }, new[]{ "ONNMJDFLDIJ" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CJCANMDEBFC : pb::IMessage<CJCANMDEBFC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CJCANMDEBFC> _parser = new pb::MessageParser<CJCANMDEBFC>(() => new CJCANMDEBFC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CJCANMDEBFC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CJCANMDEBFCReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CJCANMDEBFC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CJCANMDEBFC(CJCANMDEBFC other) : this() {
      fDACLBNKPMJ_ = other.fDACLBNKPMJ_.Clone();
      bAHIPGNCFJO_ = other.bAHIPGNCFJO_;
      switch (other.ONNMJDFLDIJCase) {
        case ONNMJDFLDIJOneofCase.LBHLMLAHHME:
          LBHLMLAHHME = other.LBHLMLAHHME.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CJCANMDEBFC Clone() {
      return new CJCANMDEBFC(this);
    }

    /// <summary>Field number for the "FDACLBNKPMJ" field.</summary>
    public const int FDACLBNKPMJFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_fDACLBNKPMJ_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> fDACLBNKPMJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FDACLBNKPMJ {
      get { return fDACLBNKPMJ_; }
    }

    /// <summary>Field number for the "BAHIPGNCFJO" field.</summary>
    public const int BAHIPGNCFJOFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueDialogueResult bAHIPGNCFJO_ = global::EggLink.DanhengServer.Proto.RogueDialogueResult.Succ;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDialogueResult BAHIPGNCFJO {
      get { return bAHIPGNCFJO_; }
      set {
        bAHIPGNCFJO_ = value;
      }
    }

    /// <summary>Field number for the "LBHLMLAHHME" field.</summary>
    public const int LBHLMLAHHMEFieldNumber = 13;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList LBHLMLAHHME {
      get { return oNNMJDFLDIJCase_ == ONNMJDFLDIJOneofCase.LBHLMLAHHME ? (global::EggLink.DanhengServer.Proto.ItemList) oNNMJDFLDIJ_ : null; }
      set {
        oNNMJDFLDIJ_ = value;
        oNNMJDFLDIJCase_ = value == null ? ONNMJDFLDIJOneofCase.None : ONNMJDFLDIJOneofCase.LBHLMLAHHME;
      }
    }

    private object oNNMJDFLDIJ_;
    /// <summary>Enum of possible cases for the "ONNMJDFLDIJ" oneof.</summary>
    public enum ONNMJDFLDIJOneofCase {
      None = 0,
      LBHLMLAHHME = 13,
    }
    private ONNMJDFLDIJOneofCase oNNMJDFLDIJCase_ = ONNMJDFLDIJOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ONNMJDFLDIJOneofCase ONNMJDFLDIJCase {
      get { return oNNMJDFLDIJCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearONNMJDFLDIJ() {
      oNNMJDFLDIJCase_ = ONNMJDFLDIJOneofCase.None;
      oNNMJDFLDIJ_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CJCANMDEBFC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CJCANMDEBFC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!fDACLBNKPMJ_.Equals(other.fDACLBNKPMJ_)) return false;
      if (BAHIPGNCFJO != other.BAHIPGNCFJO) return false;
      if (!object.Equals(LBHLMLAHHME, other.LBHLMLAHHME)) return false;
      if (ONNMJDFLDIJCase != other.ONNMJDFLDIJCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fDACLBNKPMJ_.GetHashCode();
      if (BAHIPGNCFJO != global::EggLink.DanhengServer.Proto.RogueDialogueResult.Succ) hash ^= BAHIPGNCFJO.GetHashCode();
      if (oNNMJDFLDIJCase_ == ONNMJDFLDIJOneofCase.LBHLMLAHHME) hash ^= LBHLMLAHHME.GetHashCode();
      hash ^= (int) oNNMJDFLDIJCase_;
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
      if (BAHIPGNCFJO != global::EggLink.DanhengServer.Proto.RogueDialogueResult.Succ) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BAHIPGNCFJO);
      }
      fDACLBNKPMJ_.WriteTo(output, _repeated_fDACLBNKPMJ_codec);
      if (oNNMJDFLDIJCase_ == ONNMJDFLDIJOneofCase.LBHLMLAHHME) {
        output.WriteRawTag(106);
        output.WriteMessage(LBHLMLAHHME);
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
      if (BAHIPGNCFJO != global::EggLink.DanhengServer.Proto.RogueDialogueResult.Succ) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BAHIPGNCFJO);
      }
      fDACLBNKPMJ_.WriteTo(ref output, _repeated_fDACLBNKPMJ_codec);
      if (oNNMJDFLDIJCase_ == ONNMJDFLDIJOneofCase.LBHLMLAHHME) {
        output.WriteRawTag(106);
        output.WriteMessage(LBHLMLAHHME);
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
      size += fDACLBNKPMJ_.CalculateSize(_repeated_fDACLBNKPMJ_codec);
      if (BAHIPGNCFJO != global::EggLink.DanhengServer.Proto.RogueDialogueResult.Succ) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BAHIPGNCFJO);
      }
      if (oNNMJDFLDIJCase_ == ONNMJDFLDIJOneofCase.LBHLMLAHHME) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LBHLMLAHHME);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CJCANMDEBFC other) {
      if (other == null) {
        return;
      }
      fDACLBNKPMJ_.Add(other.fDACLBNKPMJ_);
      if (other.BAHIPGNCFJO != global::EggLink.DanhengServer.Proto.RogueDialogueResult.Succ) {
        BAHIPGNCFJO = other.BAHIPGNCFJO;
      }
      switch (other.ONNMJDFLDIJCase) {
        case ONNMJDFLDIJOneofCase.LBHLMLAHHME:
          if (LBHLMLAHHME == null) {
            LBHLMLAHHME = new global::EggLink.DanhengServer.Proto.ItemList();
          }
          LBHLMLAHHME.MergeFrom(other.LBHLMLAHHME);
          break;
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
          case 16: {
            BAHIPGNCFJO = (global::EggLink.DanhengServer.Proto.RogueDialogueResult) input.ReadEnum();
            break;
          }
          case 82:
          case 80: {
            fDACLBNKPMJ_.AddEntriesFrom(input, _repeated_fDACLBNKPMJ_codec);
            break;
          }
          case 106: {
            global::EggLink.DanhengServer.Proto.ItemList subBuilder = new global::EggLink.DanhengServer.Proto.ItemList();
            if (oNNMJDFLDIJCase_ == ONNMJDFLDIJOneofCase.LBHLMLAHHME) {
              subBuilder.MergeFrom(LBHLMLAHHME);
            }
            input.ReadMessage(subBuilder);
            LBHLMLAHHME = subBuilder;
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
          case 16: {
            BAHIPGNCFJO = (global::EggLink.DanhengServer.Proto.RogueDialogueResult) input.ReadEnum();
            break;
          }
          case 82:
          case 80: {
            fDACLBNKPMJ_.AddEntriesFrom(ref input, _repeated_fDACLBNKPMJ_codec);
            break;
          }
          case 106: {
            global::EggLink.DanhengServer.Proto.ItemList subBuilder = new global::EggLink.DanhengServer.Proto.ItemList();
            if (oNNMJDFLDIJCase_ == ONNMJDFLDIJOneofCase.LBHLMLAHHME) {
              subBuilder.MergeFrom(LBHLMLAHHME);
            }
            input.ReadMessage(subBuilder);
            LBHLMLAHHME = subBuilder;
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
