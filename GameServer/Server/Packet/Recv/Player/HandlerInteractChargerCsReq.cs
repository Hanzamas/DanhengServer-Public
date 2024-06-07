﻿using EggLink.DanhengServer.Proto;
using EggLink.DanhengServer.Server.Packet.Send.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Recv.Player
{
    [Opcode(CmdIds.InteractChargerCsReq)]
    public class HandlerInteractChargerCsReq : Handler
    {
        public override void OnHandle(Connection connection, byte[] header, byte[] data)
        {
            var req = InteractChargerCsReq.Parser.ParseFrom(data);

            connection.Player!.ChargerNum = 5;
            connection.SendPacket(new PacketInteractChargerScRsp(req.ChargerInfo));
            connection.SendPacket(new PacketUpdateEnergyScNotify(connection.Player!.ChargerNum, 5));
        }
    }
}
