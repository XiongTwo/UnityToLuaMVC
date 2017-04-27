GlobalVar = {};
local this=GlobalVar;

GlobalVar.GameManage=nil;
GlobalVar.Event=nil;
GlobalVar.Const=nil;
GlobalVar.ControllerManage=nil;
GlobalVar.ResourceManage=nil;
GlobalVar.SqliteDbManage=nil;

function this.Init()
    print("GlobalVar.Init()");	

    this.Const = require("Const");
    this.Event = require("Other/events");
    this.ControllerManage = require("Manage/ControllerManage");
    this.ResourceManage=StaticModules.ResourceManage.New();
    this.SqliteDbManage=StaticModules.SqliteDbManage.New();
    --GameManageҪ����������
    this.GameManage = require("Manage/GameManage");
end

this.Init();
return this