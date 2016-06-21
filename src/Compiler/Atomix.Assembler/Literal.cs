﻿/*
* PROJECT:          Atomix Development
* LICENSE:          Copyright (C) Atomix Development, Inc - All Rights Reserved
*                   Unauthorized copying of this file, via any medium is
*                   strictly prohibited Proprietary and confidential.
* PURPOSE:          Literal class
* PROGRAMMERS:      Aman Priyadarshi (aman.eureka@gmail.com)
*/

using System.IO;

namespace Atomix.Assembler
{
    public class Literal : Instruction        
    {        
        public readonly string Assembly;

        public Literal(string aAsm)
            :base ("Literal")
        {
            Assembly = aAsm;
        }

        public override void FlushText(StreamWriter aSW)
        {
            aSW.WriteLine(Assembly);
        }
    }
}
