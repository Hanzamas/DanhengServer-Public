// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyLikeScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyLikeScRsp.proto</summary>
  public static partial class MonopolyLikeScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyLikeScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyLikeScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdNb25vcG9seUxpa2VTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iWQoR",
            "TW9ub3BvbHlMaWtlU2NSc3ASDwoHcmV0Y29kZRgMIAEoDRIeCgtyZXdhcmRf",
            "bGlzdBgKIAEoCzIJLkl0ZW1MaXN0EhMKC0hDTENGR0NPR1BNGA8gASgNQh6q",
            "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyLikeScRsp), global::EggLink.DanhengServer.Proto.MonopolyLikeScRsp.Parser, new[]{ "Retcode", "RewardList", "HCLCFGCOGPM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyLikeScRsp : pb::IMessage<MonopolyLikeScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyLikeScRsp> _parser = new pb::MessageParser<MonopolyLikeScRsp>(() => new MonopolyLikeScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyLikeScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyLikeScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyLikeScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyLikeScRsp(MonopolyLikeScRsp other) : this() {
      retcode_ = other.retcode_;
      rewardList_ = other.rewardList_ != null ? other.rewardList_.Clone() : null;
      hCLCFGCOGPM_ = other.hCLCFGCOGPM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyLikeScRsp Clone() {
      return new MonopolyLikeScRsp(this);
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

    /// <summary>Field number for the "reward_list" field.</summary>
    public const int RewardListFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemList rewardList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList RewardList {
      get { return rewardList_; }
      set {
        rewardList_ = value;
      }
    }

    /// <summary>Field number for the "HCLCFGCOGPM" field.</summary>
    public const int HCLCFGCOGPMFieldNumber = 15;
    private uint hCLCFGCOGPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HCLCFGCOGPM {
      get { return hCLCFGCOGPM_; }
      set {
        hCLCFGCOGPM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyLikeScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyLikeScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(RewardList, other.RewardList)) return false;
      if (HCLCFGCOGPM != other.HCLCFGCOGPM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (rewardList_ != null) hash ^= RewardList.GetHashCode();
      if (HCLCFGCOGPM != 0) hash ^= HCLCFGCOGPM.GetHashCode();
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
      if (rewardList_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RewardList);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (HCLCFGCOGPM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HCLCFGCOGPM);
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
      if (rewardList_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RewardList);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (HCLCFGCOGPM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HCLCFGCOGPM);
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
      if (rewardList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RewardList);
      }
      if (HCLCFGCOGPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HCLCFGCOGPM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyLikeScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.rewardList_ != null) {
        if (rewardList_ == null) {
          RewardList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        RewardList.MergeFrom(other.RewardList);
      }
      if (other.HCLCFGCOGPM != 0) {
        HCLCFGCOGPM = other.HCLCFGCOGPM;
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
          case 82: {
            if (rewardList_ == null) {
              RewardList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(RewardList);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            HCLCFGCOGPM = input.ReadUInt32();
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
          case 82: {
            if (rewardList_ == null) {
              RewardList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(RewardList);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 120: {
            HCLCFGCOGPM = input.ReadUInt32();
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
