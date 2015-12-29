using System.Collections.Generic;


/// <summary>
/// TODO            Add the unique listener interface.
/// 
/// 
/// General dispatcher to dispatch game events 
/// </summary>
public class EventDispatcher
{
    private Dictionary<string, CallBack> m_Callbacks;

    /// <summary>
    /// Dispatch an event
    /// </summary>
    /// <param name="eventName">event name</param>
    /// <param name="data">event data</param>
    public void Dispatch(string msg, params object[] data)
    {
        if (m_Callbacks == null)
            return;

        if (m_Callbacks.ContainsKey(msg))
        {
            CallBack callback = m_Callbacks[msg];
            if (callback != null)
                callback(data);
        }
    }

    /// <summary>
    /// Register an event
    /// </summary>
    /// <param name="msg">event name</param>
    /// <param name="callback">event data</param>
    public void AddListener(string msg, CallBack callback)
    {
        if (msg == null)
            return;

        if (m_Callbacks == null)
            m_Callbacks = new Dictionary<string, CallBack>();

        if (!m_Callbacks.ContainsKey(msg))
            m_Callbacks[msg] = callback;
        else
            m_Callbacks[msg] += callback;
    }

    /// <summary>
    /// Remove an event
    /// </summary>
    /// <param name="msg">event name</param>
    /// <param name="callback">event data</param>
    public void RemoveListener(string msg, CallBack callback)
    {
        if (msg == null)
            return;

        if (m_Callbacks == null)
            return;

        if (m_Callbacks.ContainsKey(msg))
            m_Callbacks[msg] -= callback;
    }
}

public delegate void CallBack(object[] data);
