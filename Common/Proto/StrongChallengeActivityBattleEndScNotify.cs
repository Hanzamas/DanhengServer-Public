// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StrongChallengeActivityBattleEndScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StrongChallengeActivityBattleEndScNotify.proto</summary>
  public static partial class StrongChallengeActivityBattleEndScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for StrongChallengeActivityBattleEndScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StrongChallengeActivityBattleEndScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5TdHJvbmdDaGFsbGVuZ2VBY3Rpdml0eUJhdHRsZUVuZFNjTm90aWZ5LnBy",
            "b3RvGhVCYXR0bGVFbmRTdGF0dXMucHJvdG8i3AEKKFN0cm9uZ0NoYWxsZW5n",
            "ZUFjdGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkSJAoKZW5kX3N0YXR1cxgNIAEo",
            "DjIQLkJhdHRsZUVuZFN0YXR1cxITCgtPQklISUVKTElNQRgPIAEoDRITCgtO",
            "RUNKTkpLTUxEShgIIAEoDRIQCghzdGFnZV9pZBgFIAEoDRIRCgltYXhfc2Nv",
            "cmUYASABKA0SEAoIc2NvcmVfaWQYCiABKA0SFAoMdG90YWxfZGFtYWdlGA4g",
            "ASgNEhMKC0lNQUxFQ0RLS0JQGAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleEndStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StrongChallengeActivityBattleEndScNotify), global::EggLink.DanhengServer.Proto.StrongChallengeActivityBattleEndScNotify.Parser, new[]{ "EndStatus", "OBIHIEJLIMA", "NECJNJKMLDJ", "StageId", "MaxScore", "ScoreId", "TotalDamage", "IMALECDKKBP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StrongChallengeActivityBattleEndScNotify : pb::IMessage<StrongChallengeActivityBattleEndScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StrongChallengeActivityBattleEndScNotify> _parser = new pb::MessageParser<StrongChallengeActivityBattleEndScNotify>(() => new StrongChallengeActivityBattleEndScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StrongChallengeActivityBattleEndScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StrongChallengeActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityBattleEndScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityBattleEndScNotify(StrongChallengeActivityBattleEndScNotify other) : this() {
      endStatus_ = other.endStatus_;
      oBIHIEJLIMA_ = other.oBIHIEJLIMA_;
      nECJNJKMLDJ_ = other.nECJNJKMLDJ_;
      stageId_ = other.stageId_;
      maxScore_ = other.maxScore_;
      scoreId_ = other.scoreId_;
      totalDamage_ = other.totalDamage_;
      iMALECDKKBP_ = other.iMALECDKKBP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrongChallengeActivityBattleEndScNotify Clone() {
      return new StrongChallengeActivityBattleEndScNotify(this);
    }

    /// <summary>Field number for the "end_status" field.</summary>
    public const int EndStatusFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.BattleEndStatus endStatus_ = global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleEndStatus EndStatus {
      get { return endStatus_; }
      set {
        endStatus_ = value;
      }
    }

    /// <summary>Field number for the "OBIHIEJLIMA" field.</summary>
    public const int OBIHIEJLIMAFieldNumber = 15;
    private uint oBIHIEJLIMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OBIHIEJLIMA {
      get { return oBIHIEJLIMA_; }
      set {
        oBIHIEJLIMA_ = value;
      }
    }

    /// <summary>Field number for the "NECJNJKMLDJ" field.</summary>
    public const int NECJNJKMLDJFieldNumber = 8;
    private uint nECJNJKMLDJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NECJNJKMLDJ {
      get { return nECJNJKMLDJ_; }
      set {
        nECJNJKMLDJ_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 5;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 1;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 10;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "total_damage" field.</summary>
    public const int TotalDamageFieldNumber = 14;
    private uint totalDamage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalDamage {
      get { return totalDamage_; }
      set {
        totalDamage_ = value;
      }
    }

    /// <summary>Field number for the "IMALECDKKBP" field.</summary>
    public const int IMALECDKKBPFieldNumber = 4;
    private uint iMALECDKKBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IMALECDKKBP {
      get { return iMALECDKKBP_; }
      set {
        iMALECDKKBP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StrongChallengeActivityBattleEndScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StrongChallengeActivityBattleEndScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EndStatus != other.EndStatus) return false;
      if (OBIHIEJLIMA != other.OBIHIEJLIMA) return false;
      if (NECJNJKMLDJ != other.NECJNJKMLDJ) return false;
      if (StageId != other.StageId) return false;
      if (MaxScore != other.MaxScore) return false;
      if (ScoreId != other.ScoreId) return false;
      if (TotalDamage != other.TotalDamage) return false;
      if (IMALECDKKBP != other.IMALECDKKBP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) hash ^= EndStatus.GetHashCode();
      if (OBIHIEJLIMA != 0) hash ^= OBIHIEJLIMA.GetHashCode();
      if (NECJNJKMLDJ != 0) hash ^= NECJNJKMLDJ.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      if (TotalDamage != 0) hash ^= TotalDamage.GetHashCode();
      if (IMALECDKKBP != 0) hash ^= IMALECDKKBP.GetHashCode();
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
      if (MaxScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MaxScore);
      }
      if (IMALECDKKBP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(IMALECDKKBP);
      }
      if (StageId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(StageId);
      }
      if (NECJNJKMLDJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NECJNJKMLDJ);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ScoreId);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) EndStatus);
      }
      if (TotalDamage != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalDamage);
      }
      if (OBIHIEJLIMA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OBIHIEJLIMA);
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
      if (MaxScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MaxScore);
      }
      if (IMALECDKKBP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(IMALECDKKBP);
      }
      if (StageId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(StageId);
      }
      if (NECJNJKMLDJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NECJNJKMLDJ);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ScoreId);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) EndStatus);
      }
      if (TotalDamage != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalDamage);
      }
      if (OBIHIEJLIMA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OBIHIEJLIMA);
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
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EndStatus);
      }
      if (OBIHIEJLIMA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OBIHIEJLIMA);
      }
      if (NECJNJKMLDJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NECJNJKMLDJ);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (ScoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      if (TotalDamage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalDamage);
      }
      if (IMALECDKKBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IMALECDKKBP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StrongChallengeActivityBattleEndScNotify other) {
      if (other == null) {
        return;
      }
      if (other.EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        EndStatus = other.EndStatus;
      }
      if (other.OBIHIEJLIMA != 0) {
        OBIHIEJLIMA = other.OBIHIEJLIMA;
      }
      if (other.NECJNJKMLDJ != 0) {
        NECJNJKMLDJ = other.NECJNJKMLDJ;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      if (other.TotalDamage != 0) {
        TotalDamage = other.TotalDamage;
      }
      if (other.IMALECDKKBP != 0) {
        IMALECDKKBP = other.IMALECDKKBP;
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
            MaxScore = input.ReadUInt32();
            break;
          }
          case 32: {
            IMALECDKKBP = input.ReadUInt32();
            break;
          }
          case 40: {
            StageId = input.ReadUInt32();
            break;
          }
          case 64: {
            NECJNJKMLDJ = input.ReadUInt32();
            break;
          }
          case 80: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 104: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 112: {
            TotalDamage = input.ReadUInt32();
            break;
          }
          case 120: {
            OBIHIEJLIMA = input.ReadUInt32();
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
            MaxScore = input.ReadUInt32();
            break;
          }
          case 32: {
            IMALECDKKBP = input.ReadUInt32();
            break;
          }
          case 40: {
            StageId = input.ReadUInt32();
            break;
          }
          case 64: {
            NECJNJKMLDJ = input.ReadUInt32();
            break;
          }
          case 80: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 104: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 112: {
            TotalDamage = input.ReadUInt32();
            break;
          }
          case 120: {
            OBIHIEJLIMA = input.ReadUInt32();
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
