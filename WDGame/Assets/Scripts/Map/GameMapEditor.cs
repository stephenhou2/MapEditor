﻿using GameEngine;
using System.Collections.Generic;
using UnityEngine;

public class GameMapEditor : Singleton<GameMapEditor>
{
    public GameObject mMapEditorRoot;

    public MapEditorConfigs MapConfig;

    private GameMapDrawer mGridDrawer;  // 网格绘制
    private GameMapDrawer mObstacleDrawer; //阻挡格绘制

    private MapEditorInputControl mInputControl; // 输入控制
    private MapEditorCameraHandle mCamControl;// 相机控制
    public MapEditorDataMgr DataMgr; //地图数据层
    private MapBoard mMapBorad;  //地图绘制

    private MapEditRecordManager mRecordMgr; // 操作回退功能

    public float zoomSpeed;
    public float moveSpeed;
    public float camMaxHeight;
    public float camMinHeight;

    private Dictionary<int, GameMapDrawer> mDrawerDic;

    private void IntializeDrawers()
    {
        Transform GROUD_DRAWER = mMapEditorRoot.transform.Find(MapDefine.MAP_GROUD_DRAWER_PATH);
        if(GROUD_DRAWER != null)
        {
            mGridDrawer = new GameMapDrawer();
            mGridDrawer.InitializeMapGridDrawer(GROUD_DRAWER.gameObject, new MapGridDrawer_Horizontal(), new MapGridDrawer_Verticle());
            RegisterDrawer(MapDefine.MapDrawer_Ground, mGridDrawer);
        }

        Transform OBSTACLE_DRAWER = mMapEditorRoot.transform.Find(MapDefine.MAP_OBSTACLE_DRAWER_PATH);
        if (OBSTACLE_DRAWER != null)
        {
            mObstacleDrawer = new GameMapDrawer();
            mObstacleDrawer.InitializeMapGridDrawer(OBSTACLE_DRAWER.gameObject, new MapObstacleDrawer_Horizontal(), new MapObstacleDrawer_Verticle());
            RegisterDrawer(MapDefine.MapDrawer_Obstacle, mObstacleDrawer);
        }
    }

    private void RegisterDrawer(int type,GameMapDrawer drawer)
    {
        if(drawer == null)
        {
            Log.Error(ErrorLevel.Critical, "RegisterDrawer Error,drawer is null!");
            return;
        }

        if(!mDrawerDic.ContainsKey(type))
            mDrawerDic.Add(type, drawer);
    }

    public void CreateNewMap(string mapId, int mapWidth, int mapHeight, int direction, float cellSize)
    {
        DataMgr.CreateMapData(mapId, mapWidth, mapHeight, direction, cellSize);
        DoDraw(MapDefine.MapDrawer_Ground);
        RefreshMapConfig();
    }

    private void RefreshMapConfig()
    {
        MapConfig.SetMapWidth(DataMgr.GetMapWidth());
        MapConfig.SetMapHeight(DataMgr.GetMapHeight());
        MapConfig.SetMapCellSize(DataMgr.GetCellSize());
        MapConfig.SetMapCellDirection(DataMgr.GetMapDirection());
    }

    public void LoadStageMap(string mapId)
    {
        DataMgr.LoadMapData(mapId);
        RefreshMapConfig();

        DoDraw(MapDefine.MapDrawer_Ground);
        DoDraw(MapDefine.MapDrawer_Obstacle);
    }

    public void UpdateMapObstacle(int col,int row, byte data)
    {
        DataMgr.UpdateObstacleData(col, row, data);
    }

    public void DoDraw(int drawerType)
    {
        if(mDrawerDic.TryGetValue(drawerType,out GameMapDrawer drawer))
        {
            drawer.MapDrawMesh();
        }
    }

    public void OnUpdate(float deltaTime)
    {

    }

    public void OnLateUpdate(float deltaTime)
    {

    }

    public void InitializeInputHandle()
    {
        if(!InputManager.Ins.HasInputControl(InputDef.MapEditorInputCtl))
        {
            mInputControl = new MapEditorInputControl();
            mCamControl = new MapEditorCameraHandle();
            mMapBorad = new MapBoard();

            mInputControl.RegisterInputHandle(mCamControl);
            mInputControl.RegisterInputHandle(mMapBorad);

            InputManager.Ins.RegisterInputControl(InputDef.MapEditorInputCtl,mInputControl);
        }

        InputManager.Ins.ChangeToInputControl(InputDef.MapEditorInputCtl);
    }

    public void OnSceneEnter()
    {
        mMapEditorRoot = GameObject.Find(GameDefine._MAP_EDITOR);
        mDrawerDic = new Dictionary<int, GameMapDrawer>();
        MapConfig = new MapEditorConfigs(); // 下面的组件初始化之前必须先初始化配置
        mRecordMgr = new MapEditRecordManager(5);
        DataMgr = new MapEditorDataMgr();

        InitializeInputHandle();

        IntializeDrawers();
    }

    public void OnSceneExit()
    {
        
    }
}
