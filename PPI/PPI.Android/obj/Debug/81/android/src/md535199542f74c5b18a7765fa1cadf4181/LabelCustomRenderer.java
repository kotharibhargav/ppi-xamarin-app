package md535199542f74c5b18a7765fa1cadf4181;


public class LabelCustomRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.LabelRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("PPI.Droid.CustomRenderer.LabelCustomRenderer, PPI.Android", LabelCustomRenderer.class, __md_methods);
	}


	public LabelCustomRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == LabelCustomRenderer.class)
			mono.android.TypeManager.Activate ("PPI.Droid.CustomRenderer.LabelCustomRenderer, PPI.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public LabelCustomRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == LabelCustomRenderer.class)
			mono.android.TypeManager.Activate ("PPI.Droid.CustomRenderer.LabelCustomRenderer, PPI.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public LabelCustomRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == LabelCustomRenderer.class)
			mono.android.TypeManager.Activate ("PPI.Droid.CustomRenderer.LabelCustomRenderer, PPI.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
