package md505c957a39ff7e8b5ab5ec054816e1e49;


public class ActiveTimedGameActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CharadeApp.ActiveTimedGameActivity, CharadeApp", ActiveTimedGameActivity.class, __md_methods);
	}


	public ActiveTimedGameActivity ()
	{
		super ();
		if (getClass () == ActiveTimedGameActivity.class)
			mono.android.TypeManager.Activate ("CharadeApp.ActiveTimedGameActivity, CharadeApp", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
