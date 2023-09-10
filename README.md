# ConsoleUtilsForUnity
unity控制台console打印拓展工具

本项目旨在展开console控制台打印的内容显示，减少打印对象内容未知的情况，同时简化多参数打印的调用。

本项目部分功能使用LitJson实现，数组、字典、json数据均会另起一行显示，其他数据之间会空一格显示

## 使用方法
```c#
//json数据
string str = "{ 'a':1 }";
JsonData jd = JsonMapper.ToObject(str);
//字典内容
Dictionary<string, int[]> testDic = new Dictionary<string, int[]>();
testDic.Add("testA", new int[] { 1, 2, 3 });
testDic.Add("testB", new int[] { 1 });
//对象
GameObject obj = new GameObject();
obj.name = "test_obj";
//向量
Vector3 vec = new Vector3();
//对象
object testObj = new object[] { "str1", 2 };
//数组
int[] ints = new int[] { 1, 2, 3 };

//输出测试
ConsoleUtils.Log("输出通知内容1 ----- ", ints, testObj, jd, testDic, obj, vec);

ConsoleUtils.Warn("输出通知内容1 ----- ", ints, testObj, jd, testDic, obj, vec);

ConsoleUtils.Error("输出通知内容1 ----- ", ints, testObj, jd, testDic, obj, vec);
```

### 运行效果
![](https://p.sda1.dev/12/25eeb0d35dedb5ea43b41404b9b62c17/image.png)

![](https://p.sda1.dev/12/ef0bc985b876f590f48890667259e60d/image.png)

详细说明见 [Unity Console控制台打印拓展工具](https://busyo.buzz/article/Unity/%E5%B7%A5%E5%85%B7/Unity-Console%E6%8E%A7%E5%88%B6%E5%8F%B0%E6%89%93%E5%8D%B0%E6%8B%93%E5%B1%95%E5%B7%A5%E5%85%B7/)