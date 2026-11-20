using System;
using System.Collections.Generic;

public class Signals
{
	private static Signals instance;

	private Dictionary<Type, ISignal> signals;

	public static T Get<T>() where T : ISignal, new()
	{
		return default(T);
	}
}
