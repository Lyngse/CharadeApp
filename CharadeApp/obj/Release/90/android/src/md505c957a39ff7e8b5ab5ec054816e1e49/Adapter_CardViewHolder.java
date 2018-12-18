package md505c957a39ff7e8b5ab5ec054816e1e49;


public class Adapter_CardViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CharadeApp.Adapter+CardViewHolder, CharadeApp", Adapter_CardViewHolder.class, __md_methods);
	}


	public Adapter_CardViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == Adapter_CardViewHolder.class)
			mono.android.TypeManager.Activate ("CharadeApp.Adapter+CardViewHolder, CharadeApp", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
