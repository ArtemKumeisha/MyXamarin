package md5a365e2618d31d03e292c615848c2304b;


public class NativeAndroidListViewRenderer
	extends md5d4dd78677dce656d5db26c85a3743ef3.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NativeRendererListView.Droid.CustomRendererControl.NativeAndroidListViewRenderer, NativeRendererListView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NativeAndroidListViewRenderer.class, __md_methods);
	}


	public NativeAndroidListViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == NativeAndroidListViewRenderer.class)
			mono.android.TypeManager.Activate ("NativeRendererListView.Droid.CustomRendererControl.NativeAndroidListViewRenderer, NativeRendererListView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public NativeAndroidListViewRenderer (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == NativeAndroidListViewRenderer.class)
			mono.android.TypeManager.Activate ("NativeRendererListView.Droid.CustomRendererControl.NativeAndroidListViewRenderer, NativeRendererListView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public NativeAndroidListViewRenderer (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == NativeAndroidListViewRenderer.class)
			mono.android.TypeManager.Activate ("NativeRendererListView.Droid.CustomRendererControl.NativeAndroidListViewRenderer, NativeRendererListView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
