package crc64a83f1f320a18a364;


public class MyLabelRender
	extends crc643f46942d9dd1fff9.LabelRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EasyParking.Droid.Renders.MyLabelRender, EasyParking.Android", MyLabelRender.class, __md_methods);
	}


	public MyLabelRender (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MyLabelRender.class)
			mono.android.TypeManager.Activate ("EasyParking.Droid.Renders.MyLabelRender, EasyParking.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MyLabelRender (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MyLabelRender.class)
			mono.android.TypeManager.Activate ("EasyParking.Droid.Renders.MyLabelRender, EasyParking.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MyLabelRender (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MyLabelRender.class)
			mono.android.TypeManager.Activate ("EasyParking.Droid.Renders.MyLabelRender, EasyParking.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
