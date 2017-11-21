using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CITest {



	[UnityTest]
	public IEnumerator _Test_Pass() {
		Assert.True (true);
		yield return null;
	}

	[UnityTest]
	public IEnumerator _Test_Fail() {
		Assert.True (false);
		yield return null;
	}
}
