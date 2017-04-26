local ControllerManage={};
local this=ControllerManage;

this.GlobalEventController=nil;
function this.GetGlobalEventController()
    if this.GlobalEventController==nil then
        this.GlobalEventController=require("Controller/GlobalEventController");
    end
    return this.GlobalEventController;
end

this.UpdateController=nil;
function this.GetUpdateController()
    if this.UpdateController==nil then
        this.UpdateController=require("Controller/UpdateController");
    end
    return this.UpdateController;
end

return this;
