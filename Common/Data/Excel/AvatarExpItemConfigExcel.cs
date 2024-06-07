﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Data.Excel
{
    [ResourceEntity("AvatarExpItemConfig.json")]
    public class AvatarExpItemConfigExcel : ExcelResource
    {
        public int ItemID { get; set; }
        public int Exp { get; set; }

        public override int GetId()
        {
            return ItemID;
        }

        public override void Loaded()
        {
            if (Exp > 0)
            {
                GameData.AvatarExpItemConfigData.Add(GetId(), this);
            }
        }

        public override void AfterAllDone()
        {
            GameData.ItemConfigData.TryGetValue(ItemID, out ItemConfigExcel? itemConfig);
            if (itemConfig == null)
            {
                return;
            }
            itemConfig.Exp = Exp;
        }
    }
}
