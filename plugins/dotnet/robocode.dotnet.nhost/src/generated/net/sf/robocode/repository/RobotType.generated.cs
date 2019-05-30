/**
 * Copyright (c) 2001-2019 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * https://robocode.sourceforge.io/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8669
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.repository {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class RobotType : global::java.lang.Object, global::java.io.Serializable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isValid0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isJuniorRobot1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isStandardRobot2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isAdvancedRobot3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isTeamRobot4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isDroid5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isSentryRobot6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isInteractiveRobot7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isPaintRobot8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getTypeFlags9;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_INVALID10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobotType11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobotType12;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ZZZZZZZZ)V")]
        public RobotType(bool par0, bool par1, bool par2, bool par3, bool par4, bool par5, bool par6, bool par7) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 26)){
            @__env.NewObject(global::net.sf.robocode.repository.RobotType.staticClass, global::net.sf.robocode.repository.RobotType.j4n__ctorRobotType11, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par7));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public RobotType(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::net.sf.robocode.repository.RobotType.staticClass, global::net.sf.robocode.repository.RobotType.j4n__ctorRobotType12, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        protected RobotType(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.repository.RobotType.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lnet/sf/robocode/repository/RobotType;")]
        public static global::net.sf.robocode.repository.RobotType INVALID {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::net.sf.robocode.repository.RobotType>(@__env, @__env.GetStaticObjectFieldPtr(global::net.sf.robocode.repository.RobotType.staticClass, global::net.sf.robocode.repository.RobotType.j4n_INVALID10));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.repository.RobotType.staticClass = @__class;
            global::net.sf.robocode.repository.RobotType.j4n_isValid0 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isValid", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isJuniorRobot1 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isJuniorRobot", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isStandardRobot2 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isStandardRobot", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isAdvancedRobot3 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isAdvancedRobot", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isTeamRobot4 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isTeamRobot", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isDroid5 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isDroid", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isSentryRobot6 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isSentryRobot", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isInteractiveRobot7 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isInteractiveRobot", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_isPaintRobot8 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "isPaintRobot", "()Z");
            global::net.sf.robocode.repository.RobotType.j4n_getTypeFlags9 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "getTypeFlags", "()I");
            global::net.sf.robocode.repository.RobotType.j4n_INVALID10 = @__env.GetStaticFieldID(global::net.sf.robocode.repository.RobotType.staticClass, "INVALID", "Lnet/sf/robocode/repository/RobotType;");
            global::net.sf.robocode.repository.RobotType.j4n__ctorRobotType11 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "<init>", "(ZZZZZZZZ)V");
            global::net.sf.robocode.repository.RobotType.j4n__ctorRobotType12 = @__env.GetMethodID(global::net.sf.robocode.repository.RobotType.staticClass, "<init>", "(I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isValid() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isValid0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isJuniorRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isJuniorRobot1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isStandardRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isStandardRobot2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isAdvancedRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isAdvancedRobot3)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isTeamRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isTeamRobot4)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isDroid() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isDroid5)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isSentryRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isSentryRobot6)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isInteractiveRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isInteractiveRobot7)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isPaintRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.repository.RobotType.j4n_isPaintRobot8)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getTypeFlags() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::net.sf.robocode.repository.RobotType.j4n_getTypeFlags9)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.repository.RobotType(@__env);
            }
        }
    }
    #endregion
}