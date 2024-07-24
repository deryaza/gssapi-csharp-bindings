namespace Test
{
    public partial struct gss_krb5_lucid_context_v1
    {
        [NativeTypeName("OM_uint32")]
        public uint version;

        [NativeTypeName("OM_uint32")]
        public uint initiate;

        [NativeTypeName("OM_uint32")]
        public uint endtime;

        [NativeTypeName("uint64_t")]
        public nuint send_seq;

        [NativeTypeName("uint64_t")]
        public nuint recv_seq;

        [NativeTypeName("OM_uint32")]
        public uint protocol;

        [NativeTypeName("gss_krb5_rfc1964_keydata_t")]
        public gss_krb5_rfc1964_keydata rfc1964_kd;

        [NativeTypeName("gss_krb5_cfx_keydata_t")]
        public gss_krb5_cfx_keydata cfx_kd;
    }
}
