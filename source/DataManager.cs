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

	public override void Initialize()
	{
		SetDontDestroy(true);
		base.Initialize();
		CommonNetwork.Instance.RecieveSpreadSheet(MASTER_ITEM_SPREAD_SHEET, MASTER_ITEM_SPREAD_SHEET_CONFIG_SHEET, onRecievedMasterItem);

		dataItem = new DataItem();

	}

	public DataItem dataItem;


}


