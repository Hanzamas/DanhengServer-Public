// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KickType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KickType.proto</summary>
  public static partial class KickTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for KickType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KickTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5LaWNrVHlwZS5wcm90byqLAQoIS2lja1R5cGUSEQoNS0lDS19TUVVFRVpF",
            "RBAAEg4KCktJQ0tfQkxBQ0sQARITCg9LSUNLX0NIQU5HRV9QV0QQAhIcChhL",
            "SUNLX0xPR0lOX1dISVRFX1RJTUVPVVQQAxIZChVLSUNLX0FDRV9BTlRJX0NI",
            "RUFURVIQBBIOCgpLSUNLX0JZX0dNEAVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.KickType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum KickType {
    [pbr::OriginalName("KICK_SQUEEZED")] KickSqueezed = 0,
    [pbr::OriginalName("KICK_BLACK")] KickBlack = 1,
    [pbr::OriginalName("KICK_CHANGE_PWD")] KickChangePwd = 2,
    [pbr::OriginalName("KICK_LOGIN_WHITE_TIMEOUT")] KickLoginWhiteTimeout = 3,
    [pbr::OriginalName("KICK_ACE_ANTI_CHEATER")] KickAceAntiCheater = 4,
    [pbr::OriginalName("KICK_BY_GM")] KickByGm = 5,
  }

  #endregion

}

#endregion Designer generated code
