// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattlePassInfoNotify.proto</summary>
  public static partial class BattlePassInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpCYXR0bGVQYXNzSW5mb05vdGlmeS5wcm90bxoQQnBUaWVyVHlwZS5wcm90",
            "byKiAgoUQmF0dGxlUGFzc0luZm9Ob3RpZnkSDQoFbGV2ZWwYCSABKA0SHAoH",
            "YnBfdGllchgEIAEoDjILLkJwVGllclR5cGUSEwoLTEJHSFBJT09KQ0UYDSAB",
            "KAQSEwoLTE1FUFBHT0hMR0EYAiABKAQSCwoDZXhwGAcgASgNEhMKC0JDSkJB",
            "RUlKQklOGAggASgEEhMKC0xQR0VPREZFUEtDGAYgASgEEhMKC0hOTkxBQUVD",
            "QUZIGAwgASgEEhMKC0xLTUFDTEJMRkFGGAsgASgEEhMKC0ZIRUdIQURPTkNP",
            "GAogASgEEhMKC0tLQk9DSk1JS0lBGAEgASgNEhMKC0hESUFFQUFET0dLGA8g",
            "ASgNEhMKC0hFS0RGT0FOSVBMGAMgASgEQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BpTierTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BattlePassInfoNotify), global::EggLink.DanhengServer.Proto.BattlePassInfoNotify.Parser, new[]{ "Level", "BpTier", "LBGHPIOOJCE", "LMEPPGOHLGA", "Exp", "BCJBAEIJBIN", "LPGEODFEPKC", "HNNLAAECAFH", "LKMACLBLFAF", "FHEGHADONCO", "KKBOCJMIKIA", "HDIAEAADOGK", "HEKDFOANIPL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattlePassInfoNotify : pb::IMessage<BattlePassInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassInfoNotify> _parser = new pb::MessageParser<BattlePassInfoNotify>(() => new BattlePassInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BattlePassInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify(BattlePassInfoNotify other) : this() {
      level_ = other.level_;
      bpTier_ = other.bpTier_;
      lBGHPIOOJCE_ = other.lBGHPIOOJCE_;
      lMEPPGOHLGA_ = other.lMEPPGOHLGA_;
      exp_ = other.exp_;
      bCJBAEIJBIN_ = other.bCJBAEIJBIN_;
      lPGEODFEPKC_ = other.lPGEODFEPKC_;
      hNNLAAECAFH_ = other.hNNLAAECAFH_;
      lKMACLBLFAF_ = other.lKMACLBLFAF_;
      fHEGHADONCO_ = other.fHEGHADONCO_;
      kKBOCJMIKIA_ = other.kKBOCJMIKIA_;
      hDIAEAADOGK_ = other.hDIAEAADOGK_;
      hEKDFOANIPL_ = other.hEKDFOANIPL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassInfoNotify Clone() {
      return new BattlePassInfoNotify(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 9;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "bp_tier" field.</summary>
    public const int BpTierFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.BpTierType bpTier_ = global::EggLink.DanhengServer.Proto.BpTierType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BpTierType BpTier {
      get { return bpTier_; }
      set {
        bpTier_ = value;
      }
    }

    /// <summary>Field number for the "LBGHPIOOJCE" field.</summary>
    public const int LBGHPIOOJCEFieldNumber = 13;
    private ulong lBGHPIOOJCE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong LBGHPIOOJCE {
      get { return lBGHPIOOJCE_; }
      set {
        lBGHPIOOJCE_ = value;
      }
    }

    /// <summary>Field number for the "LMEPPGOHLGA" field.</summary>
    public const int LMEPPGOHLGAFieldNumber = 2;
    private ulong lMEPPGOHLGA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong LMEPPGOHLGA {
      get { return lMEPPGOHLGA_; }
      set {
        lMEPPGOHLGA_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 7;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "BCJBAEIJBIN" field.</summary>
    public const int BCJBAEIJBINFieldNumber = 8;
    private ulong bCJBAEIJBIN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BCJBAEIJBIN {
      get { return bCJBAEIJBIN_; }
      set {
        bCJBAEIJBIN_ = value;
      }
    }

    /// <summary>Field number for the "LPGEODFEPKC" field.</summary>
    public const int LPGEODFEPKCFieldNumber = 6;
    private ulong lPGEODFEPKC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong LPGEODFEPKC {
      get { return lPGEODFEPKC_; }
      set {
        lPGEODFEPKC_ = value;
      }
    }

    /// <summary>Field number for the "HNNLAAECAFH" field.</summary>
    public const int HNNLAAECAFHFieldNumber = 12;
    private ulong hNNLAAECAFH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong HNNLAAECAFH {
      get { return hNNLAAECAFH_; }
      set {
        hNNLAAECAFH_ = value;
      }
    }

    /// <summary>Field number for the "LKMACLBLFAF" field.</summary>
    public const int LKMACLBLFAFFieldNumber = 11;
    private ulong lKMACLBLFAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong LKMACLBLFAF {
      get { return lKMACLBLFAF_; }
      set {
        lKMACLBLFAF_ = value;
      }
    }

    /// <summary>Field number for the "FHEGHADONCO" field.</summary>
    public const int FHEGHADONCOFieldNumber = 10;
    private ulong fHEGHADONCO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong FHEGHADONCO {
      get { return fHEGHADONCO_; }
      set {
        fHEGHADONCO_ = value;
      }
    }

    /// <summary>Field number for the "KKBOCJMIKIA" field.</summary>
    public const int KKBOCJMIKIAFieldNumber = 1;
    private uint kKBOCJMIKIA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KKBOCJMIKIA {
      get { return kKBOCJMIKIA_; }
      set {
        kKBOCJMIKIA_ = value;
      }
    }

    /// <summary>Field number for the "HDIAEAADOGK" field.</summary>
    public const int HDIAEAADOGKFieldNumber = 15;
    private uint hDIAEAADOGK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HDIAEAADOGK {
      get { return hDIAEAADOGK_; }
      set {
        hDIAEAADOGK_ = value;
      }
    }

    /// <summary>Field number for the "HEKDFOANIPL" field.</summary>
    public const int HEKDFOANIPLFieldNumber = 3;
    private ulong hEKDFOANIPL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong HEKDFOANIPL {
      get { return hEKDFOANIPL_; }
      set {
        hEKDFOANIPL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (BpTier != other.BpTier) return false;
      if (LBGHPIOOJCE != other.LBGHPIOOJCE) return false;
      if (LMEPPGOHLGA != other.LMEPPGOHLGA) return false;
      if (Exp != other.Exp) return false;
      if (BCJBAEIJBIN != other.BCJBAEIJBIN) return false;
      if (LPGEODFEPKC != other.LPGEODFEPKC) return false;
      if (HNNLAAECAFH != other.HNNLAAECAFH) return false;
      if (LKMACLBLFAF != other.LKMACLBLFAF) return false;
      if (FHEGHADONCO != other.FHEGHADONCO) return false;
      if (KKBOCJMIKIA != other.KKBOCJMIKIA) return false;
      if (HDIAEAADOGK != other.HDIAEAADOGK) return false;
      if (HEKDFOANIPL != other.HEKDFOANIPL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) hash ^= BpTier.GetHashCode();
      if (LBGHPIOOJCE != 0UL) hash ^= LBGHPIOOJCE.GetHashCode();
      if (LMEPPGOHLGA != 0UL) hash ^= LMEPPGOHLGA.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (BCJBAEIJBIN != 0UL) hash ^= BCJBAEIJBIN.GetHashCode();
      if (LPGEODFEPKC != 0UL) hash ^= LPGEODFEPKC.GetHashCode();
      if (HNNLAAECAFH != 0UL) hash ^= HNNLAAECAFH.GetHashCode();
      if (LKMACLBLFAF != 0UL) hash ^= LKMACLBLFAF.GetHashCode();
      if (FHEGHADONCO != 0UL) hash ^= FHEGHADONCO.GetHashCode();
      if (KKBOCJMIKIA != 0) hash ^= KKBOCJMIKIA.GetHashCode();
      if (HDIAEAADOGK != 0) hash ^= HDIAEAADOGK.GetHashCode();
      if (HEKDFOANIPL != 0UL) hash ^= HEKDFOANIPL.GetHashCode();
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
      if (KKBOCJMIKIA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KKBOCJMIKIA);
      }
      if (LMEPPGOHLGA != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(LMEPPGOHLGA);
      }
      if (HEKDFOANIPL != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(HEKDFOANIPL);
      }
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) BpTier);
      }
      if (LPGEODFEPKC != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(LPGEODFEPKC);
      }
      if (Exp != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Exp);
      }
      if (BCJBAEIJBIN != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(BCJBAEIJBIN);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (FHEGHADONCO != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(FHEGHADONCO);
      }
      if (LKMACLBLFAF != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(LKMACLBLFAF);
      }
      if (HNNLAAECAFH != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(HNNLAAECAFH);
      }
      if (LBGHPIOOJCE != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(LBGHPIOOJCE);
      }
      if (HDIAEAADOGK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HDIAEAADOGK);
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
      if (KKBOCJMIKIA != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KKBOCJMIKIA);
      }
      if (LMEPPGOHLGA != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(LMEPPGOHLGA);
      }
      if (HEKDFOANIPL != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(HEKDFOANIPL);
      }
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) BpTier);
      }
      if (LPGEODFEPKC != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(LPGEODFEPKC);
      }
      if (Exp != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Exp);
      }
      if (BCJBAEIJBIN != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(BCJBAEIJBIN);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (FHEGHADONCO != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(FHEGHADONCO);
      }
      if (LKMACLBLFAF != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(LKMACLBLFAF);
      }
      if (HNNLAAECAFH != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(HNNLAAECAFH);
      }
      if (LBGHPIOOJCE != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(LBGHPIOOJCE);
      }
      if (HDIAEAADOGK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HDIAEAADOGK);
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
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BpTier);
      }
      if (LBGHPIOOJCE != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LBGHPIOOJCE);
      }
      if (LMEPPGOHLGA != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LMEPPGOHLGA);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (BCJBAEIJBIN != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BCJBAEIJBIN);
      }
      if (LPGEODFEPKC != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LPGEODFEPKC);
      }
      if (HNNLAAECAFH != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(HNNLAAECAFH);
      }
      if (LKMACLBLFAF != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LKMACLBLFAF);
      }
      if (FHEGHADONCO != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(FHEGHADONCO);
      }
      if (KKBOCJMIKIA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KKBOCJMIKIA);
      }
      if (HDIAEAADOGK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HDIAEAADOGK);
      }
      if (HEKDFOANIPL != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(HEKDFOANIPL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.BpTier != global::EggLink.DanhengServer.Proto.BpTierType.None) {
        BpTier = other.BpTier;
      }
      if (other.LBGHPIOOJCE != 0UL) {
        LBGHPIOOJCE = other.LBGHPIOOJCE;
      }
      if (other.LMEPPGOHLGA != 0UL) {
        LMEPPGOHLGA = other.LMEPPGOHLGA;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.BCJBAEIJBIN != 0UL) {
        BCJBAEIJBIN = other.BCJBAEIJBIN;
      }
      if (other.LPGEODFEPKC != 0UL) {
        LPGEODFEPKC = other.LPGEODFEPKC;
      }
      if (other.HNNLAAECAFH != 0UL) {
        HNNLAAECAFH = other.HNNLAAECAFH;
      }
      if (other.LKMACLBLFAF != 0UL) {
        LKMACLBLFAF = other.LKMACLBLFAF;
      }
      if (other.FHEGHADONCO != 0UL) {
        FHEGHADONCO = other.FHEGHADONCO;
      }
      if (other.KKBOCJMIKIA != 0) {
        KKBOCJMIKIA = other.KKBOCJMIKIA;
      }
      if (other.HDIAEAADOGK != 0) {
        HDIAEAADOGK = other.HDIAEAADOGK;
      }
      if (other.HEKDFOANIPL != 0UL) {
        HEKDFOANIPL = other.HEKDFOANIPL;
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
            KKBOCJMIKIA = input.ReadUInt32();
            break;
          }
          case 16: {
            LMEPPGOHLGA = input.ReadUInt64();
            break;
          }
          case 24: {
            HEKDFOANIPL = input.ReadUInt64();
            break;
          }
          case 32: {
            BpTier = (global::EggLink.DanhengServer.Proto.BpTierType) input.ReadEnum();
            break;
          }
          case 48: {
            LPGEODFEPKC = input.ReadUInt64();
            break;
          }
          case 56: {
            Exp = input.ReadUInt32();
            break;
          }
          case 64: {
            BCJBAEIJBIN = input.ReadUInt64();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 80: {
            FHEGHADONCO = input.ReadUInt64();
            break;
          }
          case 88: {
            LKMACLBLFAF = input.ReadUInt64();
            break;
          }
          case 96: {
            HNNLAAECAFH = input.ReadUInt64();
            break;
          }
          case 104: {
            LBGHPIOOJCE = input.ReadUInt64();
            break;
          }
          case 120: {
            HDIAEAADOGK = input.ReadUInt32();
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
            KKBOCJMIKIA = input.ReadUInt32();
            break;
          }
          case 16: {
            LMEPPGOHLGA = input.ReadUInt64();
            break;
          }
          case 24: {
            HEKDFOANIPL = input.ReadUInt64();
            break;
          }
          case 32: {
            BpTier = (global::EggLink.DanhengServer.Proto.BpTierType) input.ReadEnum();
            break;
          }
          case 48: {
            LPGEODFEPKC = input.ReadUInt64();
            break;
          }
          case 56: {
            Exp = input.ReadUInt32();
            break;
          }
          case 64: {
            BCJBAEIJBIN = input.ReadUInt64();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 80: {
            FHEGHADONCO = input.ReadUInt64();
            break;
          }
          case 88: {
            LKMACLBLFAF = input.ReadUInt64();
            break;
          }
          case 96: {
            HNNLAAECAFH = input.ReadUInt64();
            break;
          }
          case 104: {
            LBGHPIOOJCE = input.ReadUInt64();
            break;
          }
          case 120: {
            HDIAEAADOGK = input.ReadUInt32();
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
