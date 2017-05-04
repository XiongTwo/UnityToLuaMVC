local UpdateController={};
local this=UpdateController;
local dup=StaticModules.UpdateController.New();

local resURL = "http://192.168.6.102:81/Card/";
local View;
local localFileList;
local serverFileList;
local updateFileList;
local downloadFiles;

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
    this.LoadLocalFiles();
    this.StartLoadServerFiles();
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
function this.StartLoadServerFiles()
    print("UpdateController.StartLoadServerFiles()");
    coroutine.start(LoadServerFiles);
end
local serverFilesBytes;
function LoadServerFiles()
    print("UpdateController.LoadServerFiles()");
    local URL=resURL.."Files.txt";
    local www = UnityEngine.WWW(URL);
	coroutine.www(www);
    if www.error~=nil then
        Debugger.LogError(www.error);
    end
    serverFilesBytes=www.bytes;
    local txt = tolua.tolstring(serverFilesBytes);
    local splitArr=Common.Split(txt,{"\n"});
    serverFileList=System.Collections.ArrayList.New();
    for i=0,splitArr.Length-1,1 do  
        serverFileList:Add(Common.StrTrim(splitArr[i]));  
    end
    GetUpdateFileList();
end
function this.LoadLocalFiles()
    print("UpdateController.LoadLocalFiles()");
    local txt=GlobalVar.ResourceManage.GetInstance().filesArray;
    localFileList=System.Collections.ArrayList.New();
    for i=0,txt.Length-1,1 do  
        localFileList:Add(Common.StrTrim(txt[i]));  
    end 
end
function GetUpdateFileList()
    print("UpdateController.GetUpdateFileList()");
    updateFileList=dup:GetUpdateFileList(serverFileList,localFileList);
    if updateFileList.Count==0 then
        print("没有要更新的文件");
        --发送全局事件（不需要更新游戏）
        GlobalVar.Event.Brocast(GlobalVar.Const.EVENT_UPDATEGAME_NO);
        return;
    end
    coroutine.start(StartUpdate);
end
local url;
local file;
function StartUpdate()
    downloadFiles=System.Collections.ArrayList.New();
    for i=0,updateFileList.Count-1,1 do
        url=resURL..updateFileList[i];
        file=updateFileList[i];
        coroutine.start(BeginDownload);
        while IsDownOK(file)==false do
            coroutine.wait(UnityEngine.Time.deltaTime);
        end
        Debugger.LogError("UpdateFile:"..file);
    end
    Common.ReplaceFile("Files.txt",serverFilesBytes);
    Debugger.LogError("UpdateFile:Files.txt");
    --发送全局事件（更新游戏文件结束）
    GlobalVar.Event.Brocast(GlobalVar.Const.EVENT_UPDATEGAME_YES);
end
function BeginDownload()
    local www = UnityEngine.WWW(url);
	coroutine.www(www);
    if www.error~=nil then
        Debugger.LogError(www.error);
    end
    Common.ReplaceFile(file,www.bytes);
    downloadFiles:Add(file);
end
function IsDownOK(file)
    return downloadFiles:Contains(file);
end
this.Init();
return this;


