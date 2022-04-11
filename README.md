# -
大二材料力学深度研讨惯性矩程序
 
运行注意：
1：vscode下载安装c#环境；
2：配置MyDoNet.dll避免频繁报提醒；
3：若提示找不到build文件，在命令行窗口输入.net:Generate Assets Build and Debug；
4：launch.json 报错，请保证dll路径与原路径相同。

各部分介绍：
1.Resources.cs和Setting.cs为app生成配置文件，不建议改动；
2:Program.cs为系统初始化启动文件；
3：Form1.cs为主体运行模块；
  （1）通过设置Color区分不同的窗口；
  （2）链接外部图片资源；
  （3）触发型网站资源链接；
  （4）通过表格改变计算对象；
  （5）根据窗口大小设定字体格式等；----不建议修改以防变形
 4：jpg文件绘图而来，可以重新导入。
 
 计划提升部分：
 1：用react重述，拆解Form1文件为css，js
 2：增加端口导入功能，“实现DWG等格式导入”
 3：拆分网格有限元化计算任意截面惯性矩             

