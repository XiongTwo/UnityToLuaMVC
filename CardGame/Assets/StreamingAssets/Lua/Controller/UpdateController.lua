local UpdateController={};
local this=UpdateController;
local dup=StaticModules.UpdateController.New();

local resURL = "http://127.0.0.1:81/";
local View;

function this.Init()
    print("UpdateController.Init()");
end

function this.Show()
    print("UpdateController.Show()");
    if View==nil then
        View = UnityEngine.GameObject.Instantiate(GlobalVar.ResourceManage.GetInstance():Load("test_prefab"));
        local script=require("View/UpdateControllerView");
        LuaBehaviour.AddLuaBehaviourLiftCycleFunction(StaticModules.E_MonoBehaviourLiftCycle.Awake,script.Awake);
        LuaBehaviour.AddLuaBehaviour(View);
    end
    View:SetActive(true);
    this.Data();
end
function this.Hide()
    View:SetActive(false);
end
function this.Data()
    local db=GlobalVar.SqliteDbManage:GetConfigDb();
    local sqReader = db:ReadFullTable("Test");
    while sqReader:Read() do
        local str = "name=" .. sqReader:GetString(sqReader:GetOrdinal("Test"));
        Debugger.LogError(str);
    end
end
this.Init();
return this;


