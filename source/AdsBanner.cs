using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsBanner : MonoBehaviour {

#if UNITY_EDITOR
	string adUnitIdTate = "unused";
	string adUnitIdYoko = "unused";
#elif UNITY_ANDROID
    string adUnitIdTate = "ca-app-pub-5869235725006697/4481993169";
	string adUnitIdYoko = "ca-app-pub-5869235725006697/2917861565";
#elif UNITY_IPHONE
    string adUnitIdTate = "ca-app-pub-5869235725006697/5958726364";
	string adUnitIdYoko = "ca-app-pub-5869235725006697/1301527568";
#else
    string adUnitIdTate = "unexpected_platform";
	string adUnitIdYoko = "unused";
#endif
	BannerView viewTate = null;        // 縦画面
	BannerView viewYoko = null;        // 横画面

	void showAdBanner(DeviceOrientationDetector.ORIENTATION _orientation)
	{
		if( _orientation == DeviceOrientationDetector.ORIENTATION.TATE)
		{
			if( viewYoko!= null)
			{
				viewYoko.Hide();
			}
			if (viewTate == null)
			{
				BannerView bannerViewTate = new BannerView(adUnitIdTate, AdSize.Banner, AdPosition.Bottom);
				// Create an empty ad request.
				AdRequest requestTate = new AdRequest.Builder().Build();
				// Load the banner with the request.
				bannerViewTate.LoadAd(requestTate);
				viewTate = bannerViewTate;
				viewTate.OnAdLoaded += View_OnAdLoaded;
			}
			else
			{
				viewTate.Show();
			}
		}
		else
		{
			if (viewTate != null)
			{
				viewTate.Hide();
			}
			if (viewYoko == null)
			{
				BannerView bannerViewYoko = new BannerView(adUnitIdYoko, AdSize.Banner, AdPosition.BottomLeft);
				// Create an empty ad request.
				AdRequest requestYoko = new AdRequest.Builder().Build();
				// Load the banner with the request.
				bannerViewYoko.LoadAd(requestYoko);
				viewYoko = bannerViewYoko;
				viewYoko.OnAdLoaded += View_OnAdLoaded;
			}
			else
			{
				viewYoko.Show();
			}
		}
	}	

	// Use this for initialization
	void Start () {
		DeviceOrientationDetector.Instance.OnChangeOrientation.AddListener(OnChangedOrientation);
	}

	private void OnChangedOrientation(DeviceOrientationDetector.ORIENTATION _orientation)
	{
		showAdBanner(_orientation);
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
