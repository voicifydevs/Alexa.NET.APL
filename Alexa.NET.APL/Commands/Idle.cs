﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.APL.Commands
{
    public class Idle:APLCommand
    {
        public override string Type => nameof(Idle);
    }
}
