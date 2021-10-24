﻿using GameEngine;

public class Hero : Agent
{
    private int _heroId;

    public Hero(int entityId, int heroId)
    {
        Initialize(entityId, heroId);
    }

    public void Initialize(int entityId, int heroId)
    {
        _entityId = entityId;
        _heroId = heroId;
        _state = new AgentState();
    }

    public override void AddState(BitType state)
    {
        _state.AddState(state);
    }

    public override void RemoveState(BitType state)
    {
        _state.RemoveState(state);
    }

    public override BitType GetAgentState()
    {
        return _state.GetAgentState();
    }

    public override int GetAgentType()
    {
        return AgentTypeDef.AGENT_TYPE_HERO;
    }

    public override int GetEntityId()
    {
        return _entityId;
    }

    private void InitializeState()
    {
        BitType clearState = BitType.BindWithBitTypes(new BitType[]
        {
                AgentStateDefine.INTERACT_FLAG,
                AgentStateDefine.MOVE_FLAG,
                AgentStateDefine.VISIBLE_FLAG,
                AgentStateDefine.RECOVER_FLAG,
                AgentStateDefine.HURTABLE_FLAG,
                AgentStateDefine.MAGIC_FLAG,
                AgentStateDefine.PHYSICAL_FLAG,
                AgentStateDefine.TARGET_FLAG,
        }, true);

        _state.InitializeAgentDefaultState(clearState);
    }

    public override void OnAlive()
    {
        InitializeState();
        ForEachSkill((ISkill skill) =>
        {
            if (skill.GetSkillType() == SkillDef.PASSIVE_SKILL)
            {
                skill.OnSkillFirstAdd(this);
            }
        });
    }

    public override void OnDead()
    {
        
    }

    public override void OnLateUpdate(float deltaTime)
    {
        
    }

    public override void OnUpdate(float deltaTime)
    {
        
    }
}
