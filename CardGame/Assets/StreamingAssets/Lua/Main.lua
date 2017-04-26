local Main = {};

local this = Main;
--主入口函数。从这里开始lua逻辑
function this.Init()					
	print("Main.Init()");
    require("GlobalVar");
    --创建全局事件控制器
    GlobalVar.ControllerManage.GetGlobalEventController();
    --发送全局事件（开始游戏）
    GlobalVar.Event.Brocast(GlobalVar.Const.EVENT_STARTGAME);
end
this.Init();
