﻿using GameEngine;
using System.Collections.Generic;
using UnityEngine;

public class AgentState
{
    private BitType _state;
    private BitType _defaultState;
    private Dictionary<BitType, AgentStateTimer> _stateTimers = new Dictionary<BitType, AgentStateTimer>();
    private List<BitType> _toRemoveStateTimers = new List<BitType>();

    public void InitializeAgentDefaultState(BitType state)
    {
        _state = state;
        _defaultState = state.Clone(false);
    }

    public BitType GetAgentState()
    {
        return _state;
    }

    public void AddState(BitType state)
    {
        if(_state != null)
            _state.BindBitType(state);
    }

    public void RemoveState(BitType state)
    {
        if(_state != null)
            _state.RemoveBitType(state);
    }

    public AgentStateTimer GetStateTimer(BitType state)
    {
        if (_stateTimers.TryGetValue(state, out AgentStateTimer timer))
        {
            return timer;
        }

        return null;
    }

    public void AddStateTimer(BitType state, AgentStateTimer timer)
    {
        var _timer = GetStateTimer(state);
        if(_timer == null)
        {
            _stateTimers.Add(state, timer);
        }
        else
        {
            
        }
    }

    public void RemoveStateTimer(BitType state)
    {
        if (_stateTimers.ContainsKey(state))
        {
            _stateTimers.Remove(state);
        }
    }

    private void DefaultActionOnStateEnd(BitType state)
    {
        if (_defaultState.HasType(state))
        {
            AddState(state);
        }
        else
        {
            RemoveState(state);
        }
    }

    private void UpdateStateTimeTimers()
    {
        _toRemoveStateTimers.Clear();

        foreach (KeyValuePair<BitType, AgentStateTimer> kv in _stateTimers)
        {
            //BitType state = kv.Key;
            //AgentStateTimer timer = kv.Value;
            //if (timer != null && timer.TimerCheck())
            //{
            //    DefaultActionOnStateEnd(state);
            //    _toRemoveStateTimers.Add(kv.Key);
            //}
        }

        for (int i = 0; i < _toRemoveStateTimers.Count; i++)
        {
            BitType state = _toRemoveStateTimers[i];
            RemoveStateTimer(state);
        }
    }

    public void Update()
    {
        UpdateStateTimeTimers();
    }
}
