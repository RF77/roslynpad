using System;

namespace RoslynPadLib.Roslyn
{
    [Serializable]
    public class RoslynData
    {
        public int Offset { get; set; }
        public string Code { get; set; }
    }
}