// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HAIIKGDHFMO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HAIIKGDHFMO.proto</summary>
  public static partial class HAIIKGDHFMOReflection {

    #region Descriptor
    /// <summary>File descriptor for HAIIKGDHFMO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HAIIKGDHFMOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQUlJS0dESEZNTy5wcm90byI3CgtIQUlJS0dESEZNTxITCgtJQ0ZLSUFH",
            "SUdESBgLIAEoDRITCgtPTE1JQk9EUEZFThgHIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HAIIKGDHFMO), global::EggLink.DanhengServer.Proto.HAIIKGDHFMO.Parser, new[]{ "ICFKIAGIGDH", "OLMIBODPFEN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HAIIKGDHFMO : pb::IMessage<HAIIKGDHFMO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HAIIKGDHFMO> _parser = new pb::MessageParser<HAIIKGDHFMO>(() => new HAIIKGDHFMO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HAIIKGDHFMO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HAIIKGDHFMOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAIIKGDHFMO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAIIKGDHFMO(HAIIKGDHFMO other) : this() {
      iCFKIAGIGDH_ = other.iCFKIAGIGDH_;
      oLMIBODPFEN_ = other.oLMIBODPFEN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HAIIKGDHFMO Clone() {
      return new HAIIKGDHFMO(this);
    }

    /// <summary>Field number for the "ICFKIAGIGDH" field.</summary>
    public const int ICFKIAGIGDHFieldNumber = 11;
    private uint iCFKIAGIGDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ICFKIAGIGDH {
      get { return iCFKIAGIGDH_; }
      set {
        iCFKIAGIGDH_ = value;
      }
    }

    /// <summary>Field number for the "OLMIBODPFEN" field.</summary>
    public const int OLMIBODPFENFieldNumber = 7;
    private uint oLMIBODPFEN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OLMIBODPFEN {
      get { return oLMIBODPFEN_; }
      set {
        oLMIBODPFEN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HAIIKGDHFMO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HAIIKGDHFMO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ICFKIAGIGDH != other.ICFKIAGIGDH) return false;
      if (OLMIBODPFEN != other.OLMIBODPFEN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ICFKIAGIGDH != 0) hash ^= ICFKIAGIGDH.GetHashCode();
      if (OLMIBODPFEN != 0) hash ^= OLMIBODPFEN.GetHashCode();
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
      if (OLMIBODPFEN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OLMIBODPFEN);
      }
      if (ICFKIAGIGDH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ICFKIAGIGDH);
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
      if (OLMIBODPFEN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OLMIBODPFEN);
      }
      if (ICFKIAGIGDH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ICFKIAGIGDH);
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
      if (ICFKIAGIGDH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ICFKIAGIGDH);
      }
      if (OLMIBODPFEN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OLMIBODPFEN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HAIIKGDHFMO other) {
      if (other == null) {
        return;
      }
      if (other.ICFKIAGIGDH != 0) {
        ICFKIAGIGDH = other.ICFKIAGIGDH;
      }
      if (other.OLMIBODPFEN != 0) {
        OLMIBODPFEN = other.OLMIBODPFEN;
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
          case 56: {
            OLMIBODPFEN = input.ReadUInt32();
            break;
          }
          case 88: {
            ICFKIAGIGDH = input.ReadUInt32();
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
          case 56: {
            OLMIBODPFEN = input.ReadUInt32();
            break;
          }
          case 88: {
            ICFKIAGIGDH = input.ReadUInt32();
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