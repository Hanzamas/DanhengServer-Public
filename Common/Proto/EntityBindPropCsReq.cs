// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityBindPropCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EntityBindPropCsReq.proto</summary>
  public static partial class EntityBindPropCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EntityBindPropCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityBindPropCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlFbnRpdHlCaW5kUHJvcENzUmVxLnByb3RvGhBNb3Rpb25JbmZvLnByb3Rv",
            "IkcKE0VudGl0eUJpbmRQcm9wQ3NSZXESEwoLSkNDREZFQ0lDQ0MYCSABKAgS",
            "GwoGbW90aW9uGAIgASgLMgsuTW90aW9uSW5mb0IeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EntityBindPropCsReq), global::EggLink.DanhengServer.Proto.EntityBindPropCsReq.Parser, new[]{ "JCCDFECICCC", "Motion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EntityBindPropCsReq : pb::IMessage<EntityBindPropCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityBindPropCsReq> _parser = new pb::MessageParser<EntityBindPropCsReq>(() => new EntityBindPropCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityBindPropCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EntityBindPropCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityBindPropCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityBindPropCsReq(EntityBindPropCsReq other) : this() {
      jCCDFECICCC_ = other.jCCDFECICCC_;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityBindPropCsReq Clone() {
      return new EntityBindPropCsReq(this);
    }

    /// <summary>Field number for the "JCCDFECICCC" field.</summary>
    public const int JCCDFECICCCFieldNumber = 9;
    private bool jCCDFECICCC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JCCDFECICCC {
      get { return jCCDFECICCC_; }
      set {
        jCCDFECICCC_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityBindPropCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityBindPropCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JCCDFECICCC != other.JCCDFECICCC) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JCCDFECICCC != false) hash ^= JCCDFECICCC.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
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
      if (motion_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Motion);
      }
      if (JCCDFECICCC != false) {
        output.WriteRawTag(72);
        output.WriteBool(JCCDFECICCC);
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
      if (motion_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Motion);
      }
      if (JCCDFECICCC != false) {
        output.WriteRawTag(72);
        output.WriteBool(JCCDFECICCC);
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
      if (JCCDFECICCC != false) {
        size += 1 + 1;
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityBindPropCsReq other) {
      if (other == null) {
        return;
      }
      if (other.JCCDFECICCC != false) {
        JCCDFECICCC = other.JCCDFECICCC;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
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
          case 18: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 72: {
            JCCDFECICCC = input.ReadBool();
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
          case 18: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 72: {
            JCCDFECICCC = input.ReadBool();
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
