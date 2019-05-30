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

namespace net.sf.robocode.security {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class HiddenAccess : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_dispatch0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_init1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_cleanup2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_update3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_initContainer4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_robocodeMain5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isCriticalEvent6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setEventTime7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setEventPriority8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setDefaultPriority9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getSerializationType10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createSpecification11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getFileSpecification12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobotTeamName13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setTeamId14;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createStatus15;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_createRules16;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isSafeThread17;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_initContainerForRobotEngine18;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorHiddenAccess19;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public HiddenAccess() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n__ctorHiddenAccess19, this);
            }
        }
        
        protected HiddenAccess(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.security.HiddenAccess.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.security.HiddenAccess.staticClass = @__class;
            global::net.sf.robocode.security.HiddenAccess.j4n_dispatch0 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "dispatch", "(Lrobocode/Event;Lrobocode/robotinterfaces/IBasicRobot;Lnet/sf/robocode/peer/IRob" +
                    "otStatics;Ljava/awt/Graphics2D;)V");
            global::net.sf.robocode.security.HiddenAccess.j4n_init1 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "init", "()V");
            global::net.sf.robocode.security.HiddenAccess.j4n_cleanup2 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "cleanup", "()V");
            global::net.sf.robocode.security.HiddenAccess.j4n_update3 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "update", "(Lrobocode/Bullet;DDLjava/lang/String;Z)V");
            global::net.sf.robocode.security.HiddenAccess.j4n_initContainer4 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "initContainer", "()V");
            global::net.sf.robocode.security.HiddenAccess.j4n_robocodeMain5 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "robocodeMain", "([Ljava/lang/String;)V");
            global::net.sf.robocode.security.HiddenAccess.j4n_isCriticalEvent6 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "isCriticalEvent", "(Lrobocode/Event;)Z");
            global::net.sf.robocode.security.HiddenAccess.j4n_setEventTime7 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setEventTime", "(Lrobocode/Event;J)V");
            global::net.sf.robocode.security.HiddenAccess.j4n_setEventPriority8 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setEventPriority", "(Lrobocode/Event;I)V");
            global::net.sf.robocode.security.HiddenAccess.j4n_setDefaultPriority9 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setDefaultPriority", "(Lrobocode/Event;)V");
            global::net.sf.robocode.security.HiddenAccess.j4n_getSerializationType10 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "getSerializationType", "(Lrobocode/Event;)B");
            global::net.sf.robocode.security.HiddenAccess.j4n_createSpecification11 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "createSpecification", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
                    "ng/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Strin" +
                    "g;)Lrobocode/control/RobotSpecification;");
            global::net.sf.robocode.security.HiddenAccess.j4n_getFileSpecification12 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "getFileSpecification", "(Lrobocode/control/RobotSpecification;)Ljava/lang/Object;");
            global::net.sf.robocode.security.HiddenAccess.j4n_getRobotTeamName13 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "getRobotTeamName", "(Lrobocode/control/RobotSpecification;)Ljava/lang/String;");
            global::net.sf.robocode.security.HiddenAccess.j4n_setTeamId14 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "setTeamId", "(Lrobocode/control/RobotSpecification;Ljava/lang/String;)V");
            global::net.sf.robocode.security.HiddenAccess.j4n_createStatus15 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "createStatus", "(DDDDDDDDDDDDIIIIJ)Lrobocode/RobotStatus;");
            global::net.sf.robocode.security.HiddenAccess.j4n_createRules16 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "createRules", "(IIIDJZI)Lrobocode/BattleRules;");
            global::net.sf.robocode.security.HiddenAccess.j4n_isSafeThread17 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "isSafeThread", "()Z");
            global::net.sf.robocode.security.HiddenAccess.j4n_initContainerForRobotEngine18 = @__env.GetStaticMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "initContainerForRobotEngine", "(Ljava/io/File;Lrobocode/control/events/IBattleListener;)V");
            global::net.sf.robocode.security.HiddenAccess.j4n__ctorHiddenAccess19 = @__env.GetMethodID(global::net.sf.robocode.security.HiddenAccess.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;Lrobocode/robotinterfaces/IBasicRobot;Lnet/sf/robocode/peer/IRob" +
            "otStatics;Ljava/awt/Graphics2D;)V")]
        public static void dispatch(global::java.lang.Object par0, global::java.lang.Object par1, global::net.sf.robocode.peer.IRobotStatics par2, global::java.lang.Object par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_dispatch0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::net.sf.robocode.peer.IRobotStatics>(@__env, par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void init() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_init1);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void cleanup() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_cleanup2);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Bullet;DDLjava/lang/String;Z)V")]
        public static void update(global::java.lang.Object par0, double par1, double par2, global::java.lang.String par3, bool par4) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 20)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_update3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void initContainer() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_initContainer4);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/String;)V")]
        public static void robocodeMain(java.lang.String[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_robocodeMain5, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;)Z")]
        public static bool isCriticalEvent(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_isCriticalEvent6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;J)V")]
        public static void setEventTime(global::java.lang.Object par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_setEventTime7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;I)V")]
        public static void setEventPriority(global::java.lang.Object par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_setEventPriority8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;)V")]
        public static void setDefaultPriority(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_setDefaultPriority9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/Event;)B")]
        public static byte getSerializationType(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((byte)(@__env.CallStaticByteMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_getSerializationType10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
            "ng/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Strin" +
            "g;)Lrobocode/control/RobotSpecification;")]
        public static global::java.lang.Object createSpecification(global::java.lang.Object par0, global::java.lang.String par1, global::java.lang.String par2, global::java.lang.String par3, global::java.lang.String par4, global::java.lang.String par5, global::java.lang.String par6, global::java.lang.String par7, global::java.lang.String par8) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 28)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_createSpecification11, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par8)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;)Ljava/lang/Object;")]
        public static global::java.lang.Object getFileSpecification(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_getFileSpecification12, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;)Ljava/lang/String;")]
        public static global::java.lang.String getRobotTeamName(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_getRobotTeamName13, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobotSpecification;Ljava/lang/String;)V")]
        public static void setTeamId(global::java.lang.Object par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_setTeamId14, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(DDDDDDDDDDDDIIIIJ)Lrobocode/RobotStatus;")]
        public static global::java.lang.Object createStatus(
                    double par0, 
                    double par1, 
                    double par2, 
                    double par3, 
                    double par4, 
                    double par5, 
                    double par6, 
                    double par7, 
                    double par8, 
                    double par9, 
                    double par10, 
                    double par11, 
                    int par12, 
                    int par13, 
                    int par14, 
                    int par15, 
                    long par16) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 44)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_createStatus15, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par11), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par12), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par13), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par14), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par15), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par16)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(IIIDJZI)Lrobocode/BattleRules;")]
        public static global::java.lang.Object createRules(int par0, int par1, int par2, double par3, long par4, bool par5, int par6) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 24)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallStaticObjectMethodPtr(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_createRules16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par6)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public static bool isSafeThread() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_isSafeThread17)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;Lrobocode/control/events/IBattleListener;)V")]
        public static void initContainerForRobotEngine(global::java.io.File par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallStaticVoidMethod(global::net.sf.robocode.security.HiddenAccess.staticClass, global::net.sf.robocode.security.HiddenAccess.j4n_initContainerForRobotEngine18, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.security.HiddenAccess(@__env);
            }
        }
    }
    #endregion
}