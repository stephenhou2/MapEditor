﻿using GameEngine;
using UnityEngine;
using System.Collections.Generic;

public abstract class Agent : IAgent
{
    /// <summary>
    /// agent唯一id
    /// </summary>
    protected int _entityId;

    /// <summary>
    /// agent 状态
    /// </summary>
    protected AgentState _state;

    /// <summary>
    /// 状态结束时间戳
    /// </summary>
    protected Dictionary<BitType,float> _state_timestamps = new Dictionary<BitType, float>();

    /// <summary>
    /// 装备列表
    /// </summary>
    protected Equip[] _equips = new Equip[EquipDef.MaxEquipNum];

    /// <summary>
    ///  agent 基础属性
    /// </summary>
    protected BaseProperty _property;

    protected List<ISkill> _allSkills = new List<ISkill>();

    public abstract int GetEntityId();
    public abstract int GetAgentType();
    public abstract void OnAlive();
    public abstract void OnDead();
    public abstract void OnLateUpdate();

    private List<BitType> _toRemoveStateTimestamps = new List<BitType>();

    private void UpdateStateTimestamps()
    {
        float now = Time.realtimeSinceStartup;

        _toRemoveStateTimestamps.Clear();
        foreach (KeyValuePair<BitType, float> kv in _state_timestamps)
        {
            if (now >= kv.Value)
            {
                RemoveState(kv.Key);
                _toRemoveStateTimestamps.Add(kv.Key);
            }
        }

        for(int i = 0;i<_toRemoveStateTimestamps.Count;i++)
        {
            BitType type = _toRemoveStateTimestamps[i];
            if (_state_timestamps.ContainsKey(type))
            {
                _state_timestamps.Remove(type);
            }
        }
    }

    public void OnUpdate()
    {
        UpdateStateTimestamps();

        Update();
    }

    public abstract void Update();

    protected void ForEachSkill(SkillEnumerator call)
    {
        foreach(ISkill skill in _allSkills)
        {
            call(skill);
        }

        foreach(Equip eqp in _equips)
        {
            eqp.ForEachSkill(call);
        }
    }

    public virtual BitType GetAgentState()
    {
        return _state.GetAgentState();
    }

    public virtual void AddState(BitType state)
    {
        _state.AddState(state);
    }

    public virtual void RemoveState(BitType state)
    {
        _state.RemoveState(state);
    }

    public virtual void AddStateTimer(BitType state,float newStamp)
    {
        if (_state_timestamps.TryGetValue(state, out float stamp))
        {
            if(newStamp > stamp)
            {
                _state_timestamps[state] = newStamp;
            }
        }
        else
        {
            _state_timestamps.Add(state, newStamp);
        }
    }
}