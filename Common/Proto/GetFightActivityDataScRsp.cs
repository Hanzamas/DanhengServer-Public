// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFightActivityDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetFightActivityDataScRsp.proto</summary>
  public static partial class GetFightActivityDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFightActivityDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFightActivityDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HZXRGaWdodEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhhGaWdodEFjdGl2",
            "aXR5R3JvdXAucHJvdG8i9gEKGUdldEZpZ2h0QWN0aXZpdHlEYXRhU2NSc3AS",
            "DwoHcmV0Y29kZRgCIAEoDRITCgtHRklCS0xLTEZIUBgKIAEoCBIoCgtITlBM",
            "S0pHREtFTBgEIAMoCzITLkZpZ2h0QWN0aXZpdHlHcm91cBJACgtMQkNNTE9B",
            "QUNIQRgBIAMoCzIrLkdldEZpZ2h0QWN0aXZpdHlEYXRhU2NSc3AuTEJDTUxP",
            "QUFDSEFFbnRyeRITCgt3b3JsZF9sZXZlbBgOIAEoDRoyChBMQkNNTE9BQUNI",
            "QUVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.FightActivityGroupReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetFightActivityDataScRsp), global::EggLink.DanhengServer.Proto.GetFightActivityDataScRsp.Parser, new[]{ "Retcode", "GFIBKLKLFHP", "HNPLKJGDKEL", "LBCMLOAACHA", "WorldLevel" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetFightActivityDataScRsp : pb::IMessage<GetFightActivityDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFightActivityDataScRsp> _parser = new pb::MessageParser<GetFightActivityDataScRsp>(() => new GetFightActivityDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetFightActivityDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetFightActivityDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFightActivityDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFightActivityDataScRsp(GetFightActivityDataScRsp other) : this() {
      retcode_ = other.retcode_;
      gFIBKLKLFHP_ = other.gFIBKLKLFHP_;
      hNPLKJGDKEL_ = other.hNPLKJGDKEL_.Clone();
      lBCMLOAACHA_ = other.lBCMLOAACHA_.Clone();
      worldLevel_ = other.worldLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFightActivityDataScRsp Clone() {
      return new GetFightActivityDataScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GFIBKLKLFHP" field.</summary>
    public const int GFIBKLKLFHPFieldNumber = 10;
    private bool gFIBKLKLFHP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool GFIBKLKLFHP {
      get { return gFIBKLKLFHP_; }
      set {
        gFIBKLKLFHP_ = value;
      }
    }

    /// <summary>Field number for the "HNPLKJGDKEL" field.</summary>
    public const int HNPLKJGDKELFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.FightActivityGroup> _repeated_hNPLKJGDKEL_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.FightActivityGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> hNPLKJGDKEL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.FightActivityGroup> HNPLKJGDKEL {
      get { return hNPLKJGDKEL_; }
    }

    /// <summary>Field number for the "LBCMLOAACHA" field.</summary>
    public const int LBCMLOAACHAFieldNumber = 1;
    private static readonly pbc::MapField<uint, uint>.Codec _map_lBCMLOAACHA_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 10);
    private readonly pbc::MapField<uint, uint> lBCMLOAACHA_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> LBCMLOAACHA {
      get { return lBCMLOAACHA_; }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 14;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetFightActivityDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetFightActivityDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (GFIBKLKLFHP != other.GFIBKLKLFHP) return false;
      if(!hNPLKJGDKEL_.Equals(other.hNPLKJGDKEL_)) return false;
      if (!LBCMLOAACHA.Equals(other.LBCMLOAACHA)) return false;
      if (WorldLevel != other.WorldLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GFIBKLKLFHP != false) hash ^= GFIBKLKLFHP.GetHashCode();
      hash ^= hNPLKJGDKEL_.GetHashCode();
      hash ^= LBCMLOAACHA.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
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
      lBCMLOAACHA_.WriteTo(output, _map_lBCMLOAACHA_codec);
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      hNPLKJGDKEL_.WriteTo(output, _repeated_hNPLKJGDKEL_codec);
      if (GFIBKLKLFHP != false) {
        output.WriteRawTag(80);
        output.WriteBool(GFIBKLKLFHP);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(WorldLevel);
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
      lBCMLOAACHA_.WriteTo(ref output, _map_lBCMLOAACHA_codec);
      if (Retcode != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Retcode);
      }
      hNPLKJGDKEL_.WriteTo(ref output, _repeated_hNPLKJGDKEL_codec);
      if (GFIBKLKLFHP != false) {
        output.WriteRawTag(80);
        output.WriteBool(GFIBKLKLFHP);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(WorldLevel);
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
      if (GFIBKLKLFHP != false) {
        size += 1 + 1;
      }
      size += hNPLKJGDKEL_.CalculateSize(_repeated_hNPLKJGDKEL_codec);
      size += lBCMLOAACHA_.CalculateSize(_map_lBCMLOAACHA_codec);
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetFightActivityDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GFIBKLKLFHP != false) {
        GFIBKLKLFHP = other.GFIBKLKLFHP;
      }
      hNPLKJGDKEL_.Add(other.hNPLKJGDKEL_);
      lBCMLOAACHA_.MergeFrom(other.lBCMLOAACHA_);
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
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
          case 10: {
            lBCMLOAACHA_.AddEntriesFrom(input, _map_lBCMLOAACHA_codec);
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            hNPLKJGDKEL_.AddEntriesFrom(input, _repeated_hNPLKJGDKEL_codec);
            break;
          }
          case 80: {
            GFIBKLKLFHP = input.ReadBool();
            break;
          }
          case 112: {
            WorldLevel = input.ReadUInt32();
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
            lBCMLOAACHA_.AddEntriesFrom(ref input, _map_lBCMLOAACHA_codec);
            break;
          }
          case 16: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 34: {
            hNPLKJGDKEL_.AddEntriesFrom(ref input, _repeated_hNPLKJGDKEL_codec);
            break;
          }
          case 80: {
            GFIBKLKLFHP = input.ReadBool();
            break;
          }
          case 112: {
            WorldLevel = input.ReadUInt32();
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
