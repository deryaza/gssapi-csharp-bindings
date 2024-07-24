namespace Test
{
    public unsafe partial struct gss_OID_desc_struct
    {
        [NativeTypeName("OM_uint32")]
        public uint length;

        public void* elements;
    }
}
