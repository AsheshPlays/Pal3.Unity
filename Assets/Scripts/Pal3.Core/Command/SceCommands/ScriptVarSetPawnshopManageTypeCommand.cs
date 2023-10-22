﻿// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.Core.Command.SceCommands
{
    #if PAL3
    [SceCommand(120, "取出当前当铺经营游戏的当前Manage类型并赋值给变量，" +
                    "参数：变量名", 0b0001)]
    public sealed class ScriptVarSetPawnshopManageTypeCommand : ICommand
    {
        public ScriptVarSetPawnshopManageTypeCommand(ushort variable)
        {
            Variable = variable;
        }

        [SceUserVariable] public ushort Variable { get; }
    }
    #endif
}