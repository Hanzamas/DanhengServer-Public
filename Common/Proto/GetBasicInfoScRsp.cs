// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetBasicInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetBasicInfoScRsp.proto</summary>
  public static partial class GetBasicInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetBasicInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetBasicInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHZXRCYXNpY0luZm9TY1JzcC5wcm90bxoRUFBFR0FDQ0hHR08ucHJvdG8i",
            "8gEKEUdldEJhc2ljSW5mb1NjUnNwEhkKEW5leHRfcmVjb3Zlcl90aW1lGA8g",
            "ASgDEg8KB2N1cl9kYXkYAyABKA0SHgoWbGFzdF9zZXRfbmlja25hbWVfdGlt",
            "ZRgKIAEoAxIpChNwbGF5ZXJfc2V0dGluZ19pbmZvGAwgASgLMgwuUFBFR0FD",
            "Q0hHR08SIgoad2Vla19jb2Nvb25fZmluaXNoZWRfY291bnQYCyABKA0SFgoO",
            "ZXhjaGFuZ2VfdGltZXMYCCABKA0SDwoHcmV0Y29kZRgHIAEoDRIZChFnYW1l",
            "cGxheV9iaXJ0aGRheRgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PPEGACCHGGOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetBasicInfoScRsp), global::EggLink.DanhengServer.Proto.GetBasicInfoScRsp.Parser, new[]{ "NextRecoverTime", "CurDay", "LastSetNicknameTime", "PlayerSettingInfo", "WeekCocoonFinishedCount", "ExchangeTimes", "Retcode", "GameplayBirthday" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetBasicInfoScRsp : pb::IMessage<GetBasicInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetBasicInfoScRsp> _parser = new pb::MessageParser<GetBasicInfoScRsp>(() => new GetBasicInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetBasicInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetBasicInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBasicInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBasicInfoScRsp(GetBasicInfoScRsp other) : this() {
      nextRecoverTime_ = other.nextRecoverTime_;
      curDay_ = other.curDay_;
      lastSetNicknameTime_ = other.lastSetNicknameTime_;
      playerSettingInfo_ = other.playerSettingInfo_ != null ? other.playerSettingInfo_.Clone() : null;
      weekCocoonFinishedCount_ = other.weekCocoonFinishedCount_;
      exchangeTimes_ = other.exchangeTimes_;
      retcode_ = other.retcode_;
      gameplayBirthday_ = other.gameplayBirthday_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBasicInfoScRsp Clone() {
      return new GetBasicInfoScRsp(this);
    }

    /// <summary>Field number for the "next_recover_time" field.</summary>
    public const int NextRecoverTimeFieldNumber = 15;
    private long nextRecoverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long NextRecoverTime {
      get { return nextRecoverTime_; }
      set {
        nextRecoverTime_ = value;
      }
    }

    /// <summary>Field number for the "cur_day" field.</summary>
    public const int CurDayFieldNumber = 3;
    private uint curDay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurDay {
      get { return curDay_; }
      set {
        curDay_ = value;
      }
    }

    /// <summary>Field number for the "last_set_nickname_time" field.</summary>
    public const int LastSetNicknameTimeFieldNumber = 10;
    private long lastSetNicknameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LastSetNicknameTime {
      get { return lastSetNicknameTime_; }
      set {
        lastSetNicknameTime_ = value;
      }
    }

    /// <summary>Field number for the "player_setting_info" field.</summary>
    public const int PlayerSettingInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.PPEGACCHGGO playerSettingInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PPEGACCHGGO PlayerSettingInfo {
      get { return playerSettingInfo_; }
      set {
        playerSettingInfo_ = value;
      }
    }

    /// <summary>Field number for the "week_cocoon_finished_count" field.</summary>
    public const int WeekCocoonFinishedCountFieldNumber = 11;
    private uint weekCocoonFinishedCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeekCocoonFinishedCount {
      get { return weekCocoonFinishedCount_; }
      set {
        weekCocoonFinishedCount_ = value;
      }
    }

    /// <summary>Field number for the "exchange_times" field.</summary>
    public const int ExchangeTimesFieldNumber = 8;
    private uint exchangeTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExchangeTimes {
      get { return exchangeTimes_; }
      set {
        exchangeTimes_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "gameplay_birthday" field.</summary>
    public const int GameplayBirthdayFieldNumber = 2;
    private uint gameplayBirthday_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameplayBirthday {
      get { return gameplayBirthday_; }
      set {
        gameplayBirthday_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetBasicInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetBasicInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NextRecoverTime != other.NextRecoverTime) return false;
      if (CurDay != other.CurDay) return false;
      if (LastSetNicknameTime != other.LastSetNicknameTime) return false;
      if (!object.Equals(PlayerSettingInfo, other.PlayerSettingInfo)) return false;
      if (WeekCocoonFinishedCount != other.WeekCocoonFinishedCount) return false;
      if (ExchangeTimes != other.ExchangeTimes) return false;
      if (Retcode != other.Retcode) return false;
      if (GameplayBirthday != other.GameplayBirthday) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NextRecoverTime != 0L) hash ^= NextRecoverTime.GetHashCode();
      if (CurDay != 0) hash ^= CurDay.GetHashCode();
      if (LastSetNicknameTime != 0L) hash ^= LastSetNicknameTime.GetHashCode();
      if (playerSettingInfo_ != null) hash ^= PlayerSettingInfo.GetHashCode();
      if (WeekCocoonFinishedCount != 0) hash ^= WeekCocoonFinishedCount.GetHashCode();
      if (ExchangeTimes != 0) hash ^= ExchangeTimes.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GameplayBirthday != 0) hash ^= GameplayBirthday.GetHashCode();
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
      if (GameplayBirthday != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameplayBirthday);
      }
      if (CurDay != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurDay);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (ExchangeTimes != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ExchangeTimes);
      }
      if (LastSetNicknameTime != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(LastSetNicknameTime);
      }
      if (WeekCocoonFinishedCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WeekCocoonFinishedCount);
      }
      if (playerSettingInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PlayerSettingInfo);
      }
      if (NextRecoverTime != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(NextRecoverTime);
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
      if (GameplayBirthday != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameplayBirthday);
      }
      if (CurDay != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurDay);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Retcode);
      }
      if (ExchangeTimes != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ExchangeTimes);
      }
      if (LastSetNicknameTime != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(LastSetNicknameTime);
      }
      if (WeekCocoonFinishedCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WeekCocoonFinishedCount);
      }
      if (playerSettingInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(PlayerSettingInfo);
      }
      if (NextRecoverTime != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(NextRecoverTime);
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
      if (NextRecoverTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextRecoverTime);
      }
      if (CurDay != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurDay);
      }
      if (LastSetNicknameTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastSetNicknameTime);
      }
      if (playerSettingInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerSettingInfo);
      }
      if (WeekCocoonFinishedCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeekCocoonFinishedCount);
      }
      if (ExchangeTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExchangeTimes);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (GameplayBirthday != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameplayBirthday);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetBasicInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.NextRecoverTime != 0L) {
        NextRecoverTime = other.NextRecoverTime;
      }
      if (other.CurDay != 0) {
        CurDay = other.CurDay;
      }
      if (other.LastSetNicknameTime != 0L) {
        LastSetNicknameTime = other.LastSetNicknameTime;
      }
      if (other.playerSettingInfo_ != null) {
        if (playerSettingInfo_ == null) {
          PlayerSettingInfo = new global::EggLink.DanhengServer.Proto.PPEGACCHGGO();
        }
        PlayerSettingInfo.MergeFrom(other.PlayerSettingInfo);
      }
      if (other.WeekCocoonFinishedCount != 0) {
        WeekCocoonFinishedCount = other.WeekCocoonFinishedCount;
      }
      if (other.ExchangeTimes != 0) {
        ExchangeTimes = other.ExchangeTimes;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GameplayBirthday != 0) {
        GameplayBirthday = other.GameplayBirthday;
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
            GameplayBirthday = input.ReadUInt32();
            break;
          }
          case 24: {
            CurDay = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            ExchangeTimes = input.ReadUInt32();
            break;
          }
          case 80: {
            LastSetNicknameTime = input.ReadInt64();
            break;
          }
          case 88: {
            WeekCocoonFinishedCount = input.ReadUInt32();
            break;
          }
          case 98: {
            if (playerSettingInfo_ == null) {
              PlayerSettingInfo = new global::EggLink.DanhengServer.Proto.PPEGACCHGGO();
            }
            input.ReadMessage(PlayerSettingInfo);
            break;
          }
          case 120: {
            NextRecoverTime = input.ReadInt64();
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
            GameplayBirthday = input.ReadUInt32();
            break;
          }
          case 24: {
            CurDay = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 64: {
            ExchangeTimes = input.ReadUInt32();
            break;
          }
          case 80: {
            LastSetNicknameTime = input.ReadInt64();
            break;
          }
          case 88: {
            WeekCocoonFinishedCount = input.ReadUInt32();
            break;
          }
          case 98: {
            if (playerSettingInfo_ == null) {
              PlayerSettingInfo = new global::EggLink.DanhengServer.Proto.PPEGACCHGGO();
            }
            input.ReadMessage(PlayerSettingInfo);
            break;
          }
          case 120: {
            NextRecoverTime = input.ReadInt64();
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
