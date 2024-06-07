// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartChallengeStoryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StartChallengeStoryInfo.proto</summary>
  public static partial class StartChallengeStoryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for StartChallengeStoryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartChallengeStoryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TdGFydENoYWxsZW5nZVN0b3J5SW5mby5wcm90bxohU3RhcnRDaGFsbGVu",
            "Z2VTdG9yeUJ1ZmZJbmZvLnByb3RvIl8KF1N0YXJ0Q2hhbGxlbmdlU3RvcnlJ",
            "bmZvEjcKD3N0b3J5X2J1ZmZfaW5mbxgOIAEoCzIcLlN0YXJ0Q2hhbGxlbmdl",
            "U3RvcnlCdWZmSW5mb0gAQgsKCWJ1ZmZfaW5mb0IeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StartChallengeStoryInfo), global::EggLink.DanhengServer.Proto.StartChallengeStoryInfo.Parser, new[]{ "StoryBuffInfo" }, new[]{ "BuffInfo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StartChallengeStoryInfo : pb::IMessage<StartChallengeStoryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartChallengeStoryInfo> _parser = new pb::MessageParser<StartChallengeStoryInfo>(() => new StartChallengeStoryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartChallengeStoryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StartChallengeStoryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeStoryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeStoryInfo(StartChallengeStoryInfo other) : this() {
      switch (other.BuffInfoCase) {
        case BuffInfoOneofCase.StoryBuffInfo:
          StoryBuffInfo = other.StoryBuffInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartChallengeStoryInfo Clone() {
      return new StartChallengeStoryInfo(this);
    }

    /// <summary>Field number for the "story_buff_info" field.</summary>
    public const int StoryBuffInfoFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfo StoryBuffInfo {
      get { return buffInfoCase_ == BuffInfoOneofCase.StoryBuffInfo ? (global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfo) buffInfo_ : null; }
      set {
        buffInfo_ = value;
        buffInfoCase_ = value == null ? BuffInfoOneofCase.None : BuffInfoOneofCase.StoryBuffInfo;
      }
    }

    private object buffInfo_;
    /// <summary>Enum of possible cases for the "buff_info" oneof.</summary>
    public enum BuffInfoOneofCase {
      None = 0,
      StoryBuffInfo = 14,
    }
    private BuffInfoOneofCase buffInfoCase_ = BuffInfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuffInfoOneofCase BuffInfoCase {
      get { return buffInfoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBuffInfo() {
      buffInfoCase_ = BuffInfoOneofCase.None;
      buffInfo_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartChallengeStoryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartChallengeStoryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StoryBuffInfo, other.StoryBuffInfo)) return false;
      if (BuffInfoCase != other.BuffInfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (buffInfoCase_ == BuffInfoOneofCase.StoryBuffInfo) hash ^= StoryBuffInfo.GetHashCode();
      hash ^= (int) buffInfoCase_;
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
      if (buffInfoCase_ == BuffInfoOneofCase.StoryBuffInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(StoryBuffInfo);
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
      if (buffInfoCase_ == BuffInfoOneofCase.StoryBuffInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(StoryBuffInfo);
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
      if (buffInfoCase_ == BuffInfoOneofCase.StoryBuffInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StoryBuffInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartChallengeStoryInfo other) {
      if (other == null) {
        return;
      }
      switch (other.BuffInfoCase) {
        case BuffInfoOneofCase.StoryBuffInfo:
          if (StoryBuffInfo == null) {
            StoryBuffInfo = new global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfo();
          }
          StoryBuffInfo.MergeFrom(other.StoryBuffInfo);
          break;
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
          case 114: {
            global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfo();
            if (buffInfoCase_ == BuffInfoOneofCase.StoryBuffInfo) {
              subBuilder.MergeFrom(StoryBuffInfo);
            }
            input.ReadMessage(subBuilder);
            StoryBuffInfo = subBuilder;
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
          case 114: {
            global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.StartChallengeStoryBuffInfo();
            if (buffInfoCase_ == BuffInfoOneofCase.StoryBuffInfo) {
              subBuilder.MergeFrom(StoryBuffInfo);
            }
            input.ReadMessage(subBuilder);
            StoryBuffInfo = subBuilder;
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
