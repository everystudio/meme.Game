using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCharaParam : CsvDataParam
{
	public int chara_serial { get; set; }
	public int chara_id { get; set; }
	public int job_id { get; set; }
	public int party_id { get; set; }

	public string name { get; set; }
	public string sex { get; set; }     // 文字列で持たせるメリットある？

	public int atk { get; set; }
	public int def { get; set; }
	public int mat { get; set; }
	public int mde { get; set; }

	public int agi { get; set; }
	public int dex { get; set; }
	public int eva { get; set; }
	public int cri { get; set; }
	public int luc { get; set; }

	public int att_fire { get; set; }
	public int att_water { get; set; }
	public int att_wind { get; set; }
	public int att_earth { get; set; }
	public int att_time { get; set; }

}

public class DataChara : CsvData<DataCharaParam> {



}






