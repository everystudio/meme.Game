using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EveryStudioLibrary;

public class DataManager : DataManagerBase<DataManager> {

	public string selectedLanguage = "ja";

	public readonly string MASTER_ITEM_SPREAD_SHEET = "1k0dGtWXslvrqKl3_vKOcUHpxxIsTLAzZ8li_d74ZzI4";
	public readonly string MASTER_ITEM_SPREAD_SHEET_CONFIG_SHEET = "od6";
	public readonly string MASTER_NOTICE_SPREAD_SHEET = "14j4P8E6fvZjdBNI7a_-CgZoR4hrnILu5S_6YC-2C0Wk";
	public readonly string MASTER_NOTICE_SPREAD_SHEET_CONFIG_SHEET = "od6";
	public MasterItem masterItem = null;
	public MasterNotice masterNotice = null;
	public MasterEquip masterEquip = null;
	public MasterEquipType masterEquipType = null;
	public void RecievedMasterItem()
	{
		masterItem.SetupDict();
	}

	public override void Initialize()
	{
		SetDontDestroy(true);
		base.Initialize();
		masterItem = new MasterItem();
		masterItem.LoadSpreadSheet(MASTER_ITEM_SPREAD_SHEET, MASTER_ITEM_SPREAD_SHEET_CONFIG_SHEET);
		masterItem.RecievedSuccessEvent.AddListener(RecievedMasterItem);
		masterNotice = new MasterNotice();
		masterNotice.LoadSpreadSheet(MASTER_NOTICE_SPREAD_SHEET, MASTER_NOTICE_SPREAD_SHEET_CONFIG_SHEET);
		masterEquip = new MasterEquip();
		masterEquip.LoadSpreadSheet(MasterEquip.SPREAD_SHEET_PAGE, MasterEquip.SPREAD_SHEET_ID);
		masterEquipType = new MasterEquipType();
		masterEquipType.LoadSpreadSheet(MasterEquipType.SPREAD_SHEET_PAGE, MasterEquipType.SPREAD_SHEET_ID);

		dataItem = new DataItem();

	}

	public DataItem dataItem;


}


