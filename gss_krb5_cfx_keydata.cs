namespace Test
{
    public partial struct gss_krb5_cfx_keydata
    {
        [NativeTypeName("OM_uint32")]
        public uint have_acceptor_subkey;

        [NativeTypeName("gss_krb5_lucid_key_t")]
        public gss_krb5_lucid_key ctx_key;

        [NativeTypeName("gss_krb5_lucid_key_t")]
        public gss_krb5_lucid_key acceptor_subkey;
    }
}
