using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkitConnector : Singleton<SkitConnector> {

	[SerializeField]
	private SkitRoot m_skitRoot;

	public SkitRoot root
	{
		get { return m_skitRoot; }
	}
}
