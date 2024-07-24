namespace Test
{
    public partial struct gss_channel_bindings_struct
    {
        [NativeTypeName("OM_uint32")]
        public uint initiator_addrtype;

        [NativeTypeName("gss_buffer_desc")]
        public gss_buffer_desc_struct initiator_address;

        [NativeTypeName("OM_uint32")]
        public uint acceptor_addrtype;

        [NativeTypeName("gss_buffer_desc")]
        public gss_buffer_desc_struct acceptor_address;

        [NativeTypeName("gss_buffer_desc")]
        public gss_buffer_desc_struct application_data;
    }
}
