using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUserItem : CPanel {

	public List<BannerUserItem> m_bannerUserItemList = new List<BannerUserItem>();
	public GameObject m_goContentsRoot;

	protected override void panelStart()
	{
		base.panelStart();

		foreach (BannerUserItem param in m_bannerUserItemList)
		{
			Destroy(param.gameObject);
		}
		m_bannerUserItemList.Clear();

		foreach(DataItemParam param in DataManager.Instance.dataItem.list)
		{
			BannerUserItem banner = PrefabManager.Instance.MakeScript<BannerUserItem>("prefab/BannerUserItem", m_goContentsRoot);
			banner.Initialize(param);
			m_bannerUserItemList.Add(banner);
		}
	}
}
