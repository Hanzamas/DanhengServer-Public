// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OfferingState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OfferingState.proto</summary>
  public static partial class OfferingStateReflection {

    #region Descriptor
    /// <summary>File descriptor for OfferingState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfferingStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNPZmZlcmluZ1N0YXRlLnByb3RvKloKDU9mZmVyaW5nU3RhdGUSFwoTT0ZG",
            "RVJJTkdfU1RBVEVfTk9ORRAAEhcKE09GRkVSSU5HX1NUQVRFX0xPQ0sQARIX",
            "ChNPRkZFUklOR19TVEFURV9PUEVOEAJCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.OfferingState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum OfferingState {
    [pbr::OriginalName("OFFERING_STATE_NONE")] None = 0,
    [pbr::OriginalName("OFFERING_STATE_LOCK")] Lock = 1,
    [pbr::OriginalName("OFFERING_STATE_OPEN")] Open = 2,
  }

  #endregion

}

#endregion Designer generated code
