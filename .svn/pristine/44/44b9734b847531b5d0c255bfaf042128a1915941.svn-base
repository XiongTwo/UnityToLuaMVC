GlobalVar = {};
local this=GlobalVar;

GlobalVar.GameManage=nil;
GlobalVar.Event=nil;
GlobalVar.Const=nil;
GlobalVar.ControllerManage=nil;
GlobalVar.ResourceManage=nil;

function this.Init()
    print("GlobalVar.Init()");	

    this.Const = require("Const");
    this.Event = require("Other/events");
    this.ControllerManage = require("Manage/ControllerManage");
    this.ResourceManage=StaticModules.ResourceManage.GetInstance();
    --GameManage要放在最后加载
    this.GameManage = require("Manage/GameManage");
end

this.Init();
return this