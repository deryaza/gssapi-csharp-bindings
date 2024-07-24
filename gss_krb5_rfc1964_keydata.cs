namespace Test
{
    public partial struct gss_krb5_rfc1964_keydata
    {
        [NativeTypeName("OM_uint32")]
        public uint sign_alg;

        [NativeTypeName("OM_uint32")]
        public uint seal_alg;

        [NativeTypeName("gss_krb5_lucid_key_t")]
        public gss_krb5_lucid_key ctx_key;
    }
}
