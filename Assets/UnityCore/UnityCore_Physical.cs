﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCore_Physical : MonoBehaviour {
    
    //Rigidbody
	private void Start_Rigidbody () {
        // 由一个点向周围爆炸的物体拟真效果
        //b.AddExplosionForce(f,v,r,u,m)

        // 给刚体施加一个力量
        //b.AddForce(v,m)
        //body.AddForce(Vector3.forward, ForceMode.Acceleration)

        // 给刚体的一个点作用力
        //b.AddForceAtPosition(f,v,m)

        // 给刚体施加一个相对作用力
        //b.AddRelativeForce(f,m)

        // 施加一个相对扭矩力
        //b.AddRelativeTorque(f,m)

        // 给刚体施加一个扭矩力
        //b.AddTorque(t,m)

        // 物体的角阻力
        //b.angularDrag

        // 角速度向量
        //b.angularVelocity

        // 相对物体自身坐标物体质量的中心点
        //b.centerOfMass

        // 相对于v到碰撞器最近的一个点
        //b.ClosestPointOnBounds(v)

        //刚体的探查模式
        //b.collisionDetectionMode

        // 刚体的自由度模拟控制
        //b.constraints

        // 碰撞检测是否启用
        //b.detectCollisions

        // 物体的阻力
        //b.drag

        // 固定旋转
        //b.freezeRotation

        // 刚体在世界坐标中一点的速度
        //b.GetPointVelocity

        // 刚体在世界坐标中一点的相对速度
        //b.GetRelativePointVelocity

        // 物体的惯性张量
        //b.inertiaTensor

        //旋转的惯性张量
        //b.inertiaTensorRotation

        // 插值线性效果
        //b.interpolation

        // 是否附带刚体效果
        //b.isKinematic

        // 刚体是否静止
        //b.IsSleeping()

        // 刚体的质量
        //b.mass

        // 最大角速度
        //b.maxAngularVelocity

        // 最大非穿透速度 ?
        //b.maxDepenetrationVelocity

        //b.MovePosition(v)

        //b.MoveRotation(q)

        //b.position

        //b.ResetCenterOfMass();

        // 重置惯性张量和旋转
        //b.ResetInertiaTensor();

        //b.rotation

        //设置质量，随着碰撞器的尺寸而缩放
        //b.SetDensity(f)

        //设置刚体静止
        //b.Sleep()

        //刚体静止阈值
        //b.sleepThreshold

        //??
        //body.solverIterations

        //body.solverVelocityIterations

        //单一方向预测碰撞
        //b.SweepTest(v, h, r, q);

        //全部方向扫描
        //b.SweepTestAll(v,d,q)

        //b.transform

        //b.useGravity

        // 刚体的速度
        //b.velocity

        //b.WakeUp()

        //在世界中的质量中心的
        //b.worldCenterOfMass()
	}

    //Physical 物理属性和辅助方法
    private void Start_Physical()
    {
        //图层蒙版常量可选择所有图层
        //Physics.AllLayers;

        //是否自动模拟物体效果
        //Physics.autoSimulation

        //如果transform改变的时候是否把状态同步到物理效果
        //Physics.autoSyncTransforms

        //碰撞反弹值
        //Physics.bounceThreshold

        //方块投射单个预测检测
        //Physics.BoxCast(v,v,d,h,v,d,m,q)

        //方块投射预测检测所有
        //Physics.BoxCastAll(v,v,d,v,d,m,q)

        //方块投身预测检测，buff结果
        //Physics.BoxCastNonAlloc(v,v,d,hs,v,d,m,q)

        //Physics.CapsuleCast(v,v,r,d,h,d,m,q)
        //Physics.CapsuleCastAll(...)
        //Physics.CapsuleCastNonAlloc(...)

        //给定的盒子是否有重叠
        //Physics.CheckBox(v,h,q,m,q)
        //Physics.CheckCapsule(v,v2,r,m,q) 胶让体
        //Physics.CheckSphere(v,r,m,q) 圆球

        //指定位置上最接近碰撞器的点
        //Physics.ClosestPoint(v,c,v,r)

        // 检测两个碰撞器是否重叠
        //Physics.ComputePenetration(c1,v1,q1,c2,v2,q2,d,d)
        
        // 新建collider默认偏移量
        //Physics.defaultContactOffset

        // 默认射线检测层级
        //Physics.DefaultRaycastLayers

        // 关节和碰撞器的准确程度
        //Physics.defaultSolverIterations
        //Physics.defaultSolverVelocityIterations

        // 判定二个层级碰撞信息
        //Physics.GetIgnoreLayerCollision(l1,l2)

        //Physics.gravity

        //让c1和c2忽略碰撞
        //Physics.IgnoreCollision(c1,c2,i)
        //Physics.IgnoreLayerCollision(l1,l2,i)
        //Physics.IgnoreRaycastLayer

        // 点到点投射,检测碰撞
        //Physics.Linecast(v1,v2,h,m,q)
        
        // 碰撞实体检测
        //Physics.OverlapBox(v,h,d,m,q)
        //Physics.OverlapBoxNonAlloc(...)
        //Physics.OverlapCapsule(...)
        //Physics.OverlapCapsuleNonAlloc(...)  
        //Physics.OverlapSphere(...)
        //Physics.OverlapSphereNonAlloc(...)

        // 是否击中后背 ?
        //Physics.queriesHitBackfaces

        // 是否触发
        //Physics.queriesHitTriggers

        // 射线检测
        //Physics.Raycast(v,d,h,d,m,q)
        //Physics.RaycastAll(...)
        //Physics.RaycastNonAlloc(...)

        // 临时模拟物理效果
        //Physics.Simulate(f)

        //球体碰撞预测
        //Physics.SphereCast(v,r,d,h,v,m,q)
        //Physics.SphereCastAll(...)
        //Physics.SphereCastNonAlloc(...)

        //Physics.SyncTransforms()
    }

    //Charactor Controller
    private void Start_CharactorController()
    {
        CharacterController cc = GetComponent<CharacterController>();

        //获取cc上面的刚体
        //cc.attachedRigidbody

        //碰撞器在世界空间中的边界体积
        //cc.bounds

        //自身的中心点
        //cc.center

        //离碰撞器最近的一个点
        //cc.ClosestPoint(v)

        //离碰撞器边界最近的一个点
        //cc.ClosestPointOnBounds(v)

        //角色和当前环境哪些部分将进行交互
        //cc.collisionFlags

        //碰撞器偏移
        //cc.contactOffset

        //其他刚体是否可以检测到cc
        //cc.detectCollisions

        //是否可以发生碰撞
        //cc.enabled

        //是否允许重叠恢复
        //cc.enableOverlapRecovery

        //cc.height
        //cc.isGrounded
        //cc.isTrigger

        //物理材质球，地面的阻力，泥塘坑洼地
        //cc.material

        //最小移动距离
        //cc.minMoveDistance

        //cc.Move(v)
        //cc.radius

        //cc自己发射线检测
        //cc.Raycast(r,h,v)

        //cc.sharedMaterial
        //cc.SimpleMove(v)
        //cc.skinWidth
        //cc.slopeLimit
        //cc.stepOffset
        //cc.velocity
    }

    //Cloth 红旗拟真效果
    private void Start_Cloth()
    {
        Cloth c = GetComponent<Cloth>();

        //布料弯曲僵硬度
        //c.bendingStiffness

        //布料碰撞数组
        //c.capsuleColliders

        //清除位置改变对布料的影响
        //c.ClearTransformMotion();

        //每秒迭代频率
        //c.clothSolverFrequency

        //蒙皮对布料影响系数
        //c.coefficients

        //粒子碰撞对质量的影响
        //c.collisionMassScale

        //阻尼布料运动
        //c.damping
        
        //允许连续的碰撞使的碰撞稳定
        //c.enableContinuousCollision

        //给布料施加一个外部常量力度
        //c.externalAcceleration

        //布料碰到角色时的摩擦力
        //c.friction

        //布料的所有法线
        //c.normals

        //随机给布料一个速度
        //c.randomAcceleration

        //给布料一个过渡效果
        //c.SetEnabledFading(e,t)

        //c.sleepThreshold

        //c.sphereColliders

        //布料拉伸僵硬度
        //c.stretchingStiffness

        //重力对布料的影响
        //c.useGravity

        //使用虚拟粒子使得碰撞稳定
        //c.useVirtualParticles

        //布料顶点个数
        //c.vertices

        //角色运动对布料影响系数
        //c.worldAccelerationScale
        //c.worldVelocityScale
    }

    //Joint 鞭尸效果
    private void Start_Joint()
    {
        CharacterJoint cj = GetComponent<CharacterJoint>();
        
        //如果是外力致使关节运动的中心的
        //cj.anchor
       
        //是否自动计算关节中心的
        //cj.autoConfigureConnectedAnchor

        //外力运动的方向轴
        //cj.axis

        //使得关节破碎的力度
        //cj.breakForce
        //cj.breakTorque

        //相对中心点
        //cj.connectedAnchor
        //cj.connectedBody

        //反作用力系数
        //cj.connectedMassScale

        //cj.currentForce
        //cj.currentTorque
        //cj.enableCollision

        //是否允许预处理
        //cj.enablePreprocessing
        //cj.enableProjection ?

        //高度扭矩限制
        //cj.highTwistLimit
        //cj.lowTwistLimit

        //cj.massScale ?

        //cj.projectionAngle ?
        //cj.projectionDistance ?

        //cj.swing1Limit
        //cj.swing2Limit
        //cj.swingAxis
        //cj.swingLimitSpring
        //cj.twistLimitSpring
    }
}
