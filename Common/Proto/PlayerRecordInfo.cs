// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerRecordInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerRecordInfo.proto</summary>
  public static partial class PlayerRecordInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerRecordInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerRecordInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJSZWNvcmRJbmZvLnByb3RvGhpQbGF5ZXJDb2xsZWN0aW9uSW5m",
            "by5wcm90byLqAQoQUGxheWVyUmVjb3JkSW5mbxITCgtJQ0NQSUZDRURJSBgF",
            "IAEoDRITCgtCUEFOQUtNS0pGThgGIAEoDRITCgtDT0JMSkRCUENCSBgNIAEo",
            "DRITCgtEQklDUEVGQ01MTxgBIAEoDRITCgtJS0hFSEJFTENBThgLIAEoDRIT",
            "CgtJQUtJSEJNRkREShgMIAEoDRITCgtHT0NOSUNMTk1QRxgCIAEoDRIuCg9j",
            "b2xsZWN0aW9uX2luZm8YByABKAsyFS5QbGF5ZXJDb2xsZWN0aW9uSW5mbxIT",
            "CgtOQklQREhNTkROTxgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlayerCollectionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerRecordInfo), global::EggLink.DanhengServer.Proto.PlayerRecordInfo.Parser, new[]{ "ICCPIFCEDIH", "BPANAKMKJFN", "COBLJDBPCBH", "DBICPEFCMLO", "IKHEHBELCAN", "IAKIHBMFDDJ", "GOCNICLNMPG", "CollectionInfo", "NBIPDHMNDNO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerRecordInfo : pb::IMessage<PlayerRecordInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerRecordInfo> _parser = new pb::MessageParser<PlayerRecordInfo>(() => new PlayerRecordInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerRecordInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerRecordInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRecordInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRecordInfo(PlayerRecordInfo other) : this() {
      iCCPIFCEDIH_ = other.iCCPIFCEDIH_;
      bPANAKMKJFN_ = other.bPANAKMKJFN_;
      cOBLJDBPCBH_ = other.cOBLJDBPCBH_;
      dBICPEFCMLO_ = other.dBICPEFCMLO_;
      iKHEHBELCAN_ = other.iKHEHBELCAN_;
      iAKIHBMFDDJ_ = other.iAKIHBMFDDJ_;
      gOCNICLNMPG_ = other.gOCNICLNMPG_;
      collectionInfo_ = other.collectionInfo_ != null ? other.collectionInfo_.Clone() : null;
      nBIPDHMNDNO_ = other.nBIPDHMNDNO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRecordInfo Clone() {
      return new PlayerRecordInfo(this);
    }

    /// <summary>Field number for the "ICCPIFCEDIH" field.</summary>
    public const int ICCPIFCEDIHFieldNumber = 5;
    private uint iCCPIFCEDIH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ICCPIFCEDIH {
      get { return iCCPIFCEDIH_; }
      set {
        iCCPIFCEDIH_ = value;
      }
    }

    /// <summary>Field number for the "BPANAKMKJFN" field.</summary>
    public const int BPANAKMKJFNFieldNumber = 6;
    private uint bPANAKMKJFN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BPANAKMKJFN {
      get { return bPANAKMKJFN_; }
      set {
        bPANAKMKJFN_ = value;
      }
    }

    /// <summary>Field number for the "COBLJDBPCBH" field.</summary>
    public const int COBLJDBPCBHFieldNumber = 13;
    private uint cOBLJDBPCBH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint COBLJDBPCBH {
      get { return cOBLJDBPCBH_; }
      set {
        cOBLJDBPCBH_ = value;
      }
    }

    /// <summary>Field number for the "DBICPEFCMLO" field.</summary>
    public const int DBICPEFCMLOFieldNumber = 1;
    private uint dBICPEFCMLO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DBICPEFCMLO {
      get { return dBICPEFCMLO_; }
      set {
        dBICPEFCMLO_ = value;
      }
    }

    /// <summary>Field number for the "IKHEHBELCAN" field.</summary>
    public const int IKHEHBELCANFieldNumber = 11;
    private uint iKHEHBELCAN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IKHEHBELCAN {
      get { return iKHEHBELCAN_; }
      set {
        iKHEHBELCAN_ = value;
      }
    }

    /// <summary>Field number for the "IAKIHBMFDDJ" field.</summary>
    public const int IAKIHBMFDDJFieldNumber = 12;
    private uint iAKIHBMFDDJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IAKIHBMFDDJ {
      get { return iAKIHBMFDDJ_; }
      set {
        iAKIHBMFDDJ_ = value;
      }
    }

    /// <summary>Field number for the "GOCNICLNMPG" field.</summary>
    public const int GOCNICLNMPGFieldNumber = 2;
    private uint gOCNICLNMPG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GOCNICLNMPG {
      get { return gOCNICLNMPG_; }
      set {
        gOCNICLNMPG_ = value;
      }
    }

    /// <summary>Field number for the "collection_info" field.</summary>
    public const int CollectionInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.PlayerCollectionInfo collectionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlayerCollectionInfo CollectionInfo {
      get { return collectionInfo_; }
      set {
        collectionInfo_ = value;
      }
    }

    /// <summary>Field number for the "NBIPDHMNDNO" field.</summary>
    public const int NBIPDHMNDNOFieldNumber = 14;
    private uint nBIPDHMNDNO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NBIPDHMNDNO {
      get { return nBIPDHMNDNO_; }
      set {
        nBIPDHMNDNO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerRecordInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerRecordInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ICCPIFCEDIH != other.ICCPIFCEDIH) return false;
      if (BPANAKMKJFN != other.BPANAKMKJFN) return false;
      if (COBLJDBPCBH != other.COBLJDBPCBH) return false;
      if (DBICPEFCMLO != other.DBICPEFCMLO) return false;
      if (IKHEHBELCAN != other.IKHEHBELCAN) return false;
      if (IAKIHBMFDDJ != other.IAKIHBMFDDJ) return false;
      if (GOCNICLNMPG != other.GOCNICLNMPG) return false;
      if (!object.Equals(CollectionInfo, other.CollectionInfo)) return false;
      if (NBIPDHMNDNO != other.NBIPDHMNDNO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ICCPIFCEDIH != 0) hash ^= ICCPIFCEDIH.GetHashCode();
      if (BPANAKMKJFN != 0) hash ^= BPANAKMKJFN.GetHashCode();
      if (COBLJDBPCBH != 0) hash ^= COBLJDBPCBH.GetHashCode();
      if (DBICPEFCMLO != 0) hash ^= DBICPEFCMLO.GetHashCode();
      if (IKHEHBELCAN != 0) hash ^= IKHEHBELCAN.GetHashCode();
      if (IAKIHBMFDDJ != 0) hash ^= IAKIHBMFDDJ.GetHashCode();
      if (GOCNICLNMPG != 0) hash ^= GOCNICLNMPG.GetHashCode();
      if (collectionInfo_ != null) hash ^= CollectionInfo.GetHashCode();
      if (NBIPDHMNDNO != 0) hash ^= NBIPDHMNDNO.GetHashCode();
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
      if (DBICPEFCMLO != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DBICPEFCMLO);
      }
      if (GOCNICLNMPG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GOCNICLNMPG);
      }
      if (ICCPIFCEDIH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ICCPIFCEDIH);
      }
      if (BPANAKMKJFN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BPANAKMKJFN);
      }
      if (collectionInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CollectionInfo);
      }
      if (IKHEHBELCAN != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IKHEHBELCAN);
      }
      if (IAKIHBMFDDJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(IAKIHBMFDDJ);
      }
      if (COBLJDBPCBH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(COBLJDBPCBH);
      }
      if (NBIPDHMNDNO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NBIPDHMNDNO);
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
      if (DBICPEFCMLO != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DBICPEFCMLO);
      }
      if (GOCNICLNMPG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GOCNICLNMPG);
      }
      if (ICCPIFCEDIH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ICCPIFCEDIH);
      }
      if (BPANAKMKJFN != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BPANAKMKJFN);
      }
      if (collectionInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CollectionInfo);
      }
      if (IKHEHBELCAN != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IKHEHBELCAN);
      }
      if (IAKIHBMFDDJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(IAKIHBMFDDJ);
      }
      if (COBLJDBPCBH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(COBLJDBPCBH);
      }
      if (NBIPDHMNDNO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NBIPDHMNDNO);
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
      if (ICCPIFCEDIH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ICCPIFCEDIH);
      }
      if (BPANAKMKJFN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BPANAKMKJFN);
      }
      if (COBLJDBPCBH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(COBLJDBPCBH);
      }
      if (DBICPEFCMLO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DBICPEFCMLO);
      }
      if (IKHEHBELCAN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IKHEHBELCAN);
      }
      if (IAKIHBMFDDJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IAKIHBMFDDJ);
      }
      if (GOCNICLNMPG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GOCNICLNMPG);
      }
      if (collectionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CollectionInfo);
      }
      if (NBIPDHMNDNO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NBIPDHMNDNO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerRecordInfo other) {
      if (other == null) {
        return;
      }
      if (other.ICCPIFCEDIH != 0) {
        ICCPIFCEDIH = other.ICCPIFCEDIH;
      }
      if (other.BPANAKMKJFN != 0) {
        BPANAKMKJFN = other.BPANAKMKJFN;
      }
      if (other.COBLJDBPCBH != 0) {
        COBLJDBPCBH = other.COBLJDBPCBH;
      }
      if (other.DBICPEFCMLO != 0) {
        DBICPEFCMLO = other.DBICPEFCMLO;
      }
      if (other.IKHEHBELCAN != 0) {
        IKHEHBELCAN = other.IKHEHBELCAN;
      }
      if (other.IAKIHBMFDDJ != 0) {
        IAKIHBMFDDJ = other.IAKIHBMFDDJ;
      }
      if (other.GOCNICLNMPG != 0) {
        GOCNICLNMPG = other.GOCNICLNMPG;
      }
      if (other.collectionInfo_ != null) {
        if (collectionInfo_ == null) {
          CollectionInfo = new global::EggLink.DanhengServer.Proto.PlayerCollectionInfo();
        }
        CollectionInfo.MergeFrom(other.CollectionInfo);
      }
      if (other.NBIPDHMNDNO != 0) {
        NBIPDHMNDNO = other.NBIPDHMNDNO;
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
            DBICPEFCMLO = input.ReadUInt32();
            break;
          }
          case 16: {
            GOCNICLNMPG = input.ReadUInt32();
            break;
          }
          case 40: {
            ICCPIFCEDIH = input.ReadUInt32();
            break;
          }
          case 48: {
            BPANAKMKJFN = input.ReadUInt32();
            break;
          }
          case 58: {
            if (collectionInfo_ == null) {
              CollectionInfo = new global::EggLink.DanhengServer.Proto.PlayerCollectionInfo();
            }
            input.ReadMessage(CollectionInfo);
            break;
          }
          case 88: {
            IKHEHBELCAN = input.ReadUInt32();
            break;
          }
          case 96: {
            IAKIHBMFDDJ = input.ReadUInt32();
            break;
          }
          case 104: {
            COBLJDBPCBH = input.ReadUInt32();
            break;
          }
          case 112: {
            NBIPDHMNDNO = input.ReadUInt32();
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
            DBICPEFCMLO = input.ReadUInt32();
            break;
          }
          case 16: {
            GOCNICLNMPG = input.ReadUInt32();
            break;
          }
          case 40: {
            ICCPIFCEDIH = input.ReadUInt32();
            break;
          }
          case 48: {
            BPANAKMKJFN = input.ReadUInt32();
            break;
          }
          case 58: {
            if (collectionInfo_ == null) {
              CollectionInfo = new global::EggLink.DanhengServer.Proto.PlayerCollectionInfo();
            }
            input.ReadMessage(CollectionInfo);
            break;
          }
          case 88: {
            IKHEHBELCAN = input.ReadUInt32();
            break;
          }
          case 96: {
            IAKIHBMFDDJ = input.ReadUInt32();
            break;
          }
          case 104: {
            COBLJDBPCBH = input.ReadUInt32();
            break;
          }
          case 112: {
            NBIPDHMNDNO = input.ReadUInt32();
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