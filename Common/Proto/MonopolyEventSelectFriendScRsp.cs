// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyEventSelectFriendScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyEventSelectFriendScRsp.proto</summary>
  public static partial class MonopolyEventSelectFriendScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyEventSelectFriendScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyEventSelectFriendScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRNb25vcG9seUV2ZW50U2VsZWN0RnJpZW5kU2NSc3AucHJvdG8aEU5MQUxP",
            "TUtORUdGLnByb3RvIoABCh5Nb25vcG9seUV2ZW50U2VsZWN0RnJpZW5kU2NS",
            "c3ASIQoLQklBSkFNQU9NQkIYCyABKAsyDC5OTEFMT01LTkVHRhIVCg1nZXRf",
            "aXRlbV9saXN0GAogASgNEg8KB3JldGNvZGUYBSABKA0SEwoLQUpOTk5QQ0dH",
            "REwYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NLALOMKNEGFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyEventSelectFriendScRsp), global::EggLink.DanhengServer.Proto.MonopolyEventSelectFriendScRsp.Parser, new[]{ "BIAJAMAOMBB", "GetItemList", "Retcode", "AJNNNPCGGDL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyEventSelectFriendScRsp : pb::IMessage<MonopolyEventSelectFriendScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyEventSelectFriendScRsp> _parser = new pb::MessageParser<MonopolyEventSelectFriendScRsp>(() => new MonopolyEventSelectFriendScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyEventSelectFriendScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyEventSelectFriendScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventSelectFriendScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventSelectFriendScRsp(MonopolyEventSelectFriendScRsp other) : this() {
      bIAJAMAOMBB_ = other.bIAJAMAOMBB_ != null ? other.bIAJAMAOMBB_.Clone() : null;
      getItemList_ = other.getItemList_;
      retcode_ = other.retcode_;
      aJNNNPCGGDL_ = other.aJNNNPCGGDL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventSelectFriendScRsp Clone() {
      return new MonopolyEventSelectFriendScRsp(this);
    }

    /// <summary>Field number for the "BIAJAMAOMBB" field.</summary>
    public const int BIAJAMAOMBBFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.NLALOMKNEGF bIAJAMAOMBB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NLALOMKNEGF BIAJAMAOMBB {
      get { return bIAJAMAOMBB_; }
      set {
        bIAJAMAOMBB_ = value;
      }
    }

    /// <summary>Field number for the "get_item_list" field.</summary>
    public const int GetItemListFieldNumber = 10;
    private uint getItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GetItemList {
      get { return getItemList_; }
      set {
        getItemList_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "AJNNNPCGGDL" field.</summary>
    public const int AJNNNPCGGDLFieldNumber = 1;
    private uint aJNNNPCGGDL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AJNNNPCGGDL {
      get { return aJNNNPCGGDL_; }
      set {
        aJNNNPCGGDL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyEventSelectFriendScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyEventSelectFriendScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BIAJAMAOMBB, other.BIAJAMAOMBB)) return false;
      if (GetItemList != other.GetItemList) return false;
      if (Retcode != other.Retcode) return false;
      if (AJNNNPCGGDL != other.AJNNNPCGGDL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (bIAJAMAOMBB_ != null) hash ^= BIAJAMAOMBB.GetHashCode();
      if (GetItemList != 0) hash ^= GetItemList.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (AJNNNPCGGDL != 0) hash ^= AJNNNPCGGDL.GetHashCode();
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
      if (AJNNNPCGGDL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AJNNNPCGGDL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (GetItemList != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GetItemList);
      }
      if (bIAJAMAOMBB_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BIAJAMAOMBB);
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
      if (AJNNNPCGGDL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AJNNNPCGGDL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (GetItemList != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GetItemList);
      }
      if (bIAJAMAOMBB_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BIAJAMAOMBB);
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
      if (bIAJAMAOMBB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BIAJAMAOMBB);
      }
      if (GetItemList != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GetItemList);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (AJNNNPCGGDL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AJNNNPCGGDL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyEventSelectFriendScRsp other) {
      if (other == null) {
        return;
      }
      if (other.bIAJAMAOMBB_ != null) {
        if (bIAJAMAOMBB_ == null) {
          BIAJAMAOMBB = new global::EggLink.DanhengServer.Proto.NLALOMKNEGF();
        }
        BIAJAMAOMBB.MergeFrom(other.BIAJAMAOMBB);
      }
      if (other.GetItemList != 0) {
        GetItemList = other.GetItemList;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.AJNNNPCGGDL != 0) {
        AJNNNPCGGDL = other.AJNNNPCGGDL;
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
            AJNNNPCGGDL = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            GetItemList = input.ReadUInt32();
            break;
          }
          case 90: {
            if (bIAJAMAOMBB_ == null) {
              BIAJAMAOMBB = new global::EggLink.DanhengServer.Proto.NLALOMKNEGF();
            }
            input.ReadMessage(BIAJAMAOMBB);
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
            AJNNNPCGGDL = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 80: {
            GetItemList = input.ReadUInt32();
            break;
          }
          case 90: {
            if (bIAJAMAOMBB_ == null) {
              BIAJAMAOMBB = new global::EggLink.DanhengServer.Proto.NLALOMKNEGF();
            }
            input.ReadMessage(BIAJAMAOMBB);
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
