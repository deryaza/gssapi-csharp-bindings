namespace Test
{
    public unsafe partial struct gss_OID_set_desc_struct
    {
        [NativeTypeName("size_t")]
        public nuint count;

        [NativeTypeName("gss_OID")]
        public gss_OID_desc_struct* elements;
    }
}
