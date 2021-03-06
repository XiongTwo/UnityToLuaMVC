local GlobalEventController={};
local this=GlobalEventController;

function this.Init()
    print("GlobalEventController.Init()");
    GlobalVar.Event.AddListener(GlobalVar.Const.EVENT_STARTGAME,this.EVENT_STARTGAME);
    GlobalVar.Event.AddListener(GlobalVar.Const.EVENT_UPDATEGAME,this.EVENT_UPDATEGAME);
    GlobalVar.Event.AddListener(GlobalVar.Const.EVENT_UPDATEGAME_NO,this.EVENT_UPDATEGAME_NO);
    GlobalVar.Event.AddListener(GlobalVar.Const.EVENT_UPDATEGAME_YES,this.EVENT_UPDATEGAME_YES);
end

function this.EVENT_STARTGAME()
    GlobalVar.Event.RemoveListener(GlobalVar.Const.EVENT_STARTGAME);
    GlobalVar.GameManage.Start();
    --GlobalVar.ControllerManage.GetUpdateController().Show();
end

function this.EVENT_UPDATEGAME()
    GlobalVar.Event.RemoveListener(GlobalVar.Const.EVENT_UPDATEGAME);
    GlobalVar.ControllerManage.GetUpdateController().Show();
end

function this.EVENT_UPDATEGAME_NO()
    GlobalVar.Event.RemoveListener(GlobalVar.Const.EVENT_UPDATEGAME_NO);
    Debugger.LogError("EVENT_UPDATEGAME_NO");
end

function this.EVENT_UPDATEGAME_YES()
    GlobalVar.Event.RemoveListener(GlobalVar.Const.EVENT_UPDATEGAME_YES);
    Debugger.LogError("EVENT_UPDATEGAME_YES");
    GlobalVar.GameManage.Reset();
end
this.Init();
return this;