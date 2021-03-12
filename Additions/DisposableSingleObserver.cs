using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO.Reactivex.Rxjava3.Observers
{
    public abstract partial class DisposableSingleObserver : global::Java.Lang.Object, global::IO.Reactivex.Rxjava3.Core.ISingleObserver, global::IO.Reactivex.Rxjava3.Disposables.IDisposable
	{
        public abstract unsafe void OnSuccess(global::Java.Lang.Object t);
    }

    internal partial class DisposableSingleObserverInvoker : DisposableSingleObserver, global::IO.Reactivex.Rxjava3.Core.ISingleObserver, global::IO.Reactivex.Rxjava3.Disposables.IDisposable
	{
		public override unsafe void OnSuccess(global::Java.Lang.Object t)
		{
			const string __id = "onNext.(Ljava/lang/Object;)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object)t).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}
	}
}