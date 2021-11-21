                                                         基本项目说明        
# 项目说明：
   本项目主要是通过.NET Core3.1框架进行开发 主要用于工业控制方面 通过自定义控件继承接口并且实现该接口就可以很好的与PLC进行数据互交并且减少代码量 性能方面比.NET Framework好上一个档次
   该项目会一直进行下去 由于上几个项目没有前期规划写的代码比较死固定没有使用反射底层通用类等(个人感觉是比较失败的上几个项目)但是我对这个项目有比较大的耐心和规划 
   后期会添加不同特性的接口让开发人员去继承初步实现尽可能的少量代码去开发  未来方面主要是PLC对SQL数据库 以及PLC输出报表等。
   有反馈使用报警控件时出现权限不足导致无法在C盘路径下创建文件夹 请用管理员权限打开IDE方可解决 发布软件需要在把C:\PLCEventErr目录下覆盖到安装电脑。
   需要对应的功能请提前添加PLC类型PlcControlsPreferences控件添加对应的PLC表 否则PLC控件无反应或者不执行代码。  
# NuGet包：
   本项目已上传到NuGet中 各位可以在NuGet管理器中输入‘ PLC通讯基础控件项目 ’进行导入 编译完成后工具管理自动出现封装好的控件。
# 项目案例：
   本项目已上传到百度云盘中 但是并不是每次都更新只会一个大版本跟新 链接: https://pan.baidu.com/s/1Y5qyCzGqja-9EmT4slzGuw 提取码: k756 复制这段内容后打开百度网盘手机App，操作更方便哦
# 项目要求：
   本项目主要是开发以及封装对应接口类让开发人员去定制封装控件 其实对PLC来说他不是：位访问模式，寄存器字访问模式，批量位访问模式，批量寄存器字模式 四种模式。就看开发人员如何去继承相应接口去使用
   如果有开发人员需要添加对应PLC以及其他PLC协议类型后期我会出一期路线图；
 # 项目控件视频：
 https://pan.baidu.com/s/1ap2zkjWe8ORIAOHKnxRL6w 提取码：4z8d
# 底层控件使用说明：   
 ![OK$TVDKKT{ 05_2RZRM4MWT](https://user-images.githubusercontent.com/60955669/132943726-6ff58945-6766-4f99-a40f-403cd41b0dba.png)
# 项目发布需要注意：
1：需要在IDE设计电脑 C盘目录下中找到3个文件夹然后 发布到安装软件的电脑中  当然可以不覆盖这样有些保存的文件和功能达不到预期效果。  
 ![1637306007(1)](https://user-images.githubusercontent.com/60955669/142580797-c298a9cb-4dbb-4e61-9793-f5b1eb6a8d43.png)  

# 项目更新展示：
1:控件宏脚本 以及全局宏脚本控件（1：需要添加DaMacroControl控件让窗口获得右键菜单打开宏窗口功能 2：绑定的宏代码需要在窗口右键打开宏编译器进行编译后才能运行绑定 注意宏代默认在C:\Program Files目录下建议发布软件时在该目录覆盖回去)  
![图片](https://user-images.githubusercontent.com/60955669/142577081-b05a7c98-e07d-40a3-9303-ab2bafffc7de.png)
![图片](https://user-images.githubusercontent.com/60955669/142577129-2a109e91-8290-4a02-90b4-a5af1ec47d83.png)
2:支持控件绑定以及利用控件动态绑定触发宏代码（绑定的代码需要编译通过才能运行)  
![图片](https://user-images.githubusercontent.com/60955669/142577296-c868b2f2-e780-4125-8e4e-2109ba8e006b.png)

3:新增监控底层设备状态控件PlcStatusView 方便设计人员添加网络监控视图 分为四种状态：1 在线(指示着设备运行中) 2 离线(指示设备离线) 3 未添加(指示设备未添加到PLC表 就是PlcControlsPreferences控件未添加设备) 4 未启用(指示该控件未启用PLC功能)。  
![1634978787(1)](https://user-images.githubusercontent.com/60955669/138549760-7e6c1632-0e76-4714-a564-dd8fb4242e96.png)

4：新增全局位控件状态切换 方便用户在IDE编辑设计模式下快速的切换控件状态 在需要的设计窗口添加PlcControlSwitch控件 找到参数ControlSwitch点击切换状态即可。  
  状态0：
 ![image](https://user-images.githubusercontent.com/60955669/137632715-0c74c336-2ba8-4968-9866-09ac33693cde.png)
  状态1：
 ![image](https://user-images.githubusercontent.com/60955669/137632738-238bb3f4-0f05-4a79-8a52-28cb7f9c7e2c.png)
# 更新计划：
1：全面覆盖宏指令脚本 以及控件触发宏脚本。  
2：优化宏脚本编译器 关键词颜色进行改变 新增内部类进行处理。   
3：新增PLC配方控件。  
# 作者：
DAtoDA
