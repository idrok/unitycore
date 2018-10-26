using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCore_3D : MonoBehaviour {

    //Vector3
    private void Start_Vector3()
    {
        Vector3 a = new Vector3(0, 3, 0); //  3
        Vector3 b = new Vector3(4, 0, 0); //  4
        Vector3 c = new Vector3(4, 3, 0); //  c = a + b; 5

        // Angle
        /*
        print( Vector3.Angle(b, c));//30 36.8699?
        print(Vector3.Angle(a, c));//60 53.1301?
        print(c.magnitude);//5 ok
        */

        // ClampMagnitude Vector3
        // 限制一个向量大小，最大为maxLength，如果小于按照原向量返回
        // 如果大于按照最大maxLength进行等比缩放
        /*
        print(Vector3.ClampMagnitude(c, 5.5f).magnitude); //5
        print(Vector3.ClampMagnitude(c, 3f).magnitude); //3
        */

        // Cross Vector3
        // 返回一个正对两个向量垂直的向量
        // 这个方法会自动计算a向量和b向量的交叉点，返回垂直这两向量的垂直向量
        /*
        print(Vector3.Cross(a, b).normalized.ToString()); // -1
        print(Vector3.Cross(a, c).normalized.ToString()); //-1
        */

        // Vector3.Distance(a,b) 计算向量a到向量b的距离

        // a·b=|a|·|b|cos<a,b>
        // 使用Dot来求角度的时候需要normalized，因为Acos取值在[-1,1]之间
        /*
        print(Mathf.Acos(Vector3.Dot(b.normalized, c.normalized)) * Mathf.Rad2Deg); // 30 36.8699?
        print(Vector3.Dot(b, c));
        */

        // Vector3.kEpsilon ?

        // 线性过渡a到b
        // Vector3.Lerp(a, b, t);

        // Vector3.LerpUnclamped = Lerp

        // Vector3.Magnitude(v) 求一个向量的大小
        /*
        print(Vector3.Magnitude(a)); //3
        print(Vector3.Magnitude(b)); //4
        */

        // Max 返回由ab中xyz组成最大值的新向量
        // Min 返回由ab中xyz组成最小值的新向量
        /*
        print(Vector3.Max(a, b).ToString()); //(4,3,0)
        print(Vector3.Min(a, c).ToString()); //(0,3,0)
        */

        // Vector3.MoveTowards(a, b, maxt)
        // 类似于Leap，但这个可以限制maxt步进值
        // maxt如果是正数向目标移动，maxt如果负数远离目标

        // Vector3.negativeInfinity ?

        // Vector3.Normalize(v)格式化一个向量值到[-1,1]

        // OrthoNormalize(a,b,t)
        // 这个一个组合方法，可以格式化a,b向量，并且找一个垂直于ab向量的t向量,相当于corss
        /*
        Vector3 t = Vector3.zero;
        Vector3.OrthoNormalize(ref a, ref b, ref t);
        print(a); // (0,1,0)
        print(t.normalized.ToString());//(0,0,-1)
        */

        // Vector3.positiveInfinity ？

        // Vector3.Project(v, p) 求一个向量在另一个向量上面的投影值
        // print(Vector3.Project(c, b).ToString()); // (4,0,0)

        // Vetor3.ProjectOnPlane(v, n)
        // 法线一般是相对于平面来定义
        // 切线一般是相对于曲面来定义
        // 求一个向量在另一个向量法线上的投影值
        //print(Vector3.ProjectOnPlane(c,b).ToString()); // (0,3,0)

        // Vector3.ReferenceEquals(o1, o2) ?

        // Vector3.Reflect(v, dir)
        // 沿着dir方向的法线生成一个反射向量
        /*
        print(Vector3.Reflect(a, Vector3.right).ToString()); // (0,3,0)
        print(Vector3.Reflect(a, Vector3.up).ToString()); //(0,-3,0)
        */

        // Vector3.RotateTowards(v, t, maxRad, maxmag)
        // 相对于一个中心点由a点旋转到b点
        //Vector3.RotateTowards(a, b, 100, 100); ?

        //Vector3.Scale(a,b)将a和b的xyz分别相乘
        //print(Vector3.Scale(a, b));// (0,0,0)

        // 同Angle，但这个是带符号的角度，由正负之分
        // Unity3d使用的左手坐标系，z轴往里面的
        // print(Vector3.SignedAngle(a, c, Vector3.back));//53

        // 相对于中心在弧线上插值， t[0,1]
        //Vector3.Slerp(a, b, t)

        // Vector3.SlerpUnclamped(a,b,t)

        // 平滑阻尼，一般用于平滑跟随相机
        // Vector3.SmoothDamp(c, t, v, t, maxs, t)
        
    }

    //Quaternion
    private void Start_Quaternion()
    {
        Quaternion a = Quaternion.AngleAxis(30, Vector3.up);
        Quaternion b = Quaternion.AngleAxis(60, Vector3.up);

        // Quaternion.Angle(q1, q2)
        // 求两个四元素之间的角度
        // print(Quaternion.Angle(a, b)); // 30

        // Quaternion.AngleAxis(a, ax)
        // 创建一个以ax为轴心的旋转角度

        // Quaternion.Dot(q1, q2) ?
        // print(Mathf.Acos( Quaternion.Dot(a, b)) * Mathf.Rad2Deg); 30 15 ?

        // 使用Vector3来创建一个旋转实体，zxy的顺序
        // Quaternion.Euler(v3)

        // Quaternion.FromToRotation(v1, v2) ??
        //print(Quaternion.FromToRotation(Vector3.up, Vector3.forward).ToString());

        // 跟父物体保持同一旋转
        //Quaternion.identity

        // Quaternion.Inverse(q)
        //反转一个旋转
        //print(Quaternion.Inverse(a));

        // Quaternion.kEpsilon ?

        // 线性插值，t[0,1]
        // Quaternion.Lerp(q1,q2,t)

        // 线性插值，t可以随意值
        //Quaternion.LerpUnclamped(q1,q2,t)

        // 朝v1旋转，指定世界的up轴
        // Quaternion.LookRotation(v1, up)

        //保持q2和q1拥有一样的旋转
        // Quaternion.RotateTowards(q1,q2,t)

        //球形插值 t[0,1]
        //Quaternion.Slerp(q1,q2,t)

        //球形插座 t无限制
        //Quaternion.SlerpUnclamped(q1,q2,t)

        //lerp slerp 线性插线和光滑线性插值
    }
    
    //Transform
    private void Start_Transform()
    {
        // 给当前transform广播一条消息，包括其子节点上是脚本全部可以接收到
        //transform.BroadcastMessage(n,p,o)

        // 子节点数量
        //transform.childCount

        // 对比标签
        //t.CompareTag(t)

        // 子节点解体
        //transform.DetachChildren()

        // 相对于世界中的旋转
        // print(transform.eulerAngles);

        // 通过n来查找一个子节点
        // transform.Find(n)

        //世界坐标中的z x y
        //transform.forward transform.right transform.up

        // 通过索引获取子节点
        //transform.GetChild(i)

        // 获取当前的迭代器，迭代子节点
        //transform.GetEnumerator()

        // 哈希值
        //transform.GetHashCode();

        // 实例化ID
        //t.GetInstanceID();

        //获取在同级上的顺序索引
        //t.GetSiblingIndex();

        //设置隐藏属性
        //transform.gameObject.hideFlags = HideFlags.NotEditable;

        //统计从根节点的所有节点数量
        //print(transform.hierarchyCapacity);

        //统计从根节点的所有节点数量
        //print(transform.hierarchyCount);

        //将t1按照指定的d方向转换到世界坐标系 Vector3.forward << = t1.forward
        //t1.TransformDirection(d)
        //print(transform.TransformDirection(Vector3.forward).ToString());

        //print( transform.TransformPoint(transform.position));
        //print(transform.position);

        //将t1按照右移动2个单位转换到世界坐标
        //Vector3 needPos = transform.TransformPoint(Vector3.right * 2);
        //Instantiate(go, needPos, Quaternion.identity);

        // ??
        //Vector3 needPos = transform.TransformVector(Vector3.right * 2);
        //Instantiate(go, needPos, Quaternion.identity);

        // 位移
        //t.Translate(v, ax)

        //???
        //t.InverseTransformDirection(v)
        //t.InverseTransformPoint(v)
        //t.InverseTransformVector(v)

        // 是否是t的子节点
        //transform.IsChildOf(t)

        //本地角度
        //transform.localEulerAngles()

        //transform.localPosition transform.localRotation transform.localScale

        //本地到世界矩阵转换
        //t.localToWorldMatrix

        // 朝着upx轴向旋转
        //transform.LookAt(v1, upx);

        //世界坐标缩放
        //transform.lossyScale

        //跟节点
        //transform.root

        //相对于ax轴向的空间转动
        //transform.Rotate(ax,a,s)

        //一个点、一个轴、一个角度定义旋转
        //transform.RotateAround(p,a,n)

        //transform.SetAsFirstSibling();
        //transform.SetAsLastSibling();
        //transform.SetSiblingIndex(i);
        //transform.SetPositionAndRotation(p, q)
        //t.SetParent(t)
    }
}
