using System.Runtime.InteropServices;

namespace Test
{
    public static unsafe partial class Methods
    {
        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_acquire_cred([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_name_t")] gss_name_struct* param1, [NativeTypeName("OM_uint32")] uint param2, [NativeTypeName("gss_OID_set")] gss_OID_set_desc_struct* param3, [NativeTypeName("gss_cred_usage_t")] int param4, [NativeTypeName("gss_cred_id_t *")] gss_cred_id_struct** param5, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param6, [NativeTypeName("OM_uint32 *")] uint* param7);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_release_cred([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_cred_id_t *")] gss_cred_id_struct** param1);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_init_sec_context([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* param1, [NativeTypeName("gss_ctx_id_t *")] gss_ctx_id_struct** param2, [NativeTypeName("gss_name_t")] gss_name_struct* param3, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param4, [NativeTypeName("OM_uint32")] uint param5, [NativeTypeName("OM_uint32")] uint param6, [NativeTypeName("gss_channel_bindings_t")] gss_channel_bindings_struct* param7, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param8, [NativeTypeName("gss_OID *")] gss_OID_desc_struct** param9, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param10, [NativeTypeName("OM_uint32 *")] uint* param11, [NativeTypeName("OM_uint32 *")] uint* param12);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_accept_sec_context([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t *")] gss_ctx_id_struct** param1, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, [NativeTypeName("gss_channel_bindings_t")] gss_channel_bindings_struct* param4, [NativeTypeName("gss_name_t *")] gss_name_struct** param5, [NativeTypeName("gss_OID *")] gss_OID_desc_struct** param6, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param7, [NativeTypeName("OM_uint32 *")] uint* param8, [NativeTypeName("OM_uint32 *")] uint* param9, [NativeTypeName("gss_cred_id_t *")] gss_cred_id_struct** param10);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_process_context_token([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_delete_sec_context([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t *")] gss_ctx_id_struct** param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_context_time([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("OM_uint32 *")] uint* param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_get_mic([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("gss_qop_t")] uint param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param4);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_verify_mic([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, [NativeTypeName("gss_qop_t *")] uint* param4);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_wrap([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, int param2, [NativeTypeName("gss_qop_t")] uint param3, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param4, int* param5, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param6);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_unwrap([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, int* param4, [NativeTypeName("gss_qop_t *")] uint* param5);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_display_status([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("OM_uint32")] uint param1, int param2, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param3, [NativeTypeName("OM_uint32 *")] uint* param4, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param5);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_indicate_mechs([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param1);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_compare_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_name_t")] gss_name_struct* param1, [NativeTypeName("gss_name_t")] gss_name_struct* param2, int* param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_display_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_name_t")] gss_name_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2, [NativeTypeName("gss_OID *")] gss_OID_desc_struct** param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_import_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param1, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param2, [NativeTypeName("gss_name_t *")] gss_name_struct** param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_release_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_name_t *")] gss_name_struct** param1);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_release_buffer([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param1);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_release_oid_set([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param1);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_cred([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* param1, [NativeTypeName("gss_name_t *")] gss_name_struct** param2, [NativeTypeName("OM_uint32 *")] uint* param3, [NativeTypeName("gss_cred_usage_t *")] int* param4, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param5);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_context([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("gss_name_t *")] gss_name_struct** param2, [NativeTypeName("gss_name_t *")] gss_name_struct** param3, [NativeTypeName("OM_uint32 *")] uint* param4, [NativeTypeName("gss_OID *")] gss_OID_desc_struct** param5, [NativeTypeName("OM_uint32 *")] uint* param6, int* param7, int* param8);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_wrap_size_limit([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, int param2, [NativeTypeName("gss_qop_t")] uint param3, [NativeTypeName("OM_uint32")] uint param4, [NativeTypeName("OM_uint32 *")] uint* param5);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_import_name_object([NativeTypeName("OM_uint32 *")] uint* param0, void* param1, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param2, [NativeTypeName("gss_name_t *")] gss_name_struct** param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_export_name_object([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_name_t")] gss_name_struct* param1, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param2, void** param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_add_cred([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* param1, [NativeTypeName("gss_name_t")] gss_name_struct* param2, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param3, [NativeTypeName("gss_cred_usage_t")] int param4, [NativeTypeName("OM_uint32")] uint param5, [NativeTypeName("OM_uint32")] uint param6, [NativeTypeName("gss_cred_id_t *")] gss_cred_id_struct** param7, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param8, [NativeTypeName("OM_uint32 *")] uint* param9, [NativeTypeName("OM_uint32 *")] uint* param10);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_cred_by_mech([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* param1, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param2, [NativeTypeName("gss_name_t *")] gss_name_struct** param3, [NativeTypeName("OM_uint32 *")] uint* param4, [NativeTypeName("OM_uint32 *")] uint* param5, [NativeTypeName("gss_cred_usage_t *")] int* param6);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_export_sec_context([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t *")] gss_ctx_id_struct** param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_import_sec_context([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param1, [NativeTypeName("gss_ctx_id_t *")] gss_ctx_id_struct** param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_release_oid([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID *")] gss_OID_desc_struct** param1);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_create_empty_oid_set([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param1);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_add_oid_set_member([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param1, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_test_oid_set_member([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param1, [NativeTypeName("gss_OID_set")] gss_OID_set_desc_struct* param2, int* param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_str_to_oid([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param1, [NativeTypeName("gss_OID *")] gss_OID_desc_struct** param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_oid_to_str([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_names_for_mech([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_OID")] gss_OID_desc_struct* param1, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_mechs_for_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("const gss_name_t")] gss_name_struct* param1, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_sign([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, int param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param4);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_verify([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, int* param4);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_seal([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, int param2, int param3, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param4, int* param5, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param6);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_unseal([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, int* param4, int* param5);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_export_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("const gss_name_t")] gss_name_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_duplicate_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("const gss_name_t")] gss_name_struct* param1, [NativeTypeName("gss_name_t *")] gss_name_struct** param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_canonicalize_name([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("const gss_name_t")] gss_name_struct* param1, [NativeTypeName("const gss_OID")] gss_OID_desc_struct* param2, [NativeTypeName("gss_name_t *")] gss_name_struct** param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_pseudo_random([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, int param2, [NativeTypeName("const gss_buffer_t")] gss_buffer_desc_struct* param3, [NativeTypeName("ssize_t")] nint param4, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param5);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_store_cred([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("const gss_cred_id_t")] gss_cred_id_struct* param1, [NativeTypeName("gss_cred_usage_t")] int param2, [NativeTypeName("const gss_OID")] gss_OID_desc_struct* param3, [NativeTypeName("OM_uint32")] uint param4, [NativeTypeName("OM_uint32")] uint param5, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param6, [NativeTypeName("gss_cred_usage_t *")] int* param7);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_set_neg_mechs([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* param1, [NativeTypeName("const gss_OID_set")] gss_OID_set_desc_struct* param2);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_indicate_mechs_by_attrs([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_const_OID_set")] gss_OID_set_desc_struct* param1, [NativeTypeName("gss_const_OID_set")] gss_OID_set_desc_struct* param2, [NativeTypeName("gss_const_OID_set")] gss_OID_set_desc_struct* param3, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param4);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_attrs_for_mech([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_const_OID")] gss_OID_desc_struct* param1, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param2, [NativeTypeName("gss_OID_set *")] gss_OID_set_desc_struct** param3);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_display_mech_attr([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_const_OID")] gss_OID_desc_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param4);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_saslname_for_mech([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("const gss_OID")] gss_OID_desc_struct* param1, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param2, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param3, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* param4);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_inquire_mech_for_saslname([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("const gss_buffer_t")] gss_buffer_desc_struct* param1, [NativeTypeName("gss_OID *")] gss_OID_desc_struct** param2);

        [NativeTypeName("#define GSS_C_DELEG_FLAG 1")]
        public const int GSS_C_DELEG_FLAG = 1;

        [NativeTypeName("#define GSS_C_MUTUAL_FLAG 2")]
        public const int GSS_C_MUTUAL_FLAG = 2;

        [NativeTypeName("#define GSS_C_REPLAY_FLAG 4")]
        public const int GSS_C_REPLAY_FLAG = 4;

        [NativeTypeName("#define GSS_C_SEQUENCE_FLAG 8")]
        public const int GSS_C_SEQUENCE_FLAG = 8;

        [NativeTypeName("#define GSS_C_CONF_FLAG 16")]
        public const int GSS_C_CONF_FLAG = 16;

        [NativeTypeName("#define GSS_C_INTEG_FLAG 32")]
        public const int GSS_C_INTEG_FLAG = 32;

        [NativeTypeName("#define GSS_C_ANON_FLAG 64")]
        public const int GSS_C_ANON_FLAG = 64;

        [NativeTypeName("#define GSS_C_PROT_READY_FLAG 128")]
        public const int GSS_C_PROT_READY_FLAG = 128;

        [NativeTypeName("#define GSS_C_TRANS_FLAG 256")]
        public const int GSS_C_TRANS_FLAG = 256;

        [NativeTypeName("#define GSS_C_DELEG_POLICY_FLAG 32768")]
        public const int GSS_C_DELEG_POLICY_FLAG = 32768;

        [NativeTypeName("#define GSS_C_BOTH 0")]
        public const int GSS_C_BOTH = 0;

        [NativeTypeName("#define GSS_C_INITIATE 1")]
        public const int GSS_C_INITIATE = 1;

        [NativeTypeName("#define GSS_C_ACCEPT 2")]
        public const int GSS_C_ACCEPT = 2;

        [NativeTypeName("#define GSS_C_GSS_CODE 1")]
        public const int GSS_C_GSS_CODE = 1;

        [NativeTypeName("#define GSS_C_MECH_CODE 2")]
        public const int GSS_C_MECH_CODE = 2;

        [NativeTypeName("#define GSS_C_AF_UNSPEC 0")]
        public const int GSS_C_AF_UNSPEC = 0;

        [NativeTypeName("#define GSS_C_AF_LOCAL 1")]
        public const int GSS_C_AF_LOCAL = 1;

        [NativeTypeName("#define GSS_C_AF_INET 2")]
        public const int GSS_C_AF_INET = 2;

        [NativeTypeName("#define GSS_C_AF_IMPLINK 3")]
        public const int GSS_C_AF_IMPLINK = 3;

        [NativeTypeName("#define GSS_C_AF_PUP 4")]
        public const int GSS_C_AF_PUP = 4;

        [NativeTypeName("#define GSS_C_AF_CHAOS 5")]
        public const int GSS_C_AF_CHAOS = 5;

        [NativeTypeName("#define GSS_C_AF_NS 6")]
        public const int GSS_C_AF_NS = 6;

        [NativeTypeName("#define GSS_C_AF_NBS 7")]
        public const int GSS_C_AF_NBS = 7;

        [NativeTypeName("#define GSS_C_AF_ECMA 8")]
        public const int GSS_C_AF_ECMA = 8;

        [NativeTypeName("#define GSS_C_AF_DATAKIT 9")]
        public const int GSS_C_AF_DATAKIT = 9;

        [NativeTypeName("#define GSS_C_AF_CCITT 10")]
        public const int GSS_C_AF_CCITT = 10;

        [NativeTypeName("#define GSS_C_AF_SNA 11")]
        public const int GSS_C_AF_SNA = 11;

        [NativeTypeName("#define GSS_C_AF_DECnet 12")]
        public const int GSS_C_AF_DECnet = 12;

        [NativeTypeName("#define GSS_C_AF_DLI 13")]
        public const int GSS_C_AF_DLI = 13;

        [NativeTypeName("#define GSS_C_AF_LAT 14")]
        public const int GSS_C_AF_LAT = 14;

        [NativeTypeName("#define GSS_C_AF_HYLINK 15")]
        public const int GSS_C_AF_HYLINK = 15;

        [NativeTypeName("#define GSS_C_AF_APPLETALK 16")]
        public const int GSS_C_AF_APPLETALK = 16;

        [NativeTypeName("#define GSS_C_AF_BSC 17")]
        public const int GSS_C_AF_BSC = 17;

        [NativeTypeName("#define GSS_C_AF_DSS 18")]
        public const int GSS_C_AF_DSS = 18;

        [NativeTypeName("#define GSS_C_AF_OSI 19")]
        public const int GSS_C_AF_OSI = 19;

        [NativeTypeName("#define GSS_C_AF_NETBIOS 20")]
        public const int GSS_C_AF_NETBIOS = 20;

        [NativeTypeName("#define GSS_C_AF_X25 21")]
        public const int GSS_C_AF_X25 = 21;

        [NativeTypeName("#define GSS_C_AF_NULLADDR 255")]
        public const int GSS_C_AF_NULLADDR = 255;

        [NativeTypeName("#define GSS_C_NO_NAME ((gss_name_t) 0)")]
        public static readonly gss_name_struct* GSS_C_NO_NAME = ((gss_name_struct*)(0));

        [NativeTypeName("#define GSS_C_NO_BUFFER ((gss_buffer_t) 0)")]
        public static readonly gss_buffer_desc_struct* GSS_C_NO_BUFFER = ((gss_buffer_desc_struct*)(0));

        [NativeTypeName("#define GSS_C_NO_OID ((gss_OID) 0)")]
        public static readonly gss_OID_desc_struct* GSS_C_NO_OID = ((gss_OID_desc_struct*)(0));

        [NativeTypeName("#define GSS_C_NO_OID_SET ((gss_OID_set) 0)")]
        public static readonly gss_OID_set_desc_struct* GSS_C_NO_OID_SET = ((gss_OID_set_desc_struct*)(0));

        [NativeTypeName("#define GSS_C_NO_CONTEXT ((gss_ctx_id_t) 0)")]
        public static readonly gss_ctx_id_struct* GSS_C_NO_CONTEXT = ((gss_ctx_id_struct*)(0));

        [NativeTypeName("#define GSS_C_NO_CREDENTIAL ((gss_cred_id_t) 0)")]
        public static readonly gss_cred_id_struct* GSS_C_NO_CREDENTIAL = ((gss_cred_id_struct*)(0));

        [NativeTypeName("#define GSS_C_NO_CHANNEL_BINDINGS ((gss_channel_bindings_t) 0)")]
        public static readonly gss_channel_bindings_struct* GSS_C_NO_CHANNEL_BINDINGS = ((gss_channel_bindings_struct*)(0));

        [NativeTypeName("#define GSS_C_NULL_OID GSS_C_NO_OID")]
        public static readonly gss_OID_desc_struct* GSS_C_NULL_OID = ((gss_OID_desc_struct*)(0));

        [NativeTypeName("#define GSS_C_NULL_OID_SET GSS_C_NO_OID_SET")]
        public static readonly gss_OID_set_desc_struct* GSS_C_NULL_OID_SET = ((gss_OID_set_desc_struct*)(0));

        [NativeTypeName("#define GSS_C_QOP_DEFAULT 0")]
        public const int GSS_C_QOP_DEFAULT = 0;

        [NativeTypeName("#define GSS_C_INDEFINITE ((OM_uint32) 0xfffffffful)")]
        public const uint GSS_C_INDEFINITE = ((uint)(0xffffffffU));

        [NativeTypeName("#define GSS_S_COMPLETE 0")]
        public const int GSS_S_COMPLETE = 0;

        [NativeTypeName("#define GSS_C_CALLING_ERROR_OFFSET 24")]
        public const int GSS_C_CALLING_ERROR_OFFSET = 24;

        [NativeTypeName("#define GSS_C_ROUTINE_ERROR_OFFSET 16")]
        public const int GSS_C_ROUTINE_ERROR_OFFSET = 16;

        [NativeTypeName("#define GSS_C_SUPPLEMENTARY_OFFSET 0")]
        public const int GSS_C_SUPPLEMENTARY_OFFSET = 0;

        [NativeTypeName("#define GSS_C_CALLING_ERROR_MASK ((OM_uint32) 0377ul)")]
        public const uint GSS_C_CALLING_ERROR_MASK = ((uint)(0377U));

        [NativeTypeName("#define GSS_C_ROUTINE_ERROR_MASK ((OM_uint32) 0377ul)")]
        public const uint GSS_C_ROUTINE_ERROR_MASK = ((uint)(0377U));

        [NativeTypeName("#define GSS_C_SUPPLEMENTARY_MASK ((OM_uint32) 0177777ul)")]
        public const uint GSS_C_SUPPLEMENTARY_MASK = ((uint)(0177777U));

        [NativeTypeName("#define GSS_S_CALL_INACCESSIBLE_READ (((OM_uint32) 1ul) << GSS_C_CALLING_ERROR_OFFSET)")]
        public const uint GSS_S_CALL_INACCESSIBLE_READ = (((uint)(1U)) << 24);

        [NativeTypeName("#define GSS_S_CALL_INACCESSIBLE_WRITE (((OM_uint32) 2ul) << GSS_C_CALLING_ERROR_OFFSET)")]
        public const uint GSS_S_CALL_INACCESSIBLE_WRITE = (((uint)(2U)) << 24);

        [NativeTypeName("#define GSS_S_CALL_BAD_STRUCTURE (((OM_uint32) 3ul) << GSS_C_CALLING_ERROR_OFFSET)")]
        public const uint GSS_S_CALL_BAD_STRUCTURE = (((uint)(3U)) << 24);

        [NativeTypeName("#define GSS_S_BAD_MECH (((OM_uint32) 1ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_MECH = (((uint)(1U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_NAME (((OM_uint32) 2ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_NAME = (((uint)(2U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_NAMETYPE (((OM_uint32) 3ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_NAMETYPE = (((uint)(3U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_BINDINGS (((OM_uint32) 4ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_BINDINGS = (((uint)(4U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_STATUS (((OM_uint32) 5ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_STATUS = (((uint)(5U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_SIG (((OM_uint32) 6ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_SIG = (((uint)(6U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_MIC GSS_S_BAD_SIG")]
        public const uint GSS_S_BAD_MIC = (((uint)(6U)) << 16);

        [NativeTypeName("#define GSS_S_NO_CRED (((OM_uint32) 7ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_NO_CRED = (((uint)(7U)) << 16);

        [NativeTypeName("#define GSS_S_NO_CONTEXT (((OM_uint32) 8ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_NO_CONTEXT = (((uint)(8U)) << 16);

        [NativeTypeName("#define GSS_S_DEFECTIVE_TOKEN (((OM_uint32) 9ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_DEFECTIVE_TOKEN = (((uint)(9U)) << 16);

        [NativeTypeName("#define GSS_S_DEFECTIVE_CREDENTIAL (((OM_uint32) 10ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_DEFECTIVE_CREDENTIAL = (((uint)(10U)) << 16);

        [NativeTypeName("#define GSS_S_CREDENTIALS_EXPIRED (((OM_uint32) 11ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_CREDENTIALS_EXPIRED = (((uint)(11U)) << 16);

        [NativeTypeName("#define GSS_S_CONTEXT_EXPIRED (((OM_uint32) 12ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_CONTEXT_EXPIRED = (((uint)(12U)) << 16);

        [NativeTypeName("#define GSS_S_FAILURE (((OM_uint32) 13ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_FAILURE = (((uint)(13U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_QOP (((OM_uint32) 14ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_QOP = (((uint)(14U)) << 16);

        [NativeTypeName("#define GSS_S_UNAUTHORIZED (((OM_uint32) 15ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_UNAUTHORIZED = (((uint)(15U)) << 16);

        [NativeTypeName("#define GSS_S_UNAVAILABLE (((OM_uint32) 16ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_UNAVAILABLE = (((uint)(16U)) << 16);

        [NativeTypeName("#define GSS_S_DUPLICATE_ELEMENT (((OM_uint32) 17ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_DUPLICATE_ELEMENT = (((uint)(17U)) << 16);

        [NativeTypeName("#define GSS_S_NAME_NOT_MN (((OM_uint32) 18ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_NAME_NOT_MN = (((uint)(18U)) << 16);

        [NativeTypeName("#define GSS_S_BAD_MECH_ATTR (((OM_uint32) 19ul) << GSS_C_ROUTINE_ERROR_OFFSET)")]
        public const uint GSS_S_BAD_MECH_ATTR = (((uint)(19U)) << 16);

        [NativeTypeName("#define GSS_S_CONTINUE_NEEDED (1 << (GSS_C_SUPPLEMENTARY_OFFSET + 0))")]
        public const int GSS_S_CONTINUE_NEEDED = (1 << (0 + 0));

        [NativeTypeName("#define GSS_S_DUPLICATE_TOKEN (1 << (GSS_C_SUPPLEMENTARY_OFFSET + 1))")]
        public const int GSS_S_DUPLICATE_TOKEN = (1 << (0 + 1));

        [NativeTypeName("#define GSS_S_OLD_TOKEN (1 << (GSS_C_SUPPLEMENTARY_OFFSET + 2))")]
        public const int GSS_S_OLD_TOKEN = (1 << (0 + 2));

        [NativeTypeName("#define GSS_S_UNSEQ_TOKEN (1 << (GSS_C_SUPPLEMENTARY_OFFSET + 3))")]
        public const int GSS_S_UNSEQ_TOKEN = (1 << (0 + 3));

        [NativeTypeName("#define GSS_S_GAP_TOKEN (1 << (GSS_C_SUPPLEMENTARY_OFFSET + 4))")]
        public const int GSS_S_GAP_TOKEN = (1 << (0 + 4));

        [NativeTypeName("#define GSS_C_PRF_KEY_FULL 0")]
        public const int GSS_C_PRF_KEY_FULL = 0;

        [NativeTypeName("#define GSS_C_PRF_KEY_PARTIAL 1")]
        public const int GSS_C_PRF_KEY_PARTIAL = 1;

        [NativeTypeName("#define GSS_S_CRED_UNAVAIL GSS_S_FAILURE")]
        public const uint GSS_S_CRED_UNAVAIL = (((uint)(13U)) << 16);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint krb5_gss_register_acceptor_identity([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_get_tkt_flags([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* context_handle, [NativeTypeName("krb5_flags *")] int* ticket_flags);

        /*
        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_copy_ccache([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* cred_handle, [NativeTypeName("krb5_ccache")] _krb5_ccache* out_ccache);
        */

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_ccache_name([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char **")] sbyte** out_name);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_set_allowable_enctypes([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* cred, [NativeTypeName("OM_uint32")] uint num_ktypes, [NativeTypeName("krb5_enctype *")] int* ktypes);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_export_lucid_sec_context([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("gss_ctx_id_t *")] gss_ctx_id_struct** context_handle, [NativeTypeName("OM_uint32")] uint version, void** kctx);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_free_lucid_sec_context([NativeTypeName("OM_uint32 *")] uint* minor_status, void* kctx);

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gsskrb5_extract_authz_data_from_sec_context([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("const gss_ctx_id_t")] gss_ctx_id_struct* context_handle, int ad_type, [NativeTypeName("gss_buffer_t")] gss_buffer_desc_struct* ad_data);

        /*
        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_set_cred_rcache([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("gss_cred_id_t")] gss_cred_id_struct* cred, [NativeTypeName("krb5_rcache")] krb5_rc_st* rcache);
*/

        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gsskrb5_extract_authtime_from_sec_context([NativeTypeName("OM_uint32 *")] uint* param0, [NativeTypeName("gss_ctx_id_t")] gss_ctx_id_struct* param1, [NativeTypeName("krb5_timestamp *")] int* param2);

        /*
        [DllImport("libgssapi_krb5.so", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("OM_uint32")]
        public static extern uint gss_krb5_import_cred([NativeTypeName("OM_uint32 *")] uint* minor_status, [NativeTypeName("krb5_ccache")] _krb5_ccache* id, [NativeTypeName("krb5_principal")] krb5_principal_data* keytab_principal, [NativeTypeName("krb5_keytab")] _krb5_kt* keytab, [NativeTypeName("gss_cred_id_t *")] gss_cred_id_struct** cred);
        */

        /*
        [NativeTypeName("#define GSS_KRB5_NT_HOSTBASED_SERVICE_NAME GSS_C_NT_HOSTBASED_SERVICE")]
        public static readonly gss_OID_desc_struct* GSS_KRB5_NT_HOSTBASED_SERVICE_NAME = GSS_C_NT_HOSTBASED_SERVICE;

        [NativeTypeName("#define GSS_KRB5_NT_USER_NAME GSS_C_NT_USER_NAME")]
        public static readonly gss_OID_desc_struct* GSS_KRB5_NT_USER_NAME = GSS_C_NT_USER_NAME;

        [NativeTypeName("#define GSS_KRB5_NT_MACHINE_UID_NAME GSS_C_NT_MACHINE_UID_NAME")]
        public static readonly gss_OID_desc_struct* GSS_KRB5_NT_MACHINE_UID_NAME = GSS_C_NT_MACHINE_UID_NAME;

        [NativeTypeName("#define GSS_KRB5_NT_STRING_UID_NAME GSS_C_NT_STRING_UID_NAME")]
        public static readonly gss_OID_desc_struct* GSS_KRB5_NT_STRING_UID_NAME = GSS_C_NT_STRING_UID_NAME;

        [NativeTypeName("#define gss_krb5_nt_general_name gss_nt_krb5_name")]
        public static readonly gss_OID_desc_struct* gss_krb5_nt_general_name = gss_nt_krb5_name;

        [NativeTypeName("#define gss_krb5_nt_principal gss_nt_krb5_principal")]
        public static readonly gss_OID_desc_struct* gss_krb5_nt_principal = gss_nt_krb5_principal;
        */

        [NativeTypeName("#define gsskrb5_register_acceptor_identity krb5_gss_register_acceptor_identity")]
        public static readonly delegate*<sbyte*, uint> gsskrb5_register_acceptor_identity = &krb5_gss_register_acceptor_identity;
    }
}
