﻿using WinFwk.UICommands;
using WinFwk.UIModules;

namespace MemoScope.Core
{
    public partial class UIClrDumpModule : UIModule, UIDataProvider<ClrDump>
    {
        public  ClrDump ClrDump { get; protected set; }

        public UIClrDumpModule()
        {
            InitializeComponent();
        }

        ClrDump UIDataProvider<ClrDump>.Data => ClrDump;
    }
}
