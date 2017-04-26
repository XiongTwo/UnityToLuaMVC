local GameManage={};

local this = GameManage;

this.timeScale =nil;

function this.Init()					
	print("GameManage.Init()");
    this.timeScale=UnityEngine.Time.timeScale;
end

function this.Start()					
	print("GameManage.Start()");
    UnityEngine.SceneManagement.SceneManager.LoadScene(GlobalVar.Const.SCENE_LOGIN,UnityEngine.SceneManagement.LoadSceneMode.Single);
    coroutine.start(Wait_Load_SCENE_LOGIN_Finish)
end
function Wait_Load_SCENE_LOGIN_Finish()
    print("Wait_Load_SCENE_LOGIN_Finish()");
    local SceneName=UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    print("SceneName:"..SceneName);
    local waitTime=0;
    while SceneName~=GlobalVar.Const.SCENE_LOGIN do
        local deltaTime=UnityEngine.Time.deltaTime;
        coroutine.wait(deltaTime);
        waitTime=waitTime+deltaTime;
        print("wait:"..deltaTime);
        SceneName=UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    end
    print("waitTime:"..waitTime);
    print("Wait_Load_SCENE_LOGIN_Finish:succeed");
    print("SceneName:"..SceneName);
    --发送全局事件（更新游戏）
    GlobalVar.Event.Brocast(GlobalVar.Const.EVENT_UPDATEGAME);
end

function this.Pause()					
	print("GameManage.Pause()");
    this.timeScale=UnityEngine.Time.timeScale;
    UnityEngine.Time.timeScale=0;
end 

function this.Continue()					
	print("GameManage.Continue()");
    UnityEngine.Time.timeScale=this.timeScale;
end

function this.Quit()					
	print("GameManage.Quit()");
    UnityEngine.Application.Quit();
end

function this.Reset()					
	print("GameManage.Reset()");
    UnityEngine.SceneManagement.SceneManager.LoadScene(GlobalVar.Const.SCENE_MAIN);
end

this.Init();
return this;
