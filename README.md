####项目简介：

项目采用经典DDD架构(用沃恩.弗农大神的话，其实这是DDD-Lite）思想进行开发，简洁而不简单，实用至上，并且所写每一行代码都经过深思熟虑，符合SOLID规则！

当然，如果你想学习完整的DDD框架，可以参考我的另一个项目（[BestQ&A--开源中国推荐项目/集`CQRS` `AES`等DDD高级特性于一体的问答系统](http://git.oschina.net/yubaolee/BestQA)）

项目详细描述：http://www.cnblogs.com/yubaolee/p/OpenAuth.html 

####项目最新进度

`1.0 beta版(2016-1-8)` 

* 完成进出库实例Stock；
* 全面实现部门数据分离，可以灵活配置用户可访问的部门，没有配置可见部门的用户自能访问自己的数据，参考Stock实例；
* 全新的基于CodeSmith EF生成机制；
* 全面完成菜单授权;
* 全面完成资源授权，后期可为第三方分配资源；
* 增加Anonymous机制，可以灵活控制Action是否需要权限控制;

`秀外`

基于B-JUI酷炫（[炫不炫，你说了算](http://demo.b-jui.com/index_tree.html/)）的动态效果：

![输入图片说明](http://git.oschina.net/uploads/images/2015/1208/005100_5849eec8_362401.jpeg "在这里输入图片标题")
![输入图片说明](http://git.oschina.net/uploads/images/2015/1208/003425_cc164edc_362401.jpeg "在这里输入图片标题")

`慧中`

教科书级的分层思想，哪怕苛刻的你阅读的是大神级精典大作（如：《企业应用架构模式》《重构与模式》《ASP.NET设计模式》等），你也可以参考本项目。不信？有图为证，Resharper自动生成的项目引用关系，毫无PS痕迹！

![输入图片说明](http://git.oschina.net/uploads/images/2015/1113/233705_271ecb3a_362401.jpeg "在这里输入图片标题")

`实用`

符合国情的RBAC（基于角色的访问控制），可以直接应用到你的系统。

`权限资源`

1. 菜单权限  经理和业务员登陆系统拥有的功能菜单是不一样的
2. 按钮权限  经理能够审批，而业务员不可以
3. 数据权限  A业务员看不到B业务员的单据
4. 字段权限  某些人查询客户信息时看不到客户的手机号或其它字段

`用户`应用系统的具体操作者，我这里设计用户是可以直接给用户分配菜单/按钮，也可以通过角色分配权限。

`角色`为了对许多拥有相似权限的用户进行分类管理，定义了角色的概念，以上所有的权限资源都可以分配给角色，角色和用户N:N的关系。

`机构`树形的公司部门结构，国内公司用的比较多，它实际上就是一个用户组，机构和用户设计成N:N的关系，也就是说有时候一个用户可以从属于两个部门，这种情况在我们客户需求中的确都出现过。

####系统工程结构：
1. OpenAuth.Domain 系统领域层
2. OpenAuth.Repository 系统仓储层，用于数据库操作
3. OpenAuth.App 应用层，为界面提供接口
4. OpenAuth.Mvc 采用基于jquery与bootstrap的B-JUI界面
5. OpenAuth.UnitTest 单元测试
6. Infrastructure 通用工具集合

####使用
管理员可直接在登录界面点击`基于精典DDD的权限管理 - 点击以开发者账号登录`登录；

普通应用账号使用：test(密码：test)登录；

####后续
更多`狂野`的功能，正在玩命加载中，敬请期待...
更多文档正在整理中....


