using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EveryStudioLibrary;

public class DataManager : DataManagerBase<DataManager> {

	public string selectedLanguage = "ja";

	public readonly string MASTER_ITEM_SPREAD_SHEET = "1k0dGtWXslvrqKl3_vKOcUHpxxIsTLAzZ8li_d74ZzI4";
	public readonly string MASTER_ITEM_SPREAD_SHEET_CONFIG_SHEET = "od6";
	public MasterItem masterItem = null;
	public void onRecievedMasterItem(TNetworkData _data)
	{
		masterItem = new MasterItem();
		masterItem.Input(SpreadSheetData.ConvertSpreadSheetData(_data.m_dictRecievedData));
		masterItem.SetupDict();
	}
	public readonly string MASTER_NOTICE_SPREAD_SHEET = "14j4P8E6fvZjdBNI7a_-CgZoR4hrnILu5S_6YC-2C0Wk";
	public readonly string MASTER_NOTICE_SPREAD_SHEET_CONFIG_SHEET = "od6";
	public MasterNotice masterNotice = null;
	public void onRecievedMasterNotice(TNetworkData _data)
	{
		masterNotice = new MasterNotice();
		masterNotice.Input(SpreadSheetData.ConvertSpreadSheetData(_data.m_dictRecievedData));
	}

	public override void Initialize()
	{
		SetDontDestroy(true);
		base.Initialize();
		CommonNetwork.Instance.RecieveSpreadSheet(MASTER_ITEM_SPREAD_SHEET, MASTER_ITEM_SPREAD_SHEET_CONFIG_SHEET, onRecievedMasterItem);
		CommonNetwork.Instance.RecieveSpreadSheet(MASTER_NOTICE_SPREAD_SHEET, MASTER_NOTICE_SPREAD_SHEET_CONFIG_SHEET, onRecievedMasterNotice);

		dataItem = new DataItem();

	}

	public DataItem dataItem;


}


