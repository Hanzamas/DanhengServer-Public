// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetRogueShopBuffInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetRogueShopBuffInfoScRsp.proto</summary>
  public static partial class GetRogueShopBuffInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetRogueShopBuffInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetRogueShopBuffInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HZXRSb2d1ZVNob3BCdWZmSW5mb1NjUnNwLnByb3RvGhJJdGVtQ29zdERh",
            "dGEucHJvdG8aEUlQQkpIRENNSUtPLnByb3RvIowBChlHZXRSb2d1ZVNob3BC",
            "dWZmSW5mb1NjUnNwEiUKD3JvZ3VlX2J1ZmZfaW5mbxgGIAEoCzIMLklQQkpI",
            "RENNSUtPEhMKC0NNSUpISUZLTlBPGA4gASgIEiIKC0tOUEZIQkxNUEdJGAcg",
            "ASgLMg0uSXRlbUNvc3REYXRhEg8KB3JldGNvZGUYAyABKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.IPBJHDCMIKOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetRogueShopBuffInfoScRsp), global::EggLink.DanhengServer.Proto.GetRogueShopBuffInfoScRsp.Parser, new[]{ "RogueBuffInfo", "CMIJHIFKNPO", "KNPFHBLMPGI", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetRogueShopBuffInfoScRsp : pb::IMessage<GetRogueShopBuffInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetRogueShopBuffInfoScRsp> _parser = new pb::MessageParser<GetRogueShopBuffInfoScRsp>(() => new GetRogueShopBuffInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetRogueShopBuffInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetRogueShopBuffInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRogueShopBuffInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRogueShopBuffInfoScRsp(GetRogueShopBuffInfoScRsp other) : this() {
      rogueBuffInfo_ = other.rogueBuffInfo_ != null ? other.rogueBuffInfo_.Clone() : null;
      cMIJHIFKNPO_ = other.cMIJHIFKNPO_;
      kNPFHBLMPGI_ = other.kNPFHBLMPGI_ != null ? other.kNPFHBLMPGI_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRogueShopBuffInfoScRsp Clone() {
      return new GetRogueShopBuffInfoScRsp(this);
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.IPBJHDCMIKO rogueBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IPBJHDCMIKO RogueBuffInfo {
      get { return rogueBuffInfo_; }
      set {
        rogueBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "CMIJHIFKNPO" field.</summary>
    public const int CMIJHIFKNPOFieldNumber = 14;
    private bool cMIJHIFKNPO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CMIJHIFKNPO {
      get { return cMIJHIFKNPO_; }
      set {
        cMIJHIFKNPO_ = value;
      }
    }

    /// <summary>Field number for the "KNPFHBLMPGI" field.</summary>
    public const int KNPFHBLMPGIFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ItemCostData kNPFHBLMPGI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData KNPFHBLMPGI {
      get { return kNPFHBLMPGI_; }
      set {
        kNPFHBLMPGI_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetRogueShopBuffInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetRogueShopBuffInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (CMIJHIFKNPO != other.CMIJHIFKNPO) return false;
      if (!object.Equals(KNPFHBLMPGI, other.KNPFHBLMPGI)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueBuffInfo_ != null) hash ^= RogueBuffInfo.GetHashCode();
      if (CMIJHIFKNPO != false) hash ^= CMIJHIFKNPO.GetHashCode();
      if (kNPFHBLMPGI_ != null) hash ^= KNPFHBLMPGI.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuffInfo);
      }
      if (kNPFHBLMPGI_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(KNPFHBLMPGI);
      }
      if (CMIJHIFKNPO != false) {
        output.WriteRawTag(112);
        output.WriteBool(CMIJHIFKNPO);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueBuffInfo);
      }
      if (kNPFHBLMPGI_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(KNPFHBLMPGI);
      }
      if (CMIJHIFKNPO != false) {
        output.WriteRawTag(112);
        output.WriteBool(CMIJHIFKNPO);
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
      if (rogueBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (CMIJHIFKNPO != false) {
        size += 1 + 1;
      }
      if (kNPFHBLMPGI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KNPFHBLMPGI);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetRogueShopBuffInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueBuffInfo_ != null) {
        if (rogueBuffInfo_ == null) {
          RogueBuffInfo = new global::EggLink.DanhengServer.Proto.IPBJHDCMIKO();
        }
        RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
      }
      if (other.CMIJHIFKNPO != false) {
        CMIJHIFKNPO = other.CMIJHIFKNPO;
      }
      if (other.kNPFHBLMPGI_ != null) {
        if (kNPFHBLMPGI_ == null) {
          KNPFHBLMPGI = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        KNPFHBLMPGI.MergeFrom(other.KNPFHBLMPGI);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.IPBJHDCMIKO();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 58: {
            if (kNPFHBLMPGI_ == null) {
              KNPFHBLMPGI = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(KNPFHBLMPGI);
            break;
          }
          case 112: {
            CMIJHIFKNPO = input.ReadBool();
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
          case 24: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.IPBJHDCMIKO();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 58: {
            if (kNPFHBLMPGI_ == null) {
              KNPFHBLMPGI = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(KNPFHBLMPGI);
            break;
          }
          case 112: {
            CMIJHIFKNPO = input.ReadBool();
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
