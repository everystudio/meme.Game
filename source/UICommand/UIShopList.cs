using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopList : CPanel {

	private string [] m_strShopNameKeyArr = new string[]
	{
		"name_shop_inn",
		"name_shop_weapon",
		"name_shop_item",
		"name_shop_station",
		"name_shop_search",
	};
	[SerializeField]
	private List<BtnShop> btnList = new List<BtnShop>();

	protected override void panelStart()
	{
		//word.Instance.selectedLanguage = "en";
		base.panelStart();

		for( int i = 0;  i < btnList.Count; i++)
		{
			btnList[i].Initialize(m_strShopNameKeyArr[i]);
		}

	}


}
