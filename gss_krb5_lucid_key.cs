namespace Test
{
    public unsafe partial struct gss_krb5_lucid_key
    {
        [NativeTypeName("OM_uint32")]
        public uint type;

        [NativeTypeName("OM_uint32")]
        public uint length;

        public void* data;
    }
}
