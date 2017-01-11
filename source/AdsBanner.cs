using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsBanner : MonoBehaviour {

#if UNITY_EDITOR
	string adUnitId1 = "unused";
#elif UNITY_ANDROID
    string adUnitId1 = "ca-app-pub-5869235725006697/4481993169";
#elif UNITY_IPHONE
    string adUnitId1 = "ca-app-pub-5869235725006697/5958726364";
#else
    string adUnitId1 = "unexpected_platform";
#endif
	BannerView view1 = null;        // 画面上部

	// Use this for initialization
	void Start () {
		BannerView bannerView1 = new BannerView(adUnitId1, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request1 = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView1.LoadAd(request1);
		view1 = bannerView1;
		view1.OnAdLoaded += View_OnAdLoaded;
	}
	private void View_OnAdLoaded(object sender, System.EventArgs e)
	{
		//refreshAds(m_strSceneNow);
		// 何かしたいならここ
		//view1.Hide();
		//view1.Show();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
