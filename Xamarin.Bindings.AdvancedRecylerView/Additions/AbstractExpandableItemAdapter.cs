using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.H6ah4i.Android.Widget.Advrecyclerview.Utils
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']"
    [global::Android.Runtime.Register("com/h6ah4i/android/widget/advrecyclerview/utils/AbstractExpandableItemAdapter", DoNotGenerateAcw = true)]
    [global::Java.Interop.JavaTypeParameters(new string[] { "GVH extends android.support.v7.widget.RecyclerView.ViewHolder", "CVH extends android.support.v7.widget.RecyclerView.ViewHolder" })]
    public abstract partial class AbstractExpandableItemAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter, global::Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapter
    {

        internal static IntPtr java_class_handle;
        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/h6ah4i/android/widget/advrecyclerview/utils/AbstractExpandableItemAdapter", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(AbstractExpandableItemAdapter); }
        }

        protected AbstractExpandableItemAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/constructor[@name='AbstractExpandableItemAdapter' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe AbstractExpandableItemAdapter()
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (Handle != IntPtr.Zero)
                return;

            try
            {
                if (GetType() != typeof(AbstractExpandableItemAdapter))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "()V"),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(Handle, "()V");
                    return;
                }

                if (id_ctor == IntPtr.Zero)
                    id_ctor = JNIEnv.GetMethodID(class_ref, "<init>", "()V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(Handle, class_ref, id_ctor);
            }
            finally
            {
            }
        }

        static IntPtr id_getItemCount;
        public override unsafe int ItemCount
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getItemCount' and count(parameter)=0]"
            [Register("getItemCount", "()I", "GetGetItemCountHandler")]
            get
            {
                if (id_getItemCount == IntPtr.Zero)
                    id_getItemCount = JNIEnv.GetMethodID(class_ref, "getItemCount", "()I");
                try
                {
                    return JNIEnv.CallIntMethod(Handle, id_getItemCount);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getItemId_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getItemId", "(I)J", "")]
        public override sealed unsafe long GetItemId(int p0)
        {
            if (id_getItemId_I == IntPtr.Zero)
                id_getItemId_I = JNIEnv.GetMethodID(class_ref, "getItemId", "(I)J");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                return JNIEnv.CallLongMethod(Handle, id_getItemId_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getItemViewType_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getItemViewType", "(I)I", "")]
        public override sealed unsafe int GetItemViewType(int p0)
        {
            if (id_getItemViewType_I == IntPtr.Zero)
                id_getItemViewType_I = JNIEnv.GetMethodID(class_ref, "getItemViewType", "(I)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                return JNIEnv.CallIntMethod(Handle, id_getItemViewType_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
        [Register("onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "")]
        public override sealed unsafe void OnBindViewHolder(global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
        {
            if (id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
                id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID(class_ref, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                JNIEnv.CallVoidMethod(Handle, id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "")]
        public override sealed unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder(global::Android.Views.ViewGroup p0, int p1)
        {
            if (id_onCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
                id_onCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID(class_ref, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder>(JNIEnv.CallObjectMethod(Handle, id_onCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        static Delegate cb_onHookGroupCollapse_IZ;
#pragma warning disable 0169
        static Delegate GetOnHookGroupCollapse_IZHandler()
        {
            if (cb_onHookGroupCollapse_IZ == null)
                cb_onHookGroupCollapse_IZ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool, bool>)n_OnHookGroupCollapse_IZ);
            return cb_onHookGroupCollapse_IZ;
        }

        static bool n_OnHookGroupCollapse_IZ(IntPtr jnienv, IntPtr native__this, int p0, bool p1)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.OnHookGroupCollapse(p0, p1);
        }
#pragma warning restore 0169

        static IntPtr id_onHookGroupCollapse_IZ;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='onHookGroupCollapse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
        [Register("onHookGroupCollapse", "(IZ)Z", "GetOnHookGroupCollapse_IZHandler")]
        public virtual unsafe bool OnHookGroupCollapse(int p0, bool p1)
        {
            if (id_onHookGroupCollapse_IZ == IntPtr.Zero)
                id_onHookGroupCollapse_IZ = JNIEnv.GetMethodID(class_ref, "onHookGroupCollapse", "(IZ)Z");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                if (GetType() == ThresholdType)
                    return JNIEnv.CallBooleanMethod(Handle, id_onHookGroupCollapse_IZ, __args);
                else
                    return JNIEnv.CallNonvirtualBooleanMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onHookGroupCollapse", "(IZ)Z"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_onHookGroupExpand_IZ;
#pragma warning disable 0169
        static Delegate GetOnHookGroupExpand_IZHandler()
        {
            if (cb_onHookGroupExpand_IZ == null)
                cb_onHookGroupExpand_IZ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool, bool>)n_OnHookGroupExpand_IZ);
            return cb_onHookGroupExpand_IZ;
        }

        static bool n_OnHookGroupExpand_IZ(IntPtr jnienv, IntPtr native__this, int p0, bool p1)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.OnHookGroupExpand(p0, p1);
        }
#pragma warning restore 0169

        static IntPtr id_onHookGroupExpand_IZ;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='onHookGroupExpand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
        [Register("onHookGroupExpand", "(IZ)Z", "GetOnHookGroupExpand_IZHandler")]
        public virtual unsafe bool OnHookGroupExpand(int p0, bool p1)
        {
            if (id_onHookGroupExpand_IZ == IntPtr.Zero)
                id_onHookGroupExpand_IZ = JNIEnv.GetMethodID(class_ref, "onHookGroupExpand", "(IZ)Z");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);

                if (GetType() == ThresholdType)
                    return JNIEnv.CallBooleanMethod(Handle, id_onHookGroupExpand_IZ, __args);
                else
                    return JNIEnv.CallNonvirtualBooleanMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onHookGroupExpand", "(IZ)Z"), __args);
            }
            finally
            {
            }
        }

        static Delegate cb_getChildCount_I;
#pragma warning disable 0169
        static Delegate GetGetChildCount_IHandler()
        {
            if (cb_getChildCount_I == null)
                cb_getChildCount_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int>)n_GetChildCount_I);
            return cb_getChildCount_I;
        }

        static int n_GetChildCount_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetChildCount(p0);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getChildCount' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getChildCount", "(I)I", "GetGetChildCount_IHandler")]
        public abstract int GetChildCount(int groupIndex);

        static Delegate cb_getChildId_II;
#pragma warning disable 0169
        static Delegate GetGetChildId_IIHandler()
        {
            if (cb_getChildId_II == null)
                cb_getChildId_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, long>)n_GetChildId_II);
            return cb_getChildId_II;
        }

        static long n_GetChildId_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetChildId(p0, p1);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getChildId' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
        [Register("getChildId", "(II)J", "GetGetChildId_IIHandler")]
        public abstract long GetChildId(int groupIndex, int childIndex);

        static Delegate cb_getChildItemViewType_II;
#pragma warning disable 0169
        static Delegate GetGetChildItemViewType_IIHandler()
        {
            if (cb_getChildItemViewType_II == null)
                cb_getChildItemViewType_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, int>)n_GetChildItemViewType_II);
            return cb_getChildItemViewType_II;
        }

        static int n_GetChildItemViewType_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetChildItemViewType(p0, p1);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getChildItemViewType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
        [Register("getChildItemViewType", "(II)I", "GetGetChildItemViewType_IIHandler")]
        public abstract int GetChildItemViewType(int groupIndex, int childIndex);

        static Delegate cb_getGroupId_I;
#pragma warning disable 0169
        static Delegate GetGetGroupId_IHandler()
        {
            if (cb_getGroupId_I == null)
                cb_getGroupId_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, long>)n_GetGroupId_I);
            return cb_getGroupId_I;
        }

        static long n_GetGroupId_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetGroupId(p0);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getGroupId' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getGroupId", "(I)J", "GetGetGroupId_IHandler")]
        public abstract long GetGroupId(int p0);

        static Delegate cb_getGroupItemViewType_I;
#pragma warning disable 0169
        static Delegate GetGetGroupItemViewType_IHandler()
        {
            if (cb_getGroupItemViewType_I == null)
                cb_getGroupItemViewType_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int>)n_GetGroupItemViewType_I);
            return cb_getGroupItemViewType_I;
        }

        static int n_GetGroupItemViewType_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetGroupItemViewType(p0);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getGroupItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getGroupItemViewType", "(I)I", "GetGetGroupItemViewType_IHandler")]
        public abstract int GetGroupItemViewType(int p0);

        static Delegate cb_getGroupCount;
