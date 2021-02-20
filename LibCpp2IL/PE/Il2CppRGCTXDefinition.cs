﻿namespace LibCpp2IL.PE
{
    public class Il2CppRGCTXDefinition
    {
        public Il2CppRGCTXDataType type;
        public int _rawIndex;

        public int MethodIndex => _rawIndex;

        public int TypeIndex => _rawIndex;

        public Il2CppMethodSpec? MethodSpec => LibCpp2IlMain.ThePe?.methodSpecs[MethodIndex];
    }
}