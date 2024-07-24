namespace Test
{
    public unsafe partial struct gss_buffer_desc_struct
    {
        [NativeTypeName("size_t")]
        public nuint length;

        public void* value;
    }
}
