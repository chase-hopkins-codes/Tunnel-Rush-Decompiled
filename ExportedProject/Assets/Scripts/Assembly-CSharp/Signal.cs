using System;

public abstract class Signal : ISignal
{
	private Action callback;

	public void AddListener(Action handler)
	{
	}

	public void RemoveListener(Action handler)
	{
	}

	public void Raise()
	{
	}
}
public abstract class Signal<T> : ISignal
{
	private Action<T> callback;

	public void AddListener(Action<T> handler)
	{
	}

	public void RemoveListener(Action<T> handler)
	{
	}

	public void Raise(T arg)
	{
	}
}
public abstract class Signal<T1, T2> : Signal
{
	private Action<T1, T2> callback;

	public void AddListener(Action<T1, T2> handler)
	{
	}

	public void RemoveListener(Action<T1, T2> handler)
	{
	}

	public void Raise(T1 arg1, T2 arg2)
	{
	}
}
