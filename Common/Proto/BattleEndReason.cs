// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattleEndReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BattleEndReason.proto</summary>
  public static partial class BattleEndReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleEndReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleEndReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVCYXR0bGVFbmRSZWFzb24ucHJvdG8qbgoPQmF0dGxlRW5kUmVhc29uEhoK",
            "FkJBVFRMRV9FTkRfUkVBU09OX05PTkUQABIdChlCQVRUTEVfRU5EX1JFQVNP",
            "Tl9BTExfRElFEAESIAocQkFUVExFX0VORF9SRUFTT05fVFVSTl9MSU1JVBAC",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.BattleEndReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum BattleEndReason {
    [pbr::OriginalName("BATTLE_END_REASON_NONE")] None = 0,
    [pbr::OriginalName("BATTLE_END_REASON_ALL_DIE")] AllDie = 1,
    [pbr::OriginalName("BATTLE_END_REASON_TURN_LIMIT")] TurnLimit = 2,
  }

  #endregion

}

#endregion Designer generated code
