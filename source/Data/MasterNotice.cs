using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterNoticeParam : CsvDataParam
{
	public int notice_id { get; set; }
	public int notice_type { get; set; }
	public string notice_icon { get; set; }
	public string date_start { get; set; }
	public string date_end { get; set; }
	public string title { get; set; }
	public string detail_mini { get; set; }
	public string detail_long { get; set; }

}

public class MasterNotice : CsvData<MasterNoticeParam> {



	override protected MasterNoticeParam makeParam(List<SpreadSheetData> _list, int _iSerial, int _iRow)
	{
		int iIndex = 1;
		SpreadSheetData dataNoticeId = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataNoticeType = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataNoticeIcon = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataDateStart = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataDateEnd = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataTitle = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataDetailMini = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);
		SpreadSheetData dataDetailLong = SpreadSheetData.GetSpreadSheet(_list, _iRow, iIndex++);

		MasterNoticeParam retParam = new MasterNoticeParam();
		//Debug.LogError(dataKey.param);
		retParam.notice_id= int.Parse(dataNoticeId.param);
		retParam.notice_type= int.Parse(dataNoticeType.param);
		retParam.notice_icon= dataNoticeIcon.param;
		retParam.date_start= dataDateStart.param;
		retParam.date_end= dataDateEnd.param;
		retParam.title= dataTitle.param;
		retParam.detail_mini= dataDetailMini.param;
		retParam.detail_long= dataDetailLong.param;

		return retParam;
	}
}
