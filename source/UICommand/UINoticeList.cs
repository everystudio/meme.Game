using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINoticeList : CPanel {

	[SerializeField]
	private GameObject m_goContentsRoot;

	[SerializeField]
	private List<BannerNotice> m_bannerNoticeList = new List<BannerNotice>();

	protected override void panelStart()
	{
		base.panelStart();

		foreach(BannerNotice notice in m_bannerNoticeList)
		{
			Destroy(notice.gameObject);
		}
		m_bannerNoticeList.Clear();

		foreach(MasterNoticeParam param in DataManager.Instance.masterNotice.list)
		{
			BannerNotice notice = PrefabManager.Instance.MakeScript<BannerNotice>("prefab/BannerNotice", m_goContentsRoot);
			notice.Initialize(param);
			m_bannerNoticeList.Add(notice);
		}
	}

}
