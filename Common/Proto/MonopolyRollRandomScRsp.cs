// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyRollRandomScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyRollRandomScRsp.proto</summary>
  public static partial class MonopolyRollRandomScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyRollRandomScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyRollRandomScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Nb25vcG9seVJvbGxSYW5kb21TY1JzcC5wcm90bxoRTk5MTkJGQUNQQkEu",
            "cHJvdG8iXwoXTW9ub3BvbHlSb2xsUmFuZG9tU2NSc3ASEAoIZXZlbnRfaWQY",
            "BiABKA0SDwoHcmV0Y29kZRgFIAEoDRIhCgtQQ0pPS0JHT0VLShgNIAEoCzIM",
            "Lk5OTE5CRkFDUEJBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.NNLNBFACPBAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyRollRandomScRsp), global::EggLink.DanhengServer.Proto.MonopolyRollRandomScRsp.Parser, new[]{ "EventId", "Retcode", "PCJOKBGOEKJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyRollRandomScRsp : pb::IMessage<MonopolyRollRandomScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyRollRandomScRsp> _parser = new pb::MessageParser<MonopolyRollRandomScRsp>(() => new MonopolyRollRandomScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyRollRandomScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyRollRandomScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyRollRandomScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyRollRandomScRsp(MonopolyRollRandomScRsp other) : this() {
      eventId_ = other.eventId_;
      retcode_ = other.retcode_;
      pCJOKBGOEKJ_ = other.pCJOKBGOEKJ_ != null ? other.pCJOKBGOEKJ_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyRollRandomScRsp Clone() {
      return new MonopolyRollRandomScRsp(this);
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 6;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
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

    /// <summary>Field number for the "PCJOKBGOEKJ" field.</summary>
    public const int PCJOKBGOEKJFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.NNLNBFACPBA pCJOKBGOEKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NNLNBFACPBA PCJOKBGOEKJ {
      get { return pCJOKBGOEKJ_; }
      set {
        pCJOKBGOEKJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyRollRandomScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyRollRandomScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventId != other.EventId) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(PCJOKBGOEKJ, other.PCJOKBGOEKJ)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (pCJOKBGOEKJ_ != null) hash ^= PCJOKBGOEKJ.GetHashCode();
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
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (EventId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EventId);
      }
      if (pCJOKBGOEKJ_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PCJOKBGOEKJ);
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
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (EventId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EventId);
      }
      if (pCJOKBGOEKJ_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PCJOKBGOEKJ);
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
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (pCJOKBGOEKJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PCJOKBGOEKJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyRollRandomScRsp other) {
      if (other == null) {
        return;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.pCJOKBGOEKJ_ != null) {
        if (pCJOKBGOEKJ_ == null) {
          PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.NNLNBFACPBA();
        }
        PCJOKBGOEKJ.MergeFrom(other.PCJOKBGOEKJ);
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
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            EventId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (pCJOKBGOEKJ_ == null) {
              PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.NNLNBFACPBA();
            }
            input.ReadMessage(PCJOKBGOEKJ);
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
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            EventId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (pCJOKBGOEKJ_ == null) {
              PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.NNLNBFACPBA();
            }
            input.ReadMessage(PCJOKBGOEKJ);
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
