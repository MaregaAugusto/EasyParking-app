package crc64a83f1f320a18a364;


public class MyEntryRender
	extends crc643f46942d9dd1fff9.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EasyParking.Droid.Renders.MyEntryRender, EasyParking.Android", MyEntryRender.class, __md_methods);
	}


	public MyEntryRender (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MyEntryRender.class)
			mono.android.TypeManager.Activate ("EasyParking.Droid.Renders.MyEntryRender, EasyParking.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MyEntryRender (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MyEntryRender.class)
			mono.android.TypeManager.Activate ("EasyParking.Droid.Renders.MyEntryRender, EasyParking.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MyEntryRender (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MyEntryRender.class)
			mono.android.TypeManager.Activate ("EasyParking.Droid.Renders.MyEntryRender, EasyParking.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
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