#pragma warning disable 0169
        static Delegate GetGetGroupCountHandler()
        {
            if (cb_getGroupCount == null)
                cb_getGroupCount = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_GetGroupCount);
            return cb_getGroupCount;
        }

        static int n_GetGroupCount(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.H6ah4i.Android.Widget.Advrecyclerview.Utils.AbstractExpandableItemAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GroupCount;
        }
#pragma warning restore 0169

        public abstract int GroupCount
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getGroupCount' and count(parameter)=0]"
            [Register("getGroupCount", "()I", "GetGetGroupCountHandler")] get;
        }

    }

    [global::Android.Runtime.Register("com/h6ah4i/android/widget/advrecyclerview/utils/AbstractExpandableItemAdapter", DoNotGenerateAcw = true)]
    internal abstract partial class AbstractExpandableItemAdapterInvoker : AbstractExpandableItemAdapter, global::Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapter
    {

        public AbstractExpandableItemAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(AbstractExpandableItemAdapterInvoker); }
        }

        static IntPtr id_getGroupCount;
        public override unsafe int GroupCount
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getGroupCount' and count(parameter)=0]"
            [Register("getGroupCount", "()I", "GetGetGroupCountHandler")]
            get
            {
                if (id_getGroupCount == IntPtr.Zero)
                    id_getGroupCount = JNIEnv.GetMethodID(class_ref, "getGroupCount", "()I");
                try
                {
                    return JNIEnv.CallIntMethod(Handle, id_getGroupCount);
                }
                finally
                {
                }
            }
        }

        static IntPtr id_getChildCount_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getChildCount' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getChildCount", "(I)I", "GetGetChildCount_IHandler")]
        public override unsafe int GetChildCount(int groupIndex)
        {
            if (id_getChildCount_I == IntPtr.Zero)
                id_getChildCount_I = JNIEnv.GetMethodID(class_ref, "getChildCount", "(I)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(groupIndex);
                return JNIEnv.CallIntMethod(Handle, id_getChildCount_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getChildId_II;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getChildId' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
        [Register("getChildId", "(II)J", "GetGetChildId_IIHandler")]
        public override unsafe long GetChildId(int groupIndex, int childIndex)
        {
            if (id_getChildId_II == IntPtr.Zero)
                id_getChildId_II = JNIEnv.GetMethodID(class_ref, "getChildId", "(II)J");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(groupIndex);
                __args[1] = new JValue(childIndex);
                return JNIEnv.CallLongMethod(Handle, id_getChildId_II, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getChildItemViewType_II;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getChildItemViewType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
        [Register("getChildItemViewType", "(II)I", "GetGetChildItemViewType_IIHandler")]
        public override unsafe int GetChildItemViewType(int groupIndex, int childIndex)
        {
            if (id_getChildItemViewType_II == IntPtr.Zero)
                id_getChildItemViewType_II = JNIEnv.GetMethodID(class_ref, "getChildItemViewType", "(II)I");
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(groupIndex);
                __args[1] = new JValue(childIndex);
                return JNIEnv.CallIntMethod(Handle, id_getChildItemViewType_II, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getGroupId_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getGroupId' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getGroupId", "(I)J", "GetGetGroupId_IHandler")]
        public override unsafe long GetGroupId(int p0)
        {
            if (id_getGroupId_I == IntPtr.Zero)
                id_getGroupId_I = JNIEnv.GetMethodID(class_ref, "getGroupId", "(I)J");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                return JNIEnv.CallLongMethod(Handle, id_getGroupId_I, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_getGroupItemViewType_I;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.utils']/class[@name='AbstractExpandableItemAdapter']/method[@name='getGroupItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getGroupItemViewType", "(I)I", "GetGetGroupItemViewType_IHandler")]
        public override unsafe int GetGroupItemViewType(int p0)
        {
            if (id_getGroupItemViewType_I == IntPtr.Zero)
                id_getGroupItemViewType_I = JNIEnv.GetMethodID(class_ref, "getGroupItemViewType", "(I)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);
                return JNIEnv.CallIntMethod(Handle, id_getGroupItemViewType_I, __args);
            }
            finally
            {
            }
        }

    }

}
