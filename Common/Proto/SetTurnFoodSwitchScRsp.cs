// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetTurnFoodSwitchScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetTurnFoodSwitchScRsp.proto</summary>
  public static partial class SetTurnFoodSwitchScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SetTurnFoodSwitchScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetTurnFoodSwitchScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTZXRUdXJuRm9vZFN3aXRjaFNjUnNwLnByb3RvGhRUdXJuRm9vZFN3aXRj",
            "aC5wcm90byJkChZTZXRUdXJuRm9vZFN3aXRjaFNjUnNwEg8KB3JldGNvZGUY",
            "DCABKA0SJAoLREJNRVBGSERNQkQYAyABKA4yDy5UdXJuRm9vZFN3aXRjaBIT",
            "CgtBQ0pPREpMT1BDShgCIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TurnFoodSwitchReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetTurnFoodSwitchScRsp), global::EggLink.DanhengServer.Proto.SetTurnFoodSwitchScRsp.Parser, new[]{ "Retcode", "DBMEPFHDMBD", "ACJODJLOPCJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetTurnFoodSwitchScRsp : pb::IMessage<SetTurnFoodSwitchScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetTurnFoodSwitchScRsp> _parser = new pb::MessageParser<SetTurnFoodSwitchScRsp>(() => new SetTurnFoodSwitchScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetTurnFoodSwitchScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetTurnFoodSwitchScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetTurnFoodSwitchScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetTurnFoodSwitchScRsp(SetTurnFoodSwitchScRsp other) : this() {
      retcode_ = other.retcode_;
      dBMEPFHDMBD_ = other.dBMEPFHDMBD_;
      aCJODJLOPCJ_ = other.aCJODJLOPCJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetTurnFoodSwitchScRsp Clone() {
      return new SetTurnFoodSwitchScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "DBMEPFHDMBD" field.</summary>
    public const int DBMEPFHDMBDFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.TurnFoodSwitch dBMEPFHDMBD_ = global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TurnFoodSwitch DBMEPFHDMBD {
      get { return dBMEPFHDMBD_; }
      set {
        dBMEPFHDMBD_ = value;
      }
    }

    /// <summary>Field number for the "ACJODJLOPCJ" field.</summary>
    public const int ACJODJLOPCJFieldNumber = 2;
    private bool aCJODJLOPCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ACJODJLOPCJ {
      get { return aCJODJLOPCJ_; }
      set {
        aCJODJLOPCJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetTurnFoodSwitchScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetTurnFoodSwitchScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (DBMEPFHDMBD != other.DBMEPFHDMBD) return false;
      if (ACJODJLOPCJ != other.ACJODJLOPCJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (DBMEPFHDMBD != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) hash ^= DBMEPFHDMBD.GetHashCode();
      if (ACJODJLOPCJ != false) hash ^= ACJODJLOPCJ.GetHashCode();
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
      if (ACJODJLOPCJ != false) {
        output.WriteRawTag(16);
        output.WriteBool(ACJODJLOPCJ);
      }
      if (DBMEPFHDMBD != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) DBMEPFHDMBD);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      if (ACJODJLOPCJ != false) {
        output.WriteRawTag(16);
        output.WriteBool(ACJODJLOPCJ);
      }
      if (DBMEPFHDMBD != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) DBMEPFHDMBD);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (DBMEPFHDMBD != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DBMEPFHDMBD);
      }
      if (ACJODJLOPCJ != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetTurnFoodSwitchScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.DBMEPFHDMBD != global::EggLink.DanhengServer.Proto.TurnFoodSwitch.None) {
        DBMEPFHDMBD = other.DBMEPFHDMBD;
      }
      if (other.ACJODJLOPCJ != false) {
        ACJODJLOPCJ = other.ACJODJLOPCJ;
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
            ACJODJLOPCJ = input.ReadBool();
            break;
          }
          case 24: {
            DBMEPFHDMBD = (global::EggLink.DanhengServer.Proto.TurnFoodSwitch) input.ReadEnum();
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
            ACJODJLOPCJ = input.ReadBool();
            break;
          }
          case 24: {
            DBMEPFHDMBD = (global::EggLink.DanhengServer.Proto.TurnFoodSwitch) input.ReadEnum();
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
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
